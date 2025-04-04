using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class lookupproduct : Form
    {
        private NumericUpDown quantityUpDown;
        private int selectedProductId = 0;
        private int currentUserId = 1;
        private string connectionString = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";
        private string selectedProductName;
        private decimal selectedProductPrice;
        private int selectedProductQty;
        UserMain cust;

        public lookupproduct()
        {
            InitializeComponent();

            // Initialize and configure quantityUpDown
            quantityUpDown = new NumericUpDown();
            quantityUpDown.Location = new System.Drawing.Point(650, 50); // Adjust position as needed
            quantityUpDown.Minimum = 1;
            quantityUpDown.Maximum = 100;
            quantityUpDown.Value = 1;
            quantityUpDown.Width = 80;
            this.Controls.Add(quantityUpDown);

            LoadProduct();

            // Configure grid
            gridproduct.CellClick += gridproduct_CellClick;
            gridproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridproduct.MultiSelect = false;
        }

        private void DefineColumns()
        {
            gridproduct.Columns.Clear();
            gridproduct.Columns.Add("PRODUCTID", "Product ID");
            gridproduct.Columns.Add("NAME", "Name");
            gridproduct.Columns.Add("CATEGORY", "Category");
            gridproduct.Columns.Add("PRICE", "Price");
            gridproduct.Columns.Add("DESCRIPTION", "Description");
            gridproduct.Columns.Add("CREATEDAT", "Created At");
            gridproduct.Columns.Add("UPDATEDAT", "Updated At");
            gridproduct.Columns.Add("QTY", "Quantity");
            gridproduct.Columns.Add("BRAND", "Brand");
        }

        private void gridproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gridproduct.Rows[e.RowIndex];

                // Ensure all required cells have values
                if (selectedRow.Cells["PRODUCTID"].Value != null &&
                    selectedRow.Cells["NAME"].Value != null &&
                    selectedRow.Cells["PRICE"].Value != null &&
                    selectedRow.Cells["QTY"].Value != null)
                {
                    selectedProductId = Convert.ToInt32(selectedRow.Cells["PRODUCTID"].Value);
                    selectedProductName = selectedRow.Cells["NAME"].Value.ToString();
                    selectedProductPrice = Convert.ToDecimal(selectedRow.Cells["PRICE"].Value);
                    selectedProductQty = Convert.ToInt32(selectedRow.Cells["QTY"].Value);

                    // Update quantityUpDown maximum based on available stock
                    quantityUpDown.Maximum = selectedProductQty;

                    // Optional: Show selection feedback
                    MessageBox.Show($"Selected product: {selectedProductName}\nPrice: ${selectedProductPrice:N2}\nAvailable Quantity: {selectedProductQty}",
                        "Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate selected product
                if (selectedProductId <= 0)
                {
                    MessageBox.Show("Please select a product first.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantityToBuy = (int)quantityUpDown.Value;

                // Validate quantity
                if (quantityToBuy <= 0)
                {
                    MessageBox.Show("Please enter a quantity greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (quantityToBuy > selectedProductQty)
                {
                    MessageBox.Show($"Insufficient stock. Available quantity: {selectedProductQty}.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate total cost
                decimal totalCost = quantityToBuy * selectedProductPrice;

                // Insert into shoppingcart table
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    // Get a new CARTID
                    int cartId = GetNewCartId(connection);

                    // Insert the record
                    string insertQuery = @"
                INSERT INTO shoppingcart (CARTID, USERID, TOTALCOST, CREATEDAT, UPDATEDAT) 
                VALUES (:cartId, :userId, :totalCost, SYSDATE, SYSDATE)";

                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("cartId", cartId));
                        command.Parameters.Add(new OracleParameter("userId", currentUserId)); // Replace with the logged-in user's ID
                        command.Parameters.Add(new OracleParameter("totalCost", totalCost));

                        command.ExecuteNonQuery();
                    }

                    // Update the product stock
                    UpdateProductStock(selectedProductId, selectedProductQty - quantityToBuy);

                    // Refresh the product list to reflect the updated quantities
                    LoadProduct();

                    // Show success message
                    MessageBox.Show($"Successfully added {quantityToBuy} units of {selectedProductName} to cart.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Log the error or show it to the user
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetNewCartId(OracleConnection connection)
        {
            try
            {
                string query = "SELECT shoppingcart_seq.NEXTVAL FROM dual"; // Assuming a sequence exists in your database

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        throw new InvalidOperationException("Failed to retrieve a valid CARTID.");

                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating CARTID: " + ex.Message);
            }
        }
        private void LoadProduct()
        {
            try
            {
                // Define columns if not already defined
                DefineColumns();

                gridproduct.Rows.Clear(); // Clear any existing rows in the DataGridView

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to fetch all product data
                    string query = "SELECT PRODUCTID, NAME, CATEGORY, PRICE, DESCRIPTION, CREATEDAT, UPDATEDAT, QTY, BRAND FROM PRODUCT";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each row of product data to the DataGridView
                                gridproduct.Rows.Add(
                                    reader["PRODUCTID"].ToString(),
                                    reader["NAME"].ToString(),
                                    reader["CATEGORY"].ToString(),
                                    reader["PRICE"].ToString(),
                                    reader["DESCRIPTION"].ToString(),
                                    reader["CREATEDAT"].ToString(),
                                    reader["UPDATEDAT"].ToString(),
                                    reader["QTY"].ToString(),
                                    reader["BRAND"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductStock(int productId, int newQuantity)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE PRODUCT SET QTY = :newQty WHERE PRODUCTID = :productId";
                    using (OracleCommand cmd = new OracleCommand(updateQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("newQty", newQuantity));
                        cmd.Parameters.Add(new OracleParameter("productId", productId));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Your existing LoadProduct, LoadFilteredProducts, and AddProductToCart methods remain the same

        private void lookupproduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchmetrobox.Text.Trim();
            //LoadFilteredProducts(searchTerm);
        }

        // Remove redundant event handlers
        private void searchmetrobox_Click(object sender, EventArgs e)
        {
            // Only perform search when search button is clicked
        }


        public void LoadFilteredProducts(string searchTerm)
        {
            try
            {
                gridproduct.Rows.Clear(); // Clear existing rows

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to filter products based on the search term
                    string query = "SELECT PRODUCTID, NAME, CATEGORY, PRICE, DESCRIPTION, CREATEDAT, UPDATEDAT, QTY, BRAND FROM PRODUCT " +
                                   "WHERE LOWER(NAME) LIKE LOWER(:searchTerm) OR LOWER(CATEGORY) LIKE LOWER(:searchTerm)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("searchTerm", "%" + searchTerm + "%")); // Use wildcard for filtering

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add rows to DataGridView with correct column names
                                gridproduct.Rows.Add(
                                    reader["PRODUCTID"].ToString(),
                                    reader["NAME"].ToString(),
                                    reader["CATEGORY"].ToString(),
                                    reader["PRICE"].ToString(),
                                    reader["DESCRIPTION"].ToString(),
                                    reader["CREATEDAT"].ToString(),
                                    reader["UPDATEDAT"].ToString(),
                                    reader["QTY"].ToString(),
                                    reader["BRAND"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading filtered products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Keep your existing LoadProduct, LoadFilteredProducts, and AddProductToCart methods as they are
    }
}
