﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultimate_eleDataSet1.current_selection' table. You can move, or remove it, as needed.
            this.current_selectionTableAdapter.Fill(this.ultimate_eleDataSet1.current_selection);

        }

        private void currentSelectionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
