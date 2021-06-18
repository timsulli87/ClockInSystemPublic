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
    public partial class FormEditRemoveEmp2 : Form
    {
        public FormEditRemoveEmp2()
        {
            InitializeComponent();
        }

        public string mgrPin;
        public string mgrName;
        public int autoclick;
        public string empID;
        public string accessLevel;
        bool successFName;
        bool successLName;
        bool successAccessLevel;
        string position;

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Check FName input
            if (textBoxFName.Text != "")
            {
                successFName = true;

                //Check LName input
                if (textBoxLName.Text != "")
                {
                    successLName = true;

                    //Check Position input
                    if (radioButtonEmp.Checked == true)
                    {
                        accessLevel = "1";
                        successAccessLevel = true;
                        position = "Employee";
                    }
                    else if (radioButtonMgr.Checked == true)
                    {
                        accessLevel = "2";
                        successAccessLevel = true;
                        position = "Manager";
                    }
                    else
                    {
                        successAccessLevel = false;
                        MessageBox.Show("Please select a position.");
                    }
                }
                else
                {
                    successLName = false;
                    MessageBox.Show("Please enter a last name.");
                }
            }
            else
            {
                successFName = false;
                MessageBox.Show("Please enter a first name.");
            }

            if (successFName == true && successLName == true && successAccessLevel == true)
            {
                DataAccess db = new DataAccess();

                db.EditEmp(empID, textBoxFName.Text, textBoxLName.Text, accessLevel);

                MessageBox.Show($"Updated record:" +
                    $"\nFirst Name: {textBoxFName.Text}" +
                    $"\nLast Name: {textBoxLName.Text}" +
                    $"\nPosition: {position}");

                FormMgrMenu formMgrMenu = new FormMgrMenu();
                formMgrMenu.mgrPin = mgrPin;
                formMgrMenu.labelMgrInfo.Text = mgrName;
                this.Close();
                formMgrMenu.Show();
            }
        }

        private void FormEditRemoveEmp2_Load(object sender, EventArgs e)
        {
            if (autoclick == 1)
            {
                radioButtonEmp.PerformClick();
            }
            else if (autoclick == 2)
            {
                radioButtonMgr.PerformClick();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMgrMenu formMgrMenu = new FormMgrMenu();
            formMgrMenu.mgrPin = mgrPin;
            formMgrMenu.labelMgrInfo.Text = mgrName;
            this.Close();
            formMgrMenu.Show();
        }
    }
}
