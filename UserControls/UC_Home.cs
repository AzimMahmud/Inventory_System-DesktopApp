using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateInventorySystem.UserControls
{
    public partial class UC_Home : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
        public UC_Home()
        {
            InitializeComponent();
            
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            TotalSales();
            TotalPurchase();
            TotalSalesAmount();
            TotalPurchaseAmount();
      
        }

        private void TotalSales()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                
                SqlCommand cmd = new SqlCommand("SELECT COUNT(TransactionID) AS TotalSale FROM store.[Transaction] WHERE TransactionTypeID LIKE 'S-%' GROUP BY TransactionID ", con);
                con.Open();
               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lblTotalSales.Text = dt.Rows.Count.ToString();

            }
        }


        private void TotalSalesAmount()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("select SUM(NetAmount) AS SalesAmount from store.[Transaction]  WHERE TransactionTypeID Like 'S-%'", con);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lblTotalSalesAmount.Text = dt.Rows[0]["SalesAmount"].ToString();

            }
        }


        private void TotalPurchase()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("SELECT COUNT(TransactionID) AS TotalSale FROM store.[Transaction] WHERE TransactionTypeID LIKE 'P-%' GROUP BY TransactionID ", con);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                lblPurchase.Text = dt.Rows.Count.ToString();

            }
        }

        private void TotalPurchaseAmount()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("select SUM(NetAmount) AS PurchaseAmount from store.[Transaction]  WHERE TransactionTypeID Like 'P-%'", con);
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                
                lblTotalPurchaseAmount.Text = dt.Rows[0]["PurchaseAmount"].ToString();
                
            }
        }
    }
}
