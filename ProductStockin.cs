﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductStockin : Form
    {
        public ProductStockin()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DGVproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
