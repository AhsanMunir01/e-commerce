using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class qty : Form

    {
       // private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buybtn;
       // private System.Windows.Forms.TextBox textBoxqty;
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        private int selectedProductId;
        private string selectedProductName;
        private decimal selectedProductPrice;
        private int currentUserId;  // Declare currentUserId
        private int cartid;
        public qty()
        {
            InitializeComponent();
        }
        public void ProductDetails(int productId, string productName, decimal price)
        {
            selectedProductId = productId;
            selectedProductName = productName;
            selectedProductPrice = price;
        }
        private void buybtn_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDownQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddProductToCart(selectedProductId, selectedProductName, selectedProductPrice, quantity);

            MessageBox.Show($"You have successfully bought {quantity} units of {selectedProductName}.", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void qty_Load(object sender, EventArgs e)
        {

        }
        private void AddProductToCart(int productId, string productName, decimal price, int quantity)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // First, check if the product already exists in the cart
                    string checkQuery = "SELECT COUNT(*) FROM CartItem WHERE UserID = :userId AND ProductID = :productId";
                    using (OracleCommand checkCmd = new OracleCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.Add(new OracleParameter("userId", currentUserId));
                        checkCmd.Parameters.Add(new OracleParameter("productId", productId));

                        int existingItemCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingItemCount > 0)
                        {
                            // Update quantity if product already in cart
                            string updateQuery = "UPDATE CartItem SET Quantity = Quantity + :quantity WHERE UserID = :userId AND ProductID = :productId";
                            using (OracleCommand updateCmd = new OracleCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.Add(new OracleParameter("quantity", quantity));
                                updateCmd.Parameters.Add(new OracleParameter("userId", currentUserId));
                                updateCmd.Parameters.Add(new OracleParameter("productId", productId));
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert new cart item if it's not already in the cart
                            string insertQuery = "INSERT INTO CartItem (CartItemID, UserID, ProductID, Quantity, AddedDate) " +
                                                 "VALUES (CARTITEM_SEQ.NEXTVAL, :userId, :productId, :quantity, SYSDATE)";
                            using (OracleCommand insertCmd = new OracleCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.Add(new OracleParameter("userId", currentUserId));
                                insertCmd.Parameters.Add(new OracleParameter("productId", productId));
                                insertCmd.Parameters.Add(new OracleParameter("quantity", quantity));
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show($"Product {productName} has been added to the cart.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product to the cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetCurrentUserId(int userId)
        {
            currentUserId = userId;
        }
        private void textBoxqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(textBoxqty.Text))
            {
                try
                {
                    DateTime createdat = DateTime.Now;  // Define createdat
                    DateTime updatedat = DateTime.Now;  // Define updatedat
                    int userid = currentUserId;  // Use current user ID
                    decimal Total = selectedProductPrice * (int)numericUpDownQuantity.Value;  // Correct the calculation

                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();

                        // Insert query for SHOPPINGCART table
                        string query = @"
                    INSERT INTO SHOPPINGCART (CARTID, USERID, TOTALCOST, CREATEDAT, UPDATEDAT)
                    VALUES (:CARTID, :USERID, :TOTALCOST, :CREATEDAT, :UPDATEDAT)";

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            // Bind parameters
                            cmd.Parameters.Add(":CARTID", OracleDbType.Int32).Value = cartid;
                            cmd.Parameters.Add(":USERID", OracleDbType.Int32).Value = userid;
                            cmd.Parameters.Add(":TOTALCOST", OracleDbType.Decimal).Value = Total;
                            cmd.Parameters.Add(":CREATEDAT", OracleDbType.Date).Value = createdat;
                            cmd.Parameters.Add(":UPDATEDAT", OracleDbType.Date).Value = updatedat;

                            // Execute query
                            int rowsInserted = cmd.ExecuteNonQuery();
                            if (rowsInserted > 0)
                            {
                                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
