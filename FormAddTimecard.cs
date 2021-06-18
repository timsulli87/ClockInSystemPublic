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
    public partial class FormAddTimecard : Form
    {
        public string mgrPin;
        public string mgrName;
        public List<Employee> employees = new List<Employee>();

        public FormAddTimecard()
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

                FormAddTimecard2 formAddTimecard2 = new FormAddTimecard2();

                formAddTimecard2.labelFullName.Text = employees[selection].FullName;
                formAddTimecard2.currentEmpID = employees[selection].EmpID;
                formAddTimecard2.dateTimePickerOut.Checked = false;
                formAddTimecard2.mgrPin = mgrPin;
                formAddTimecard2.mgrName = mgrName;

                this.Hide();
                formAddTimecard2.Show();
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
