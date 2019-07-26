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
    public partial class SalesReturnReport : Form
    {
        private string CS = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public SalesReturnReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            CrystalReportSalesReturn report = new CrystalReportSalesReturn();

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from store.vw_SalesReport where CustomerName Like '" + txtPurchaseClientName.Text + "%' AND TransactionTypeID Like 'SR-%'", con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                report.SetDataSource(dt);

                cryReportSalesReturn.ReportSource = report;
                cryReportSalesReturn.Refresh();

            }
        }
    }
}
