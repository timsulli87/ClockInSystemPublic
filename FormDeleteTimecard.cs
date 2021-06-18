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
    public partial class FormDeleteTimecard : Form
    {
        public string mgrPin;
        public string mgrName;
        public List<Employee> employees = new List<Employee>();

        public FormDeleteTimecard()
        {
            InitializeComponent();
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

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee.");
            }
            else
            {
                int selection = listBoxResults.SelectedIndex;
                FormDeleteTimecard2 formDeleteTimecard2 = new FormDeleteTimecard2();

                formDeleteTimecard2.labelCurrentEmp.Text = employees[selection].FullName;
                formDeleteTimecard2.currentEmpID = employees[selection].EmpID;
                formDeleteTimecard2.mgrPin = mgrPin;
                formDeleteTimecard2.mgrName = mgrName;

                this.Close();
                formDeleteTimecard2.Show();
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
