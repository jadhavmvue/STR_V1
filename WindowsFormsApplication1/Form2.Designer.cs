namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ultimate_eleDataSet1 = new WindowsFormsApplication1.ultimate_eleDataSet1();
            this.currentSelectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.current_selectionTableAdapter = new WindowsFormsApplication1.ultimate_eleDataSet1TableAdapters.current_selectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimate_eleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSelectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.currentSelectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ultimate_eleDataSet1
            // 
            this.ultimate_eleDataSet1.DataSetName = "ultimate_eleDataSet1";
            this.ultimate_eleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currentSelectionBindingSource
            // 
            this.currentSelectionBindingSource.DataMember = "current selection";
            this.currentSelectionBindingSource.DataSource = this.ultimate_eleDataSet1;
            this.currentSelectionBindingSource.CurrentChanged += new System.EventHandler(this.currentSelectionBindingSource_CurrentChanged);
            // 
            // current_selectionTableAdapter
            // 
            this.current_selectionTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultimate_eleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSelectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ultimate_eleDataSet1 ultimate_eleDataSet1;
        private System.Windows.Forms.BindingSource currentSelectionBindingSource;
        private ultimate_eleDataSet1TableAdapters.current_selectionTableAdapter current_selectionTableAdapter;
    }
}