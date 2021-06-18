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
    public class DataAccess
    {
        public int CheckPin(string pin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.ExecuteScalar<int>("dbo.CheckPin @EmpID", new { EmpID = pin });
            }
        }

        public Employee MatchPin(string pin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<Employee>("dbo.MatchPin @EmpID", new { EmpID = pin }).SingleOrDefault();
            }
        }

        public int CheckStatus(string pin)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.ExecuteScalar<int>("dbo.CheckStatus @EmpID", new { EmpID = pin });
            }
        }

        public void ClockIn(string empID, string storeID, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.ClockIn @EmpID, @StoreID, @TimeIn, @Type", new { EmpID = empID, StoreID = storeID, TimeIn = DateTime.Now, Type = type });
            }
        }

        public void ClockOut(string empID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.ClockOut @EmpID, @TimeOut", new { EmpID = empID, TimeOut = DateTime.Now });
            }
        }

        public List<Employee> GetByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<Employee>("dbo.GetByLastName @EmpLName", new { EmpLName = lastName }).ToList();
            }
        }

        public List<Timecard> EmpReport(string pin, DateTime timeIn, DateTime timeOut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<Timecard>("dbo.EmpReport @EmpID, @TimeIn, @TimeOut", new { EmpID = pin, TimeIn = timeIn, TimeOut = timeOut }).ToList();
            }
        }

        public List<EmployeeTimecard> StoreReport(string storeID, DateTime start, DateTime end)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<EmployeeTimecard>("dbo.StoreReport @StoreID, @Start, @End", new { StoreID = storeID, Start = start, End = end }).ToList();
            }
        }

        public List<EmployeeTimecard> DayReport(DateTime date, string storeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<EmployeeTimecard>("dbo.DayReport @Date, @StoreID", new { Date = date, StoreID = storeID }).ToList();
            }
        }

        public void DeleteEmp(string empID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.DeleteEmp @EmpID", new { EmpID = empID });
            }
        }

        public void EditEmp(string empID, string empFName, string empLName, string accessLevel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.EditEmp @EmpID, @EmpFName, @EmpLName, @AccessLevel", new
                {
                    EmpID = empID,
                    EmpFName = empFName,
                    EmpLName = empLName,
                    AccessLevel = accessLevel
                });
            }
        }

        public void EditTime(int timecardID, DateTime timeIn, DateTime timeOut, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.EditTime @TimecardID, @TimeIn, @TimeOut, @Type", new
                {
                    TimecardID = timecardID,
                    TimeIn = timeIn,
                    TimeOut = timeOut,
                    Type = type
                }); ;
            }
        }

        public void EditClockinTime(int timecardID, DateTime timeIn, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.EditClockinTime @TimecardID, @TimeIn, @Type", new
                {
                    TimecardID = timecardID,
                    TimeIn = timeIn,
                    Type = type
                }); ;
            }
        }

        public void AddEmp(string empID, string empFName, string empLName, string accessLevel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.AddEmp @EmpID, @EmpFName, @EmpLName, @AccessLevel", new
                {
                    EmpID = empID,
                    EmpFName = empFName,
                    EmpLName = empLName,
                    AccessLevel = accessLevel
                });
            }
        }

        public void DeleteTimecard(int timecardID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.DeleteTimecard @TimecardID", new { TimecardID = timecardID });
            }

        }

        public void AddTimecard(string empID, string storeID, DateTime timeIn, DateTime timeOut, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.AddTimecard @EmpID, @StoreID, @TimeIn, @TimeOut, @Type", new
                {
                    EmpID = empID,
                    StoreID = storeID,
                    TimeIn = timeIn,
                    TimeOut = timeOut,
                    Type = type
                });
            }
        }

        public void AddClockin(string empID, string storeID, DateTime timeIn, string type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                connection.Execute("dbo.AddClockin @EmpID, @StoreID, @TimeIn, @Type", new
                {
                    EmpID = empID,
                    StoreID = storeID,
                    TimeIn = timeIn,
                    Type = type
                });
            }
        }

        public List<Timecard> SelectTimecard(string empID, DateTime date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DBTest")))
            {
                return connection.Query<Timecard>("dbo.SelectTimecard @EmpID, @Date", new { EmpID = empID, Date = date }).ToList();
            }
        }
    }
}
