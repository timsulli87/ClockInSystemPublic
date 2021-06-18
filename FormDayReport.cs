using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockInSystemPublic
{
    public partial class FormDayReport : Form
    {
        public string mgrPin;
        public string mgrName;
        string storeID;
        bool storeSuccess;
        bool clockOut;

        public FormDayReport()
        {
            InitializeComponent();
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            List<EmployeeTimecard> employeeTimecards = new List<EmployeeTimecard>();

            if (radioButtonMarietta.Checked)
            {
                storeID = "1";
                storeSuccess = true;
            }
            else if (radioButtonAlpharetta.Checked)
            {
                storeID = "2";
                storeSuccess = true;
            }
            else if (radioButtonBuford.Checked)
            {
                storeID = "3";
                storeSuccess = true;
            }
            else
            {
                MessageBox.Show("Please select a store.");
                storeSuccess = false;
            }

            if (storeSuccess)
            {
                employeeTimecards = db.DayReport(dateTimePickerDate.Value.Date, storeID);

                dataGridViewReport.Rows.Clear();

                foreach (EmployeeTimecard value in employeeTimecards)
                {
                    if (value.TimeOut.Year == 0001)
                    {
                        clockOut = false;
                    }
                    else
                    {
                        clockOut = true;
                    }

                    if (clockOut)
                    {
                        dataGridViewReport.Rows.Add(value.EmpID, value.EmpFName, value.EmpLName, value.TimeIn.ToShortTimeString(),
                            value.TimeOut.ToShortTimeString(), value.Type, value.TotalHours);
                    }
                    else
                    {
                        dataGridViewReport.Rows.Add(value.EmpID, value.EmpFName, value.EmpLName, value.TimeIn.ToShortTimeString(),
                            "", value.Type, value.TotalHours);
                    }
                }
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormMgrMenu formMgrMenu = new FormMgrMenu();
            formMgrMenu.mgrPin = mgrPin;
            formMgrMenu.labelMgrInfo.Text = mgrName;
            this.Close();
            formMgrMenu.Show();
        }
    }
}
