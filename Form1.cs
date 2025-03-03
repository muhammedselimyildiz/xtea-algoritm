﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xtea_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xtea a = new Xtea();
            string str = textBox1.Text;
            string ky = textBox2.Text;
            textBox5.Text= a.Encrypt(str, ky);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xtea a = new Xtea();
            string str = textBox4.Text;
            string ky = textBox3.Text;
            textBox6.Text = a.Decrypt(str, ky);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 16)
            {
                MessageBox.Show("Your key must be at least 16 characters");
                textBox2.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 16)
            {
                MessageBox.Show("Your key must be at least 16 characters");
                textBox3.Focus();
            }
        }
    }
}
