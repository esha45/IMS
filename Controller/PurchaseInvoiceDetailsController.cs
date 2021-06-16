using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS.Controller
{
    class PurchaseInvoiceDetailsController
    {
        public static void SelectedIndexChanged(ComboBox PurchaseInvoiceCB, DataGridView dataGridViewPurchaseInvoiceDetails,DataGridViewColumn mPIDgv, DataGridViewColumn prodIDGV, DataGridViewColumn prodNameGV, DataGridViewColumn QuantityGV, DataGridViewColumn PerUnitPriceGV, DataGridViewColumn TotalAmountGV,Label GrossTotalTextLabel)
        {
            if (PurchaseInvoiceCB.SelectedIndex != -1 && PurchaseInvoiceCB.SelectedIndex != 0)
            {
                float gt = 0;
                Selection.showPurchaseInvoiceDetails(Convert.ToInt64(PurchaseInvoiceCB.SelectedValue.ToString()), dataGridViewPurchaseInvoiceDetails, mPIDgv, prodIDGV, prodNameGV, QuantityGV, PerUnitPriceGV, TotalAmountGV);
                foreach (DataGridViewRow row in dataGridViewPurchaseInvoiceDetails.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                GrossTotalTextLabel.Text = gt.ToString();
                gt = 0;
            }
        }

        public static void CellClick(DataGridViewCellEventArgs e,DataGridView dataGridViewPurchaseInvoiceDetails,ComboBox PurchaseInvoiceCB, Label GrossTotalTextLabel)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dataGridViewPurchaseInvoiceDetails.Rows[e.RowIndex];
                DialogResult dr = MessageBox.Show("Are you sure, you want to Delete?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int q;
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        Insertion.insertDeletedItem(Convert.ToInt64(PurchaseInvoiceCB.SelectedValue.ToString()), Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), Selection.userID, DateTime.Today);
                        object ob = Selection.getProductQuantity(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            Updation.updateStock(Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString()), q);
                            float tot = Convert.ToSingle(GrossTotalTextLabel.Text) - Convert.ToSingle(row.Cells["TotalAmountGV"].Value.ToString());
                            GrossTotalTextLabel.Text = tot.ToString();
                            Deletion.delete(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                            dataGridViewPurchaseInvoiceDetails.Rows.Remove(row);
                        }
                        sc.Complete();
                    }

                }
            }
        }
    }
}
