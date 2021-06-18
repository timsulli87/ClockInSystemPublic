using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ClockInSystemPublic
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpFName { get; set; }
        public string EmpLName { get; set; }
        public string AccessLevel { get; set; }

        public string FullName
        {
            get
            {
                return $"{EmpFName} {EmpLName}";
            }
        }

        public string FullInfo
        {
            get
            {
                return $"{EmpID} {EmpFName} {EmpLName}";
            }
        }
    }
}
