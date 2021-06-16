using IMS.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
    public partial class SalesReturn : Sample2
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        Hashtable ht = new Hashtable();
        float amountRefund = 0;
        public static String salesID;

        public SalesReturn()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            SalesReturnController.LoadBtnClick(PaymentTypeTxt, UserTxt, DatePicker, SalesIDTxt, rg, salesID, dataGridViewSalesReturn, SalesIDGV, ProdIDGV, BarcodeGV, ProductNameGV, QuantityGV, TotalDiscountGV, TotalAmountGV, AmountGivenGV, ReturnedAmountGV, DateGV, ProductPriceGV, PerProductDiscountGV, PerProductTotalGV, UserNameGV, PaymentTypeGV);
        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            SalesReturnController.SavebtnClick(RefundTxt, SalesIDTxt, ht, amountRefund);
        }

        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            SalesReturnController.BarcodeTxtValidating(ht, BarcodeTxt, dataGridViewSalesReturn, amountRefund, RefundTxt);
        }

        private void dataGridViewSalesReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
