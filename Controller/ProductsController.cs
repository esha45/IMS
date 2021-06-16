using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class ProductsController
    {
        public static void save(TextBox ProductNametxt, TextBox Barcodetxt, Label ProductNameEmpErrLabel, Label BarcodeEmpErrLabel, DateTimePicker ExpiryDatePicker, Label ExpiryValidErrLabel, ComboBox ProductCategoryCB, Label ProductCategoryEmpErrLabel, DataGridView dataGridViewProducts, int edit, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn expDateGV, DataGridViewColumn prodBarcodeGV, DataGridViewColumn catNameGV, DataGridViewColumn catIDGV, Panel LeftPanel, int productID)
        {
            if (ProductNametxt.Text == "") { ProductNameEmpErrLabel.Visible = true; } else { ProductNameEmpErrLabel.Visible = false; }
            if (Barcodetxt.Text == "") { BarcodeEmpErrLabel.Visible = true; } else { BarcodeEmpErrLabel.Visible = false; }
            if (ExpiryDatePicker.Value.Date < DateTime.Now.Date) { ExpiryValidErrLabel.Visible = true; } else { ExpiryValidErrLabel.Visible = false; }
            if (ProductCategoryCB.SelectedIndex == -1 || ProductCategoryCB.SelectedIndex == 0) { ProductCategoryEmpErrLabel.Visible = true; } else { ProductCategoryEmpErrLabel.Visible = false; }

            if (ProductNameEmpErrLabel.Visible || BarcodeEmpErrLabel.Visible || ExpiryValidErrLabel.Visible || ProductCategoryEmpErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    if (ExpiryDatePicker.Value.Date == DateTime.Now.Date)
                    {
                        Insertion.insertProduct(ProductNametxt.Text, Barcodetxt.Text, Convert.ToInt32(ProductCategoryCB.SelectedValue));
                    }
                    else
                    {
                        Insertion.insertProduct(ProductNametxt.Text, Barcodetxt.Text, Convert.ToInt32(ProductCategoryCB.SelectedValue), ExpiryDatePicker.Value);
                    }

                    Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV);
                    MainClass.disable_Reset(LeftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (ExpiryDatePicker.Value.Date == DateTime.Now.Date)
                        {
                            Updation.updateProduct(productID, ProductNametxt.Text, Barcodetxt.Text, Convert.ToInt32(ProductCategoryCB.SelectedValue));
                        }
                        else
                        {
                            Updation.updateProduct(productID, ProductNametxt.Text, Barcodetxt.Text, Convert.ToInt32(ProductCategoryCB.SelectedValue), ExpiryDatePicker.Value);
                        }

                        Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV);
                        MainClass.disable_Reset(LeftPanel);
                    }
                }
            }
        }

        public static void delete(int edit, int productID, DataGridView dataGridViewProducts, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn expDateGV, DataGridViewColumn prodBarcodeGV, DataGridViewColumn catNameGV, DataGridViewColumn catIDGV)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Deletion.delete(productID, "st_productDelete", "@prodID");
                    Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV);
                }
            }
        }

        public static void CellClick(DataGridViewCellEventArgs e,int edit,int productID, DataGridView dataGridViewProducts,TextBox ProductNametxt,DateTimePicker ExpiryDatePicker, TextBox Barcodetxt,ComboBox ProductCategoryCB, Panel LeftPanel)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                ProductNametxt.Text = row.Cells["prodNameGV"].Value.ToString();
                if (row.Cells["expDateGV"].FormattedValue.ToString() == "")
                {
                    ExpiryDatePicker.Value = DateTime.Now;
                }
                else
                {
                    ExpiryDatePicker.Value = Convert.ToDateTime(row.Cells["expDateGV"].Value.ToString());
                }
                Barcodetxt.Text = row.Cells["prodBarcodeGV"].Value.ToString();
                ProductCategoryCB.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
