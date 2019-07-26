using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADD
using System.IO;
using UltimateInventorySystem.UserControls;

namespace UltimateInventorySystem.Forms
{
    public partial class AddUser : Form
    {
        string imageLocation = "";
        string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
        
        public AddUser(string v)
        {
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName;
                picBoxUserImage.ImageLocation = imageLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var imagePath = "";
            
            int isActive;

            if (imageLocation != "")
            {
                File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());

            }

            if (chkBoxIsActive.Checked==true){isActive = 1; }
            else{isActive = 0;}

            if (txtBoxFirstName.Text != null && txtBoxContact.Text != null && txtBoxEmail.Text != null && txtBoxUserName.Text != null && txtBoxPassword.Text != null)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string insertQuery = "INSERT INTO store.Users(FirstName,LastName,Contact,Email,UserName,[Password],RoleName,UserImage,IsActive)" +
                                         " VALUES  (@firstname, @lastname, store.fn_contact(@contact), @email, @username, @password, @role ,@image, @isActive)";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.Add(new SqlParameter("@firstname", txtBoxFirstName.Text));
                    cmd.Parameters.Add(new SqlParameter("@lastname", txtBoxLastName.Text));
                    cmd.Parameters.Add(new SqlParameter("@contact", txtBoxContact.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", txtBoxEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@username", txtBoxUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@password", txtBoxPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@role", comboBoxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("@image", imagePath));
                    cmd.Parameters.Add(new SqlParameter("@isActive", isActive));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    ;
                    MessageBox.Show("New user is added successfully!!!! ");

                }
            }
            else
            {
                MessageBox.Show("Please enter required information");
            }

            this.Close();
    
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
           
            var imagePath = "";

            if (imageLocation == "")
            {
                imagePath = lblUserImgPath.Text;
            }
            else
            {
                File.Copy(imageLocation, Path.Combine(@"C:\Uploads", Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString())), true);
                imagePath = Uri.EscapeDataString(DateTime.Now.ToLocalTime().ToLongDateString() + Path.GetFileName(imageLocation).ToString());

            }

            int isActive;

            if (chkBoxIsActive.Checked == true) { isActive = 1; }
            else { isActive = 0; }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string updateQuery = "UPDATE store.Users SET FirstName = @firstname,LastName = @lastname, Contact = @contact,Email = @email ,UserName = @username ,[Password] = @password,RoleName = @role, UserImage = @imagepath ,IsActive = @isact WHERE UserID = @userid";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.Add(new SqlParameter("@firstname", txtBoxFirstName.Text));
                cmd.Parameters.Add(new SqlParameter("@lastname", txtBoxLastName.Text));
                cmd.Parameters.Add(new SqlParameter("@contact", txtBoxContact.Text));
                cmd.Parameters.Add(new SqlParameter("@email", txtBoxEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@username", txtBoxUserName.Text));
                cmd.Parameters.Add(new SqlParameter("@password", txtBoxPassword.Text));
                cmd.Parameters.Add(new SqlParameter("@role", comboBoxRole.Text));
                cmd.Parameters.Add(new SqlParameter("@imagepath", imagePath));
                cmd.Parameters.Add(new SqlParameter("@isact", isActive));
                cmd.Parameters.Add(new SqlParameter("@userid", Int16.Parse(lblUserID.Text)));
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Update Informaton Successfully!!! ");
            }

            this.Close();
        }
    
    }
}
