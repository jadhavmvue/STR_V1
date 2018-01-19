using System;
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
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Ultimate" && textBox2.Text.Trim() == "JadhavSir@123")
            {
                MessageBox.Show("Login successfully ");

                Form3 asd = new Form3();
                asd.Show();
                this.Hide();
            }
            else
            {

                label4.Text = "Please Enter Valid Name & Password";
                //Form3 asd = new Form3();
                //asd.Show();
                //this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
