using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {

        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Selection.showStockDetails(dataGridViewStocks, prodIDGV, prodNameGV, QuantityGV, BarcodeGV, ExpiryGV, BuyingPriceGV, SellingPriceGV, CategoryGV, TotalAmountGV, StatusGV);
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            base.Addbtn.Enabled = false;
            base.Editbtn.Enabled = false;
            base.Savebtn.Enabled = false;
            base.Deletebtn.Enabled = false;
        }
    }
}
