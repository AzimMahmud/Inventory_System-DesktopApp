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
using UltimateInventorySystem.Forms;

namespace UltimateInventorySystem.UserControls
{
    public partial class UC_Sales : UserControl
    {
        private string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        private string tranType = "";
        private Transaction tran;
        private string _userid;
        public UC_Sales(string userID)
        {
            InitializeComponent();
            _userid = userID;
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            Transaction tran = new Transaction("Sales Return", _userid);
            tran.ShowDialog();
        }


       

        private void btnAddNewSales_Click(object sender, EventArgs e)
        {
            tran = new Transaction("Sales", _userid);
            tran.ShowDialog();
        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT tr.TransactionID, tr.TransactionTypeID, tr.TransactionType, tr.[Date],tr.Rate, tr.Quantity,tr.Discount, tr.GrossAmount, tr.Vat, tr.NetAmount,  p.ProductID, p.ProductName, u.UserID, u.UserName, c.CustomerID, c.CustomerName FROM store.[Transaction] tr JOIN store.Customers c ON tr.ClientID = c.CustomerID JOIN store.Products p ON tr.ProductID = p.ProductID JOIN store.Users u ON tr.UserID = u.UserID WHERE tr.TransactionType = 'Sales'", con);
               

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);


                if (dt.Rows.Count != 0)
                {
                    dgVewSales.DataSource = dt;

                }
                else
                {
                    dt.Rows.Add(dt.NewRow());
                    dgVewSales.DataSource = dt;

                }


                dgVewSales.Columns["TransactionID"].Visible = false;
                dgVewSales.Columns["TransactionType"].Visible = false;

                dgVewSales.Columns["UserID"].Visible = false;
                dgVewSales.Columns["CustomerID"].Visible = false;
                dgVewSales.Columns["ProductID"].Visible = false;
                dgVewSales.Columns["GrossAmount"].Visible = false;
                dgVewSales.Columns["Discount"].Visible = false;
                dgVewSales.Columns["Vat"].Visible = false;
                dgVewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }

        private void dgVewSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgVewSales.CurrentRow.Cells["TransactionID"].Value.ToString() != "") { 
                Transaction tr = new Transaction(tranType, _userid);

                tr.lblTransaction.Show();
                tr.lblTransactionID.Show();
                tr.lblTranId.Hide();
                tr.lblTransactionHeader.Text = "Edit Sales Info";
                tr.lblTranId.Text = this.dgVewSales.CurrentRow.Cells["TransactionID"].Value.ToString();
                tr.lblTransactionID.Text = this.dgVewSales.CurrentRow.Cells["TransactionTypeID"].Value.ToString();
                tr.comBoxCustomerName.Text = this.dgVewSales.CurrentRow.Cells["CustomerName"].Value.ToString();
                tr.lblClientID.Text = this.dgVewSales.CurrentRow.Cells["CustomerID"].Value.ToString();
                tr.txtBoxDiscount.Text = this.dgVewSales.CurrentRow.Cells["Discount"].Value.ToString();
                tr.txtBoxVat.Text = this.dgVewSales.CurrentRow.Cells["Vat"].Value.ToString();
                tr.txtBoxQuantity.Text = this.dgVewSales.CurrentRow.Cells["Quantity"].Value.ToString();
                tr.txtBoxRate.Text = this.dgVewSales.CurrentRow.Cells["Rate"].Value.ToString();
                tr.txtBoxDiscountAmount.Text = this.dgVewSales.CurrentRow.Cells["Discount"].Value.ToString();
                tr.txtBoxNetAmount.Text = this.dgVewSales.CurrentRow.Cells["NetAmount"].Value.ToString();
                tr.txtBoxVatAmount.Text = this.dgVewSales.CurrentRow.Cells["Vat"].Value.ToString();
                tr.txtBoxGrossAmount.Text = this.dgVewSales.CurrentRow.Cells["GrossAmount"].Value.ToString();

                tr.btnSubmitTransaction.Hide();
                tr.btnUpdate.Show();

                tr.Show();
            }
        }
    }
}
