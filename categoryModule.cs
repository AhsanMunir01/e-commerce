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
    public partial class categoryModule : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        public categoryModule()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxcategoryname.Clear();
            textBoxcategoryname.Focus();
            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
        }

        private void textBoxcategoryname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxcategoryname.Text))
                {
                    MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO category (CATEGORYID, categoryName) VALUES (category_seq.NEXTVAL, :categoryName)";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("categoryName", textBoxcategoryname.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxcategoryname.Text))
                {
                    MessageBox.Show("category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE category SET categoryName = :categoryName WHERE categoryID = :categoryID";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("categoryName", textBoxcategoryname.Text.Trim()));
                            cmd.Parameters.Add(new OracleParameter("categoryID", Convert.ToInt32(lblid.Text)));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
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
