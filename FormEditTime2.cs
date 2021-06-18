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
    public partial class FormEditTime2 : Form
    {
        public string mgrPin;
        public string mgrName;
        public List<Timecard> timecards = new List<Timecard>();
        public string currentEmpID;


        public FormEditTime2()
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {

            if (listBoxResults.SelectedItem == null)
            {
                MessageBox.Show("Please select a timecard.");
            }
            else
            {
                int selection = listBoxResults.SelectedIndex;
                FormEditTime3 formEditTime3 = new FormEditTime3();

                formEditTime3.labelFullName.Text = labelCurrentEmp.Text;
                formEditTime3.timecardID = timecards[selection].TimecardID;
                formEditTime3.dateTimePickerChangeDate.Value = dateTimePickerDate.Value;
                formEditTime3.dateTimePickerIn.Value = timecards[selection].TimeIn;
                if (timecards[selection].TimeOut.Year == 0001)
                {
                    formEditTime3.dateTimePickerOut.Checked = false;
                }
                else
                {
                    formEditTime3.dateTimePickerOut.Value = timecards[selection].TimeOut;
                }

                if (timecards[selection].Type.ToLower() == "store")
                {
                    formEditTime3.radioButtonStore.Checked = true;
                }
                else if (timecards[selection].Type.ToLower().Contains("admin"))
                {
                    formEditTime3.radioButtonAdmin.Checked = true;
                    formEditTime3.comboBoxAdminTypes.Visible = true;
                    formEditTime3.comboBoxAdminTypes.DataSource = AdminTypes.types;
                    formEditTime3.comboBoxAdminTypes.DisplayMember = "FullInfo";
                }

                formEditTime3.mgrPin = mgrPin;
                formEditTime3.mgrName = mgrName;
                this.Close();
                formEditTime3.Show();
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

        private void FormEditTime2_Load(object sender, EventArgs e)
        {

        }
    }
}
