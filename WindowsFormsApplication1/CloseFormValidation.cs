﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class CloseFormValidation : Form
    {
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public CloseFormValidation()
        {
            InitializeComponent();
        }

        private void CloseFormValidation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Ultimate" && textBox2.Text.Trim() == "JadhavSir@123")
            {
                this.ReturnValue1 = "Port is Disconnected";
                this.DialogResult = DialogResult.OK;
                this.Close();              
            }
            else
            {
                label4.Text = "Please Enter Valid Name & Password";                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseFormValidation close111 = new CloseFormValidation();
            close111.Close();
            this.Close();
        }
    }
}
