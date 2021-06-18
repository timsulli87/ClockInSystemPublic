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
    public partial class FormAddTimecard2 : Form
    {
        public string mgrPin;
        public string mgrName;
        public string currentEmpID;
        DateTime date;
        TimeSpan timeIn;
        TimeSpan timeOut;
        DateTime dateTimeIn;
        DateTime dateTimeOut;
        string type;
        bool success = true;

        public FormAddTimecard2()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            date = dateTimePickerDate.Value.Date;
            timeIn = dateTimePickerIn.Value.TimeOfDay;

            if (radioButtonStore.Checked == false && radioButtonAdmin.Checked == false)
            {
                MessageBox.Show("Please select a timecard type.");
            }
            else if (radioButtonStore.Checked == true)
            {
                success = true;
            }
            else
            {
                if (radioButtonStore.Checked == true)
                {
                    type = "Store";
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

                DataAccess db = new DataAccess();

                if (success)
                {
                    if (dateTimePickerOut.Checked)
                    {
                        timeOut = dateTimePickerOut.Value.TimeOfDay;
                        dateTimeOut = date + timeOut;
                        db.AddTimecard(currentEmpID, "1", dateTimeIn, dateTimeOut, type);

                        MessageBox.Show($"Added new timecard" +
                            $"\nPin: {currentEmpID}" +
                            $"\nDate: {date.ToShortDateString()}" +
                            $"\nTime In: {dateTimeIn.ToShortTimeString()}" +
                            $"\nTime Out: {dateTimeOut.ToShortTimeString()}" +
                            $"\nType: {type}");

                        FormMgrMenu formMgrMenu = new FormMgrMenu();
                        formMgrMenu.mgrPin = mgrPin;
                        formMgrMenu.labelMgrInfo.Text = mgrName;
                        this.Close();
                        formMgrMenu.Show();
                    }
                    else
                    {
                        db.AddClockin(currentEmpID, "1", dateTimeIn, type);
                        MessageBox.Show($"Added new timecard" +
                            $"\nPin: {currentEmpID}" +
                            $"\nDate: {date.ToShortDateString()}" +
                            $"\nTime In: {dateTimeIn.ToShortTimeString()}" +
                            $"\nType: {type}");

                        FormMgrMenu formMgrMenu = new FormMgrMenu();
                        formMgrMenu.mgrPin = mgrPin;
                        formMgrMenu.labelMgrInfo.Text = mgrName;
                        this.Close();
                        formMgrMenu.Show();
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

        private void FormAddTimecard2_Load(object sender, EventArgs e)
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

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerOut.CustomFormat = null;
            dateTimePickerOut.Format = DateTimePickerFormat.Time;
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
