using System;
using System.Collections.Generic;

namespace WebApplication7.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Status { get; set; }
        public int TechId { get; set; }
    }
}
