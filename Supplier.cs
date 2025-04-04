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
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{

    public partial class Supplier : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        public Supplier()
        {
            InitializeComponent();
        }

        
        

        private void addproductbtn_Click_1(object sender, EventArgs e)
        {
            suppliermodule suppliermodule = new suppliermodule();
            suppliermodule.ShowDialog();
            LoadSupplier();
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
                    if (MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            conn.Open();

                            // SQL query to delete the supplier based on SID in the database
                            string query = "DELETE FROM SUPPLIER WHERE SID = :supplierID"; // Using SID for deletion
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                // Use the ID from DataGridView to fetch the corresponding SID from the database
                                cmd.Parameters.Add(new OracleParameter("supplierID", Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["SID"].Value)));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Supplier Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadSupplier(); // Refresh grid
                            }
                        }
                    }
                }
                else if (colName == "Edit")
                {
                    // Create a new SupplierModule for editing
                    suppliermodule supplierModule = new suppliermodule();
                   // supplierModule.sidTextBox.Text = DGVproduct.Rows[e.RowIndex].Cells["SID"].Value.ToString(); // SID
                    supplierModule.textBoxsuppliername.Text = DGVproduct.Rows[e.RowIndex].Cells["SNAME"].Value.ToString(); // Supplier Name
                    supplierModule.supplieraddresstxt.Text = DGVproduct.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString(); // Address
                    supplierModule.contactpersontxt.Text = DGVproduct.Rows[e.RowIndex].Cells["CONTACTPERSON"].Value.ToString(); // Contact Person
                    supplierModule.phonenumbertxt.Text = DGVproduct.Rows[e.RowIndex].Cells["PHONENO"].Value.ToString(); // Phone Number
                    supplierModule.emailtxtbox.Text = DGVproduct.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString(); // Email
                    supplierModule.faxnumbertxt.Text = DGVproduct.Rows[e.RowIndex].Cells["FAX"].Value.ToString(); // Fax

                    supplierModule.Updatebtn.Enabled = true;
                    supplierModule.Savebtn.Enabled = false; // Disable save button during editing
                    supplierModule.ShowDialog();

                    LoadSupplier(); // Refresh grid after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void LoadSupplier()
        {
            try
            {
                DGVproduct.Rows.Clear(); // Clear existing rows

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // Updated SQL query for the SUPPLIER table
                    string query = "SELECT SID, SNAME, ADDRESS, CONTACTPERSON, PHONENO, EMAIL, FAX FROM SUPPLIER";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add rows to DataGridView with correct column names
                                DGVproduct.Rows.Add(
                                    reader["SID"].ToString(),
                                    reader["SNAME"].ToString(),
                                    reader["ADDRESS"].ToString(),
                                    reader["CONTACTPERSON"].ToString(),
                                    reader["PHONENO"].ToString(),
                                    reader["EMAIL"].ToString(),
                                    reader["FAX"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
