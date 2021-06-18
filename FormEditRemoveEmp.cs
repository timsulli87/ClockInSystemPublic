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
    public partial class FormEditRemoveEmp : Form
    {
        public string mgrPin;
        public string mgrName;
        List<Employee> employees = new List<Employee>();

        private void UpdateBinding()
        {
            listBoxResults.DataSource = employees;
            listBoxResults.DisplayMember = "FullInfo";
        }

        public FormEditRemoveEmp()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            employees = db.GetByLastName(textBoxLastName.Text);

            UpdateBinding();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee.");
            }
            else
            {
                int selection = listBoxResults.SelectedIndex;
                string selectedID = employees[selection].EmpID;

                FormEditRemoveEmp2 formEditRemoveEmp2 = new FormEditRemoveEmp2();

                formEditRemoveEmp2.empID = employees[selection].EmpID;

                formEditRemoveEmp2.textBoxFName.Text = employees[selection].EmpFName;
                formEditRemoveEmp2.textBoxLName.Text = employees[selection].EmpLName;

                if (employees[selection].AccessLevel == "1")
                {
                    formEditRemoveEmp2.autoclick = 1;
                }
                else if (employees[selection].AccessLevel == "2")
                {
                    formEditRemoveEmp2.autoclick = 2;
                }

                formEditRemoveEmp2.mgrPin = mgrPin;
                formEditRemoveEmp2.mgrName = mgrName;
                this.Close();
                formEditRemoveEmp2.Show();
            }
        }

        //***Removed "Delete Employee" funciton***

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (listBoxResults.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please select an employee.");
        //    }
        //    else
        //    {
        //        int selection = listBoxResults.SelectedIndex;
        //        string selectedID = employees[selection].EmpID;

        //        DataAccess db = new DataAccess();

        //        db.DeleteEmp(selectedID);

        //        MessageBox.Show($"Deleted record for {employees[selection].FullName}");

        //        FormMgrMenu formMgrMenu = new FormMgrMenu();
        //        formMgrMenu.mgrPin = mgrPin;
        //        formMgrMenu.labelMgrInfo.Text = mgrName;
        //        this.Close();
        //        formMgrMenu.Show();
        //    }
        //}

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
