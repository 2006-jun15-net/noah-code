using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class Employee2
    {
        public Employee2()
        {
            EmpDetails = new HashSet<EmpDetails>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Ssn { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<EmpDetails> EmpDetails { get; set; }
    }
}
