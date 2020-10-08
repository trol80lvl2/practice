using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Status { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Model { get; set; }
    }
}
