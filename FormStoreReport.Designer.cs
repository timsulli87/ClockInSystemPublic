
namespace ClockInSystemPublic
{
    partial class FormStoreReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoreReport));
            this.labelStore = new System.Windows.Forms.Label();
            this.radioButtonMarietta = new System.Windows.Forms.RadioButton();
            this.radioButtonBuford = new System.Windows.Forms.RadioButton();
            this.radioButtonAlpharetta = new System.Windows.Forms.RadioButton();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonRunReport = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStore
            // 
            this.labelStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.Location = new System.Drawing.Point(43, 25);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(54, 24);
            this.labelStore.TabIndex = 0;
            this.labelStore.Text = "Store";
            // 
            // radioButtonMarietta
            // 
            this.radioButtonMarietta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMarietta.AutoSize = true;
            this.radioButtonMarietta.Location = new System.Drawing.Point(155, 25);
            this.radioButtonMarietta.Name = "radioButtonMarietta";
            this.radioButtonMarietta.Size = new System.Drawing.Size(93, 28);
            this.radioButtonMarietta.TabIndex = 0;
            this.radioButtonMarietta.TabStop = true;
            this.radioButtonMarietta.Text = "Marietta";
            this.radioButtonMarietta.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuford
            // 
            this.radioButtonBuford.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBuford.AutoSize = true;
            this.radioButtonBuford.Location = new System.Drawing.Point(372, 25);
            this.radioButtonBuford.Name = "radioButtonBuford";
            this.radioButtonBuford.Size = new System.Drawing.Size(83, 28);
            this.radioButtonBuford.TabIndex = 2;
            this.radioButtonBuford.TabStop = true;
            this.radioButtonBuford.Text = "Buford";
            this.radioButtonBuford.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlpharetta
            // 
            this.radioButtonAlpharetta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonAlpharetta.AutoSize = true;
            this.radioButtonAlpharetta.Location = new System.Drawing.Point(254, 25);
            this.radioButtonAlpharetta.Name = "radioButtonAlpharetta";
            this.radioButtonAlpharetta.Size = new System.Drawing.Size(112, 28);
            this.radioButtonAlpharetta.TabIndex = 3;
            this.radioButtonAlpharetta.TabStop = true;
            this.radioButtonAlpharetta.Text = "Alpharetta";
            this.radioButtonAlpharetta.UseVisualStyleBackColor = true;
            // 
            // labelEndDate
            // 
            this.labelEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(43, 107);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(88, 24);
            this.labelEndDate.TabIndex = 4;
            this.labelEndDate.Text = "End Date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(43, 67);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(89, 24);
            this.labelStartDate.TabIndex = 5;
            this.labelStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(155, 63);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(117, 29);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(155, 103);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(117, 29);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // buttonRunReport
            // 
            this.buttonRunReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRunReport.Location = new System.Drawing.Point(99, 147);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(160, 37);
            this.buttonRunReport.TabIndex = 3;
            this.buttonRunReport.Text = "Run Report";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoBack.Location = new System.Drawing.Point(99, 582);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(160, 37);
            this.buttonGoBack.TabIndex = 6;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pin,
            this.First,
            this.Last,
            this.Type,
            this.TotalHours});
            this.dataGridViewReport.Location = new System.Drawing.Point(47, 201);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.Size = new System.Drawing.Size(565, 360);
            this.dataGridViewReport.TabIndex = 7;
            this.dataGridViewReport.TabStop = false;
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
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
            // FormStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 631);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonRunReport);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.radioButtonAlpharetta);
            this.Controls.Add(this.radioButtonBuford);
            this.Controls.Add(this.radioButtonMarietta);
            this.Controls.Add(this.labelStore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStoreReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.RadioButton radioButtonMarietta;
        private System.Windows.Forms.RadioButton radioButtonBuford;
        private System.Windows.Forms.RadioButton radioButtonAlpharetta;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonRunReport;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHours;
    }
}