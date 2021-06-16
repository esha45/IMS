using IMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoiceDetails : Sample2
    {

        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Selection.getListWithTwoParameters("st_getPurchaseInvoiceList", PurchaseInvoiceCB, "Company", "ID", "@month", DatePicker.Value.Month, "@year", DatePicker.Value.Year);
        }

        public override void Backbtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showwindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridViewPurchaseInvoiceDetails.AutoGenerateColumns = false;
            Selection.getListWithTwoParameters("st_getPurchaseInvoiceList", PurchaseInvoiceCB, "Company", "ID", "@month", DatePicker.Value.Month, "@year", DatePicker.Value.Year);
        }

        private void PurchaseInvoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchaseInvoiceDetailsController.SelectedIndexChanged(PurchaseInvoiceCB, dataGridViewPurchaseInvoiceDetails, mPIDgv, prodIDGV, prodNameGV, QuantityGV, PerUnitPriceGV, TotalAmountGV, GrossTotalTextLabel);
        }

        private void dataGridViewPurchaseInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseInvoiceDetailsController.CellClick(e, dataGridViewPurchaseInvoiceDetails, PurchaseInvoiceCB, GrossTotalTextLabel);
        }
    }
    
}
