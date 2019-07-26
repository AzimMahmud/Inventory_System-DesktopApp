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
    public partial class UC_Users : UserControl
    {
        private string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        private Dictionary<int, string> userDetails = new Dictionary<int, string>();

        public UC_Users()
        {
            InitializeComponent();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser role = new AddUser("");
            role.ShowDialog();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            AutoComplete();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM store.Users", con);

                DataTable dtUser = new DataTable();

                daUser.Fill(dtUser);


                if (dtUser.Rows.Count != 0)
                {
                    dgViewUser.DataSource = dtUser;

                }
                else
                {
                    dtUser.Rows.Add(dtUser.NewRow());
                    dgViewUser.DataSource = dtUser;

                }

               

                dgViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgViewUser.Columns["Password"].Visible = false;
                dgViewUser.Columns["UserImage"].Visible = false;
                dgViewUser.Columns["RoleName"].Visible = false;

            }
        }

        private void dgViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (userDetails.Count != 0)
            {
                userDetails.Clear();
            }

            LoadDataToDictionary();




            ConfrirmUserUpOrDel confrirm = new ConfrirmUserUpOrDel(userDetails);
            confrirm.lblUserID.Text = userDetails[1] + " " + userDetails[2];
            confrirm.lblUserID.Text = this.dgViewUser.CurrentRow.Cells["UserID"].Value.ToString();

            confrirm.ShowDialog();
        }

        private void LoadDataToDictionary()
        {
            userDetails.Add(0, this.dgViewUser.CurrentRow.Cells["UserID"].Value.ToString());
            userDetails.Add(1, this.dgViewUser.CurrentRow.Cells["FirstName"].Value.ToString());
            userDetails.Add(2, this.dgViewUser.CurrentRow.Cells["LastName"].Value.ToString());
            userDetails.Add(3, this.dgViewUser.CurrentRow.Cells["Contact"].Value.ToString());
            userDetails.Add(4, this.dgViewUser.CurrentRow.Cells["Email"].Value.ToString());
            userDetails.Add(5, this.dgViewUser.CurrentRow.Cells["UserName"].Value.ToString());
            userDetails.Add(6, this.dgViewUser.CurrentRow.Cells["Password"].Value.ToString());
            userDetails.Add(7, this.dgViewUser.CurrentRow.Cells["RoleName"].Value.ToString());
            userDetails.Add(8, this.dgViewUser.CurrentRow.Cells["UserImage"].Value.ToString());
            userDetails.Add(9, this.dgViewUser.CurrentRow.Cells["UserImage"].Value.ToString());
            userDetails.Add(10, this.dgViewUser.CurrentRow.Cells["IsActive"].Value.ToString());
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM store.Users WHERE UserName Like @username", con);

                cmd.Parameters.AddWithValue("@username", txtBoxSearchUser.Text);

                con.Open();

                SqlDataAdapter daUser = new SqlDataAdapter(cmd);

                DataTable dtUser = new DataTable();

                daUser.Fill(dtUser);


                if (dtUser.Rows.Count != 0)
                {
                    dgViewUser.Refresh();
                    dgViewUser.DataSource = dtUser;

                    dgViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgViewUser.Columns["Password"].Visible = false;
                    dgViewUser.Columns["UserImage"].Visible = false;
                    dgViewUser.Columns["RoleName"].Visible = false;
                    btnClear.Show();

                }
                else
                {
                    MessageBox.Show("User Not Found");
                }      

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM store.Users", con);

                DataTable dtUser = new DataTable();

                daUser.Fill(dtUser);

                dgViewUser.DataSource = dtUser;

                dgViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgViewUser.Columns["Password"].Visible = false;
                dgViewUser.Columns["UserImage"].Visible = false;
                dgViewUser.Columns["RoleName"].Visible = false;

            }

            txtBoxSearchUser.Text = "";
            btnClear.Hide();
        }


        private void AutoComplete()
        {
            txtBoxSearchUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBoxSearchUser.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();


            using (SqlConnection con = new SqlConnection(cs))
            {
               SqlDataAdapter userReader = new SqlDataAdapter("SELECT UserName FROM store.Users ORDER BY UserName ASC", con);


               DataTable dt = new DataTable();

                userReader.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string username = dt.Rows[i]["UserName"].ToString();
                    collection.Add(username);
                }

                txtBoxSearchUser.AutoCompleteCustomSource = collection;

            }

        }

        private void txtBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            btnClear.Show();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter userReader = new SqlDataAdapter("SELECT * FROM store.Users WHERE UserName = '" + txtBoxSearchUser.Text +"'", con);


                DataTable dt = new DataTable();

                userReader.Fill(dt);

                if (dt.Rows.Count > 0)

                {

                    dgViewUser.DataSource = dt;


                }


            }


          

          
            
        }

       
    }
}
