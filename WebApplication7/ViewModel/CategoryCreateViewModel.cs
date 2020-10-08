using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class CategoryCreateViewModel
    {
        public int IdCat { get; set; }
        public string NameCat { get; set; }
        public string NameMod { get; set; }
        public string NameMan { get; set; }
        public IFormFile Path { get; set; }
    }
}
