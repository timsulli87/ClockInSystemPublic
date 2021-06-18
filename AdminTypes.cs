using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInSystemPublic
{
    class AdminTypes
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Code}-{Name}";
            }
        }

        private AdminTypes(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public static AdminTypes[] types =
        {
            new AdminTypes("-", "<Select Type>--"),
            new AdminTypes("BD", "Bank Deposits"),
            new AdminTypes("CL", "Craigslist"),
            new AdminTypes("MM", "Manager Meeting"),
            new AdminTypes("PR", "Posting Rent"),
            new AdminTypes("DP", "Display"),
            new AdminTypes("SS", "Showing Space"),
            new AdminTypes("SM", "Staff Meeting"),
            new AdminTypes("SP", "Supply Purchases"),
            new AdminTypes("SC", "Scheduling"),
            new AdminTypes("IN", "Instagram"),
            new AdminTypes("DT", "Design Tuesdays"),
            new AdminTypes("DL", "Dealer AM/PM"),
            new AdminTypes("MI", "Miscellaneous")
        };

        public static AdminTypes[] empTypes =
        {
            new AdminTypes("-", "<Select Type>--"),
            new AdminTypes("BD", "Bank Deposits"),
            new AdminTypes("CL", "Craigslist"),
            new AdminTypes("DP", "Display"),
            new AdminTypes("SM", "Staff Meeting"),
            new AdminTypes("SP", "Supply Purchases"),
            new AdminTypes("IN", "Instagram"),
            new AdminTypes("DT", "Design Tuesdays"),
            new AdminTypes("DL", "Dealer AM/PM"),
            new AdminTypes("MI", "Miscellaneous")
        };
    }
}
