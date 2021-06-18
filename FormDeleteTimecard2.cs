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
    public partial class FormDeleteTimecard2 : Form
    {
        public string mgrPin;
        public string mgrName;
        public string currentEmpID;
        public List<Timecard> timecards = new List<Timecard>();

        public FormDeleteTimecard2()
        {
            InitializeComponent();
        }

        private void UpdateBinding()
        {
            listBoxResults.DataSource = timecards;

            listBoxResults.DisplayMember = "TimecardInfo";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            timecards = db.SelectTimecard(currentEmpID, dateTimePickerDate.Value.Date);
            UpdateBinding();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem == null)
            {
                MessageBox.Show("Please select a timecard.");
            }
            else
            {
                int selection = listBoxResults.SelectedIndex;
                DataAccess db = new DataAccess();

                db.DeleteTimecard(timecards[selection].TimecardID);
                MessageBox.Show($"Deleted Timecard" +
                    $"\nTimecard ID: {timecards[selection].TimecardID}" +
                    $"\nEmployee Pin: {timecards[selection].EmpID}" +
                    $"\nDate: {timecards[selection].TimeIn.ToShortDateString()}" +
                    $"\nTime In: {timecards[selection].TimeIn.ToShortTimeString()}" +
                    $"\nTime Out: {timecards[selection].TimeOut.ToShortTimeString()}" +
                    $"\nType: {timecards[selection].Type}");

                FormMgrMenu formMgrMenu = new FormMgrMenu();
                formMgrMenu.mgrPin = mgrPin;
                formMgrMenu.labelMgrInfo.Text = mgrName;
                this.Close();
                formMgrMenu.Show();
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
