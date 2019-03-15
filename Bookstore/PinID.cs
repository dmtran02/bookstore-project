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

namespace Bookstore.Classes
{
    public partial class PinID : Form
    {
        int tryCount = 0;

        public PinID()
        {
            InitializeComponent();
            this.ActiveControl = txtPINEntry;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int holder = int.Parse(txtPINEntry.Text);
            if (Globals.BookStore.EmployeeList.verifyPin(holder))
            {
                this.Hide();
                BookForm BookForm = new BookForm();
                BookForm.Show();
            }
            else
            {
                tryCount++;
                txtPINEntry.Text = "";
                txtPINEntry.Focus();
                if (tryCount == Globals.BookStore.tryCountMax)
                {
                    MessageBox.Show("Max attempts reached. Force exitting now...", "Intrusion Alert!");
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tryCount = 0;
            this.Close();
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
