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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            titlelable.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void hidesubmenu()
        {
            
            if (panelsubsetting.Visible == true)
                panelsubsetting.Visible = false;
        }
        private void customizedesign()
        {
           
            panelsubsetting.Visible = false;
        }

        private void setting_Click(object sender, EventArgs e)
        {
           showsubmenu(panelsubsetting);

        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new User_Account());
            hidesubmenu();

        }

        private void storebtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Store());
            hidesubmenu();
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
