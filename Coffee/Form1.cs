﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service.userService ds = new Service.userService();
            label2.Text =ds.getUser();

        }
    }
}
