using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS.Controller
{
    class PurchaseInvoiceController
    {
        public static void BarcodeTxt(TextBox BarcodeTxt, String[] productData,int productID, TextBox ProductTxt,TextBox SelectQuantityTxt,TextBox PerUnitPriceTxt)
        {
            if (BarcodeTxt.Text != "")
            {
                productData = Selection.getProductByBarcodePI(BarcodeTxt.Text);
                productID = Convert.ToInt32(productData[0]);
                ProductTxt.Text = productData[1];
                string barcode = productData[2];
                ProductTxt.Enabled = false;
                if (barcode != null)
                {
                    SelectQuantityTxt.Focus();
                }
            }
            else
            {
                productID = 0;
                ProductTxt.Text = "";
                PerUnitPriceTxt.Text = "";
                Array.Clear(productData, 0, productData.Length);
            }
        }

        public static void SelectQuantityTxt(TextBox SelectQuantityTxt, TextBox PerUnitPriceTxt, Label TotalAmountTxtLabel,Regex rg)
        {
            if (SelectQuantityTxt.Text != "")
            {
                if (rg.Match(SelectQuantityTxt.Text).Success)
                {
                    float quantity, price, totalPrice;
                    quantity = Convert.ToSingle(SelectQuantityTxt.Text);
                    price = Convert.ToSingle(PerUnitPriceTxt.Text);
                    totalPrice = quantity * price;
                    TotalAmountTxtLabel.Text = totalPrice.ToString("###########.##");
                }
                else
                {
                    SelectQuantityTxt.SelectAll();
                }
            }
            else
            {
                TotalAmountTxtLabel.Text = "0.00";
            }
        }

        public static void AddToCartBtn(String[] productData, Label GrossTotalTextLabel, float grossTotal, Label TotalAmountTxtLabel, TextBox PerUnitPriceTxt, TextBox ProductTxt, int productID, ComboBox SupplierCB, Label SuppEmpErrLabel, TextBox BarcodeTxt, Label BarcodeEmpErrLabel, TextBox SelectQuantityTxt, Label QuantityEmpErrLabel, DataGridView dataGridViewPurchaseInvoice)
        {
            if (SupplierCB.SelectedIndex == -1 || SupplierCB.SelectedIndex == 0) { SuppEmpErrLabel.Visible = true; } else { SuppEmpErrLabel.Visible = false; }
            if (BarcodeTxt.Text == "") { BarcodeEmpErrLabel.Visible = true; } else { BarcodeEmpErrLabel.Visible = false; }
            if (SelectQuantityTxt.Text == "") { QuantityEmpErrLabel.Visible = true; } else { QuantityEmpErrLabel.Visible = false; }
            if (SuppEmpErrLabel.Visible || BarcodeEmpErrLabel.Visible || QuantityEmpErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                dataGridViewPurchaseInvoice.Rows.Add(productID, ProductTxt.Text, SelectQuantityTxt.Text, PerUnitPriceTxt.Text, TotalAmountTxtLabel.Text);
                grossTotal += Convert.ToSingle(TotalAmountTxtLabel.Text);
                GrossTotalTextLabel.Text = grossTotal.ToString();
                productID = 0;
                ProductTxt.Text = "";
                PerUnitPriceTxt.Text = "";
                BarcodeTxt.Text = "";
                TotalAmountTxtLabel.Text = "";
                SelectQuantityTxt.Text = "";
                Array.Clear(productData, 0, productData.Length);
            }
        }

        public static void CellClick(DataGridViewCellEventArgs e, DataGridView dataGridViewPurchaseInvoice, float grossTotal,Label GrossTotalTextLabel)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridViewPurchaseInvoice.Rows[e.RowIndex];
                    grossTotal -= Convert.ToSingle(row.Cells["TotalAmountGV"].Value.ToString());
                    GrossTotalTextLabel.Text = grossTotal.ToString();
                    dataGridViewPurchaseInvoice.Rows.Remove(row);
                }
            }
        }

        public static void save(DataGridView dataGridViewPurchaseInvoice,ComboBox SupplierCB,int co,Label GrossTotalTextLabel)
        {
            if (dataGridViewPurchaseInvoice.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = Insertion.insertPurchaseInvoice(DateTime.Today, Selection.userID, Convert.ToInt32(SupplierCB.SelectedValue));

                    foreach (DataGridViewRow row in dataGridViewPurchaseInvoice.Rows)
                    {
                        co += Insertion.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["TotalAmountGV"].Value.ToString()));
                        object[] arr = Selection.checkProductPriceExistance(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));


                        if (arr[3] != null)
                        {
                            float discountPercentage = Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()) * Convert.ToSingle(arr[3].ToString()) / 100;
                            float profitPercentage = Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()) * Convert.ToSingle(arr[4].ToString()) / 100;
                            float totalAmount = Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()) + profitPercentage - discountPercentage;
                            Updation.updateProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()), totalAmount, discountPercentage, profitPercentage);
                        }
                        else
                        {
                            Insertion.insertProductPrice(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PerUnitPriceGV"].Value.ToString()));
                        }

                        int q;
                        object ob = Selection.getProductQuantity(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));

                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            Updation.updateStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            Insertion.insertStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));
                        }
                    }

                    if (co > 0)
                    {
                        MainClass.showMsg("Purchase Invoice Created Successfully", "Success", "Success");
                        GrossTotalTextLabel.Text = "";
                        dataGridViewPurchaseInvoice.Rows.Clear();
                    }
                    else
                    {
                        MainClass.showMsg("Unable to Create Purchase Invoice", "Error", "Error");
                    }
                    sc.Complete();
                }
            }
        }

        public static void PerUnitPriceTxt(TextBox PerUnitPriceTxt,Regex rg)
        {
            if (PerUnitPriceTxt.Text != "")
            {
                if (!rg.Match(PerUnitPriceTxt.Text).Success)
                {
                    PerUnitPriceTxt.Text = "";
                    PerUnitPriceTxt.Focus();
                }
            }
        }
    }
}
