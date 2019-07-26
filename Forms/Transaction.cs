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
   

    public partial class Transaction : Form
    {
        private string transactionType;
        private string clientID;
        private string productID;
        private string _userid;
        private decimal netAmount;
        

        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public Transaction(string tranType, string userID)
        {
            InitializeComponent();
            transactionType = tranType;
            _userid = userID;
        }

        private void btnSubmitTransaction_Click(object sender, EventArgs e)
        {
            clientID =  comBoxCustomerName.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(cs))
            { 
                if (txtBoxQuantity.Text != "0.00")
                {
                    SqlCommand cmd = new SqlCommand("store.sp_Transaction", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@transactionid", 0);
                    cmd.Parameters.AddWithValue("@operation", "Insert");
                    cmd.Parameters.AddWithValue("@transactiontype", transactionType);
                    cmd.Parameters.AddWithValue("@trasactiontypeid", "");
                    cmd.Parameters.AddWithValue("@productid", Int16.Parse(productID));
                    cmd.Parameters.AddWithValue("@date", datePickerTransaction.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtBoxQuantity.Text);
                    cmd.Parameters.AddWithValue("@vatamount", txtBoxVatAmount.Text);
                    cmd.Parameters.AddWithValue("@clientid", Int16.Parse(clientID));
                    cmd.Parameters.AddWithValue("@rate", txtBoxRate.Text);
                    cmd.Parameters.AddWithValue("@discountamount", txtBoxDiscountAmount.Text);
                    cmd.Parameters.AddWithValue("@userid", Int16.Parse(_userid));

                    con.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show(transactionType + " Successsfully!!!");
                    this.Hide();
                }
            }
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
           
            txtBoxTranType.Text = transactionType;

            loadProduct();
            loadCustomer();

            if (transactionType == "Purchase Return")
            {
                lblTransaction.Show();
                comBoxTranTypeID.Show();
                PruchaseTransactionTypeIDLoad();
            }
            else if (transactionType == "Sales Return")
            {
                lblTransaction.Show();
                comBoxTranTypeID.Show();
                SalesTransactionTypeIDLoad();
            }


        }

        public void PruchaseTransactionTypeIDLoad()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                con.Open();
                string query = @"SELECT TransactionTypeID, TransactionID FROM store.[Transaction] WHERE TransactionTypeID LIKE 'P-%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                comBoxTranTypeID.DisplayMember = "TransactionTypeID";
                comBoxTranTypeID.ValueMember = "TransactionID";
                comBoxTranTypeID.DataSource = dt;

 
            }
        }

        public void SalesTransactionTypeIDLoad()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                con.Open();
                string query = @"SELECT TransactionTypeID, TransactionID FROM store.[Transaction] WHERE TransactionTypeID LIKE 'S-%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                comBoxTranTypeID.DisplayMember = "TransactionTypeID";
                comBoxTranTypeID.ValueMember = "TransactionID";
                comBoxTranTypeID.DataSource = dt;


            }
        }

        private void loadProduct()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dt = new DataTable("Products");
                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM store.Products WHERE IsActive = 1", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                
                comBoxProductName.DisplayMember = "ProductName";
                comBoxProductName.ValueMember = "ProductID";
                comBoxProductName.DataSource = dt;

            }
        }


        private void loadCustomer()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dt = new DataTable();
                if (transactionType == "Sales" || transactionType == "Sales Return")
                {
                    SqlCommand cmd = new SqlCommand("SELECT CustomerID, CustomerName FROM store.Customers WHERE IsActive = 1", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    comBoxCustomerName.DisplayMember = "CustomerName";
                    comBoxCustomerName.ValueMember = "CustomerID";
                    comBoxCustomerName.DataSource = dt;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT SupplierID, BusinessName FROM store.Supplier WHERE IsActive = 1", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    comBoxCustomerName.DisplayMember = "BusinessName";
                    comBoxCustomerName.ValueMember = "SupplierID";
                    comBoxCustomerName.DataSource = dt;
                }

            }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            decimal amount;
            string vatrate = "";
            if (txtBoxQuantity.Text == "")
            {
                txtBoxGrossAmount.Text = "0";
            }
            else if (txtBoxRate.Text != "" && txtBoxQuantity.Text != "")
            {
                decimal rate = decimal.Parse(txtBoxRate.Text);
                decimal quantity = decimal.Parse(txtBoxQuantity.Text);
                amount = rate * quantity;

                txtBoxGrossAmount.Text = amount.ToString("0.00");

                vatrate = txtBoxVat.Text;

                decimal vatRate;
                

                if (txtBoxVat.Text == "")
                {
                    vatRate = 0;
                }
                else
                {
                    vatRate = decimal.Parse(vatrate);
                }
                amount = amount * (vatRate / 100);

                txtBoxVatAmount.Text = amount.ToString("0.00");
            }
        }

        private void txtBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal amount;
            if (txtBoxDiscount.Text == "")
            {
                txtBoxDiscountAmount.Text = "0";
            }
            else if (txtBoxGrossAmount.Text != "" && txtBoxDiscount.Text != "")
            {
                decimal grossAmount = decimal.Parse(txtBoxGrossAmount.Text);
                decimal discount = decimal.Parse(txtBoxDiscount.Text);
                amount = grossAmount * (discount/100);

                txtBoxDiscountAmount.Text = amount.ToString("0.00");
            }
        }

        private void txtBoxVat_TextChanged(object sender, EventArgs e)
        {
            decimal amount;
            string vatrate = "";
            
            if (txtBoxGrossAmount.Text != "")
            {
                vatrate = txtBoxVat.Text;
                decimal vatRate;
                decimal grossAmount = decimal.Parse(txtBoxGrossAmount.Text);
                if (txtBoxVat.Text == "")
                {
                     vatRate = 0;
                }
                else
                {
                    vatRate = decimal.Parse(vatrate);
                }
                amount = grossAmount * (vatRate / 100);

                txtBoxVatAmount.Text = amount.ToString("0.00");
            }
        }

     

       
        private void txtBoxGrossAmount_TextChanged(object sender, EventArgs e)
        {
            netAmount = decimal.Parse(txtBoxGrossAmount.Text);
            txtBoxNetAmount.Text = netAmount.ToString("0.00");
        }

        private void txtBoxDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            netAmount = decimal.Parse(txtBoxGrossAmount.Text) - decimal.Parse(txtBoxDiscountAmount.Text);
            txtBoxNetAmount.Text = netAmount.ToString("0.00");

        }

        private void txtBoxVatAmount_TextChanged(object sender, EventArgs e)
        {
            netAmount = (decimal.Parse(txtBoxGrossAmount.Text) - decimal.Parse(txtBoxDiscountAmount.Text)) + decimal.Parse(txtBoxVatAmount.Text);
            txtBoxNetAmount.Text = netAmount.ToString("0.00");
        }


        private void comBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unitRate = "";
            string vatRate = "";
            string salesMargin = "";


            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select ProductID, UnitRate, SalesVatRate, SalesMarginRate from store.Products where ProductName= '" + comBoxProductName.Text + "'", con);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);


                foreach (DataRow data in dt.Rows)
                {
                    productID = data["ProductID"].ToString();
                    unitRate = data["UnitRate"].ToString();
                    vatRate = data["SalesVatRate"].ToString();
                    salesMargin = data["SalesMarginRate"].ToString();

                }
              
            }

            if (transactionType == "Sales" || transactionType == "Sales Return" )
            {
                decimal salesRate = decimal.Parse(unitRate) + (decimal.Parse(unitRate) * (decimal.Parse(salesMargin) / 100));

                txtBoxVat.Text = vatRate;
                txtBoxRate.Text = salesRate.ToString("0.00");
            }
            else
            {

                txtBoxRate.Text = unitRate;
            }

        }

        
        private void comBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select CustomerID from store.Customers where CustomerName = '" + comBoxCustomerName.Text + "'", con);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);


                foreach (DataRow data in dt.Rows)
                {

                    clientID = data["CustomerID"].ToString();


                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxQuantity.Text != "0.00")
                {
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("store.sp_Transaction", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@transactionid", Int16.Parse(lblTranId.Text));
                    cmd.Parameters.AddWithValue("@operation", "Update");
                    cmd.Parameters.AddWithValue("@transactiontype", transactionType);
                    cmd.Parameters.AddWithValue("@date", datePickerTransaction.Text);
                    cmd.Parameters.AddWithValue("@trasactiontypeid", lblTransactionID.Text);
                    cmd.Parameters.AddWithValue("@clientid", Int16.Parse(clientID));
                    cmd.Parameters.AddWithValue("@productid", Int16.Parse(productID));
                    cmd.Parameters.AddWithValue("@rate", txtBoxRate.Text);

                    cmd.Parameters.AddWithValue("@quantity", Int16.Parse(txtBoxQuantity.Text));
                    cmd.Parameters.AddWithValue("@discountamount", txtBoxDiscountAmount.Text);

                    cmd.Parameters.AddWithValue("@vatamount", txtBoxVatAmount.Text);
                    cmd.Parameters.AddWithValue("@userid", Int16.Parse(_userid));

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(transactionType + " Info Update Successsfully!!!");
                    this.Hide();                   

                }
            }
        }

        private void comBoxTranTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd;
                SqlDataReader dr;
                DataTable dt = new DataTable();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM store.[Transaction] WHERE TransactionTypeID = @TranTypeID", con);
                cmd.Parameters.AddWithValue("@TranTypeID", comBoxTranTypeID.Text);
                dr = cmd.ExecuteReader();
                dt.Load(dr);


                txtBoxDiscountAmount.Text = dt.Rows[0]["Discount"].ToString();
                txtBoxGrossAmount.Text = dt.Rows[0]["GrossAmount"].ToString();
                txtBoxNetAmount.Text = dt.Rows[0]["NetAmount"].ToString();
                txtBoxQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                txtBoxRate.Text = dt.Rows[0]["Rate"].ToString();
                txtBoxVatAmount.Text = dt.Rows[0]["Vat"].ToString();
                datePickerTransaction.Text = dt.Rows[0]["Date"].ToString();

                string productID = dt.Rows[0]["ProductID"].ToString();

                cmd = new SqlCommand("SELECT ProductName FROM store.Products WHERE ProductID= @ProductID", con);
                cmd.Parameters.AddWithValue("@ProductID", Int16.Parse(productID));
                string productName = cmd.ExecuteScalar().ToString();

                comBoxProductName.Text = productName;

            }
        }
    }
}
