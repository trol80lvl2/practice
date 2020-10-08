using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class AddForm
    {
        public int Category { get; set; }
        public int Manufacturer { get; set; }
        public int Model { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateStart { get; set; }     
        public DateTime? DateEnd { get; set; }
    }
}
