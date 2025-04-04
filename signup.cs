using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using  Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class signuppage : Form
    {
        public signuppage()
        {
            InitializeComponent();
        }
        private ConnectionState conn;
        private void signuppage_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void createaccountlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void rolecobobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_Click(object sender, EventArgs e)
        {

        }



        private void createaccountlbl_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void signupbtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernametxt.Text) || string.IsNullOrEmpty(passwordtxt.Text) ||
                string.IsNullOrEmpty(Emailtxt.Text) || string.IsNullOrEmpty(rolecobobox.Text) ||
                dateTimePicker1.Value == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(passwordtxt.Text);

            try
            {
                string constr = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";

                using (OracleConnection conn = new OracleConnection(constr))
                {
                    conn.Open();

                    // Get the max userID and increment it
                    int userID = 1;
                    string maxIdQuery = "SELECT NVL(MAX(userID), 0) FROM Users";
                    using (OracleCommand maxIdCmd = new OracleCommand(maxIdQuery, conn))
                    {
                        object result = maxIdCmd.ExecuteScalar();
                        userID = Convert.ToInt32(result) + 1;
                    }

                    // Insert the new user record
                    string query = "INSERT INTO Users (UserID, Name, Password, Email, Role, CreatedAt) " +
                          "VALUES (:UserID, :Name, :Password, :Email, :Role, :CreatedAt)";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("userID", userID));
                        cmd.Parameters.Add(new OracleParameter("name", usernametxt.Text));
                        cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
                        cmd.Parameters.Add(new OracleParameter("email", Emailtxt.Text));
                        cmd.Parameters.Add(new OracleParameter("role", rolecobobox.Text));
                        cmd.Parameters.Add(new OracleParameter("createdat", dateTimePicker1.Value));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("User created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            if (rolecobobox.Text == "customer")
                            {
                                this.Hide();
                                customerDetails CustomerDetail = new customerDetails(userID);
                                CustomerDetail.Show();
                            }
                            else
                            {
                                this.Hide();
                                LoginForm login = new LoginForm();
                                login.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User creation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelshopname_Click(object sender, EventArgs e)
        {

        }

        private void signuppage_Load_1(object sender, EventArgs e)
        {

        }

        private void passwordtxt_Click(object sender, EventArgs e)
        {

        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

