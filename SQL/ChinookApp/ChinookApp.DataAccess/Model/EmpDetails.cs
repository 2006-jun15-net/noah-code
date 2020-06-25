using System;
using System.Collections.Generic;

namespace ChinookApp.DataAccess.Model
{
    public partial class EmpDetails
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal? Salary { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string St { get; set; }
        public string Country { get; set; }

        public virtual Employee2 Employee { get; set; }
    }
}
