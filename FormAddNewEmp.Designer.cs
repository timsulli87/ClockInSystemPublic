
namespace ClockInSystemPublic
{
    partial class FormAddNewEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewEmp));
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.radioButtonEmp = new System.Windows.Forms.RadioButton();
            this.radioButtonMgr = new System.Windows.Forms.RadioButton();
            this.buttonCreateEmp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPin
            // 
            this.textBoxPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPin.Location = new System.Drawing.Point(169, 32);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(151, 29);
            this.textBoxPin.TabIndex = 0;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFName.Location = new System.Drawing.Point(169, 83);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(151, 29);
            this.textBoxFName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLName.Location = new System.Drawing.Point(169, 133);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(151, 29);
            this.textBoxLName.TabIndex = 2;
            // 
            // labelPin
            // 
            this.labelPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPin.AutoSize = true;
            this.labelPin.Location = new System.Drawing.Point(41, 32);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(42, 24);
            this.labelPin.TabIndex = 3;
            this.labelPin.Text = "Pin:";
            // 
            // labelFName
            // 
            this.labelFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(41, 83);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(106, 24);
            this.labelFName.TabIndex = 4;
            this.labelFName.Text = "First Name:";
            this.labelFName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelLName
            // 
            this.labelLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(41, 133);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(104, 24);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Last Name:";
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(41, 181);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(81, 24);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position:";
            // 
            // radioButtonEmp
            // 
            this.radioButtonEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEmp.AutoSize = true;
            this.radioButtonEmp.Location = new System.Drawing.Point(169, 179);
            this.radioButtonEmp.Name = "radioButtonEmp";
            this.radioButtonEmp.Size = new System.Drawing.Size(114, 28);
            this.radioButtonEmp.TabIndex = 7;
            this.radioButtonEmp.TabStop = true;
            this.radioButtonEmp.Text = "Employee";
            this.radioButtonEmp.UseVisualStyleBackColor = true;
            // 
            // radioButtonMgr
            // 
            this.radioButtonMgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMgr.AutoSize = true;
            this.radioButtonMgr.Location = new System.Drawing.Point(169, 213);
            this.radioButtonMgr.Name = "radioButtonMgr";
            this.radioButtonMgr.Size = new System.Drawing.Size(103, 28);
            this.radioButtonMgr.TabIndex = 8;
            this.radioButtonMgr.TabStop = true;
            this.radioButtonMgr.Text = "Manager";
            this.radioButtonMgr.UseVisualStyleBackColor = true;
            // 
            // buttonCreateEmp
            // 
            this.buttonCreateEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateEmp.Location = new System.Drawing.Point(67, 281);
            this.buttonCreateEmp.Name = "buttonCreateEmp";
            this.buttonCreateEmp.Size = new System.Drawing.Size(188, 44);
            this.buttonCreateEmp.TabIndex = 9;
            this.buttonCreateEmp.Text = "Create Employee";
            this.buttonCreateEmp.UseVisualStyleBackColor = true;
            this.buttonCreateEmp.Click += new System.EventHandler(this.buttonCreateEmp_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(67, 343);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(188, 44);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddNewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 418);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateEmp);
            this.Controls.Add(this.radioButtonMgr);
            this.Controls.Add(this.radioButtonEmp);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelPin);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxPin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAddNewEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.RadioButton radioButtonEmp;
        private System.Windows.Forms.RadioButton radioButtonMgr;
        private System.Windows.Forms.Button buttonCreateEmp;
        private System.Windows.Forms.Button buttonCancel;
    }
}