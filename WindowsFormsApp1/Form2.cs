﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        public void open (object obj)
        {
            Application.Run(new Form1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open1(object obj)
        {
            Application.Run(new Form5());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open2(object obj)
        {
            Application.Run(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open3(object obj)
        {
            Application.Run(new Form3());
        }
    }
}
