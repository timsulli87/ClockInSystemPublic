using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInSystemPublic
{
    public class EmployeeTimecard
    {
        public string EmpID { get; set; }

        public string EmpFName { get; set; }

        public string EmpLName { get; set; }

        public string TimecardID { get; set; }

        public string StoreID { get; set; }

        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        public string Type { get; set; }

        public decimal TotalHours { get; set; }
    }
}
