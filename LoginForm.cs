using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{


    public partial class LoginForm : Form
    {
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void packgroundpic_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createaccountbtn_Click(object sender, EventArgs e)
        {
            signuppage signup = new signuppage();
            signup.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createaccountlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           signuppage signUp = new signuppage();
            signUp.Show();
            this.Hide();
        }

        private void rolecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            string name = usernametxt.Text;
            string password = passwordtxt.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            bool isAuth = authUser(name, password);

            if (isAuth)
            {
                MessageBox.Show("Login successful");
                string role = getRole(name);
                if (role == "admin")
                {
                    admin Admin = new admin();
                    Admin.Show();
                }
                else if (role == "customer")
                {
                    UserMain user = new UserMain();
                    user.Show();
                    this.Hide();
                }
                else if(role == "delivery")
                {
                    CAshier cashier = new CAshier();
                    cashier.Show();
                    this.Hide();
                }
                else if(role =="manager")
                {
                    Manager manager = new Manager();
                    manager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid role");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool authUser(string name, string password)
        {
            try
            {
                string query = "SELECT password FROM users WHERE UPPER(name) = UPPER(:name)";
                string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";

                using (OracleConnection conn = new OracleConnection(conStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader.GetString(0);
                                return dbPassword == HashPassword(password);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return false;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
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

        private string getRole(string name)
        {
            try
            {
                string query = "SELECT role FROM users WHERE name = :name";
                string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";

                using (OracleConnection conn = new OracleConnection(conStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return null;
        }

        private void passwordtxt_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}


