
namespace ClockInSystemPublic
{
    partial class FormAddTimecard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTimecard2));
            this.labelType = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelFullName = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.comboBoxAdminTypes = new System.Windows.Forms.ComboBox();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.Location = new System.Drawing.Point(41, 231);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(83, 29);
            this.labelType.TabIndex = 39;
            this.labelType.Text = "Type";
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(41, 98);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(83, 29);
            this.labelDate.TabIndex = 38;
            this.labelDate.Text = "Date";
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.Location = new System.Drawing.Point(41, 144);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(83, 29);
            this.labelTimeIn.TabIndex = 37;
            this.labelTimeIn.Text = "Time In";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(164, 94);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(156, 29);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Location = new System.Drawing.Point(21, 24);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(241, 52);
            this.labelFullName.TabIndex = 34;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOut.Location = new System.Drawing.Point(164, 185);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.ShowCheckBox = true;
            this.dateTimePickerOut.ShowUpDown = true;
            this.dateTimePickerOut.Size = new System.Drawing.Size(156, 29);
            this.dateTimePickerOut.TabIndex = 2;
            this.dateTimePickerOut.ValueChanged += new System.EventHandler(this.dateTimePickerOut_ValueChanged);
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerIn.Location = new System.Drawing.Point(164, 140);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.ShowUpDown = true;
            this.dateTimePickerIn.Size = new System.Drawing.Size(156, 29);
            this.dateTimePickerIn.TabIndex = 1;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(178, 324);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(115, 46);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(25, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 46);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.Location = new System.Drawing.Point(41, 189);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(99, 29);
            this.labelTimeOut.TabIndex = 40;
            this.labelTimeOut.Text = "Time Out";
            // 
            // comboBoxAdminTypes
            // 
            this.comboBoxAdminTypes.DropDownWidth = 225;
            this.comboBoxAdminTypes.FormattingEnabled = true;
            this.comboBoxAdminTypes.Location = new System.Drawing.Point(164, 266);
            this.comboBoxAdminTypes.Name = "comboBoxAdminTypes";
            this.comboBoxAdminTypes.Size = new System.Drawing.Size(156, 32);
            this.comboBoxAdminTypes.TabIndex = 42;
            this.comboBoxAdminTypes.Visible = false;
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Location = new System.Drawing.Point(164, 232);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(72, 28);
            this.radioButtonStore.TabIndex = 43;
            this.radioButtonStore.Text = "Store";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(249, 232);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(83, 28);
            this.radioButtonAdmin.TabIndex = 44;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // FormAddTimecard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 393);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonStore);
            this.Controls.Add(this.comboBoxAdminTypes);
            this.Controls.Add(this.labelTimeOut);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTimeIn);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAddTimecard2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Timecard";
            this.Load += new System.EventHandler(this.FormAddTimecard2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTimeIn;
        public System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.Label labelFullName;
        public System.Windows.Forms.DateTimePicker dateTimePickerOut;
        public System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTimeOut;
        public System.Windows.Forms.ComboBox comboBoxAdminTypes;
        private System.Windows.Forms.RadioButton radioButtonStore;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}