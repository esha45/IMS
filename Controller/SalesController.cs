using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class SalesController
    {
        public static void BarcodeTxt(Label GrossTotalTextLabel, float grossTotal, bool productCheck, DataGridView dataGridViewSales, string[] prodARR, TextBox BarcodeTxt,TextBox GrossTotalTxt,TextBox TotalDiscountTxt, TextBox AmountGivenTxt, TextBox ChangetoGiveTxt)
        {
            if (BarcodeTxt.Text != "")
            {
                GrossTotalTxt.Text = "";
                TotalDiscountTxt.Text = "";
                AmountGivenTxt.Text = "";
                ChangetoGiveTxt.Text = "";
                int quantityCount = 0, stockQuantity = 0, nCount = 0;
                prodARR = Selection.getProductByBarcode(BarcodeTxt.Text);
                foreach (DataGridViewRow row in dataGridViewSales.Rows)
                {
                    if (prodARR[0] == row.Cells["prodIDGV"].Value.ToString())
                    {
                        quantityCount = quantityCount + Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    }
                }
                stockQuantity = Convert.ToInt32(Selection.getProductQuantity(Convert.ToInt32(prodARR[0])));
                nCount = stockQuantity - quantityCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridViewSales.RowCount == 0)
                    {
                        dataGridViewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridViewSales.Rows)
                        {
                            if (row.Cells["prodIDGV"].Value.ToString() == prodARR[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                                //dataGridViewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                            }
                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridViewSales.Rows)
                            {
                                if (row.Cells["prodIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float discount = 0;
                                    row.Cells["QuantityGV"].Value = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["DiscountGV"].Value.ToString() != null)
                                    {
                                        discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) + Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                                        row.Cells["DiscountGV"].Value = discount;
                                    }

                                    float total = (Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString())) - Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                                    row.Cells["TotalAmountGV"].Value = total;
                                }
                            }
                        }
                        else
                        {
                            dataGridViewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                        }
                    }

                    foreach (DataGridViewRow item in dataGridViewSales.Rows)
                    {
                        grossTotal += Convert.ToSingle(item.Cells["TotalAmountGV"].Value.ToString());
                    }
                    GrossTotalTextLabel.Text = Math.Round(grossTotal, 0).ToString();
                    grossTotal = 0;
                    BarcodeTxt.Focus();
                    BarcodeTxt.Text = "";
                }
            }
        }

        public static void CellClick(float grossTotal, string[] prodARR, Label GrossTotalTextLabel, DataGridView dataGridViewSales, DataGridViewCellEventArgs e,TextBox GrossTotalTxt,TextBox TotalDiscountTxt, TextBox AmountGivenTxt, TextBox ChangetoGiveTxt)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    GrossTotalTxt.Text = "";
                    TotalDiscountTxt.Text = "";
                    AmountGivenTxt.Text = "";
                    ChangetoGiveTxt.Text = "";
                    float gross, total, discount;
                    DataGridViewRow row = dataGridViewSales.Rows[e.RowIndex];
                    int quantity = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    if (quantity == 1)
                    {
                        gross = Convert.ToSingle(GrossTotalTextLabel.Text);
                        gross = gross - Convert.ToSingle(row.Cells["TotalAmountGV"].Value.ToString());
                        GrossTotalTextLabel.Text = gross.ToString();
                        dataGridViewSales.Rows.Remove(row);
                    }
                    else if (quantity > 1)
                    {
                        quantity--;
                        row.Cells["QuantityGV"].Value = quantity;
                        discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        row.Cells["DiscountGV"].Value = discount;
                        total = Convert.ToSingle(row.Cells["QuantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()) - discount;
                        row.Cells["TotalAmountGV"].Value = total;

                        foreach (DataGridViewRow item in dataGridViewSales.Rows)
                        {
                            grossTotal += Convert.ToSingle(item.Cells["TotalAmountGV"].Value.ToString());
                        }
                        GrossTotalTextLabel.Text = grossTotal.ToString();
                        grossTotal = 0;
                    }
                }
            }
        }

        public static void CheckoutBtn(DataGridView dataGridViewSales,TextBox GrossTotalTxt,TextBox TotalDiscountTxt)
        {
            if (dataGridViewSales.Rows.Count > 0)
            {
                double discount = 0, grossTotal1 = 0;
                foreach (DataGridViewRow row in dataGridViewSales.Rows)
                {
                    discount += Math.Round(Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()), 0);
                    grossTotal1 += Convert.ToSingle(row.Cells["TotalAmountGV"].Value.ToString());
                }
                GrossTotalTxt.Text = Math.Round(grossTotal1, 0).ToString();
                TotalDiscountTxt.Text = discount.ToString();
            }
        }

        public static void AmountGivenTxt(TextBox AmountGivenTxt, Regex rg,TextBox GrossTotalTxt, TextBox ChangetoGiveTxt)
        {
            if (AmountGivenTxt.Text != "")
            {
                if (!rg.Match(AmountGivenTxt.Text).Success)
                {
                    AmountGivenTxt.Text = "";
                    AmountGivenTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(AmountGivenTxt.Text);
                    float amountToReturn = amountGiven - Convert.ToSingle(GrossTotalTxt.Text);
                    ChangetoGiveTxt.Text = Math.Round(amountToReturn, 0).ToString();
                }
            }
        }

        public static void AmountGivenTxtValidating(TextBox AmountGivenTxt,TextBox GrossTotalTxt, TextBox ChangetoGiveTxt)
        {
            if (AmountGivenTxt.Text != "" && GrossTotalTxt.Text != "")
            {
                if (!(Convert.ToSingle(GrossTotalTxt.Text) <= Convert.ToSingle(AmountGivenTxt.Text)))
                {
                    AmountGivenTxt.Text = "";
                    ChangetoGiveTxt.Text = "";
                    AmountGivenTxt.Focus();
                }
            }
        }

        public static void PayBtnClick(Label GrossTotalTextLabel, GroupBox PaymentsGroupBox, DataGridView dataGridViewSales, TextBox GrossTotalTxt,TextBox TotalDiscountTxt, ComboBox PaymentTypeCB,TextBox AmountGivenTxt, TextBox ChangetoGiveTxt)
        {
            if (GrossTotalTxt.Text != "" && TotalDiscountTxt.Text != "" && PaymentTypeCB.SelectedIndex != -1 && AmountGivenTxt.Text != "" && ChangetoGiveTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Insertion.insertSales(dataGridViewSales, "prodIDGV", "QuantityGV", Selection.userID, DateTime.Now, Convert.ToSingle(GrossTotalTxt.Text), Convert.ToSingle(TotalDiscountTxt.Text), Convert.ToSingle(AmountGivenTxt.Text), Convert.ToSingle(ChangetoGiveTxt.Text), PaymentTypeCB.SelectedItem.ToString(), "PerUnitPriceGV", "DiscountGV");
                    MainClass.enable_Reset(PaymentsGroupBox);
                    dataGridViewSales.Rows.Clear();
                    GrossTotalTextLabel.Text = "0.00";
   //                 SalesReport sr = new SalesReport();
    //                sr.Show();
                }
            }
        }
    }
}
