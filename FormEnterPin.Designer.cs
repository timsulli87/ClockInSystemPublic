
namespace ClockInSystemPublic
{
    partial class FormEnterPin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterPin));
            this.labelEnterPin = new System.Windows.Forms.Label();
            this.textBoxEnterPin = new System.Windows.Forms.TextBox();
            this.buttonSubmitPin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnterPin
            // 
            this.labelEnterPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterPin.AutoSize = true;
            this.labelEnterPin.Location = new System.Drawing.Point(65, 25);
            this.labelEnterPin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEnterPin.Name = "labelEnterPin";
            this.labelEnterPin.Size = new System.Drawing.Size(87, 24);
            this.labelEnterPin.TabIndex = 0;
            this.labelEnterPin.Text = "Enter Pin";
            // 
            // textBoxEnterPin
            // 
            this.textBoxEnterPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEnterPin.Location = new System.Drawing.Point(59, 69);
            this.textBoxEnterPin.Name = "textBoxEnterPin";
            this.textBoxEnterPin.Size = new System.Drawing.Size(100, 29);
            this.textBoxEnterPin.TabIndex = 1;
            // 
            // buttonSubmitPin
            // 
            this.buttonSubmitPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmitPin.Location = new System.Drawing.Point(59, 123);
            this.buttonSubmitPin.Name = "buttonSubmitPin";
            this.buttonSubmitPin.Size = new System.Drawing.Size(100, 38);
            this.buttonSubmitPin.TabIndex = 2;
            this.buttonSubmitPin.Text = "Submit";
            this.buttonSubmitPin.UseVisualStyleBackColor = true;
            this.buttonSubmitPin.Click += new System.EventHandler(this.buttonSubmitPin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(59, 197);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 41);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormEnterPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 301);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSubmitPin);
            this.Controls.Add(this.textBoxEnterPin);
            this.Controls.Add(this.labelEnterPin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEnterPin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormEnterPin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterPin;
        private System.Windows.Forms.TextBox textBoxEnterPin;
        private System.Windows.Forms.Button buttonSubmitPin;
        private System.Windows.Forms.Button buttonExit;
    }
}

