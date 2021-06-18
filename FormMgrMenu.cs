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
    public partial class FormMgrMenu : Form
    {
        public string mgrPin;
        int count;

        public FormMgrMenu()
        {
            InitializeComponent();
        }

        private void buttonClockInStore_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(mgrPin);

            if (count > 0)
            {
                MessageBox.Show("You are already clocked in.");
            }
            else
            {
                db.ClockIn(mgrPin, "1", "Store");

                MessageBox.Show($"Clocked in at {DateTime.Now.ToString("t")} as Store");
            }
        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(mgrPin);

            if (count == 0)
            {
                MessageBox.Show("You are not clocked in.");
            }
            else
            {
                db.ClockOut(mgrPin);

                MessageBox.Show($"Clocked out at {DateTime.Now.ToString("t")}");
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            FormEnterPin formEnterPin = new FormEnterPin();

            this.Close();
            formEnterPin.Show();
        }

        private void buttonEditTime_Click(object sender, EventArgs e)
        {
            FormEditTime formEditTimeSearch = new FormEditTime();
            formEditTimeSearch.mgrPin = mgrPin;
            formEditTimeSearch.mgrName = labelMgrInfo.Text;
            this.Hide();
            formEditTimeSearch.Show();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            FormAddNewEmp formAddNewEmp = new FormAddNewEmp();
            formAddNewEmp.mgrPin = mgrPin;
            formAddNewEmp.mgrName = labelMgrInfo.Text;
            this.Hide();
            formAddNewEmp.Show();
        }

        private void buttonEditRemoveEmp_Click(object sender, EventArgs e)
        {
            FormEditRemoveEmp formEditRemoveEmp = new FormEditRemoveEmp();
            formEditRemoveEmp.mgrPin = mgrPin;
            formEditRemoveEmp.mgrName = labelMgrInfo.Text;
            this.Hide();
            formEditRemoveEmp.Show();
        }

        private void buttonEmpReport_Click(object sender, EventArgs e)
        {
            FormEmployeeReport formEmployeeReport = new FormEmployeeReport();
            formEmployeeReport.mgrPin = mgrPin;
            formEmployeeReport.mgrName = labelMgrInfo.Text;
            this.Hide();
            formEmployeeReport.Show();
        }

        private void buttonStoreReport_Click(object sender, EventArgs e)
        {
            FormStoreReport formStoreReport = new FormStoreReport();
            formStoreReport.mgrPin = mgrPin;
            formStoreReport.mgrName = labelMgrInfo.Text;
            this.Hide();
            formStoreReport.Show();
        }

        private void buttonDeleteTimecard_Click(object sender, EventArgs e)
        {
            FormDeleteTimecard formDeleteTimecard = new FormDeleteTimecard();
            formDeleteTimecard.mgrPin = mgrPin;
            formDeleteTimecard.mgrName = labelMgrInfo.Text;
            this.Hide();
            formDeleteTimecard.Show();
        }

        private void buttonClockInAdmin_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            count = db.CheckStatus(mgrPin);

            if (count > 0)
            {
                MessageBox.Show("You are already clocked in.");
            }
            else
            {
                comboBoxAdminTypes.Visible = true;
                comboBoxAdminTypes.DataSource = AdminTypes.types;
                comboBoxAdminTypes.DisplayMember = "FullInfo";
                buttonConfirm.BackColor = Color.LightSeaGreen;
                buttonConfirm.Visible = true;
            }
        }

        private void buttonAddTimecard_Click(object sender, EventArgs e)
        {
            FormAddTimecard formAddTimecard = new FormAddTimecard();
            formAddTimecard.mgrPin = mgrPin;
            formAddTimecard.mgrName = labelMgrInfo.Text;
            this.Hide();
            formAddTimecard.Show();
        }

        private void buttonDayReport_Click(object sender, EventArgs e)
        {
            FormDayReport formDayReport = new FormDayReport();
            formDayReport.mgrPin = mgrPin;
            formDayReport.mgrName = labelMgrInfo.Text;
            this.Hide();
            formDayReport.Show();
        }

        private void FormMgrMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int choice = comboBoxAdminTypes.SelectedIndex;
            AdminTypes selection = AdminTypes.types[choice];

            db.ClockIn(mgrPin, "1", $"Admin-{selection.Code}");

            MessageBox.Show($"Clocked in at {DateTime.Now.ToString("t")} as Admin-{selection.Code}");
        }
    }
}
