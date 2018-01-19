namespace WindowsFormsApplication1
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpmdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultimate_eleDataSet = new WindowsFormsApplication1.ultimate_eleDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpmdataTableAdapter = new WindowsFormsApplication1.ultimate_eleDataSetTableAdapters.rpmdataTableAdapter();
            this.DataSet28 = new WindowsFormsApplication1.DataSet28();
            this.tbldata_28_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbldata_28_1TableAdapter = new WindowsFormsApplication1.DataSet28TableAdapters.tbldata_28_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rpmdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimate_eleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldata_28_1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpmdataBindingSource
            // 
            this.rpmdataBindingSource.DataMember = "rpmdata";
            this.rpmdataBindingSource.DataSource = this.ultimate_eleDataSet;
            // 
            // ultimate_eleDataSet
            // 
            this.ultimate_eleDataSet.DataSetName = "ultimate_eleDataSet";
            this.ultimate_eleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbldata_28_1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // rpmdataTableAdapter
            // 
            this.rpmdataTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet28_1
            // 
            this.DataSet28.DataSetName = "DataSet28_1";
            this.DataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldata_28_1BindingSource
            // 
            this.tbldata_28_1BindingSource.DataMember = "tbldata_28";
            this.tbldata_28_1BindingSource.DataSource = this.DataSet28;
            // 
            // tbldata_28_1TableAdapter
            // 
            this.tbldata_28_1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpmdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimate_eleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldata_28_1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rpmdataBindingSource;
        private ultimate_eleDataSet ultimate_eleDataSet;
        private ultimate_eleDataSetTableAdapters.rpmdataTableAdapter rpmdataTableAdapter;
        private System.Windows.Forms.BindingSource tbldata_28_1BindingSource;
        private DataSet28 DataSet28;
        private DataSet28TableAdapters.tbldata_28_1TableAdapter tbldata_28_1TableAdapter;
    }
}