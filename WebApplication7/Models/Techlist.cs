using System;
using System.Collections.Generic;

namespace WebApplication7.Models
{
    public partial class Techlist
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public int Manufacturer { get; set; }
        public int Model { get; set; }
        public string Photo { get; set; }
    }
}
