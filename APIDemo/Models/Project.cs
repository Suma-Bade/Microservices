using System;
using System.Collections.Generic;

namespace APIDemo.Models
{
    public partial class Project
    {
        public Project()
        {
            Employee = new HashSet<Employee>();
        }

        public string Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
