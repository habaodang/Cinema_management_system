﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public partial class mainTest : Form
    {
        public mainTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addMovieForm f = new addMovieForm();
            f.Show();
            this.Hide();
        }

        private void mainTest_Load(object sender, EventArgs e)
        {

        }
    }
}
