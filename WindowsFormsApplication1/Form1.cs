using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportParameter[] parms = new ReportParameter[4];
            parms[0] = new ReportParameter("Date", "123");
            parms[1] = new ReportParameter("Batch", "123");
            parms[2] = new ReportParameter("Shift", "123");
            parms[3] = new ReportParameter("Supervisor", "123");
            // parms[1] = new ReportParameter("param_course", textbox(n).text);
            this.reportViewer1.LocalReport.SetParameters(parms);

            // TODO: This line of code loads data into the 'DataSet28_1.tbldata_28_1' table. You can move, or remove it, as needed.
            this.tbldata_28_1TableAdapter.Fill(this.DataSet28.tbldata_28_1,"123");
            // TODO: This line of code loads data into the 'ultimate_eleDataSet.rpmdata' table. You can move, or remove it, as needed.
         //   this.rpmdataTableAdapter.Fill(this.ultimate_eleDataSet.rpmdata,"127",Convert.ToDateTime("2016-12-12 12:12:12"));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
