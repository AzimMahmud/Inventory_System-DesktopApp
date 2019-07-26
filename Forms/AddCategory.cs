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
    public partial class AddCategory : Form
    {

        public AddCategory()
        {
            InitializeComponent();
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {

            fillComBox();
        }

        public void fillComBox()
        {

            string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable("Category");
                con.Open();
                string query = "select CategoryID,CategoryName from store.Category Where IsActive=1";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                comBoxParentCategory.DisplayMember = "CategoryName";
                comBoxParentCategory.ValueMember = "CategoryID";
                comBoxParentCategory.DataSource = dt;
                con.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int isActive;
            string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxCategoryName.Text != "" && chkAddAsSubCat.Checked == false)
                {
                    if (chkIsActive.Checked == true){isActive = 1;}
                    else{isActive = 0;}
                    SqlDataAdapter da = new SqlDataAdapter("Insert Into store.Category (CategoryName,IsActive) values ('" + txtBoxCategoryName.Text + "'," + isActive + ")", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Category Added Successfully");
                }
                else if (chkAddAsSubCat.Checked==true)
                {
                    if (txtBoxCategoryName.Text != "" && comBoxParentCategory.Text != "")
                    {
                        if (chkIsActive.Checked == true) { isActive = 1; }
                        else { isActive = 0; }
                        SqlDataAdapter dr = new SqlDataAdapter("SELECT CategoryID FROM store.Category WHERE CategoryName = '" + comBoxParentCategory.Text + "';",con);
                        DataTable dt = new DataTable();
                        string x= "";
                        dr.Fill(dt);
                        foreach (DataRow item in dt.Rows)
                        {
                            x = item["CategoryID"].ToString();
                        }
                        SqlCommand da = new SqlCommand("Insert Into store.SubCategory (SubCategoryName,CategoryID,IsActive) values ('" + txtBoxCategoryName.Text + "'," + Int32.Parse(x) + "," + isActive + ")", con);
                        con.Open();
                        da.ExecuteNonQuery();
                        MessageBox.Show("SubCategory Added Successfully");
                    }
                }
            }
        }

        private void chkAddAsSubCat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddAsSubCat.Checked)
            {
                lblParentCategory.Visible = true;
                comBoxParentCategory.Visible = true;
            }
            else
            {
                lblParentCategory.Visible = false;
                comBoxParentCategory.Visible = false;
            }
        }
    }
}
