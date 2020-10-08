using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7
{
    public class TechlistsController : Controller
    {
        private readonly MainContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public TechlistsController(MainContext context,IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Techlists
        public async Task<IActionResult> Index()
        {
            return View(await _context.Techlist.ToListAsync());
        }

        // GET: Techlists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var techlist = await _context.Techlist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (techlist == null)
            {
                return NotFound();
            }

            return View(techlist);
        }

        // GET: Techlists/Create
        public IActionResult Create()
        {
            ViewBag.Category = from s in _context.Category
                               select s;
            ViewBag.Model = from s in _context.Model
                            select s;
            ViewBag.Manufacturer = from s in _context.Manufacturer
                                   select s;
            return View();
        }

        // POST: Techlists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateViewModel category)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (category.Path != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + category.Path.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    category.Path.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Techlist category1 = new Techlist
                {
                    Category = Convert.ToInt32(category.NameCat),
                    Model = Convert.ToInt32(category.NameMod),
                    Manufacturer = Convert.ToInt32(category.NameMan),
                    Photo = uniqueFileName
                };
                _context.Add(category1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Techlists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var techlist = await _context.Techlist.FindAsync(id);
            if (techlist == null)
            {
                return NotFound();
            }
            return View(techlist);
        }

        // POST: Techlists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Category,Manufacturer,Model,Photo")] Techlist techlist)
        {
            if (id != techlist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(techlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechlistExists(techlist.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(techlist);
        }

        // GET: Techlists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var techlist = await _context.Techlist
                .FirstOrDefaultAsync(m => m.Id == id);
            if (techlist == null)
            {
                return NotFound();
            }

            return View(techlist);
        }

        // POST: Techlists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var techlist = await _context.Techlist.FindAsync(id);
            _context.Techlist.Remove(techlist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechlistExists(int id)
        {
            return _context.Techlist.Any(e => e.Id == id);
        }
    }
}
