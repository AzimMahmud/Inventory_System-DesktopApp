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
    public partial class UC_Purchase : UserControl
    {
        private string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        private string tranType = "";
        private string userID;
        public UC_Purchase(string userid)
        {
            userID = userid;
            InitializeComponent();
        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            Transaction tran = new Transaction("Purchase Return", userID);
            tran.ShowDialog();
        }

        private void btnAddNewPurchase_Click(object sender, EventArgs e)
        {
            Transaction tran = new Transaction("Purchase", "1");
            tran.ShowDialog();
        }

       
        private void UC_Purchase_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter daPurchase = new SqlDataAdapter("SELECT tr.TransactionID, tr.TransactionTypeID, tr.TransactionType, tr.[Date],tr.Rate, tr.Quantity,tr.Discount, tr.GrossAmount, tr.Vat, tr.NetAmount,  p.ProductID, p.ProductName, u.UserID, u.UserName, s.SupplierID, s.BusinessName FROM store.[Transaction] tr JOIN store.Supplier s ON tr.ClientID = s.SupplierID JOIN store.Products p ON tr.ProductID = p.ProductID JOIN store.Users u ON tr.UserID = u.UserID WHERE tr.TransactionType = 'Purchase'", con);
                
                DataTable dtPurchase = new DataTable();

                daPurchase.Fill(dtPurchase);


                if (dtPurchase.Rows.Count != 0)
                {
                    dgViewPurchases.DataSource = dtPurchase;
                    
                }
                else
                {
                    dtPurchase.Rows.Add(dtPurchase.NewRow());
                    dgViewPurchases.DataSource = dtPurchase;
                  
                }
             


                tranType = dgViewPurchases.CurrentRow.Cells["TransactionType"].Value.ToString();
                userID = dgViewPurchases.CurrentRow.Cells["UserID"].Value.ToString();


                dgViewPurchases.Columns["TransactionID"].Visible = false;
                dgViewPurchases.Columns["TransactionType"].Visible = false;

                dgViewPurchases.Columns["UserID"].Visible = false;
                dgViewPurchases.Columns["SupplierID"].Visible = false;
                dgViewPurchases.Columns["ProductID"].Visible = false;
                dgViewPurchases.Columns["GrossAmount"].Visible = false;
                dgViewPurchases.Columns["Discount"].Visible = false;
                dgViewPurchases.Columns["Vat"].Visible = false;
                dgViewPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }


        }

        private void dgViewPurchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgViewPurchases.CurrentRow.Cells["TransactionID"].Value.ToString() != "")
            {
                Transaction tr = new Transaction(tranType, userID);

                tr.lblTransaction.Show();
                tr.lblTransactionID.Show();
                tr.lblTransactionHeader.Text = "Edit Purchase Info";
                tr.lblTransactionID.Text = this.dgViewPurchases.CurrentRow.Cells["TransactionTypeID"].Value.ToString();
                tr.comBoxCustomerName.Text = this.dgViewPurchases.CurrentRow.Cells["BusinessName"].Value.ToString();
                tr.lblClientID.Text = this.dgViewPurchases.CurrentRow.Cells["SupplierID"].Value.ToString();
                tr.txtBoxDiscount.Text = this.dgViewPurchases.CurrentRow.Cells["Discount"].Value.ToString();
                tr.txtBoxVat.Text = this.dgViewPurchases.CurrentRow.Cells["Vat"].Value.ToString();
                tr.txtBoxQuantity.Text = this.dgViewPurchases.CurrentRow.Cells["Quantity"].Value.ToString();
                tr.txtBoxRate.Text = this.dgViewPurchases.CurrentRow.Cells["Rate"].Value.ToString();
                tr.txtBoxDiscountAmount.Text = this.dgViewPurchases.CurrentRow.Cells["Discount"].Value.ToString();
                tr.txtBoxNetAmount.Text = this.dgViewPurchases.CurrentRow.Cells["NetAmount"].Value.ToString();
                tr.txtBoxVatAmount.Text = this.dgViewPurchases.CurrentRow.Cells["Vat"].Value.ToString();
                tr.txtBoxGrossAmount.Text = this.dgViewPurchases.CurrentRow.Cells["GrossAmount"].Value.ToString();

                tr.Show();
            }

        }
    }
}
