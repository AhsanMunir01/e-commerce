using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class forgetpassword : Form
    {
        private string connectionString = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";

        public forgetpassword()
        {
            InitializeComponent();
        }

        private void textBoxnewpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string username = textBoxnewpassword.Text.Trim();
            string newPassword = textBoxconfrimpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashedPassword = HashPassword(newPassword);

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("UPDATE USERS SET PASSWORD = :hashedPassword WHERE USERNAME = :username", conn))
                    {
                        cmd.Parameters.Add(":hashedPassword", OracleDbType.Varchar2).Value = hashedPassword;
                        cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        int rowsUpdated = cmd.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Username not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
    

