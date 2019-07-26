using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UltimateInventorySystem.Forms
{
    public partial class AddCustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int isActive;
            if (chkIsActive.Checked) { isActive = 1; }
            else { isActive = 0; }
            using(SqlConnection con=new SqlConnection(cs))
            {
                if (txtBoxCustomerName.Text!="" && txtBoxContactNo.Text!="" &&txtBoxEmail.Text!="" &&txtBoxCity.Text!="" && txtBoxCountry.Text!="")
                {
                    con.Open();
                    string query = "INSERT INTO store.Customers (CustomerName,Email,Contact,City,State,Country,IsActive) VALUES (@name,@email,store.fn_Contact(@contact),@city,@state,@country,@isactive)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtBoxCustomerName.Text);
                    cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtBoxContactNo.Text);
                    cmd.Parameters.AddWithValue("@city", txtBoxCity.Text);
                    cmd.Parameters.AddWithValue("@state", txtBoxState.Text);
                    cmd.Parameters.AddWithValue("@country", txtBoxCountry.Text);
                    cmd.Parameters.AddWithValue("@isactive", isActive);
                    cmd.ExecuteNonQuery();
                  
                    MessageBox.Show("New Customer Added Successfully");
                    txtBoxCity.Clear();
                    txtBoxContactNo.Clear();
                    txtBoxCountry.Clear();
                    txtBoxCustomerName.Clear();
                    txtBoxEmail.Clear();
                    txtBoxState.Clear();
                    chkIsActive.Checked = false;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxCity.Clear();
            txtBoxContactNo.Clear();
            txtBoxCountry.Clear();
            txtBoxCustomerName.Clear();
            txtBoxEmail.Clear();
            txtBoxState.Clear();
            chkIsActive.Checked = false;
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            int isActive;
            if (chkIsActive.Checked) { isActive = 1; }
            else { isActive = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxCustomerName.Text != "" && txtBoxContactNo.Text != "" && txtBoxEmail.Text != "" && txtBoxCity.Text != "" && txtBoxCountry.Text != "")
                {
                    con.Open();
                    string query = "UPDATE store.Customers SET CustomerName = @name,Email = @email,Contact = store.fn_Contact(@contact),City = @city,State = @state,Country = @country,IsActive = @isactive WHERE CustomerID = @custid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtBoxCustomerName.Text);
                    cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtBoxContactNo.Text);
                    cmd.Parameters.AddWithValue("@city", txtBoxCity.Text);
                    cmd.Parameters.AddWithValue("@state", txtBoxState.Text);
                    cmd.Parameters.AddWithValue("@country", txtBoxCountry.Text);
                    cmd.Parameters.AddWithValue("@isactive", isActive);
                    cmd.Parameters.AddWithValue("@custid", Int16.Parse(lblCustomerID.Text));
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Update Customer Info Successfully");
                    txtBoxCity.Clear();
                    txtBoxContactNo.Clear();
                    txtBoxCountry.Clear();
                    txtBoxCustomerName.Clear();
                    txtBoxEmail.Clear();
                    txtBoxState.Clear();
                    chkIsActive.Checked = false;
                }
            }
        }
    }
}
