using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Brand : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        public Brand()
        {
            InitializeComponent();
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            LoadBrand(); // Call LoadBrand when the form loads
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void managerbrandlable_Click(object sender, EventArgs e) { }

        private void addbrandbtn_Click(object sender, EventArgs e)
        {
            BrandModule brandModule = new BrandModule();
            brandModule.ShowDialog();
        }
        // data retrieve from brand table

        public void LoadBrand()
        {
            try
            {
                DGVbrand.Rows.Clear(); // Clear existing rows

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // Correct SQL query with case-sensitive column names
                    string query = "SELECT BRANDID, BRANDNAME FROM BRAND ORDER BY BRANDID";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Retrieved BrandID: {reader["BRANDID"]}, BrandName: {reader["BRANDNAME"]}");

                                // Add rows to DataGridView with BrandID and BrandName
                                DGVbrand.Rows.Add(reader["BRANDID"].ToString(), reader["BRANDNAME"].ToString());
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




        private void DGVbrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = DGVbrand.Columns[e.ColumnIndex].Name;

                if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            conn.Open();

                            string query = "DELETE FROM Brand WHERE BrandID = :brandID";
                            using (OracleCommand cmd = new OracleCommand(query, conn))
                            {
                                cmd.Parameters.Add(new OracleParameter("brandID", Convert.ToInt32(DGVbrand.Rows[e.RowIndex].Cells[0].Value)));
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBrand(); // Refresh grid
                            }
                        }
                    }
                }
                else if (colName == "Edit")
                {
                    BrandModule brndModule = new BrandModule();
                    brndModule.lblid.Text = DGVbrand.Rows[e.RowIndex].Cells[0].Value.ToString(); // BrandID
                    brndModule.textBoxbrandname.Text = DGVbrand.Rows[e.RowIndex].Cells[1].Value.ToString(); // BrandName
                    brndModule.Updatebtn.Enabled = true;
                    brndModule.Savebtn.Enabled = false;
                    brndModule.ShowDialog();
                    LoadBrand(); // Refresh grid after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

    
