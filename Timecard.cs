using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInSystemPublic
{
    public class Timecard
    {
        public int TimecardID { get; set; }

        public string EmpID { get; set; }

        public string StoreID { get; set; }

        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        public DateTime Date { get; set; }

        public double Hours { get; set; }

        public string Type { get; set; }



        public string EmpReport
        {
            get
            {
                return $"{TimeIn.Date.ToShortDateString()}     {TimeIn.TimeOfDay}     {TimeOut.TimeOfDay}     {TimeOut - TimeIn}";
            }
        }

        public string TimecardInfo
        {
            get
            {
                return $"{TimeIn.Date.ToShortDateString()}        {TimeIn.ToShortTimeString()}        {TimeOut.ToShortTimeString()}        {Type}";
            }
        }

        public string PartialTimecardInfo
        {
            get
            {
                return $"{TimeIn.Date.ToShortDateString()}     {TimeIn.TimeOfDay}               {Type}";
            }
        }
    }
}
