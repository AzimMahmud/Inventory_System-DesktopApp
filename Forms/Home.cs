using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UltimateInventorySystem.UserControls;

namespace UltimateInventorySystem
{
    public partial class Home : Form
    {
        private string userID;
        private string userName;
        private string userRole;

        public Home(DataTable dt)
        {
            
            InitializeComponent();
            foreach (DataRow row in dt.Rows)
            {
                userID = row["UserID"].ToString();
                userName = row["UserName"].ToString();
                userRole = row["RoleName"].ToString();
                
            }

        }



        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelHome.Controls.Clear();
            panelHome.Controls.Add(c);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblUserName.Text = userName;
            lblRole.Text = userRole;
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();     
            UC_Home uch = new UC_Home();
            addControlToPanel(uch);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            addControlToPanel(uch);

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UC_Users uch = new UC_Users();
            addControlToPanel(uch);
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            UC_Contacts uch = new UC_Contacts();
            addControlToPanel(uch);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            UC_Products uch = new UC_Products();
            addControlToPanel(uch);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            UC_Purchase uch = new UC_Purchase(userID);
            addControlToPanel(uch);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            UC_Sales uch = new UC_Sales(userID);
            addControlToPanel(uch);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Reports uch = new UC_Reports();
            addControlToPanel(uch);
        }
    }
}
