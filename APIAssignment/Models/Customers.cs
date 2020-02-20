using System;
using System.Collections.Generic;

namespace APIAssignment.Models
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
    }
}
