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
    public partial class ProductPricing : Sample2
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public ProductPricing()
        {
            InitializeComponent();
            Selection.getList("st_getCategoryList", ProductCategoryCB, "Category", "ID");
        }

        private void ProductCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductCategoryCB.SelectedIndex != -1 && ProductCategoryCB.SelectedIndex != 0)
            {
                Selection.showProductsWRTCategory(Convert.ToInt32(ProductCategoryCB.SelectedValue.ToString()), dataGridViewProductPricing, prodIDGV, prodNameGV, BuyingPriceGV, ProfitMarginGV, DiscountGV, FinalSellingPriceGV);
            }
        }

        private void dataGridViewProductPricing_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProductPricing.CurrentCell.ColumnIndex == 4)
            {
                dataGridViewProductPricing.BeginEdit(true);
            }
        }

        private void dataGridViewProductPricing_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProductPricingController.CellEndEdit(e, dataGridViewProductPricing, rg);
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            ProductPricingController.save(ProductCategoryCB, dataGridViewProductPricing);
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridViewProductPricing.AutoGenerateColumns = false;
        }
    }
}
