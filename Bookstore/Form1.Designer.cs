namespace Bookstore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLoginInstructions = new System.Windows.Forms.Label();
            this.btnFindMe = new System.Windows.Forms.Button();
            this.txtAccessIDEntry = new System.Windows.Forms.TextBox();
            this.picBoxWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(188, 23);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(189, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Bookworm Bookstore!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginInstructions
            // 
            this.lblLoginInstructions.AutoSize = true;
            this.lblLoginInstructions.Location = new System.Drawing.Point(77, 413);
            this.lblLoginInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginInstructions.Name = "lblLoginInstructions";
            this.lblLoginInstructions.Size = new System.Drawing.Size(317, 13);
            this.lblLoginInstructions.TabIndex = 1;
            this.lblLoginInstructions.Text = "Enter your FIVE DIGIT Access ID below and then click \"Find Me\"";
            // 
            // btnFindMe
            // 
            this.btnFindMe.Location = new System.Drawing.Point(323, 442);
            this.btnFindMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(54, 38);
            this.btnFindMe.TabIndex = 2;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = true;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // txtAccessIDEntry
            // 
            this.txtAccessIDEntry.Location = new System.Drawing.Point(131, 452);
            this.txtAccessIDEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccessIDEntry.Name = "txtAccessIDEntry";
            this.txtAccessIDEntry.Size = new System.Drawing.Size(134, 20);
            this.txtAccessIDEntry.TabIndex = 3;
            // 
            // picBoxWelcome
            // 
            this.picBoxWelcome.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWelcome.Image")));
            this.picBoxWelcome.Location = new System.Drawing.Point(52, 51);
            this.picBoxWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxWelcome.Name = "picBoxWelcome";
            this.picBoxWelcome.Size = new System.Drawing.Size(466, 349);
            this.picBoxWelcome.TabIndex = 4;
            this.picBoxWelcome.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 495);
            this.Controls.Add(this.picBoxWelcome);
            this.Controls.Add(this.txtAccessIDEntry);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.lblLoginInstructions);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Bookworm Bookstore";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLoginInstructions;
        private System.Windows.Forms.Button btnFindMe;
        private System.Windows.Forms.TextBox txtAccessIDEntry;
        private System.Windows.Forms.PictureBox picBoxWelcome;
    }
}

