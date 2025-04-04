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
    
    public partial class loadcart : Form
    {
        private string connectionString = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";
        private List<CartItem> cartItems;
        private decimal totalAmount = 0;
        private int currentCartId;
        public loadcart()
        {
            InitializeComponent();
            cartItems = new List<CartItem>();
            SetupDataGridView();
            LoadCartItems();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cardpaymentradio_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SetupDataGridView()
        {
            // Configure DataGridView
            DGVcartload.AutoGenerateColumns = false;
            DGVcartload.AllowUserToAddRows = false;
            DGVcartload.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Define columns
            DGVcartload.Columns.Clear();
            DGVcartload.Columns.Add("ProductName", "Product Name");
            DGVcartload.Columns.Add("Price", "Price");
            DGVcartload.Columns.Add("Quantity", "Quantity");
            DGVcartload.Columns.Add("TotalPrice", "Total Price");

            // Add delete button column
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Action";
            deleteButton.Text = "Remove";
            deleteButton.Name = "DeleteButton";
            deleteButton.UseColumnTextForButtonValue = true;
            DGVcartload.Columns.Add(deleteButton);

            // Style the grid
            DGVcartload.DefaultCellStyle.Padding = new Padding(5);
            DGVcartload.ColumnHeadersDefaultCellStyle.Font = new Font(DGVcartload.Font, FontStyle.Bold);
            DGVcartload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCartItems()
        {
            try
            {
                cartItems.Clear();
                DGVcartload.Rows.Clear();
                totalAmount = 0;

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.ITEMID, c.CARTID, c.PRODUCTID, c.QUANTITY, 
                                   p.NAME as ProductName, p.PRICE 
                                   FROM shoppingcart c 
                                   JOIN PRODUCT p ON c.PRODUCTID = p.PRODUCTID 
                                   WHERE c.CARTID = :cartId";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("cartId", currentCartId));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CartItem item = new CartItem
                                {
                                    ItemId = Convert.ToInt32(reader["userID"]),
                                    CartId = Convert.ToInt32(reader["CARTID"]),
                                    ProductId = Convert.ToInt32(reader["PRODUCTID"]),
                                    ProductName = reader["ProductName"].ToString(),
                                    Price = Convert.ToDecimal(reader["PRICE"]),
                                    Quantity = Convert.ToInt32(reader["QUANTITY"])
                                };

                                cartItems.Add(item);
                                totalAmount += item.TotalPrice;

                                DGVcartload.Rows.Add(
                                    item.ProductName,
                                    $"${item.Price:N2}",
                                    item.Quantity,
                                    $"${item.TotalPrice:N2}"
                                );
                            }
                        }
                    }
                }

                //UpdateTotalDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DGVcartload_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
