using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<HomeController> _logger;
        public MainContext db;
        public HomeController(ILogger<HomeController> logger,MainContext context,UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            ViewBag.List = from s in db.Techlist
                           join i in db.Model on s.Model equals i.IdMod
                           join t in db.Manufacturer on s.Manufacturer equals t.IdMan
                           join f in db.Category on s.Category equals f.IdCat
                           select new ViewMod
                           {
                               Category = f.NameCat,
                               Id = s.Id,
                               Manufacturer = t.NameMan,
                               Model = i.NameMod,
                               Path = s.Photo
                           };
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Category = from s in db.Category
                               select s;
            ViewBag.Manufacturer = from s in db.Manufacturer
                                   select s;
            ViewBag.Model = from s in db.Model
                            select s;
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(AddForm add)
        {
            Techlist techlist = new Techlist
            {
                Category = add.Category,
                Manufacturer = add.Manufacturer,
                Model = add.Model,
                Photo = "img/5.png"
            };
            db.Techlist.Add(techlist);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Category()
        {
            ViewBag.Category = from s in db.Category
                               select s;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult List(int id)
        {
            ViewBag.List = from s in db.Techlist
                           where s.Category == id
                           join i in db.Manufacturer on s.Category equals i.IdMan
                           join f in db.Model on s.Model equals f.IdMod
                           select new List {
                               Manufacturer = i.NameMan,
                               Id = s.Id,
                               Model = f.NameMod,
                               Path = s.Photo
                           };
            ViewBag.Back = (from s in db.Category
                            where s.IdCat == id
                            select s).FirstOrDefault();
            return View();
        }
        public IActionResult Orders()
        {
            var userId = userManager.GetUserId(User);
            ViewBag.Items = from s in db.Order
                             where s.UserId == userId
                             join i in db.Techlist on s.TechId equals i.Id
                             join f in db.Category on i.Category equals f.IdCat
                             join m in db.Model on i.Model equals m.IdMod
                             join k in db.Manufacturer on i.Manufacturer equals k.IdMan
                             orderby s.Status
                             select new OrderViewModel{
                                Category = f.NameCat,
                                DateEnd = s.DateEnd,
                                DateStart = s.DateStart,
                                Id=s.Id,
                                Manufacturer = k.NameMan,
                                Model = m.NameMod,
                                Status = s.Status
                             };
            return View();
        }
    }
}
