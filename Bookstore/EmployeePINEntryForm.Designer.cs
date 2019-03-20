namespace Bookstore.Classes
{
    partial class PinID
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
            this.btn = new System.Windows.Forms.Button();
            this.lblPINEntry = new System.Windows.Forms.Label();
            this.txtPINEntry = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(514, 319);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(112, 54);
            this.btn.TabIndex = 0;
            this.btn.Text = "Submit";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblPINEntry
            // 
            this.lblPINEntry.AutoSize = true;
            this.lblPINEntry.Location = new System.Drawing.Point(85, 334);
            this.lblPINEntry.Name = "lblPINEntry";
            this.lblPINEntry.Size = new System.Drawing.Size(157, 25);
            this.lblPINEntry.TabIndex = 1;
            this.lblPINEntry.Text = "Enter your PIN:";
            // 
            // txtPINEntry
            // 
            this.txtPINEntry.Location = new System.Drawing.Point(248, 331);
            this.txtPINEntry.Name = "txtPINEntry";
            this.txtPINEntry.Size = new System.Drawing.Size(246, 31);
            this.txtPINEntry.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(658, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 43);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PinID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPINEntry);
            this.Controls.Add(this.lblPINEntry);
            this.Controls.Add(this.btn);
            this.Name = "PinID";
            this.Text = "Enter your PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblPINEntry;
        private System.Windows.Forms.TextBox txtPINEntry;
        private System.Windows.Forms.Button btnExit;
    }
}