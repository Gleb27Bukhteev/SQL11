﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("21.10.2017 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " +
            time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main Main = new Main();
            Main.Show();
            this.Hide();   
        }
    }
}
