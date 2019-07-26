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
using System.IO;
using UltimateInventorySystem.UserControls;

namespace UltimateInventorySystem.Forms
{
    public partial class AddProduct : Form
    {
        string imageLocation = "";
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public AddProduct()
        {
            InitializeComponent();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryLoad();
            UnitLoad();
        }

        public void CategoryLoad()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable("Category");
                con.Open();
                string query = "select CategoryID,CategoryName from store.Category Where IsActive=1";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                comBoxCategoryName.DisplayMember = "CategoryName";
                comBoxCategoryName.ValueMember = "CategoryID";
                comBoxCategoryName.DataSource = dt;
                
            }
        }
        public void UnitLoad()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "select UnitId,UnitName from store.Unit Where IsActive=1";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                comBoxUnit.DisplayMember = "UnitName";
                comBoxUnit.ValueMember = "UnitID";
                comBoxUnit.DataSource = dt;
                
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int isActive;
            if (txtBoxProductName.Text != "" && txtBoxSalesMarginRate.Text != "" && txtBoxSalesVatRate.Text != "" && txtBoxUnitRate.Text != "" && comBoxCategoryName.Text != "" && comBoxSubCategoryName.Text != "")
            {
                if (chkIsActive.Checked == true) { isActive = 1; }
                else { isActive = 0; }
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query1 = "select * from store.SubCategory where SubCategoryName='" + comBoxSubCategoryName.Text + "'";
                    SqlCommand sc = new SqlCommand(query1, con);
                    SqlDataAdapter sda = new SqlDataAdapter(sc);
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    string subCategoryID = "";
                    foreach (DataRow item in tb.Rows)
                    {
                        subCategoryID = item["SubCategoryID"].ToString();
                    }

                    string query3 = "select UnitID from store.Unit where UnitName='" + comBoxUnit.Text + "'";
                    SqlDataAdapter saunit = new SqlDataAdapter(query3, con);
                    DataTable dtunit = new DataTable();
                    saunit.Fill(dtunit);
                    string unitID = "";
                    foreach (DataRow item in dtunit.Rows)
                    {
                        unitID = item["unitID"].ToString();
                    }

                    var imagePath = "";

                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());

                    con.Open();
                    string query = "INSERT INTO store.Products (ProductName,SubCategoryID,[Description],UnitID,UnitRate,SalesMarginRate,SalesVatRate,ProductImage,IsActive)VALUES(@proname,@subcatid,@description, @unitid,@unitrate, @salesmarginrate,@salesvatrate, @image,@isactive)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@proname", txtBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@subcatid", Convert.ToInt32(subCategoryID));
                    cmd.Parameters.AddWithValue("@description", rTxtBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@unitid",Convert.ToInt32(unitID));
                    cmd.Parameters.AddWithValue("@unitrate",txtBoxUnitRate.Text);
                    cmd.Parameters.AddWithValue("@salesmarginrate",txtBoxSalesMarginRate.Text);
                    cmd.Parameters.AddWithValue("@image",imagePath);
                    cmd.Parameters.AddWithValue("@salesvatrate",txtBoxSalesVatRate.Text);
                    cmd.Parameters.AddWithValue("@isactive",isActive);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Inserted !");

                    rTxtBoxDescription.Clear();
                    txtBoxProductName.Clear();
                    txtBoxSalesMarginRate.Clear();
                    txtBoxSalesVatRate.Clear();
                    txtBoxUnitRate.Clear();
                    chkIsActive.Checked = false;
                    comBoxCategoryName.Text = "";
                    comBoxSubCategoryName.Text = "";
                    comBoxUnit.Text = "";
                    picBoxProduct.Refresh();

                }
            }
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rTxtBoxDescription.Clear();
            txtBoxProductName.Clear();
            txtBoxSalesMarginRate.Clear();
            txtBoxSalesVatRate.Clear();
            txtBoxUnitRate.Clear();
            chkIsActive.Checked = false;
            comBoxCategoryName.Text = "";
            comBoxSubCategoryName.Text = "";
            comBoxUnit.Text = "";
        }

        private void comBoxSubCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                if (comBoxCategoryName.SelectedValue.ToString()!=null)
                {
                    string query = "select SubCategoryID,SubCategoryName from store.SubCategory Where IsActive=1 and CategoryID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", comBoxCategoryName.SelectedValue.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comBoxSubCategoryName.DisplayMember = "SubCategoryName";
                    comBoxSubCategoryName.ValueMember = "SubCategoryID";
                    comBoxSubCategoryName.DataSource = dt;

                }
            }
        }

        private void btnProdImgBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                picBoxProduct.ImageLocation = imageLocation;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                var imagePath = "";

                if (imageLocation == "")
                {
                    imagePath = lblimagePath.Text;
                }
                else
                {
                    File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                    imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());

                }



                int isActive;
                if (chkIsActive.Checked) { isActive = 1; }
                else { isActive = 0; }

                con.Open();
                string query = "update store.Products set ProductName=@proname,SubCategoryID=@subcatid,[Description]=@des,UnitID=@unitid,UnitRate=@unitrate,SalesMarginRate=@salesmargin,SalesVatRate=@salesvat,ProductImage=@proimage,IsActive=@isactive where ProductID=@proid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@proname", txtBoxProductName.Text);
                cmd.Parameters.AddWithValue("@subcatid", Int32.Parse(lblSubCategoryID.Text));
                cmd.Parameters.AddWithValue("@des", rTxtBoxDescription.Text);
                cmd.Parameters.AddWithValue("@unitid", Int32.Parse(lblUnitID.Text));
                cmd.Parameters.AddWithValue("@unitrate",txtBoxUnitRate.Text);
                cmd.Parameters.AddWithValue("@salesmargin",Int32.Parse(txtBoxSalesMarginRate.Text));
                cmd.Parameters.AddWithValue("@salesvat",Int32.Parse(txtBoxSalesVatRate.Text));
                cmd.Parameters.AddWithValue("@proimage",imagePath);
                cmd.Parameters.AddWithValue("@isactive",isActive);
                cmd.Parameters.AddWithValue("@proid",Int32.Parse(lblProductID.Text));
                cmd.ExecuteNonQuery();
               
            }
            this.Close();
        }
    }
}
