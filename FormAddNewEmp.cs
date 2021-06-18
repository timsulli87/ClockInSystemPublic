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
    public partial class FormAddNewEmp : Form
    {
        public string mgrPin;
        public string mgrName;
        string pinInput;
        string accessLevel;
        bool successPin;
        bool successFName;
        bool successLName;
        bool successAccessLevel;
        string position;

        public FormAddNewEmp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateEmp_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            pinInput = textBoxPin.Text;

            //Check Pin input
            if (pinInput.Length == 4)
            {
                successPin = Int32.TryParse(pinInput, out int number);
                if (!successPin)
                {
                    successPin = false;
                    MessageBox.Show("Please enter a 4 digit Pin.");
                }

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

            }
            else
            {
                MessageBox.Show("Please enter a 4 digit Pin.");
            }

            //Create new record
            if (successPin == true && successFName == true && successLName == true && successAccessLevel == true)
            {
                db.AddEmp(textBoxPin.Text, textBoxFName.Text, textBoxLName.Text, accessLevel);
                MessageBox.Show($"Created new employee" +
                    $"\nPin: {textBoxPin.Text}" +
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
