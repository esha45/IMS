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
    public partial class Supplier : Sample2
    {

        int edit;
        int supplierID;
        short status;

        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_Reset(LeftPanel);
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_Reset(LeftPanel);
            edit = 0;
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);
        }

        public override void Savebtn_Click(object sender, EventArgs e)
        {
            SupplierController.SavebtnClick(supplierID, LeftPanel, dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV, NTNText, Phone2Txt, edit, status, StatusCMEmpErrLabel, AddressEmpErrLabel, Phone1EmpErrLabel, ContactPersonEmpErrLabel, SupplierNameErrLabel, SupplierNameTxt, ContactPersonTxt, Phone1Txt, AddressTxt, StatusCB);
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {
            SupplierController.DeletebtnClick(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV, edit, supplierID);
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            SupplierController.SearchtxtTextChanged(Searchtxt, dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
        }

        private void dataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierController.dataGridViewSupplierCellClick(LeftPanel, StatusCB, NTNText, AddressTxt, Phone2Txt, Phone1Txt, ContactPersonTxt, SupplierNameTxt, supplierID, dataGridViewSupplier, e, edit);
        }
    }


}
