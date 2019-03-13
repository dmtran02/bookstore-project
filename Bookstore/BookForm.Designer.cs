namespace Bookstore
{
    partial class BookForm
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
            this.lblISBNEntry = new System.Windows.Forms.Label();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.txtISBNEntry1 = new System.Windows.Forms.TextBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.txtISBNEntry2 = new System.Windows.Forms.TextBox();
            this.btnAddBookTrans = new System.Windows.Forms.Button();
            this.btnUpdateBookTrans = new System.Windows.Forms.Button();
            this.btnDeleteBookTrans = new System.Windows.Forms.Button();
            this.btnISBNConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblISBNEntry
            // 
            this.lblISBNEntry.AutoSize = true;
            this.lblISBNEntry.Location = new System.Drawing.Point(25, 47);
            this.lblISBNEntry.Name = "lblISBNEntry";
            this.lblISBNEntry.Size = new System.Drawing.Size(380, 25);
            this.lblISBNEntry.TabIndex = 0;
            this.lblISBNEntry.Text = "Enter the ISBN for the Book (nnn-nnn):";
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Location = new System.Drawing.Point(53, 123);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(215, 25);
            this.lblSelectTransaction.TabIndex = 1;
            this.lblSelectTransaction.Text = "Select a Transaction:";
            this.lblSelectTransaction.Visible = false;
            // 
            // txtISBNEntry1
            // 
            this.txtISBNEntry1.Location = new System.Drawing.Point(411, 47);
            this.txtISBNEntry1.Name = "txtISBNEntry1";
            this.txtISBNEntry1.Size = new System.Drawing.Size(99, 31);
            this.txtISBNEntry1.TabIndex = 2;
            this.txtISBNEntry1.TextChanged += new System.EventHandler(this.txtISBNEntry1_TextChanged);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(516, 47);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(19, 25);
            this.lblDash.TabIndex = 3;
            this.lblDash.Text = "-";
            // 
            // txtISBNEntry2
            // 
            this.txtISBNEntry2.Location = new System.Drawing.Point(541, 47);
            this.txtISBNEntry2.Name = "txtISBNEntry2";
            this.txtISBNEntry2.Size = new System.Drawing.Size(100, 31);
            this.txtISBNEntry2.TabIndex = 4;
            this.txtISBNEntry2.TextChanged += new System.EventHandler(this.txtISBNEntry2_TextChanged);
            // 
            // btnAddBookTrans
            // 
            this.btnAddBookTrans.Location = new System.Drawing.Point(203, 177);
            this.btnAddBookTrans.Name = "btnAddBookTrans";
            this.btnAddBookTrans.Size = new System.Drawing.Size(399, 37);
            this.btnAddBookTrans.TabIndex = 5;
            this.btnAddBookTrans.Text = "Add a New Book To Inventory";
            this.btnAddBookTrans.UseVisualStyleBackColor = true;
            this.btnAddBookTrans.Visible = false;
            this.btnAddBookTrans.Click += new System.EventHandler(this.btnAddBookTrans_Click);
            // 
            // btnUpdateBookTrans
            // 
            this.btnUpdateBookTrans.Location = new System.Drawing.Point(203, 247);
            this.btnUpdateBookTrans.Name = "btnUpdateBookTrans";
            this.btnUpdateBookTrans.Size = new System.Drawing.Size(399, 39);
            this.btnUpdateBookTrans.TabIndex = 6;
            this.btnUpdateBookTrans.Text = "Update a Book In Inventory";
            this.btnUpdateBookTrans.UseVisualStyleBackColor = true;
            this.btnUpdateBookTrans.Visible = false;
            this.btnUpdateBookTrans.Click += new System.EventHandler(this.btnUpdateBookTrans_Click);
            // 
            // btnDeleteBookTrans
            // 
            this.btnDeleteBookTrans.Location = new System.Drawing.Point(203, 314);
            this.btnDeleteBookTrans.Name = "btnDeleteBookTrans";
            this.btnDeleteBookTrans.Size = new System.Drawing.Size(399, 43);
            this.btnDeleteBookTrans.TabIndex = 7;
            this.btnDeleteBookTrans.Text = "Delete a Book From Inventory";
            this.btnDeleteBookTrans.UseVisualStyleBackColor = true;
            this.btnDeleteBookTrans.Visible = false;
            this.btnDeleteBookTrans.Click += new System.EventHandler(this.btnDeleteBookTrans_Click);
            // 
            // btnISBNConfirm
            // 
            this.btnISBNConfirm.Location = new System.Drawing.Point(659, 30);
            this.btnISBNConfirm.Name = "btnISBNConfirm";
            this.btnISBNConfirm.Size = new System.Drawing.Size(116, 62);
            this.btnISBNConfirm.TabIndex = 8;
            this.btnISBNConfirm.Text = "Confirm";
            this.btnISBNConfirm.UseVisualStyleBackColor = true;
            this.btnISBNConfirm.Click += new System.EventHandler(this.btnISBNConfirm_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.btnISBNConfirm);
            this.Controls.Add(this.btnDeleteBookTrans);
            this.Controls.Add(this.btnUpdateBookTrans);
            this.Controls.Add(this.btnAddBookTrans);
            this.Controls.Add(this.txtISBNEntry2);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.txtISBNEntry1);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.lblISBNEntry);
            this.Name = "BookForm";
            this.Text = "Book Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISBNEntry;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.TextBox txtISBNEntry1;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.TextBox txtISBNEntry2;
        private System.Windows.Forms.Button btnAddBookTrans;
        private System.Windows.Forms.Button btnUpdateBookTrans;
        private System.Windows.Forms.Button btnDeleteBookTrans;
        private System.Windows.Forms.Button btnISBNConfirm;
    }
}