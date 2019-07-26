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
using UltimateInventorySystem.Reports;

namespace UltimateInventorySystem.Forms
{
    public partial class PurchaseReport : Form
    {
        private string CS = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CrystalReportPurchase report = new CrystalReportPurchase();

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM store.vw_PurchaseReport WHERE TransactionTypeID LIKE 'P-%' AND BusinessName LIKE '" + txtPurchaseClientName.Text +"%'", con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                report.SetDataSource(dt);

                cryReportPurchase.ReportSource = report;
                cryReportPurchase.Refresh();

            }
        }
    }
}
