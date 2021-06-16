using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS.Controller
{
    class SalesReturnController
    {
        public static void LoadBtnClick(TextBox PaymentTypeTxt, TextBox UserTxt, DateTimePicker DatePicker, TextBox SalesIDTxt,Regex rg, string salesID,DataGridView dataGridViewSalesReturn,DataGridViewColumn SalesIDGV, DataGridViewColumn ProdIDGV, DataGridViewColumn BarcodeGV, DataGridViewColumn ProductNameGV, DataGridViewColumn QuantityGV, DataGridViewColumn TotalDiscountGV, DataGridViewColumn TotalAmountGV, DataGridViewColumn AmountGivenGV, DataGridViewColumn ReturnedAmountGV, DataGridViewColumn DateGV, DataGridViewColumn ProductPriceGV, DataGridViewColumn PerProductDiscountGV, DataGridViewColumn PerProductTotalGV, DataGridViewColumn UserNameGV, DataGridViewColumn PaymentTypeGV )
        {
            if (SalesIDTxt.Text != "")
            {
                if (rg.Match(SalesIDTxt.Text).Success)
                {
                    salesID = SalesIDTxt.Text;
                    Selection.showSalesReturn(Convert.ToInt32(SalesIDTxt.Text), dataGridViewSalesReturn, SalesIDGV, ProdIDGV, BarcodeGV, ProductNameGV, QuantityGV, TotalDiscountGV, TotalAmountGV, AmountGivenGV, ReturnedAmountGV, DateGV, ProductPriceGV, PerProductDiscountGV, PerProductTotalGV, UserNameGV, PaymentTypeGV);

                    if (dataGridViewSalesReturn.RowCount > 0)
                    {
                        //DatePicker.Value = Convert.ToDateTime(dataGridViewSalesReturn.Rows[0].Cells["DateGV"].Value);
                        UserTxt.Text = dataGridViewSalesReturn.Rows[0].Cells["UserNameGV"].Value.ToString();
                        PaymentTypeTxt.Text = dataGridViewSalesReturn.Rows[0].Cells["PaymentTypeGV"].Value.ToString();
                    }
                }
                else
                {
                    SalesIDTxt.Text = "";
                    SalesIDTxt.Focus();
                    DatePicker.Value = DateTime.Now;
                    UserTxt.Text = "";
                    PaymentTypeTxt.Text = "";
                }
            }
            else
            {
                DatePicker.Value = DateTime.Now;
                UserTxt.Text = "";
                PaymentTypeTxt.Text = "";
            }
        }

        public static void SavebtnClick(TextBox RefundTxt,TextBox SalesIDTxt, Hashtable ht,float amountRefund)
        {
            if (RefundTxt.Text != null && ht.Count > 0 && SalesIDTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += Insertion.insertRefund(Convert.ToInt32(SalesIDTxt.Text), DateTime.Now, Selection.userID, Convert.ToInt32(de.Key), Convert.ToInt16(de.Value), Convert.ToSingle(amountRefund));
                            int currentQuantity = (int)Selection.getProductQuantity(Convert.ToInt32(de.Key));
                            int finalQuantity = currentQuantity + Convert.ToInt16(de.Value);
                            Updation.updateStock(Convert.ToInt32(de.Key), finalQuantity);
                        }
                        if (x > 0)
                        {
                            DialogResult drr = MainClass.showMsg("Return & Refund Successfull", "Success", "Success");
                            if (drr == DialogResult.OK)
                            {
                               // SalesRefundReport sr = new SalesRefundReport();
                               // sr.ShowDialog();
                            }
                            x = 0;
                            ht.Clear();
                        }
                        sc.Complete();
                    }
                }
            }
            else
            {
                MainClass.showMsg("Please Provide Complete Details", "Error", "Error");
            }
        }

        public static void BarcodeTxtValidating(Hashtable ht,TextBox BarcodeTxt, DataGridView dataGridViewSalesReturn,float amountRefund, TextBox RefundTxt)
        {
            if (BarcodeTxt.Text != "")
            {
                if (dataGridViewSalesReturn.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridViewSalesReturn.Rows)
                        {
                            if (BarcodeTxt.Text == row.Cells["BarcodeGV"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are you Sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    int productID = Convert.ToInt32(row.Cells["ProdIDGV"].Value.ToString());
                                    float productPrice = Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString());
                                    int productQuantity = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()) - 1;
                                    amountRefund += productPrice;
                                    RefundTxt.Text = Math.Round(amountRefund, 0).ToString();

                                    if (productQuantity == 0)
                                    {
                                        if (ht.ContainsKey(row.Cells["ProdIDGV"].Value))
                                        {
                                            int prodIDht = Convert.ToInt32(row.Cells["ProdIDGV"].Value.ToString());
                                            ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) - 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["ProdIDGV"].Value, 1);
                                        }
                                        dataGridViewSalesReturn.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["QuantityGV"].Value = productQuantity;
                                        row.Cells["PerProductTotalGV"].Value = (Convert.ToSingle(row.Cells["ProductPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));

                                        if (ht.ContainsKey(row.Cells["ProdIDGV"].Value))
                                        {
                                            int prodIDht = Convert.ToInt32(row.Cells["ProdIDGV"].Value.ToString());
                                            ht[prodIDht] = Convert.ToInt32(ht[prodIDht]) + 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["ProdIDGV"].Value, 1);
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        sc.Complete();
                    }
                }
            }
        }
    }
}
