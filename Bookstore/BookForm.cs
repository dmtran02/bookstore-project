using Bookstore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void txtISBNEntry1_TextChanged(object sender, EventArgs e)
        {
            if (txtISBNEntry1.Text.Length == Globals.BookStore.tryCountMax)
            {
                txtISBNEntry2.Focus();
            }
        }

        private void txtISBNEntry2_TextChanged(object sender, EventArgs e)
        {
            if (txtISBNEntry2.Text.Length == Globals.BookStore.tryCountMax)
            {
                btnISBNConfirm.Focus();
            }
        }

        private void btnISBNConfirm_Click(object sender, EventArgs e)
        {
            if (txtISBNEntry1.Text.Length < Globals.BookStore.ISBNLeftLength || txtISBNEntry1.Text.Length > Globals.BookStore.ISBNLeftLength)
            {
                MessageBox.Show("The left side of the ISBN should only consist of exactly three digits.", "Invalid Leftmost ISBN Length Detected");
                txtISBNEntry1.Focus();
            }
            else if (txtISBNEntry2.Text.Length < Globals.BookStore.ISBNRightLength || txtISBNEntry2.Text.Length > Globals.BookStore.ISBNRightLength)
            {
                MessageBox.Show("The right side of the ISBN should only consist of exactly three digits.", "Invalid Rightmost ISBN Length Detected");
                txtISBNEntry2.Focus();
            }
            else
            {
                btnISBNConfirm.Visible = false;
                lblISBNEntry.Visible = false;
                lblSelectTransaction.Visible = true;
                btnAddBookTrans.Visible = true;
                btnUpdateBookTrans.Visible = true;
                btnDeleteBookTrans.Visible = true;
            }
        }

        private void btnAddBookTrans_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateBookTrans_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBookTrans_Click(object sender, EventArgs e)
        {

        }
    }
}
