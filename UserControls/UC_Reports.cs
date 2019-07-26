using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateInventorySystem.Forms;

namespace UltimateInventorySystem.UserControls
{
    public partial class UC_Reports : UserControl
    {
        public UC_Reports()
        {
            InitializeComponent();
        }

        private void btnReportPurchase_Click(object sender, EventArgs e)
        {
            PurchaseReport PurReport = new PurchaseReport();
            PurReport.ShowDialog();
        }

        private void btnReportSales_Click(object sender, EventArgs e)
        {
            SalesReports SalesReports = new SalesReports();
            SalesReports.ShowDialog();
        }

        private void btnReportPurchaseReturn_Click(object sender, EventArgs e)
        {
            PurchaseReturnReport PurReturnReport = new PurchaseReturnReport();
            PurReturnReport.ShowDialog();
        }

        private void btnReportSalesReturn_Click(object sender, EventArgs e)
        {

            SalesReturnReport salesReturn = new SalesReturnReport();
            salesReturn.ShowDialog();
        }
    }
}
