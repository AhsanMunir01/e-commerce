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
    public partial class suppliermodule : Form
    {
        private string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=database; PASSWORD=database";
        public void clear()
        {
            supplieraddresstxt.Clear();
            textBoxsuppliername.Clear();
            emailtxtbox.Clear();
            phonenumbertxt.Clear();
            faxnumbertxt.Clear();
            contactpersontxt.Clear();

            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
            textBoxsuppliername.Focus();
        }
        public suppliermodule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void suppliermodule_Load(object sender, EventArgs e)
        {

        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(textBoxsuppliername.Text))
                {
                    MessageBox.Show("Please enter a supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to save this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO SUPPLIER (SID, SNAME, ADDRESS, EMAIL, PHONENO, FAX, CONTACTPERSON) " +
                "VALUES (supplier_seq.NEXTVAL, :SNAME, :ADDRESS, :EMAIL, :PHONENO, :FAX, :CONTACTPERSON)";

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("SupplierName", textBoxsuppliername.Text));
                            cmd.Parameters.Add(new OracleParameter("Address", supplieraddresstxt.Text));
                            cmd.Parameters.Add(new OracleParameter("Email", emailtxtbox.Text));
                            cmd.Parameters.Add(new OracleParameter("PhoneNumber", phonenumbertxt.Text));
                            cmd.Parameters.Add(new OracleParameter("FaxNumber", faxnumbertxt.Text));
                            cmd.Parameters.Add(new OracleParameter("ContactPerson", contactpersontxt.Text));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supplieraddresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactpersontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void faxnumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(textBoxsuppliername.Text))
                {
                    MessageBox.Show("Please enter a supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Supplier SET SupplierName = :SupplierName, Address = :Address, Email = :Email, " +
                                       "PhoneNumber = :PhoneNumber, FaxNumber = :FaxNumber, ContactPerson = :ContactPerson " +
                                       "WHERE SupplierID = :SupplierID"; // You need to provide SupplierID for updating

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            // Assume you have a way to get the SupplierID
                           // cmd.Parameters.Add(new OracleParameter("SupplierID", sId)); // Replace with actual selected ID
                            cmd.Parameters.Add(new OracleParameter("SupplierName", textBoxsuppliername.Text));
                            cmd.Parameters.Add(new OracleParameter("Address", supplieraddresstxt.Text));
                            cmd.Parameters.Add(new OracleParameter("Email", emailtxtbox.Text));
                            cmd.Parameters.Add(new OracleParameter("PhoneNumber", phonenumbertxt.Text));
                            cmd.Parameters.Add(new OracleParameter("FaxNumber", faxnumbertxt.Text));
                            cmd.Parameters.Add(new OracleParameter("ContactPerson", contactpersontxt.Text));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
