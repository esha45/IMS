using IMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Sales : Sample2
    {
        bool productCheck;
        string[] prodARR = new string[6];
        float grossTotal=0;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public Sales()
        {
            InitializeComponent();
        }

        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            SalesController.BarcodeTxt(GrossTotalTextLabel, grossTotal, productCheck, dataGridViewSales, prodARR, BarcodeTxt, GrossTotalTxt, TotalDiscountTxt, AmountGivenTxt, ChangetoGiveTxt);
        }

        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesController.CellClick(grossTotal, prodARR, GrossTotalTextLabel, dataGridViewSales, e, GrossTotalTxt, TotalDiscountTxt, AmountGivenTxt, ChangetoGiveTxt);
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            SalesController.CheckoutBtn(dataGridViewSales, GrossTotalTxt, TotalDiscountTxt);
        }

        private void AmountGivenTxt_TextChanged(object sender, EventArgs e)
        {
            SalesController.AmountGivenTxt(AmountGivenTxt, rg, GrossTotalTxt, ChangetoGiveTxt);
        }

        private void AmountGivenTxt_Validating(object sender, CancelEventArgs e)
        {
            SalesController.AmountGivenTxtValidating(AmountGivenTxt, GrossTotalTxt, AmountGivenTxt);
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            SalesController.PayBtnClick(GrossTotalTextLabel, PaymentsGroupBox, dataGridViewSales, GrossTotalTxt, TotalDiscountTxt, PaymentTypeCB, AmountGivenTxt, ChangetoGiveTxt);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            ViewSalesReceipts vsr = new ViewSalesReceipts();
            MainClass.showwindow(vsr, this, MDI.ActiveForm);
        }
    }
}
