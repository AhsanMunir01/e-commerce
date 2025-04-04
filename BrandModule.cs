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
    public partial class BrandModule : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        public BrandModule()
        {
            InitializeComponent();
        }

        private void brandmodulepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrandModulelable_Click(object sender, EventArgs e)
        {

        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BrandName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbrandname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

            clear();
        }
        public void clear()
        {
            textBoxbrandname.Clear();
            Updatebtn.Enabled = false;
            Savebtn.Enabled = true;
            textBoxbrandname.Focus();


        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //to insert brand name to table
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Brand(BrandName) VALUES(:BrandName)";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("BrandName", textBoxbrandname.Text));
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

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxbrandname.Text))
                {
                    MessageBox.Show("Brand name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this brand?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Brand SET BrandName = :brandName WHERE BrandID = :brandID";
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("brandName", textBoxbrandname.Text.Trim()));
                            cmd.Parameters.Add(new OracleParameter("brandID", Convert.ToInt32(lblid.Text)));
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