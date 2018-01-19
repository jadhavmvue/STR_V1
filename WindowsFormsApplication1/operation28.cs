using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class operation28 : Form
    {
        string userid = "", datetimeMD = "", datetimeMD1 = "", datetimeMD2 = "", update_txtBox1 = "", update_txtBox2 = "", update_txtBox3 = "", update_txtBox4 = "", update_txtBox5 = "", update_txtBox6 = "", update_txtBox7 = "", update_txtBox8 = "", update_txtBox9 = "", update_txtBox10 = "";
        int rowId;
        static string sConnectionString = ConfigurationManager.ConnectionStrings["MyConn007"].ConnectionString;
        public MySqlConnection myConn;
        public operation28(string id, int i)
        {
            InitializeComponent();
            userid = id;
            rowId = i;
        }

        private void operation28_Load(object sender, EventArgs e)
        {
            myConn = new MySqlConnection(sConnectionString);
            try
            {
                if (myConn != null) { }
                myConn.Open();

            }
            catch (System.Exception ex)
            {
                //restartApplication();
            }

            int rowcount = GlobalClass.dt.Rows.Count;
            if (GlobalClass.dt.Rows.Count == 0)
            {

                button2.Visible = false;

                button1.Visible = true;

            }

            else if (userid == "")
            {

                button2.Visible = false;

                button1.Visible = true;

            }

            else
            {
                try
                {
                    textBox1.Text = GlobalClass.dt.Rows[rowId][0].ToString();

                    textBox2.Text = GlobalClass.dt.Rows[rowId][1].ToString();

                    dateTimePicker1.Text = GlobalClass.dt.Rows[rowId][2].ToString();

                    dateTimePicker2.Text = GlobalClass.dt.Rows[rowId][3].ToString();

                    textBox5.Text = GlobalClass.dt.Rows[rowId][4].ToString();

                    textBox6.Text = GlobalClass.dt.Rows[rowId][5].ToString();

                    textBox7.Text = GlobalClass.dt.Rows[rowId][6].ToString();

                    textBox8.Text = GlobalClass.dt.Rows[rowId][7].ToString();

                    textBox9.Text = GlobalClass.dt.Rows[rowId][8].ToString();

                    textBox10.Text = GlobalClass.dt.Rows[rowId][9].ToString();

                    update_txtBox1 = textBox1.Text;
                    update_txtBox2 = textBox2.Text;
                    datetimeMD1 = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    datetimeMD2 = dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    //update_txtBox3 = textBox3.Text;
                    //update_txtBox4 = textBox4.Text;
                    update_txtBox5 = textBox5.Text;
                    update_txtBox6 = textBox6.Text;
                    update_txtBox7 = textBox7.Text;
                    update_txtBox8 = textBox8.Text;
                    update_txtBox9 = textBox9.Text;
                    update_txtBox10 = textBox10.Text;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

            }
        }
    }
}
