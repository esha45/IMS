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
    public partial class ViewSalesReceipts : Sample
    {
        public static int salesID;
        public ViewSalesReceipts()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Selection.showDailySales(DatePicker.Value, dataGridViewReceipts, SalesIDGV, UserGV, TotalAmountGV, TotalDiscountGV, AmountGivenGV, ReturnedAmountGV,UserIDGV);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showwindow(s, this, MDI.ActiveForm);
        }

 /*       private void dataGridViewReceipts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridViewReceipts.Rows[e.RowIndex];
                salesID = Convert.ToInt32(row.Cells["SalesIDGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }
 */
    }
}
