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
                if (tryCount == Globals.BookStore.tryCountMax)
                {
                    MessageBox.Show("Max attempts reached. Force exitting now...", "Intrusion Alert!");
                    this.Close();
                }
            }
        }
    }
}
