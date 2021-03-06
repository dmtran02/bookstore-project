﻿using Bookstore.Classes;
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
    public partial class Form1 : Form
    {
        private int tryCount = 0;

        public Form1()
        {
            InitializeComponent();
            Globals.BookStore.EmployeeList.initializeEntireList();
            this.ActiveControl = txtAccessIDEntry;
            this.Height = 550;
        }

        private void btnFindMe_Click(object sender, EventArgs e)
        {
            string test = txtAccessIDEntry.Text;
            int intTest;
            bool isNumerical = int.TryParse(test, out intTest);

            /*
             * First checks if the user input is numeric
             */

            if (isNumerical)
            {

                /*
                 * Second checks if the user input is appropriate length
                 */

                if(test.Length != Globals.BookStore.accessIDLength)
                {
                    MessageBox.Show("Please enter a valid Access ID!", "Invalid Access ID Detected");
                    tryCount++;
                    txtAccessIDEntry.Text = "";
                    txtAccessIDEntry.Focus();
                }
                else
                {
                    int accessID = int.Parse(txtAccessIDEntry.Text);
                    //Console.WriteLine(accessID);
                    if(Globals.BookStore.findEmployee(accessID))
                    {
                        // MessageBox.Show("Employee ID has been found!", "You have been found!");
                        this.Hide();
                        PinID PINForm = new PinID();
                        PINForm.Show();
                        tryCount = 0;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Access ID.", "Invalid Access ID Detected");
                        tryCount++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Access ID!", "Invalid Access ID Detected");
                tryCount++;
                txtAccessIDEntry.Focus();
            }

            /*
             * This if statement tracks the attempts the user makes before force exitting the program.
             */

            if(tryCount == Globals.BookStore.tryCountMax)
            {
                MessageBox.Show("You have reached the max attempts... Force Exitting now...", "Intrusion Detected");
                this.Close();
            }
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Globals.BookStore.rewindFiles();
            Application.Exit();
        }
    }
}
