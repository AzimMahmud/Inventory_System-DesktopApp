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
    public partial class PurchaseReturnReport : Form
    {
        private string CS = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public PurchaseReturnReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CrystalReportPurchaseReturn report = new CrystalReportPurchaseReturn();

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from store.vw_PurchaseReport where BusinessName LIKE '" + txtPurchaseClientName.Text + "%' AND TransactionTypeID LIKE 'PR-%'", con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                report.SetDataSource(dt);

                cryReportPurchaseReturn.ReportSource = report;
                cryReportPurchaseReturn.Refresh();

            }
        }
    }
}
