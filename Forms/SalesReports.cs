using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateInventorySystem.Reports;

namespace UltimateInventorySystem.Forms
{
    public partial class SalesReports : Form
    {
        private string CS = ConfigurationManager.ConnectionStrings["UltimateInventorySystemDB"].ConnectionString;

        public SalesReports()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CrystalReportSales report = new CrystalReportSales();

            using (SqlConnection con = new SqlConnection(CS))
            {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from store.vw_SalesReport WHERE CustomerName Like '" + txtPurchaseClientName.Text + "%' AND TransactionTypeID Like 'S-%'" , con);
               
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                report.SetDataSource(dt);

                cryReportSales.ReportSource = report;

            }

        }
    }
}
