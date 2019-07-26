using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateInventorySystem.Forms
{
    public partial class AddSupplier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        SqlCommand cmd;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxBusinessName.Clear();
            txtBoxCity.Clear();
            txtBoxContactNo.Clear();
            txtBoxContactPerson.Clear();
            txtBoxEmail.Clear();
            txtBoxState.Clear();
            txtBoxCountry.Clear();
            chkIsActive.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                int isActive;
                if (chkIsActive.Checked == true) { isActive = 1; }
                else { isActive = 0; }
                using (SqlConnection con = new SqlConnection(cs))
                {
                    if (txtBoxBusinessName.Text != "" && txtBoxContactPerson.Text != "" && txtBoxContactNo.Text != "" && txtBoxCity.Text != "" && txtBoxCountry.Text != "")
                    {
                        con.Open();
                        string query = "INSERT INTO store.Supplier (BusinessName,ContactPersonName,Email,Contact,City,State,Country,IsActive) VALUES(@businessname,@contactperson,@email,store.fn_Contact(@contact),@city,@state,@country,@isactive)";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@businessname",txtBoxBusinessName.Text);
                        cmd.Parameters.AddWithValue("@contactperson",txtBoxContactPerson.Text);
                        cmd.Parameters.AddWithValue("@email",txtBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@contact",txtBoxContactNo.Text);
                        cmd.Parameters.AddWithValue("@city",txtBoxCity.Text);
                        cmd.Parameters.AddWithValue("@state",txtBoxState.Text);
                        cmd.Parameters.AddWithValue("@country",txtBoxCountry.Text);
                        cmd.Parameters.AddWithValue("@isactive",isActive);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Supplier Added Successfully");

                    txtBoxBusinessName.Clear();
                    txtBoxCity.Clear();
                    txtBoxContactNo.Clear();
                    txtBoxContactPerson.Clear();
                    txtBoxEmail.Clear();
                    txtBoxState.Clear();
                    txtBoxCountry.Clear();
                    chkIsActive.Checked = false;
                }
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int isActive;
            if (chkIsActive.Checked) { isActive = 1; }
            else { isActive = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxBusinessName.Text != "" && txtBoxContactNo.Text != "" && txtBoxEmail.Text != "" && txtBoxCity.Text != "" && txtBoxCountry.Text != "")
                {
                    con.Open();
                    string query = "UPDATE store.Supplier SET BusinessName = @businessname,ContactPersonName = @contactpersonname, Email = @email,Contact = store.fn_Contact(@contact),City = @city,State = @state,Country = @country,IsActive = @isactive WHERE SupplierID = @supid";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@businessname", txtBoxBusinessName.Text);
                    cmd.Parameters.AddWithValue("@contactpersonname", txtBoxContactPerson.Text);
                    cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtBoxContactNo.Text);
                    cmd.Parameters.AddWithValue("@city", txtBoxCity.Text);
                    cmd.Parameters.AddWithValue("@state", txtBoxState.Text);
                    cmd.Parameters.AddWithValue("@country", txtBoxCountry.Text);
                    cmd.Parameters.AddWithValue("@isactive", isActive);
                    cmd.Parameters.AddWithValue("@supid", Int16.Parse(lblSupplierID.Text));
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Update Supplier Info Successfully");
                    txtBoxCity.Clear();
                    txtBoxContactNo.Clear();
                    txtBoxCountry.Clear();
                    txtBoxContactPerson.Clear();
                    txtBoxBusinessName.Clear();
                    txtBoxEmail.Clear();
                    txtBoxState.Clear();
                    chkIsActive.Checked = false;
                }
            }
        }
    }
}
