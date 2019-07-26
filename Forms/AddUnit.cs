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
    public partial class AddUnit : Form
    {
        SqlCommand cmd;
        public AddUnit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int isActive;
            string cs = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
            if (chkIsActive.Checked == true) { isActive = 1; }
            else { isActive = 0; }
            using (SqlConnection con = new SqlConnection(cs))
            {
                if (txtBoxUnitName.Text!="" && txtBoxUnitShortName.Text!="")
                {
                    con.Open();
                    string query = "INSERT INTO store.Unit(UnitName,ShortName,IsActive) VALUES ('" + txtBoxUnitName.Text + "','" + txtBoxUnitShortName.Text + "'," + isActive + ")";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Unit Added Successfully");

                    txtBoxUnitName.Clear();
                    txtBoxUnitShortName.Clear();
                    chkIsActive.Checked = false;

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxUnitName.Clear();
            txtBoxUnitShortName.Clear();
            chkIsActive.Checked = false;
        }
    }
}
