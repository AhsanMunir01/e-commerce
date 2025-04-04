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
    public partial class CAshier : Form
    {
        public CAshier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closepic_Click(object sender, EventArgs e)
        {

        }

        private void cloasepic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelslide_Paint(object sender, PaintEventArgs e)
        {

        }

        public void slide(Button button)
        {
            panelslide.BackColor = Color.White;
            panelslide.Height = button.Height;
            panelslide.Top = button.Top;
        }

        private void newtranscationbtn_Click(object sender, EventArgs e)
        {
            slide(newtranscationbtn);
            GetTransNo();
        }

        private void Searchproductbtn_Click(object sender, EventArgs e)
        {
            slide(Searchproductbtn);
        }

        private void adddiscountbtn_Click(object sender, EventArgs e)
        {
            slide(adddiscountbtn);
        }

        private void clearcartbtn_Click(object sender, EventArgs e)
        {
            slide(clearcartbtn);
        }

        private void dailysalebtn_Click(object sender, EventArgs e)
        {
            slide(dailysalebtn);
        }

        private void changepasswordbtn_Click(object sender, EventArgs e)
        {
            slide(changepasswordbtn);
        }

        private void sattlepaymentbtn_Click(object sender, EventArgs e)
        {
            slide(sattlepaymentbtn);
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
             slide(Logoutbtn);
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void timer_Click(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToLongTimeString();
        }
         
        public void GetTransNo()
        {
            //implement this function
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transno = sdate + "1001";
            notransactionlbl.Text = transno;
        }

        private void notransactionlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
