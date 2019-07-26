using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateInventorySystem.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace UltimateInventorySystem.UserControls
{
    public partial class UC_Contacts : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
        public UC_Contacts()
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newCus = new AddCustomer();
            newCus.ShowDialog();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier newSup = new AddSupplier();
            newSup.ShowDialog();
        }

        private void UC_Contacts_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection con=new SqlConnection (cs))
            {
                string query1 = "select * from store.Customers";
                SqlDataAdapter da1 = new SqlDataAdapter(query1, con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgVewCustomers.DataSource = dt1;
               
                dgVewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query2 = "select * from store.Supplier";
                SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgVewSuppliers.DataSource = dt2;
                dgVewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
