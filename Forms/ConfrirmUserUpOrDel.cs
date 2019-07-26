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
    public partial class ConfrirmUserUpOrDel : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        Dictionary<int, string> _userDictionary = new Dictionary<int, string>();
        public ConfrirmUserUpOrDel(Dictionary<int, string> userDictionary)
        {
            _userDictionary = userDictionary;
            InitializeComponent();
            lblUserID.Text = _userDictionary[0];
            lblUserName.Text = _userDictionary[1] + " " + _userDictionary[2];
            lblFname.Text = _userDictionary[1];
            lblLName.Text = _userDictionary[2];
            lblContact.Text = _userDictionary[3];
            lblEmail.Text = _userDictionary[4];
            lblRole.Text = _userDictionary[7];
            picBoxUser.ImageLocation = @"C:\Uploads\" + _userDictionary[9];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            AddUser userForm = new AddUser("Edit");

            userForm.lblUserHeader.Text = "Update User Info";

            userForm.lblUserID.Text = _userDictionary[0];
            userForm.txtBoxFirstName.Text = _userDictionary[1];
            userForm.txtBoxLastName.Text = _userDictionary[2];
            userForm.txtBoxContact.Text = _userDictionary[3];
            userForm.txtBoxEmail.Text = _userDictionary[4];
            userForm.txtBoxUserName.Text = _userDictionary[5];
            userForm.txtBoxPassword.Text = _userDictionary[6];
            userForm.comboBoxRole.Text = _userDictionary[7];
            userForm.lblUserImgPath.Text = _userDictionary[8];
            userForm.lblUserID.Visible = false;

            if (_userDictionary[10] == "True")
            {
                userForm.chkBoxIsActive.Checked = true;
            }
            else
            {
                userForm.chkBoxIsActive.Checked = false;
            }

            userForm.picBoxUserImage.ImageLocation =
                @"c:\Uploads\" + _userDictionary[9];

            userForm.btnSave.Hide();
            userForm.btnUserUpdate.Show();

            userForm.Show();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (_userDictionary[5] == "admin")
            {
                MessageBox.Show("You can not delete admin");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM store.Users WHERE UserID = @userid", con);
                    cmd.Parameters.AddWithValue("@userid", Int16.Parse(lblUserID.Text));
                    con.Open();
                    int rowEffect = cmd.ExecuteNonQuery();

                    if (rowEffect > 0)
                    {
                        MessageBox.Show("User Deleted Successfully!!!");
                    }

                }
            }
            this.Hide();
        }
    }
}
