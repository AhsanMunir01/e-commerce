using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserMain : Form
    {
        private int currentUserId = 1; // Replace this with actual user ID from login logic.
        private int currentProductId = 123; // Replace this with actual product ID as needed.
       // private Form activeForm = null;
        public UserMain()
        {
            InitializeComponent();

        }

        #region button

        private void shopnamelbl_Click(object sender, EventArgs e)
        {

        }

        private void cloasepic_Click(object sender, EventArgs e)
        {
            this.Dispose();                                                                                                                                                                                                                                                                                                 
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Searchproductbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void shoppingcartbtn_Click(object sender, EventArgs e)
        {
        }

        private void trackingorderbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
        }

        private void userprofilebtn_Click(object sender, EventArgs e)
        {
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
        }

        private void Homebtn_Click_1(object sender, EventArgs e)
        {

        }

        private void UserMain_Load(object sender, EventArgs e)
        {

        }

        private void panelsroll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searchproductbtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new lookupproduct());
        }
        #endregion button
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

        private void shoppingcartbtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new loadcart());
        }

        private void trackingorderbtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new trackdata());
        }
        private void feedbackbtn_Click_1(object sender, EventArgs e)
        {
            if (currentProductId != 0) // Ensure a product is selected
            {
                openChildForm(new feedback(currentUserId, currentProductId));
            }
            else
            {
                MessageBox.Show("Please select a product before giving feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            // Call login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close the current form
            
        }

        private void userprofilebtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new userprofile());
        }

        private void titlelable_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}