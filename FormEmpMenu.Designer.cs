
namespace ClockInSystemPublic
{
    partial class FormEmpMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpMenu));
            this.buttonClockInStore = new System.Windows.Forms.Button();
            this.buttonClockOut = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelEmpInfo = new System.Windows.Forms.Label();
            this.buttonClockinAdmin = new System.Windows.Forms.Button();
            this.buttonEmpReport = new System.Windows.Forms.Button();
            this.comboBoxAdminTypes = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClockInStore
            // 
            this.buttonClockInStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClockInStore.Location = new System.Drawing.Point(64, 91);
            this.buttonClockInStore.Name = "buttonClockInStore";
            this.buttonClockInStore.Size = new System.Drawing.Size(166, 36);
            this.buttonClockInStore.TabIndex = 0;
            this.buttonClockInStore.Text = "Clock In Store";
            this.buttonClockInStore.UseVisualStyleBackColor = true;
            this.buttonClockInStore.Click += new System.EventHandler(this.buttonClockInStore_Click);
            // 
            // buttonClockOut
            // 
            this.buttonClockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClockOut.Location = new System.Drawing.Point(64, 292);
            this.buttonClockOut.Name = "buttonClockOut";
            this.buttonClockOut.Size = new System.Drawing.Size(166, 36);
            this.buttonClockOut.TabIndex = 2;
            this.buttonClockOut.Text = "Clock Out";
            this.buttonClockOut.UseVisualStyleBackColor = true;
            this.buttonClockOut.Click += new System.EventHandler(this.buttonClockOut_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(64, 388);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(166, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelEmpInfo
            // 
            this.labelEmpInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmpInfo.Location = new System.Drawing.Point(84, 23);
            this.labelEmpInfo.Name = "labelEmpInfo";
            this.labelEmpInfo.Size = new System.Drawing.Size(146, 48);
            this.labelEmpInfo.TabIndex = 3;
            // 
            // buttonClockinAdmin
            // 
            this.buttonClockinAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClockinAdmin.Location = new System.Drawing.Point(64, 144);
            this.buttonClockinAdmin.Name = "buttonClockinAdmin";
            this.buttonClockinAdmin.Size = new System.Drawing.Size(166, 36);
            this.buttonClockinAdmin.TabIndex = 1;
            this.buttonClockinAdmin.Text = "Clock In Admin";
            this.buttonClockinAdmin.UseVisualStyleBackColor = true;
            this.buttonClockinAdmin.Click += new System.EventHandler(this.buttonClockinAdmin_Click);
            // 
            // buttonEmpReport
            // 
            this.buttonEmpReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmpReport.Location = new System.Drawing.Point(64, 340);
            this.buttonEmpReport.Name = "buttonEmpReport";
            this.buttonEmpReport.Size = new System.Drawing.Size(166, 36);
            this.buttonEmpReport.TabIndex = 3;
            this.buttonEmpReport.Text = "View My Hours";
            this.buttonEmpReport.UseVisualStyleBackColor = true;
            this.buttonEmpReport.Click += new System.EventHandler(this.buttonEmpReport_Click);
            // 
            // comboBoxAdminTypes
            // 
            this.comboBoxAdminTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAdminTypes.DropDownWidth = 225;
            this.comboBoxAdminTypes.FormattingEnabled = true;
            this.comboBoxAdminTypes.Location = new System.Drawing.Point(64, 196);
            this.comboBoxAdminTypes.Name = "comboBoxAdminTypes";
            this.comboBoxAdminTypes.Size = new System.Drawing.Size(166, 32);
            this.comboBoxAdminTypes.TabIndex = 5;
            this.comboBoxAdminTypes.Text = "   <Select Type>";
            this.comboBoxAdminTypes.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.Location = new System.Drawing.Point(64, 244);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(166, 36);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormEmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 443);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxAdminTypes);
            this.Controls.Add(this.buttonEmpReport);
            this.Controls.Add(this.buttonClockinAdmin);
            this.Controls.Add(this.labelEmpInfo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonClockOut);
            this.Controls.Add(this.buttonClockInStore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEmpMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Menu";
            this.Load += new System.EventHandler(this.FormEmpMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClockInStore;
        private System.Windows.Forms.Button buttonClockOut;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label labelEmpInfo;
        private System.Windows.Forms.Button buttonClockinAdmin;
        private System.Windows.Forms.Button buttonEmpReport;
        private System.Windows.Forms.ComboBox comboBoxAdminTypes;
        private System.Windows.Forms.Button buttonConfirm;
    }
}