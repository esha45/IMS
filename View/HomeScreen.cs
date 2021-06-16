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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void poductsbtn_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showwindow(p, this, MDI.ActiveForm);
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            MainClass.showwindow(sp, this, MDI.ActiveForm);
        }

        private void PurchaseInvoicebtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.showwindow(pi, this, MDI.ActiveForm);
        }

        private void Salesbtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showwindow(s, this, MDI.ActiveForm);
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            MainClass.showwindow(obj, this, MDI.ActiveForm);
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showwindow(c, this, MDI.ActiveForm);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            MainClass.showwindow(lg, this, MDI.ActiveForm);
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            Stocks st = new Stocks();
            MainClass.showwindow(st, this, MDI.ActiveForm);
        }

        private void ProductPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing pp = new ProductPricing();
            MainClass.showwindow(pp, this, MDI.ActiveForm);
        }

        private void SalesReturnBtn_Click(object sender, EventArgs e)
        {
            SalesReturn sr = new SalesReturn();
            MainClass.showwindow(sr, this, MDI.ActiveForm);
        }
    }
}
