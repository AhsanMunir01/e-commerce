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
    public partial class ProductModule : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";

        public ProductModule()
        {
            InitializeComponent();
        }
        public void clear()
        {
            //textBoxproductid.Clear();
            productnametxtbox.Clear();
            description.Clear();
            pricetextbox.Clear();
            brandcombobox.SelectedIndex = -1;
            categorycombobox.SelectedIndex = -1;
            Qtybox.Value = 0;

          //  textBoxproductid.Enabled = true;
            //textBoxproductid.Focus();
            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
        }
        private void ProductModule_Load(object sender, EventArgs e)
        {

            loadCategory(); // Load categories into the ComboBox
            loadBrand();
        }

        public void loadCategory()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT DISTINCT CategoryName 
            FROM Category";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            categorycombobox.Items.Clear();
                            while (reader.Read())
                            {
                                categorycombobox.Items.Add(reader["CategoryName"].ToString());
                            }

                            // Check if items were added
                            if (categorycombobox.Items.Count == 0)
                            {
                                MessageBox.Show("No categories found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadBrand()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT DISTINCT BrandName 
            FROM Brand";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            brandcombobox.Items.Clear();
                            while (reader.Read())
                            {
                                brandcombobox.Items.Add(reader["BrandName"].ToString());
                            }

                            // Check if items were added
                            if (brandcombobox.Items.Count == 0)
                            {
                                MessageBox.Show("No brands found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading brands: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Class to represent ComboBox items with value and display text
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text; // This is what will be displayed in the ComboBox
            }
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(productnametxtbox.Text))
                {
                    MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (categorycombobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (brandcombobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a brand.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to save this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO PRODUCT (PRODUCTID, NAME, CATEGORY, PRICE, DESCRIPTION, CREATEDAT, UPDATEDAT, QTY, BRAND) " +
                              "VALUES (product_seq.NEXTVAL, :Name, :Category, :Price, :Description, :CreatedAt, :UpdatedAt, :Qty, :Brand)";

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            // Get the selected category and brand IDs
                            ComboBoxItem selectedCategory = (ComboBoxItem)categorycombobox.SelectedItem;
                            ComboBoxItem selectedBrand = (ComboBoxItem)brandcombobox.SelectedItem;

                            // Use the selected category and brand IDs for the insert
                            cmd.Parameters.Add(new OracleParameter("Name", productnametxtbox.Text));
                            cmd.Parameters.Add(new OracleParameter("Category", selectedCategory.Value)); // Use CategoryID
                            cmd.Parameters.Add(new OracleParameter("Price", Convert.ToDecimal(pricetextbox.Text)));
                            cmd.Parameters.Add(new OracleParameter("Description", description.Text));
                            cmd.Parameters.Add(new OracleParameter("CreatedAt", DateTime.Now));
                            cmd.Parameters.Add(new OracleParameter("UpdatedAt", DateTime.Now));
                            cmd.Parameters.Add(new OracleParameter("Qty", Convert.ToInt32(Qtybox.Value)));
                            cmd.Parameters.Add(new OracleParameter("Brand", selectedBrand.Value)); // Use BrandID

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to get the next Product ID (if you're using a sequence or some logic)
        private int GetNextProductID()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT product_seq.NEXTVAL FROM dual"; 

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
 
        }

        private void productnametxtbox_TextChanged(object sender, EventArgs e)
        {
            // Step 1: Validate the input for length
            if (productnametxtbox.Text.Length > 50) // Example limit
            {
                MessageBox.Show("Product name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                productnametxtbox.Text = productnametxtbox.Text.Substring(0, 50); // Trim to the limit
                productnametxtbox.SelectionStart = productnametxtbox.Text.Length; // Set cursor to end
            }

            Savebtn.Enabled = !string.IsNullOrWhiteSpace(productnametxtbox.Text);

            
        }
    }
}
