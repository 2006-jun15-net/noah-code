using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class Department
    {
        public Department()
        {
            Employee2 = new HashSet<Employee2>();
        }

        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee2> Employee2 { get; set; }
    }
}
