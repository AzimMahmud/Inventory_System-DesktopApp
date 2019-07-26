using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace UltimateInventorySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from store.Users where UserName = '" + txtBoxUserName.Text + "' and [Password] = '" + txtBoxPassword.Text + "' and IsActive = 1", con);

                DataTable dt = new DataTable();

                cmd.Fill(dt);
                

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Home HomeWindow = new Home(dt);
                    HomeWindow.Show();

                }
                else
                {
                    MessageBox.Show("Your User Name or Password Incorrect!!!");
                }
            }
            

        }
    }
}
