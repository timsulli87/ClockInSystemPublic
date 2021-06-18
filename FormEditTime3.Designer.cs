
namespace ClockInSystemPublic
{
    partial class FormEditTime3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTime3));
            this.dateTimePickerChangeDate = new System.Windows.Forms.DateTimePicker();
            this.labelFullName = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonStore = new System.Windows.Forms.RadioButton();
            this.comboBoxAdminTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePickerChangeDate
            // 
            this.dateTimePickerChangeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerChangeDate.Location = new System.Drawing.Point(173, 95);
            this.dateTimePickerChangeDate.Name = "dateTimePickerChangeDate";
            this.dateTimePickerChangeDate.Size = new System.Drawing.Size(154, 29);
            this.dateTimePickerChangeDate.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Location = new System.Drawing.Point(50, 24);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(241, 52);
            this.labelFullName.TabIndex = 20;
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOut.Location = new System.Drawing.Point(173, 186);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.ShowCheckBox = true;
            this.dateTimePickerOut.ShowUpDown = true;
            this.dateTimePickerOut.Size = new System.Drawing.Size(154, 29);
            this.dateTimePickerOut.TabIndex = 2;
            this.dateTimePickerOut.ValueChanged += new System.EventHandler(this.dateTimePickerOut_ValueChanged);
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerIn.Location = new System.Drawing.Point(173, 141);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.ShowUpDown = true;
            this.dateTimePickerIn.Size = new System.Drawing.Size(154, 29);
            this.dateTimePickerIn.TabIndex = 1;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(190, 328);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(115, 46);
            this.buttonGoBack.TabIndex = 7;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(37, 328);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(115, 46);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.Location = new System.Drawing.Point(50, 145);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(83, 29);
            this.labelTimeIn.TabIndex = 26;
            this.labelTimeIn.Text = "Time In";
            this.labelTimeIn.Click += new System.EventHandler(this.labelTimeIn_Click);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(50, 99);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(83, 29);
            this.labelDate.TabIndex = 27;
            this.labelDate.Text = "Date";
            // 
            // labelType
            // 
            this.labelType.Location = new System.Drawing.Point(50, 232);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(83, 29);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Type";
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.Location = new System.Drawing.Point(50, 190);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(99, 29);
            this.labelTimeOut.TabIndex = 30;
            this.labelTimeOut.Text = "Time Out";
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(256, 232);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(83, 28);
            this.radioButtonAdmin.TabIndex = 4;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // radioButtonStore
            // 
            this.radioButtonStore.AutoSize = true;
            this.radioButtonStore.Location = new System.Drawing.Point(171, 232);
            this.radioButtonStore.Name = "radioButtonStore";
            this.radioButtonStore.Size = new System.Drawing.Size(72, 28);
            this.radioButtonStore.TabIndex = 3;
            this.radioButtonStore.Text = "Store";
            this.radioButtonStore.UseVisualStyleBackColor = true;
            // 
            // comboBoxAdminTypes
            // 
            this.comboBoxAdminTypes.DropDownWidth = 225;
            this.comboBoxAdminTypes.FormattingEnabled = true;
            this.comboBoxAdminTypes.Location = new System.Drawing.Point(171, 266);
            this.comboBoxAdminTypes.Name = "comboBoxAdminTypes";
            this.comboBoxAdminTypes.Size = new System.Drawing.Size(156, 32);
            this.comboBoxAdminTypes.TabIndex = 5;
            this.comboBoxAdminTypes.Visible = false;
            // 
            // FormEditTime3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 401);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonStore);
            this.Controls.Add(this.comboBoxAdminTypes);
            this.Controls.Add(this.labelTimeOut);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTimeIn);
            this.Controls.Add(this.dateTimePickerChangeDate);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonChange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormEditTime3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Time";
            this.Load += new System.EventHandler(this.FormEditTime3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePickerChangeDate;
        public System.Windows.Forms.Label labelFullName;
        public System.Windows.Forms.DateTimePicker dateTimePickerOut;
        public System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTimeOut;
        public System.Windows.Forms.ComboBox comboBoxAdminTypes;
        public System.Windows.Forms.RadioButton radioButtonStore;
        public System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}