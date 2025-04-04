using System;
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
    public partial class stockentry : Form
    {
        public stockentry()
        {
            InitializeComponent();
        }

        private void linkLabelgenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getreference();
        }

        private void textBoxreferenceno_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void getreference()
        {
            Random random = new Random();
            textBoxreferenceno.Clear();
            textBoxreferenceno.Text = random.Next(100000, 999999).ToString();
        }

        private void linkLabelbrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockin productStockin = new ProductStockin();
            productStockin.ShowDialog();
        }

        private void entrybtn_Click(object sender, EventArgs e)
        {
              
        }

        public void clear()
        {
            textBoxreferenceno.Clear();
            textBoxstockinby.Clear();
            dateTimePickerstockindate.Value = DateTime.Now;
            

        }
    }
}
