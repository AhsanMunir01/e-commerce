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
    public partial class category : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";

        public category()
        {
            InitializeComponent();
        }

        private void addbrandbtn_Click(object sender, EventArgs e)
        {
            categoryModule categoryModule = new categoryModule();
            categoryModule.ShowDialog();
            LoadCategory();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            LoadCategory(); // Call LoadBrand when the form loads
        }
        private void DGVcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVcategory.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM CATEGORY WHERE CategoryID = :CategoryID";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("CategoryID", Convert.ToInt32(DGVcategory.Rows[e.RowIndex].Cells[0].Value)));
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategory();
                }
            }
            else if (colName == "Edit")
            {
                categoryModule categoryModule = new categoryModule();
                categoryModule.lblid.Text = DGVcategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                categoryModule.textBoxcategoryname.Text = DGVcategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryModule.Updatebtn.Enabled = true;
                categoryModule.Savebtn.Enabled = false;
                categoryModule.ShowDialog();
                LoadCategory();
            }
        }
        public void LoadCategory()
        {
            try
            {
                DGVcategory.Rows.Clear(); // Clear existing rows

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Database connection established.");

                    // Correct SQL query
                    string query = "SELECT categoryid, categoryname FROM CATEGORY ORDER BY categoryid";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Debugging: Print data to the console
                                Console.WriteLine($"Retrieved categoryid: {reader["categoryid"]}, categoryname: {reader["categoryname"]}");

                                // Add rows to DataGridView
                                DGVcategory.Rows.Add(reader["categoryid"].ToString(), reader["categoryname"].ToString());
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


    }
}
