using System;
using System.Collections.Generic;

namespace APIAssignment.Models
{
    public partial class UserAccounts
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}
