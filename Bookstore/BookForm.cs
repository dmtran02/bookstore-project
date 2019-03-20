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
using System.IO;

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
            string fullISBN = "";
            string leftISBN = txtISBNEntry1.Text;
            string rightISBN = txtISBNEntry2.Text;
            fullISBN += leftISBN;
            fullISBN += "-";
            fullISBN += rightISBN;
            
            if((txtISBNEntry1.Text.Length < Globals.BookStore.ISBNLeftLength && txtISBNEntry2.Text.Length < Globals.BookStore.ISBNRightLength) 
                || (txtISBNEntry1.Text.Length > Globals.BookStore.ISBNLeftLength && txtISBNEntry2.Text.Length > Globals.BookStore.ISBNRightLength))
            {
                MessageBox.Show("The left and right side of the ISBN should only consist of exactly three digits each (nnn-nnn).", "Invalid ISBN Found");
                txtISBNEntry1.Text = "";
                txtISBNEntry2.Text = "";
                txtISBNEntry1.Focus();
            }
            else if(txtISBNEntry1.Text.Length < Globals.BookStore.ISBNLeftLength && txtISBNEntry2.Text.Length < Globals.BookStore.ISBNRightLength)
            {
                MessageBox.Show("The left and right side of the ISBN should only consist of exactly three digits each (nnn-nnn).", "Invalid ISBN Found");
                txtISBNEntry1.Text = "";
                txtISBNEntry2.Text = "";
                txtISBNEntry1.Focus();
            }
            else if (txtISBNEntry1.Text.Length < Globals.BookStore.ISBNLeftLength || txtISBNEntry1.Text.Length > Globals.BookStore.ISBNLeftLength)
            {
                MessageBox.Show("The left side of the ISBN should only consist of exactly three digits.", "Invalid Leftmost ISBN Length Detected");
                txtISBNEntry1.Text = "";
                txtISBNEntry2.Text = "";
                txtISBNEntry1.Focus();
            }
            else if (txtISBNEntry2.Text.Length < Globals.BookStore.ISBNRightLength || txtISBNEntry2.Text.Length > Globals.BookStore.ISBNRightLength)
            {
                MessageBox.Show("The right side of the ISBN should only consist of exactly three digits.", "Invalid Rightmost ISBN Length Detected");
                txtISBNEntry1.Text = "";
                txtISBNEntry2.Text = "";
                txtISBNEntry1.Focus();
            }
            else if (Globals.BookStore.Book.verifyISBN(fullISBN))
            {
                btnISBNConfirm.Visible = false;
                lblISBNEntry.Text = "ISBN: ";
                lblSelectTransaction.Visible = true;
                btnAddBookTrans.Visible = true;
                btnUpdateBookTrans.Visible = true;
                btnDeleteBookTrans.Visible = true;

                txtISBNEntry1.ReadOnly = true;
                txtISBNEntry2.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("You have entered an invalid ISBN. Please try again.", "Invalid ISBN Detected");
                txtISBNEntry1.Text = "";
                txtISBNEntry2.Text = "";
                txtISBNEntry1.Focus();
            }
        }

        private void btnAddBookTrans_Click(object sender, EventArgs e)
        {
            btnDone.Visible = true;

            lblBookISBN.Visible = true;
            lblBookTitle.Visible = true;
            lblBookAuthor.Visible = true;
            lblBookPrice.Visible = true;
            lblOnHand.Visible = true;
            lblTransDate.Visible = true;

            txtBookISBN.Visible = true;
            txtBookTitle.Visible = true;
            txtBookAuthor.Visible = true;
            txtBookPrice.Visible = true;
            txtOnHand.Visible = true;
            txtTransDate.Visible = true;

            btnAddTransConfirm.Visible = true;
            btnAddTransCancel.Visible = true;
            btnUpdateTransConfirm.Visible = false;
            btnUpdateTransCancel.Visible = false;
            btnDeleteTransConfirm.Visible = false;
            btnDeleteTransCancel.Visible = false;

            txtBookISBN.Text = "";
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            txtBookPrice.Text = "";
            txtOnHand.Text = "";
            txtTransDate.Text = "";
        }

        private void btnUpdateBookTrans_Click(object sender, EventArgs e)
        {
            lblBookISBN.Visible = true;
            lblBookTitle.Visible = true;
            lblBookAuthor.Visible = true;
            lblBookPrice.Visible = true;
            lblOnHand.Visible = true;
            lblTransDate.Visible = true;

            txtBookISBN.Visible = true;
            txtBookTitle.Visible = true;
            txtBookAuthor.Visible = true;
            txtBookPrice.Visible = true;
            txtOnHand.Visible = true;
            txtTransDate.Visible = true;

            btnUpdateTransConfirm.Visible = true;
            btnUpdateTransCancel.Visible = true;
            btnAddTransConfirm.Visible = false;
            btnAddTransCancel.Visible = false;
            btnDeleteTransConfirm.Visible = false;
            btnDeleteTransCancel.Visible = false;

            // add text for textboxes of book information
            string bookISBN, bookTitle, bookAuthor, bookPrice, bookOnHand, bookTransDate;

            string fullISBN = "";
            string leftISBN = txtISBNEntry1.Text;
            string rightISBN = txtISBNEntry2.Text;
            fullISBN += leftISBN;
            fullISBN += "-";
            fullISBN += rightISBN;

            Globals.BookStore.Book.getRecord(fullISBN, out bookISBN, out bookTitle, out bookAuthor, out bookPrice, out bookOnHand, out bookTransDate);

            txtBookISBN.Text = bookISBN;
            txtBookTitle.Text = bookTitle;
            txtBookAuthor.Text = bookAuthor;
            txtBookPrice.Text = bookPrice;
            txtOnHand.Text = bookOnHand;
            txtTransDate.Text = bookTransDate;

            btnDone.Visible = true;
            Globals.BookStore.rewindFiles();
        }

        private void btnDeleteBookTrans_Click(object sender, EventArgs e)
        {
            // search for book isbn and delete it from list
            btnDeleteTransConfirm.Visible = true;
            btnDeleteTransCancel.Visible = true;
            btnAddTransConfirm.Visible = false;
            btnAddTransCancel.Visible = false;
            btnUpdateTransConfirm.Visible = false;
            btnUpdateTransCancel.Visible = false;

            lblBookISBN.Visible = false;
            lblBookTitle.Visible = false;
            lblBookAuthor.Visible = false;
            lblBookPrice.Visible = false;
            lblOnHand.Visible = false;
            lblTransDate.Visible = false;

            txtBookISBN.Visible = false;
            txtBookTitle.Visible = false;
            txtBookAuthor.Visible = false;
            txtBookPrice.Visible = false;
            txtOnHand.Visible = false;
            txtTransDate.Visible = false;

            txtBookISBN.Text = "";
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            txtBookPrice.Text = "";
            txtOnHand.Text = "";
            txtTransDate.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnISBNConfirm.Visible = true;
            lblISBNEntry.Text = "Enter the ISBN for the Book (nnn-nnn): ";
            lblSelectTransaction.Visible = false;
            btnAddBookTrans.Visible = false;
            btnUpdateBookTrans.Visible = false;
            btnDeleteBookTrans.Visible = false;

            lblBookISBN.Visible = false;
            lblBookTitle.Visible = false;
            lblBookAuthor.Visible = false;
            lblBookPrice.Visible = false;
            lblOnHand.Visible = false;
            lblTransDate.Visible = false;

            txtBookISBN.Visible = false;
            txtBookTitle.Visible = false;
            txtBookAuthor.Visible = false;
            txtBookPrice.Visible = false;
            txtOnHand.Visible = false;
            txtTransDate.Visible = false;

            txtBookISBN.Text = "";
            txtBookTitle.Text = "";
            txtBookAuthor.Text = "";
            txtBookPrice.Text = "";
            txtOnHand.Text = "";
            txtTransDate.Text = "";

            txtISBNEntry1.Text = "";
            txtISBNEntry1.ReadOnly = false;
            txtISBNEntry2.Text = "";
            txtISBNEntry2.ReadOnly = false;
            txtISBNEntry1.Focus();

            btnDone.Visible = false;
            btnDeleteTransConfirm.Visible = false;
            btnDeleteTransCancel.Visible = false;
            btnAddTransConfirm.Visible = false;
            btnAddTransCancel.Visible = false;
            btnUpdateTransConfirm.Visible = false;
            btnUpdateTransCancel.Visible = false;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Form1 mainMenuForm = new Form1();
            mainMenuForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTransConfirm_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            found = Globals.BookStore.checkForDuplicateRecord(txtBookISBN.Text);
            if(found == true)
            {
                MessageBox.Show("The new book was not added successfully...", "Add Transaction Failure");

            }
            else
            {
                string concatRecord = "";
                concatRecord += txtBookISBN.Text + " * " + txtBookTitle.Text + " * " + txtBookAuthor.Text + " * "
                    + txtBookPrice.Text + " * " + txtOnHand.Text + " * " + txtTransDate.Text;
                Boolean isDuplicate = false;
                Globals.BookStore.findAndSaveBook(txtBookISBN.Text, out isDuplicate);
                if (found)
                {
                    MessageBox.Show("isDuplicate = true");
                    Globals.BookStore.rewindFiles();
                }
                else
                {
                    Console.WriteLine("Else statement executed...");
                    if (Globals.BookStore.checkForDuplicateRecord(txtBookISBN.Text))
                    {
                        Console.WriteLine("Duplicate Record detected...");
                    }
                    //Globals.BookStore.writeOneRecord(concatRecord);
                    try
                    {
                        Console.WriteLine("Try statement executed...");
                        if (!File.Exists("updatedBookFile.txt"))
                        {
                            File.Create("updatedBookFile.txt").Dispose();

                            using (StreamWriter sw = File.AppendText("updatedBookFile.txt"))
                            {
                                sw.WriteLine(concatRecord);
                                sw.Dispose();
                                sw.Close();
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText("updatedBookFile.txt"))
                            {
                                sw.WriteLine(concatRecord);
                                sw.Dispose();
                                sw.Close();
                            }
                        }
                        /*
                        StreamWriter sw = new StreamWriter("updatedBookFile.txt");
                        sw.Write(concatRecord);
                        sw.Flush();
                        sw.Close();
                        */
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex);
                    }
                }
                MessageBox.Show("The new book has been added successfully!", "New Book Added!");
            }
        }

        private void btnAddTransCancel_Click(object sender, EventArgs e)
        {
            lblBookISBN.Visible = false;
            lblBookTitle.Visible = false;
            lblBookAuthor.Visible = false;
            lblBookPrice.Visible = false;
            lblOnHand.Visible = false;
            lblTransDate.Visible = false;

            txtBookISBN.Visible = false;
            txtBookISBN.Text = "";
            txtBookTitle.Visible = false;
            txtBookTitle.Text = "";
            txtBookAuthor.Visible = false;
            txtBookAuthor.Text = "";
            txtBookPrice.Visible = false;
            txtBookPrice.Text = "";
            txtOnHand.Visible = false;
            txtOnHand.Text = "";
            txtTransDate.Visible = false;
            txtTransDate.Text = "";

            btnAddTransConfirm.Visible = false;
            btnAddTransCancel.Visible = false;
        }

        //Copyremainingrecords findsavebook and checkduplicate

        private void btnUpdateTransConfirm_Click(object sender, EventArgs e)
        {
            string concatRecord = "";
            concatRecord += txtBookISBN.Text + " * " + txtBookTitle.Text + " * " + txtBookAuthor.Text + " * "
                + txtBookPrice.Text + " * " + txtOnHand.Text + " * " + txtTransDate.Text;
            Boolean found = false;
            Globals.BookStore.findAndSaveBook(txtBookISBN.Text, out found);
            if (found)
            {
                MessageBox.Show("found = true");
                Globals.BookStore.rewindFiles();
            }
            else
            {
                Console.WriteLine("Else statement executed...");
                if (Globals.BookStore.checkForDuplicateRecord(txtBookISBN.Text))
                {
                    Console.WriteLine("Duplicate Record detected...");
                }
                //Globals.BookStore.writeOneRecord(concatRecord);
                else
                {
                    Globals.BookStore.writeOneRecord(concatRecord);
                }
            }
            Globals.BookStore.rewindFiles();
        }

        private void btnUpdateTransCancel_Click(object sender, EventArgs e)
        {
            lblBookISBN.Visible = false;
            lblBookTitle.Visible = false;
            lblBookAuthor.Visible = false;
            lblBookPrice.Visible = false;
            lblOnHand.Visible = false;
            lblTransDate.Visible = false;

            txtBookISBN.Visible = false;
            txtBookISBN.Text = "";
            txtBookTitle.Visible = false;
            txtBookTitle.Text = "";
            txtBookAuthor.Visible = false;
            txtBookAuthor.Text = "";
            txtBookPrice.Visible = false;
            txtBookPrice.Text = "";
            txtOnHand.Visible = false;
            txtOnHand.Text = "";
            txtTransDate.Visible = false;
            txtTransDate.Text = "";

            btnUpdateTransConfirm.Visible = false;
            btnUpdateTransCancel.Visible = false;
        }

        private void btnDeleteTransConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTransCancel_Click(object sender, EventArgs e)
        {
            lblBookISBN.Visible = false;
            lblBookTitle.Visible = false;
            lblBookAuthor.Visible = false;
            lblBookPrice.Visible = false;
            lblOnHand.Visible = false;
            lblTransDate.Visible = false;

            txtBookISBN.Visible = false;
            txtBookISBN.Text = "";
            txtBookTitle.Visible = false;
            txtBookTitle.Text = "";
            txtBookAuthor.Visible = false;
            txtBookAuthor.Text = "";
            txtBookPrice.Visible = false;
            txtBookPrice.Text = "";
            txtOnHand.Visible = false;
            txtOnHand.Text = "";
            txtTransDate.Visible = false;
            txtTransDate.Text = "";

            btnDeleteTransConfirm.Visible = false;
            btnDeleteTransCancel.Visible = false;
        }
    }
}
