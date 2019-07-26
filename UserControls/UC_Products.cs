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
using System.Configuration;
using System.Data.SqlClient;

namespace UltimateInventorySystem.UserControls
{
    public partial class UC_Products : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
        public UC_Products()
        {
            InitializeComponent();
        }


        private void btnAddNewProduct_Click(object sender, EventArgs e)  //ok
        {
            AddProduct newProduct = new AddProduct();
            newProduct.ShowDialog();
        }


        private void UC_Products_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query1 = "select p.ProductID,p.ProductName,p.SubCategoryID,p.Description,p.UnitID,p.UnitRate,p.SalesVatRate,p.SalesMarginRate,p.ProductImage,p.IsActive,sc.SubCategoryName,c.CategoryName,u.UnitName from store.Products p join store.SubCategory sc on p.SubCategoryID=sc.SubCategoryID join store.Unit u on p.UnitID=u.UnitID join store.Category c on sc.CategoryID=c.CategoryID";
                SqlDataAdapter daProduct = new SqlDataAdapter(query1, con);
                DataTable dtProduct = new DataTable();
                daProduct.Fill(dtProduct);


                if(dtProduct.Rows.Count != 0)
                {
                    dgViewProducts.DataSource = dtProduct;

                }
                else
                {
                    dtProduct.Rows.Add(dtProduct.NewRow());
                    dgViewProducts.DataSource = dtProduct;

                }

                

                dgViewProducts.Columns["SubCategoryID"].Visible = false;
                dgViewProducts.Columns["UnitID"].Visible = false;
                dgViewProducts.Columns["ProductImage"].Visible = false;
                dgViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                string query2 = "select * from store.Category";
                SqlDataAdapter daCategory = new SqlDataAdapter(query2, con);
                DataTable dtCategory = new DataTable();
                daCategory.Fill(dtCategory);

                if (dtCategory.Rows.Count != 0)
                {
                    dgViewCategory.DataSource = dtCategory;

                }
                else
                {
                    dtCategory.Rows.Add(dtCategory.NewRow());
                    dgViewCategory.DataSource = dtCategory;

                }


                
                dgViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                string query3 = "select * from store.Unit";
                SqlDataAdapter daUnit = new SqlDataAdapter(query3, con);
                DataTable dtUnit = new DataTable();
                daUnit.Fill(dtUnit);

                if (dtCategory.Rows.Count != 0)
                {
                    dgViewUnit.DataSource = dtUnit;


                }
                else
                {
                    dtUnit.Rows.Add(dtUnit.NewRow());
                    dgViewUnit.DataSource = dtUnit;

                }

               
                dgViewUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory categoryForm = new AddCategory();
            categoryForm.ShowDialog();
        }

        private void btnAddUnit_Click_1(object sender, EventArgs e)
        {
            AddUnit newUnit = new AddUnit();
            newUnit.ShowDialog();
        }


        private void dgViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.lblAddNewProduct.Text = "Update Product Info";

            addProduct.lblProductID.Text = this.dgViewProducts.CurrentRow.Cells["ProductID"].Value.ToString();
            addProduct.txtBoxProductName.Text = this.dgViewProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            addProduct.comBoxCategoryName.Text = this.dgViewProducts.CurrentRow.Cells["CategoryName"].Value.ToString();
            addProduct.comBoxSubCategoryName.Text = this.dgViewProducts.CurrentRow.Cells["SubCategoryName"].Value.ToString();
            addProduct.rTxtBoxDescription.Text = this.dgViewProducts.CurrentRow.Cells["Description"].Value.ToString();
            addProduct.txtBoxUnitRate.Text = this.dgViewProducts.CurrentRow.Cells["UnitRate"].Value.ToString();
            addProduct.txtBoxSalesMarginRate.Text = this.dgViewProducts.CurrentRow.Cells["SalesMarginRate"].Value.ToString();
            addProduct.txtBoxSalesVatRate.Text = this.dgViewProducts.CurrentRow.Cells["SalesVatRate"].Value.ToString();

            addProduct.lblSubCategoryID.Text = this.dgViewProducts.CurrentRow.Cells["SubCategoryID"].Value.ToString();
            addProduct.lblUnitID.Text = this.dgViewProducts.CurrentRow.Cells["SubCategoryID"].Value.ToString();
            addProduct.lblimagePath.Text = this.dgViewProducts.CurrentRow.Cells["ProductImage"].Value.ToString();
            
            if (this.dgViewProducts.CurrentRow.Cells["IsActive"].Value.ToString() == "True")
            {
                addProduct.chkIsActive.Checked = true;
            }
            else
            {
                addProduct.chkIsActive.Checked = false;
            }

            addProduct.picBoxProduct.ImageLocation =
                @"c:\Uploads\" + this.dgViewProducts.CurrentRow.Cells["ProductImage"].Value;

            addProduct.btnSave.Hide();
            addProduct.btnUpdateProduct.Show();

            addProduct.Show();

        }
    }
}
