using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class ProductPricingController
    {
        public static void CellEndEdit(DataGridViewCellEventArgs e, DataGridView dataGridViewProductPricing, Regex rg)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridViewProductPricing.Rows[e.RowIndex];
                if (row.Cells["ProfitMarginGV"].Value != null && rg.Match(row.Cells["ProfitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["BuyingPriceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;

                    float finalSellingPrice = buyingPrice + amountToIncrease;
                    float discountPer;
                    if (row.Cells["DiscountGV"].Value != null && rg.Match(row.Cells["DiscountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["FinalSellingPriceGV"].Value = finalSellingPrice - discountPer;
                }
                else
                {
                    row.Cells["FinalSellingPriceGV"].Value = null;
                    row.Cells["DiscountGV"].Value = null;
                    row.Cells["ProfitMarginGV"].Value = null;
                }
            }
        }

        public static void save(ComboBox ProductCategoryCB, DataGridView dataGridViewProductPricing)
        {
            int check = 0;
            if (ProductCategoryCB.SelectedIndex != -1 && ProductCategoryCB.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridViewProductPricing.Rows)
                {
                    if ((bool)row.Cells["CheckBoxGV"].FormattedValue == true)
                    {
                        check++;
                        int prodID;
                        float discount, profitMargin, buyingPrice, sellingPrice;
                        prodID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                        buyingPrice = Convert.ToSingle(row.Cells["BuyingPriceGV"].Value.ToString());
                        discount = row.Cells["DiscountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                        profitMargin = row.Cells["ProfitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString());

                        if (discount == 0 && profitMargin == 0)
                        {
                            sellingPrice = buyingPrice;
                        }
                        else
                        {
                            sellingPrice = Convert.ToSingle(row.Cells["FinalSellingPriceGV"].Value.ToString());
                        }

                        Updation.updateProductPrice(prodID, buyingPrice, sellingPrice, discount, profitMargin);
                    }
                }
                if (check > 0)
                {
                    MainClass.showMsg("Product Pricing updated successfully...", "Success", "Success");
                    check = 0;
                }
                else
                {
                    MainClass.showMsg("Please select any product first...", "Error", "Error");
                    check = 0;
                }
            }
        }
    }
}
