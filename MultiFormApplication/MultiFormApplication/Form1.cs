﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
            

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown) {
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string password = tbpassword.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from users where username='{0}' and password='{1}'", uname, password);
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                new DashBoard().Show();
               
            }
            else {
                MessageBox.Show("Invalid user");
            }
            conn.Close();

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text;
            string password = tbpassword.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from users where username='{0}' and password='{1}'", uname, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                new DashBoard().Show();
                
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
            conn.Close();

        }
    }
}
