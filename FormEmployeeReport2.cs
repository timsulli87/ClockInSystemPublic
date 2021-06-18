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
    public partial class FormEmployeeReport2 : Form
    {
        public string mgrPin;
        public string mgrName;
        public string currentEmpID;
        public List<Timecard> timecards = new List<Timecard>();

        public FormEmployeeReport2()
        {
            InitializeComponent();
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            DateTime start = dateTimePickerStart.Value.Date;
            DateTime end = dateTimePickerEnd.Value.Date;
            double totalHours = 0;

            if (start > end)
            {
                MessageBox.Show("Start Date cannot be later than End Date");
            }
            else
            {
                timecards = db.EmpReport(currentEmpID, start, end);

                dataGridViewReport.Rows.Clear();

                foreach (Timecard value in timecards)
                {
                    string dateIn = value.TimeIn.Date.ToShortDateString();
                    string timeIn = value.TimeIn.ToShortTimeString();
                    string timeOut = value.TimeOut.ToShortTimeString();
                    string type = value.Type;

                    TimeSpan hoursSpan = value.TimeOut - value.TimeIn;

                    dataGridViewReport.Rows.Add(dateIn, timeIn, timeOut, type, hoursSpan.TotalHours);

                    totalHours = totalHours + hoursSpan.TotalHours;
                }

                dataGridViewReport.Rows.Add("", "", "", "", totalHours);
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

        private void buttonExcelReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature is not working yet.");
        }
    }
}
