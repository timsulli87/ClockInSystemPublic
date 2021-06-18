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
    public partial class FormEmpMenu : Form
    {
        public string mgrPin;
        public Timecard clockInTime = new Timecard();

        FormEnterPin formEnterPin = new FormEnterPin();

        public string currentPin;

        int count;

        public FormEmpMenu()
        {
            InitializeComponent();
        }

        private void FormEmpMenu_Load(object sender, EventArgs e)
        {

        }

        internal void LoadEmp(Employee employee)
        {
            Employee currentEmp = new Employee();
        }

        private void buttonClockInStore_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(currentPin);

            if (count > 0)
            {
                MessageBox.Show("You are already clocked in.");
            }
            else
            {
                db.ClockIn(currentPin, "1", "Store");

                MessageBox.Show($"Clocked in at {DateTime.Now.ToString("t")} as Store");

                this.Close();
                formEnterPin.Show();
            }
        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(currentPin);

            if (count == 0)
            {
                MessageBox.Show("You are not clocked in.");
            }
            else
            {
                db.ClockOut(currentPin);

                MessageBox.Show($"Clocked out at {DateTime.Now.ToString("t")}");

                this.Close();
                formEnterPin.Show();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            formEnterPin.Show();
        }

        private void buttonClockinAdmin_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(currentPin);

            if (count > 0)
            {
                MessageBox.Show("You are already clocked in.");
            }
            else
            {
                comboBoxAdminTypes.Visible = true;
                comboBoxAdminTypes.DataSource = AdminTypes.empTypes;
                comboBoxAdminTypes.DisplayMember = "FullInfo";
                buttonConfirm.BackColor = Color.LightSeaGreen;
                buttonConfirm.Visible = true;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int choice = comboBoxAdminTypes.SelectedIndex;

            if (choice == 0)
            {
                MessageBox.Show("Please select an admin hours type");
            }
            else
            {
                AdminTypes selection = AdminTypes.empTypes[choice];

                db.ClockIn(currentPin, "1", $"Admin-{selection.Code}");

                MessageBox.Show($"Clocked in at {DateTime.Now.ToString("t")} as Admin-{selection.Code}");

                this.Close();
                formEnterPin.Show();
            }
        }

        private void buttonEmpReport_Click(object sender, EventArgs e)
        {
            FormViewMyHours formViewMyHours = new FormViewMyHours();
            formViewMyHours.currentEmpID = currentPin;
            formViewMyHours.labelEmployeeName.Text = labelEmpInfo.Text;
            this.Close();
            formViewMyHours.Show();
        }
    }
}
