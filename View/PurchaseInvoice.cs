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
using System.Transactions;
using IMS.Controller;

namespace IMS
{
    public partial class PurchaseInvoice : Sample2
    {
        int co;
        int productID;
        float grossTotal;
        private string[] productData = new string[3];
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9*])?$");
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_Reset(LeftPanel);
            Selection.getList("st_getSupplierList", SupplierCB, "Supplier", "ID");
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_Reset(LeftPanel);
        }

        private void BarcodeTxt_Leave(object sender, EventArgs e)
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

           // PurchaseInvoiceController.BarcodeTxt(BarcodeTxt, productData, productID, ProductTxt, SelectQuantityTxt, PerUnitPriceTxt);
        }

        private void SelectQuantityTxt_TextChanged(object sender, EventArgs e)
        {
            PurchaseInvoiceController.SelectQuantityTxt(SelectQuantityTxt, PerUnitPriceTxt, TotalAmountTxtLabel,rg);
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceController.AddToCartBtn(productData, GrossTotalTextLabel, grossTotal, TotalAmountTxtLabel, PerUnitPriceTxt, ProductTxt, productID, SupplierCB, SuppEmpErrLabel, BarcodeTxt, BarcodeEmpErrLabel, SelectQuantityTxt, QuantityEmpErrLabel, dataGridViewPurchaseInvoice);
        }

        private void dataGridViewPurchaseInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseInvoiceController.CellClick(e, dataGridViewPurchaseInvoice, grossTotal, GrossTotalTextLabel);
        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceController.save(dataGridViewPurchaseInvoice, SupplierCB, co, GrossTotalTextLabel);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showwindow(pid, this, MDI.ActiveForm);
        }

        private void PerUnitPriceTxt_TextChanged(object sender, EventArgs e)
        {
            PurchaseInvoiceController.PerUnitPriceTxt(PerUnitPriceTxt, rg);
        }
    }
}
