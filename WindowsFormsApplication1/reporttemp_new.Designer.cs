﻿namespace WindowsFormsApplication1
{
    partial class reporttemp_new
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet28 = new WindowsFormsApplication1.DataSet28();
            this.temp_calculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_import = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.supervisertxt = new System.Windows.Forms.TextBox();
            this.superviserlbl = new System.Windows.Forms.Label();
            this.b10 = new System.Windows.Forms.TextBox();
            this.b9 = new System.Windows.Forms.TextBox();
            this.b8 = new System.Windows.Forms.TextBox();
            this.b6 = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.TextBox();
            this.b5 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.batchtxt = new System.Windows.Forms.TextBox();
            this.shiftlbl = new System.Windows.Forms.Label();
            this.shiftcombo = new System.Windows.Forms.ComboBox();
            this.batchlbl = new System.Windows.Forms.Label();
            this.benchbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.chembercombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tempTableAdapter = new WindowsFormsApplication1.DataSet28TableAdapters.tempTableAdapter();
            this.temp_calculationTableAdapter = new WindowsFormsApplication1.DataSet28TableAdapters.temp_calculationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_calculationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tempBindingSource
            // 
            this.tempBindingSource.DataMember = "temp";
            this.tempBindingSource.DataSource = this.DataSet28;
            this.tempBindingSource.CurrentChanged += new System.EventHandler(this.tempBindingSource_CurrentChanged);
            // 
            // DataSet28
            // 
            this.DataSet28.DataSetName = "DataSet28";
            this.DataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temp_calculationBindingSource
            // 
            this.temp_calculationBindingSource.DataMember = "temp_calculation";
            this.temp_calculationBindingSource.DataSource = this.DataSet28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.supervisertxt);
            this.panel1.Controls.Add(this.superviserlbl);
            this.panel1.Controls.Add(this.b10);
            this.panel1.Controls.Add(this.b9);
            this.panel1.Controls.Add(this.b8);
            this.panel1.Controls.Add(this.b6);
            this.panel1.Controls.Add(this.b7);
            this.panel1.Controls.Add(this.b5);
            this.panel1.Controls.Add(this.b4);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b1);
            this.panel1.Controls.Add(this.batchtxt);
            this.panel1.Controls.Add(this.shiftlbl);
            this.panel1.Controls.Add(this.shiftcombo);
            this.panel1.Controls.Add(this.batchlbl);
            this.panel1.Controls.Add(this.benchbl);
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.chembercombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 140);
            this.panel1.TabIndex = 2;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(715, 108);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(54, 23);
            this.btn_import.TabIndex = 19;
            this.btn_import.Text = "Refresh";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Visible = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(596, 42);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 17;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(674, 42);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 16;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // supervisertxt
            // 
            this.supervisertxt.Location = new System.Drawing.Point(655, 80);
            this.supervisertxt.Name = "supervisertxt";
            this.supervisertxt.Size = new System.Drawing.Size(100, 20);
            this.supervisertxt.TabIndex = 5;
            // 
            // superviserlbl
            // 
            this.superviserlbl.AutoSize = true;
            this.superviserlbl.Location = new System.Drawing.Point(594, 83);
            this.superviserlbl.Name = "superviserlbl";
            this.superviserlbl.Size = new System.Drawing.Size(57, 13);
            this.superviserlbl.TabIndex = 11;
            this.superviserlbl.Text = "Supervisor";
            // 
            // b10
            // 
            this.b10.Location = new System.Drawing.Point(652, 106);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(57, 20);
            this.b10.TabIndex = 15;
            this.b10.Text = "11";
            this.b10.Visible = false;
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(589, 106);
            this.b9.Name = "b9";
            this.b9.ReadOnly = true;
            this.b9.Size = new System.Drawing.Size(57, 20);
            this.b9.TabIndex = 14;
            this.b9.Text = "L.B.C.";
            this.b9.Visible = false;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(526, 106);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(57, 20);
            this.b8.TabIndex = 13;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(400, 106);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(57, 20);
            this.b6.TabIndex = 11;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(463, 106);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(57, 20);
            this.b7.TabIndex = 12;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(333, 106);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(57, 20);
            this.b5.TabIndex = 10;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(270, 106);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(57, 20);
            this.b4.TabIndex = 9;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(207, 106);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(57, 20);
            this.b3.TabIndex = 8;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(144, 106);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(57, 20);
            this.b2.TabIndex = 7;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(81, 106);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(57, 20);
            this.b1.TabIndex = 6;
            // 
            // batchtxt
            // 
            this.batchtxt.Location = new System.Drawing.Point(483, 81);
            this.batchtxt.Name = "batchtxt";
            this.batchtxt.Size = new System.Drawing.Size(100, 20);
            this.batchtxt.TabIndex = 4;
            // 
            // shiftlbl
            // 
            this.shiftlbl.AutoSize = true;
            this.shiftlbl.Location = new System.Drawing.Point(268, 84);
            this.shiftlbl.Name = "shiftlbl";
            this.shiftlbl.Size = new System.Drawing.Size(28, 13);
            this.shiftlbl.TabIndex = 9;
            this.shiftlbl.Text = "Shift";
            // 
            // shiftcombo
            // 
            this.shiftcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftcombo.FormattingEnabled = true;
            this.shiftcombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.shiftcombo.Location = new System.Drawing.Point(296, 79);
            this.shiftcombo.Name = "shiftcombo";
            this.shiftcombo.Size = new System.Drawing.Size(121, 21);
            this.shiftcombo.TabIndex = 3;
            this.shiftcombo.SelectedIndexChanged += new System.EventHandler(this.shiftcombo_SelectedIndexChanged);
            // 
            // batchlbl
            // 
            this.batchlbl.AutoSize = true;
            this.batchlbl.Location = new System.Drawing.Point(442, 86);
            this.batchlbl.Name = "batchlbl";
            this.batchlbl.Size = new System.Drawing.Size(35, 13);
            this.batchlbl.TabIndex = 7;
            this.batchlbl.Text = "Batch";
            // 
            // benchbl
            // 
            this.benchbl.AutoSize = true;
            this.benchbl.Location = new System.Drawing.Point(20, 113);
            this.benchbl.Name = "benchbl";
            this.benchbl.Size = new System.Drawing.Size(55, 13);
            this.benchbl.TabIndex = 5;
            this.benchbl.Text = "Bench No";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(19, 85);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(36, 13);
            this.datelbl.TabIndex = 5;
            this.datelbl.Text = "Date :";
            // 
            // chembercombo
            // 
            this.chembercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chembercombo.FormattingEnabled = true;
            this.chembercombo.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.chembercombo.Location = new System.Drawing.Point(353, 50);
            this.chembercombo.Name = "chembercombo";
            this.chembercombo.Size = new System.Drawing.Size(121, 21);
            this.chembercombo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chember :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Steam Curing Report";
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.tempBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.temp_calculationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report12 - Copy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 144);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(774, 517);
            this.reportViewer1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(774, 517);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tempTableAdapter
            // 
            this.tempTableAdapter.ClearBeforeFill = true;
            // 
            // temp_calculationTableAdapter
            // 
            this.temp_calculationTableAdapter.ClearBeforeFill = true;
            // 
            // reporttemp_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "reporttemp_new";
            this.Text = "Steam Curing Report";
            this.Load += new System.EventHandler(this.reporttemp_new_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reporttemp_new_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_calculationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox supervisertxt;
        private System.Windows.Forms.Label superviserlbl;
        private System.Windows.Forms.TextBox b10;
        private System.Windows.Forms.TextBox b9;
        private System.Windows.Forms.TextBox b8;
        private System.Windows.Forms.TextBox b6;
        private System.Windows.Forms.TextBox b7;
        private System.Windows.Forms.TextBox b5;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox batchtxt;
        private System.Windows.Forms.Label shiftlbl;
        private System.Windows.Forms.Label batchlbl;
        private System.Windows.Forms.Label benchbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.ComboBox chembercombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftcombo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tempBindingSource;
        private DataSet28 DataSet28;
        private System.Windows.Forms.BindingSource temp_calculationBindingSource;
        private DataSet28TableAdapters.tempTableAdapter tempTableAdapter;
        private DataSet28TableAdapters.temp_calculationTableAdapter temp_calculationTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_import;
    }
}