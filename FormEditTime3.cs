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
    public partial class FormEditTime3 : Form
    {
        public string mgrPin;
        public string mgrName;
        public int timecardID;
        DateTime date;
        TimeSpan timeIn;
        TimeSpan timeOut;
        DateTime dateTimeIn;
        DateTime dateTimeOut;
        string type;
        bool success = true;

        public FormEditTime3()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            date = dateTimePickerChangeDate.Value.Date;
            timeIn = dateTimePickerIn.Value.TimeOfDay;
            timeOut = dateTimePickerOut.Value.TimeOfDay;

            if (radioButtonStore.Checked == true)
            {
                type = "Store";
                success = true;
            }
            else
            {
                int choice = comboBoxAdminTypes.SelectedIndex;

                if (choice == 0)
                {
                    MessageBox.Show("Please select an admin hours type");
                    success = false;
                }
                else
                {
                    AdminTypes selection = AdminTypes.types[choice];
                    type = $"Admin-{selection.Code}";
                    success = true;
                }
            }

            dateTimeIn = date + timeIn;
            dateTimeOut = date + timeOut;

            DataAccess db = new DataAccess();
            FormMgrMenu formMgrMenu = new FormMgrMenu();

            if (success)
            {
                //Clock out time specified
                if (dateTimePickerOut.Checked)
                {
                    if (dateTimeIn > dateTimeOut)
                    {
                        MessageBox.Show("Time In cannot be later than Time Out.");
                    }
                    else
                    {
                        db.EditTime(timecardID, dateTimeIn, dateTimeOut, type);
                        MessageBox.Show($"Changed timecard to" +
                            $"\nDate: {date.ToShortDateString()}" +
                            $"\nTime In: {dateTimeIn.ToShortTimeString()}" +
                            $"\nTime Out: {dateTimeOut.ToShortTimeString()}" +
                            $"\nType: {type}");

                        formMgrMenu.mgrPin = mgrPin;
                        formMgrMenu.labelMgrInfo.Text = mgrName;
                        this.Close();
                        formMgrMenu.Show();
                    }
                }
                //No clock out time specified
                else
                {
                    db.EditClockinTime(timecardID, dateTimePickerIn.Value, type);
                    MessageBox.Show($"Changed timecard to" +
                        $"\nTime In: {dateTimePickerIn.Value.ToShortTimeString()}" +
                        $"\nType: {type}");

                    formMgrMenu.mgrPin = mgrPin;
                    formMgrMenu.labelMgrInfo.Text = mgrName;
                    this.Close();
                    formMgrMenu.Show();
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

        private void labelTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.CustomFormat = null;
            dateTimePickerOut.Format = DateTimePickerFormat.Time;
        }

        private void FormEditTime3_Load(object sender, EventArgs e)
        {
            if (!dateTimePickerOut.Checked)
            {
                // hide date value since it's not set
                dateTimePickerOut.CustomFormat = " ";
                dateTimePickerOut.Format = DateTimePickerFormat.Custom;
                dateTimePickerOut.ShowUpDown = true;
            }
            else
            {
                dateTimePickerOut.CustomFormat = null;
                dateTimePickerOut.Format = DateTimePickerFormat.Time; // set the date format you want.
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked == true)
            {
                comboBoxAdminTypes.Visible = true;
                comboBoxAdminTypes.DataSource = AdminTypes.types;
                comboBoxAdminTypes.DisplayMember = "FullInfo";
            }
            else
            {
                comboBoxAdminTypes.Visible = false;
            }
        }
    }
}
