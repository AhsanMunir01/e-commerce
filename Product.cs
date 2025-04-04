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
    public partial class Product : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";

        public Product()
        {
            InitializeComponent();
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule();
            productModule.ShowDialog();
            LoadProduct();
        }
        private void Product_load(object sender, EventArgs e)
        {
            LoadProduct(); // Call LoadBrand when the form loads
        }
        private void DGVproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Ensure the clicked cell is within the bounds of the DataGridView
                if (e.RowIndex < 0) return;

                string colName = DGVproduct.Columns[e.ColumnIndex].Name;

                if (colName == "Delete")
                {
                    // Confirm the deletion
                    if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            conn.Open();

                            // SQL query to delete the product based on PRODUCTID in the database
                            string query = "DELETE FROM PRODUCT WHERE PRODUCTID = :productID"; // Using PRODUCTID for deletion
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                // Use the ID from DataGridView to fetch the corresponding PRODUCTID from the database
                                cmd.Parameters.Add(new OracleParameter("productID", Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["ID"].Value)));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Product Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProduct(); // Refresh grid
                            }
                        }
                    }
                }
                else if (colName == "Edit")
                {
                    // Create a new ProductModule for editing
                    ProductModule productModule = new ProductModule();
                   // productModule.productID.Text = DGVproduct.Rows[e.RowIndex].Cells["PRODUCTID"].Value.ToString(); // PRODUCTID
                    productModule.productnametxtbox.Text = DGVproduct.Rows[e.RowIndex].Cells["NAME"].Value.ToString(); // Product Name
                    productModule.categorycombobox.SelectedItem = DGVproduct.Rows[e.RowIndex].Cells["CATEGORY"].Value.ToString(); // Category
                    productModule.pricetextbox.Text = DGVproduct.Rows[e.RowIndex].Cells["PRICE"].Value.ToString(); // Price
                    productModule.description.Text = DGVproduct.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString(); // Description
                    productModule.Qtybox.Value = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["QTY"].Value); // Quantity
                    productModule.brandcombobox.SelectedItem = DGVproduct.Rows[e.RowIndex].Cells["BRAND"].Value.ToString(); // Brand

                    productModule.Updatebtn.Enabled = true;
                    productModule.Savebtn.Enabled = false; // Disable save button during editing
                    productModule.ShowDialog();

                    LoadProduct(); // Refresh grid after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void productlowerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerbrandlable_Click(object sender, EventArgs e)
        {

        }
        public void LoadProduct()
        {
            try
            {
                DGVproduct.Rows.Clear(); // Clear existing rows

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // Correct SQL query with case-sensitive column names
                    string query = "SELECT PRODUCTID, NAME, CATEGORY, PRICE, DESCRIPTION, QTY, BRAND FROM PRODUCT";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add rows to DataGridView with correct column names
                                DGVproduct.Rows.Add(
                                    reader["PRODUCTID"].ToString(),
                                    reader["NAME"].ToString(),
                                    reader["CATEGORY"].ToString(),
                                    reader["PRICE"].ToString(),
                                    reader["DESCRIPTION"].ToString(),
                                    reader["QTY"].ToString(),
                                    reader["BRAND"].ToString() // Assuming you want to display the brand name
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

        private void brandlogo_Click(object sender, EventArgs e)
        {

        }

        private void searchmetrobox_Click(object sender, EventArgs e)
        {

        }
    }
}
