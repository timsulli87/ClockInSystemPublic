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
    public partial class FormEnterPin : Form
    {

        public Employee currentEmp = new Employee();
        public string currentEmpID;

        public FormEnterPin()
        {
            InitializeComponent();
        }

        private void buttonSubmitPin_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int count = db.CheckPin(textBoxEnterPin.Text);

            if (count == 1)
            {
                currentEmp = db.MatchPin(textBoxEnterPin.Text);

                if (currentEmp.AccessLevel == "2")
                {
                    FormMgrMenu formMgrMenu = new FormMgrMenu();
                    formMgrMenu.labelMgrInfo.Text = currentEmp.FullName;
                    formMgrMenu.mgrPin = currentEmp.EmpID;

                    textBoxEnterPin.Clear();
                    this.Hide();
                    formMgrMenu.Show();
                }
                else if (currentEmp.AccessLevel == "1")
                {
                    FormEmpMenu formEmpMenu = new FormEmpMenu();
                    formEmpMenu.labelEmpInfo.Text = currentEmp.FullName;
                    formEmpMenu.currentPin = currentEmp.EmpID;

                    textBoxEnterPin.Clear();
                    this.Hide();
                    formEmpMenu.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Pin.");
                textBoxEnterPin.Clear();
            }
        }

        private void FormEnterPin_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
