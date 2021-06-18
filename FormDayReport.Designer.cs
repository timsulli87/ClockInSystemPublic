
namespace ClockInSystemPublic
{
    partial class FormDayReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDayReport));
            this.radioButtonAlpharetta = new System.Windows.Forms.RadioButton();
            this.radioButtonBuford = new System.Windows.Forms.RadioButton();
            this.radioButtonMarietta = new System.Windows.Forms.RadioButton();
            this.labelStore = new System.Windows.Forms.Label();
            this.buttonRunReport = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAlpharetta
            // 
            this.radioButtonAlpharetta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAlpharetta.AutoSize = true;
            this.radioButtonAlpharetta.Location = new System.Drawing.Point(145, 61);
            this.radioButtonAlpharetta.Name = "radioButtonAlpharetta";
            this.radioButtonAlpharetta.Size = new System.Drawing.Size(112, 28);
            this.radioButtonAlpharetta.TabIndex = 1;
            this.radioButtonAlpharetta.TabStop = true;
            this.radioButtonAlpharetta.Text = "Alpharetta";
            this.radioButtonAlpharetta.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuford
            // 
            this.radioButtonBuford.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBuford.AutoSize = true;
            this.radioButtonBuford.Location = new System.Drawing.Point(263, 61);
            this.radioButtonBuford.Name = "radioButtonBuford";
            this.radioButtonBuford.Size = new System.Drawing.Size(83, 28);
            this.radioButtonBuford.TabIndex = 2;
            this.radioButtonBuford.TabStop = true;
            this.radioButtonBuford.Text = "Buford";
            this.radioButtonBuford.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarietta
            // 
            this.radioButtonMarietta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMarietta.AutoSize = true;
            this.radioButtonMarietta.Location = new System.Drawing.Point(46, 61);
            this.radioButtonMarietta.Name = "radioButtonMarietta";
            this.radioButtonMarietta.Size = new System.Drawing.Size(93, 28);
            this.radioButtonMarietta.TabIndex = 0;
            this.radioButtonMarietta.TabStop = true;
            this.radioButtonMarietta.Text = "Marietta";
            this.radioButtonMarietta.UseVisualStyleBackColor = true;
            // 
            // labelStore
            // 
            this.labelStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(42, 22);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(54, 24);
            this.labelStore.TabIndex = 5;
            this.labelStore.Text = "Store";
            // 
            // buttonRunReport
            // 
            this.buttonRunReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunReport.Location = new System.Drawing.Point(298, 108);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(160, 37);
            this.buttonRunReport.TabIndex = 4;
            this.buttonRunReport.Text = "Run Report";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.First,
            this.Last,
            this.In,
            this.Out,
            this.Type,
            this.TotalHours});
            this.dataGridViewReport.Location = new System.Drawing.Point(46, 166);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.Size = new System.Drawing.Size(764, 374);
            this.dataGridViewReport.TabIndex = 9;
            this.dataGridViewReport.TabStop = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoBack.Location = new System.Drawing.Point(298, 561);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(160, 37);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(422, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 24);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(426, 60);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(135, 29);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Pin";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // First
            // 
            this.First.HeaderText = "First";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            // 
            // Last
            // 
            this.Last.HeaderText = "Last";
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            // 
            // In
            // 
            this.In.HeaderText = "In";
            this.In.Name = "In";
            this.In.ReadOnly = true;
            // 
            // Out
            // 
            this.Out.HeaderText = "Out";
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // TotalHours
            // 
            this.TotalHours.HeaderText = "Total Hours";
            this.TotalHours.Name = "TotalHours";
            this.TotalHours.ReadOnly = true;
            // 
            // FormDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 621);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.buttonRunReport);
            this.Controls.Add(this.radioButtonAlpharetta);
            this.Controls.Add(this.radioButtonBuford);
            this.Controls.Add(this.radioButtonMarietta);
            this.Controls.Add(this.labelStore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlpharetta;
        private System.Windows.Forms.RadioButton radioButtonBuford;
        private System.Windows.Forms.RadioButton radioButtonMarietta;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button buttonRunReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHours;
    }
}