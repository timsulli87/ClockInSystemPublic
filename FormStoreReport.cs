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
    public partial class FormStoreReport : Form
    {
        public string mgrPin;
        public string mgrName;
        string storeID;
        public List<EmployeeTimecard> timecards = new List<EmployeeTimecard>();
        public Employee employee = new Employee();
        bool storeSuccess;

        public FormStoreReport()
        {
            InitializeComponent();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormMgrMenu formMgrMenu = new FormMgrMenu();
            formMgrMenu.mgrPin = mgrPin;
            formMgrMenu.labelMgrInfo.Text = mgrName;
            this.Close();
            formMgrMenu.Show();
        }

        private void buttonRunReport_Click(object sender, EventArgs e)
        {
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
                DataAccess db = new DataAccess();
                DateTime start = dateTimePickerStart.Value.Date;
                DateTime end = dateTimePickerEnd.Value.Date;


                if (start > end)
                {
                    MessageBox.Show("Start Date cannot be later than End Date");
                }
                else
                {
                    timecards = db.StoreReport(storeID, start, end);

                    dataGridViewReport.Rows.Clear();

                    foreach (EmployeeTimecard value in timecards)
                    {
                        dataGridViewReport.Rows.Add(value.EmpID, value.EmpFName, value.EmpLName, value.Type, value.TotalHours);
                    }
                }
            }
        }
    }
}
