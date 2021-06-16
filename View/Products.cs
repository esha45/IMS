using IMS.Controller;
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
    public partial class Products : Sample2
    {
        int edit;
        int productID;
        // short status;

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_Reset(LeftPanel);
            Selection.getList("st_getCategoryList", ProductCategoryCB, "Category", "ID");
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_Reset(LeftPanel);
            
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);
        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            ProductsController.save(ProductNametxt, Barcodetxt, ProductNameEmpErrLabel, BarcodeEmpErrLabel, ExpiryDatePicker, ExpiryValidErrLabel, ProductCategoryCB, ProductCategoryEmpErrLabel, dataGridViewProducts, edit, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV, LeftPanel, productID);
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {
            ProductsController.delete(edit, productID, dataGridViewProducts, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV);
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchtxt.Text != "")
            {
                Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV,prodBarcodeGV, catNameGV, catIDGV, Searchtxt.Text);
            }
            else
            {
                Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV,prodBarcodeGV, catNameGV, catIDGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Selection.showProducts(dataGridViewProducts, prodIDGV, prodNameGV, expDateGV, prodBarcodeGV, catNameGV, catIDGV);
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsController.CellClick(e, edit, productID, dataGridViewProducts, ProductNametxt, ExpiryDatePicker, Barcodetxt, ProductCategoryCB, LeftPanel);
        }

        private void ProductNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
