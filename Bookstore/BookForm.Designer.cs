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
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.txtBookISBN = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtOnHand = new System.Windows.Forms.TextBox();
            this.txtTransDate = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblISBNEntry
            // 
            this.lblISBNEntry.AutoSize = true;
            this.lblISBNEntry.Location = new System.Drawing.Point(98, 54);
            this.lblISBNEntry.Name = "lblISBNEntry";
            this.lblISBNEntry.Size = new System.Drawing.Size(380, 25);
            this.lblISBNEntry.TabIndex = 0;
            this.lblISBNEntry.Text = "Enter the ISBN for the Book (nnn-nnn):";
            this.lblISBNEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Location = new System.Drawing.Point(126, 130);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(215, 25);
            this.lblSelectTransaction.TabIndex = 1;
            this.lblSelectTransaction.Text = "Select a Transaction:";
            this.lblSelectTransaction.Visible = false;
            // 
            // txtISBNEntry1
            // 
            this.txtISBNEntry1.Location = new System.Drawing.Point(484, 54);
            this.txtISBNEntry1.Name = "txtISBNEntry1";
            this.txtISBNEntry1.Size = new System.Drawing.Size(99, 31);
            this.txtISBNEntry1.TabIndex = 2;
            this.txtISBNEntry1.TextChanged += new System.EventHandler(this.txtISBNEntry1_TextChanged);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(589, 54);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(19, 25);
            this.lblDash.TabIndex = 3;
            this.lblDash.Text = "-";
            // 
            // txtISBNEntry2
            // 
            this.txtISBNEntry2.Location = new System.Drawing.Point(614, 54);
            this.txtISBNEntry2.Name = "txtISBNEntry2";
            this.txtISBNEntry2.Size = new System.Drawing.Size(100, 31);
            this.txtISBNEntry2.TabIndex = 4;
            this.txtISBNEntry2.TextChanged += new System.EventHandler(this.txtISBNEntry2_TextChanged);
            // 
            // btnAddBookTrans
            // 
            this.btnAddBookTrans.Location = new System.Drawing.Point(276, 184);
            this.btnAddBookTrans.Name = "btnAddBookTrans";
            this.btnAddBookTrans.Size = new System.Drawing.Size(399, 42);
            this.btnAddBookTrans.TabIndex = 5;
            this.btnAddBookTrans.Text = "Add a New Book To Inventory";
            this.btnAddBookTrans.UseVisualStyleBackColor = true;
            this.btnAddBookTrans.Visible = false;
            this.btnAddBookTrans.Click += new System.EventHandler(this.btnAddBookTrans_Click);
            // 
            // btnUpdateBookTrans
            // 
            this.btnUpdateBookTrans.Location = new System.Drawing.Point(276, 247);
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
            this.btnDeleteBookTrans.Location = new System.Drawing.Point(276, 313);
            this.btnDeleteBookTrans.Name = "btnDeleteBookTrans";
            this.btnDeleteBookTrans.Size = new System.Drawing.Size(399, 37);
            this.btnDeleteBookTrans.TabIndex = 7;
            this.btnDeleteBookTrans.Text = "Delete a Book From Inventory";
            this.btnDeleteBookTrans.UseVisualStyleBackColor = true;
            this.btnDeleteBookTrans.Visible = false;
            this.btnDeleteBookTrans.Click += new System.EventHandler(this.btnDeleteBookTrans_Click);
            // 
            // btnISBNConfirm
            // 
            this.btnISBNConfirm.Location = new System.Drawing.Point(732, 37);
            this.btnISBNConfirm.Name = "btnISBNConfirm";
            this.btnISBNConfirm.Size = new System.Drawing.Size(116, 62);
            this.btnISBNConfirm.TabIndex = 8;
            this.btnISBNConfirm.Text = "Confirm";
            this.btnISBNConfirm.UseVisualStyleBackColor = true;
            this.btnISBNConfirm.Click += new System.EventHandler(this.btnISBNConfirm_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(74, 481);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(59, 25);
            this.lblBookTitle.TabIndex = 9;
            this.lblBookTitle.Text = "Title:";
            this.lblBookTitle.Visible = false;
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(67, 403);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(66, 25);
            this.lblBookISBN.TabIndex = 10;
            this.lblBookISBN.Text = "ISBN:";
            this.lblBookISBN.Visible = false;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(52, 560);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(81, 25);
            this.lblBookAuthor.TabIndex = 11;
            this.lblBookAuthor.Text = "Author:";
            this.lblBookAuthor.Visible = false;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(583, 403);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(67, 25);
            this.lblBookPrice.TabIndex = 12;
            this.lblBookPrice.Text = "Price:";
            this.lblBookPrice.Visible = false;
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Location = new System.Drawing.Point(547, 481);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(103, 25);
            this.lblOnHand.TabIndex = 13;
            this.lblOnHand.Text = "On Hand:";
            this.lblOnHand.Visible = false;
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.Location = new System.Drawing.Point(468, 560);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(182, 25);
            this.lblTransDate.TabIndex = 14;
            this.lblTransDate.Text = "Transaction Date:";
            this.lblTransDate.Visible = false;
            // 
            // txtBookISBN
            // 
            this.txtBookISBN.Location = new System.Drawing.Point(139, 400);
            this.txtBookISBN.Name = "txtBookISBN";
            this.txtBookISBN.Size = new System.Drawing.Size(202, 31);
            this.txtBookISBN.TabIndex = 15;
            this.txtBookISBN.Visible = false;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(139, 478);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(202, 31);
            this.txtBookTitle.TabIndex = 16;
            this.txtBookTitle.Visible = false;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(139, 557);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(202, 31);
            this.txtBookAuthor.TabIndex = 17;
            this.txtBookAuthor.Visible = false;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(656, 400);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(202, 31);
            this.txtBookPrice.TabIndex = 18;
            this.txtBookPrice.Visible = false;
            // 
            // txtOnHand
            // 
            this.txtOnHand.Location = new System.Drawing.Point(656, 478);
            this.txtOnHand.Name = "txtOnHand";
            this.txtOnHand.Size = new System.Drawing.Size(202, 31);
            this.txtOnHand.TabIndex = 19;
            this.txtOnHand.Visible = false;
            // 
            // txtTransDate
            // 
            this.txtTransDate.Location = new System.Drawing.Point(656, 557);
            this.txtTransDate.Name = "txtTransDate";
            this.txtTransDate.Size = new System.Drawing.Size(202, 31);
            this.txtTransDate.TabIndex = 20;
            this.txtTransDate.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(401, 628);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(117, 48);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(894, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 62);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 688);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtTransDate);
            this.Controls.Add(this.txtOnHand);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookISBN);
            this.Controls.Add(this.lblTransDate);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookISBN);
            this.Controls.Add(this.lblBookTitle);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClose);
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
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label lblTransDate;
        private System.Windows.Forms.TextBox txtBookISBN;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtOnHand;
        private System.Windows.Forms.TextBox txtTransDate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnExit;
    }
}