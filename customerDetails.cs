using Oracle.ManagedDataAccess.Client;
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
    public partial class customerDetails : Form
    {

        public customerDetails()
        {
            InitializeComponent();
        }

        private void customerDetails_Load(object sender, EventArgs e)
        {

        }

        private void addresslbl_Click(object sender, EventArgs e)
        {

        }
        private int _userID;

        public customerDetails(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private int GetUserID()
        {
            return _userID;
        }
        private int GetUserIDFromDatabase(string username)
        {
            int userID = 0; // Default value if user doesn't exist

            try
            {
                // Database connection string
                string constr = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";

                using (OracleConnection conn = new OracleConnection(constr))
                {
                    conn.Open();

                    // Query to get the UserID based on the username
                    string query = "SELECT UserID FROM Users WHERE name = :name";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("name", username));  // Username should be passed

                        // Execute the query and get the UserID
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            userID = Convert.ToInt32(result); // Convert the result to an integer
                        }
                        else
                        {
                            MessageBox.Show($"User with username '{username}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving UserID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userID;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrEmpty(addresstxt.Text) || string.IsNullOrEmpty(phonenotxt.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Database connection string
                string constr = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";

                using (OracleConnection conn = new OracleConnection(constr))
                {
                    conn.Open();

                    // Ensure UserID is valid
                    if (_userID == 0)
                    {
                        MessageBox.Show("UserID is invalid. Could not retrieve the correct UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1. Check if the UserID exists in the Users table (optional, as we have the UserID)
                    string userCheckQuery = "SELECT COUNT(*) FROM Users WHERE UserID = :UserID";
                    using (OracleCommand cmdCheck = new OracleCommand(userCheckQuery, conn))
                    {
                        cmdCheck.Parameters.Add(new OracleParameter("UserID", _userID));
                        int userCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (userCount == 0)
                        {
                            MessageBox.Show($"User with UserID {_userID} does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit if the user doesn't exist
                        }
                    }

                    // 2. Generate a new CustomerID
                    int customerID = 1;
                    string maxIdQuery = "SELECT NVL(MAX(CUSTOMERID), 0) FROM CustomerDetails";
                    using (OracleCommand maxIdCmd = new OracleCommand(maxIdQuery, conn))
                    {
                        object result = maxIdCmd.ExecuteScalar();
                        customerID = Convert.ToInt32(result) + 1;
                    }

                    // 3. Insert the new customer details into the CustomerDetails table
                    string query = "INSERT INTO CustomerDetails (CustomerID, UserID, Address, Phone) " +
                                   "VALUES (:CustomerID, :UserID, :Address, :Phone)";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("CustomerID", customerID));
                        cmd.Parameters.Add(new OracleParameter("UserID", _userID));  // Use the valid UserID
                        cmd.Parameters.Add(new OracleParameter("Address", addresstxt.Text));
                        cmd.Parameters.Add(new OracleParameter("Phone", phonenotxt.Text));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Customer details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to LoginForm
                            this.Hide();
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}