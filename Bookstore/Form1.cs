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
        public Form1()
        {
            InitializeComponent();
            Globals.BookStore.EmployeeList.initializeEntireList();
        }

        private void btnFindMe_Click(object sender, EventArgs e)
        {

        }
    }
}
