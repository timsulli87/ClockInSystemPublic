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
    public partial class FormEmployeeReport : Form
    {
        public string mgrPin;
        public string mgrName;
        public List<Employee> employees = new List<Employee>();

        public FormEmployeeReport()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            listBoxResults.DataSource = employees;
            listBoxResults.DisplayMember = "FullInfo";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            employees = db.GetByLastName(textBoxLastName.Text);

            UpdateBinding();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormMgrMenu formMgrMenu = new FormMgrMenu();
            formMgrMenu.mgrPin = mgrPin;
            formMgrMenu.labelMgrInfo.Text = mgrName;
            this.Close();
            formMgrMenu.Show();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee.");
            }
            else
            {
                int selection = listBoxResults.SelectedIndex;

                FormEmployeeReport2 formEmployeeReport2 = new FormEmployeeReport2();

                formEmployeeReport2.labelEmployeeName.Text = employees[selection].FullName;
                formEmployeeReport2.currentEmpID = employees[selection].EmpID;
                formEmployeeReport2.mgrPin = mgrPin;
                formEmployeeReport2.mgrName = mgrName;

                this.Hide();
                formEmployeeReport2.Show();
            }
        }
    }
}
