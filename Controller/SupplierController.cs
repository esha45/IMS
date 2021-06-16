using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class SupplierController
    {
        public static void SavebtnClick(int supplierID, Panel LeftPanel, DataGridView dataGridViewSupplier,DataGridViewColumn suppIDGV, DataGridViewColumn suppNameGV, DataGridViewColumn contactPersonGV, DataGridViewColumn phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn ntnGV, DataGridViewColumn addressGV, DataGridViewColumn StatusGV , TextBox NTNText, TextBox Phone2Txt, int edit, short status, Label StatusCMEmpErrLabel, Label AddressEmpErrLabel, Label Phone1EmpErrLabel, Label ContactPersonEmpErrLabel, Label SupplierNameErrLabel, TextBox SupplierNameTxt,TextBox ContactPersonTxt,TextBox Phone1Txt,TextBox AddressTxt,ComboBox StatusCB)
        {
            if (SupplierNameTxt.Text == "") { SupplierNameErrLabel.Visible = true; } else { SupplierNameErrLabel.Visible = false; }
            if (ContactPersonTxt.Text == "") { ContactPersonEmpErrLabel.Visible = true; } else { ContactPersonEmpErrLabel.Visible = false; }
            if (Phone1Txt.Text == "") { Phone1EmpErrLabel.Visible = true; } else { Phone1EmpErrLabel.Visible = false; }
            if (AddressTxt.Text == "") { AddressEmpErrLabel.Visible = true; } else { AddressEmpErrLabel.Visible = false; }
            if (StatusCB.SelectedIndex == -1) { StatusCMEmpErrLabel.Visible = true; } else { StatusCMEmpErrLabel.Visible = false; }

            if (SupplierNameErrLabel.Visible || ContactPersonEmpErrLabel.Visible || Phone1EmpErrLabel.Visible || AddressEmpErrLabel.Visible || StatusCMEmpErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                if (StatusCB.SelectedIndex == 0)
                {
                    status = 1;
                }
                else if (StatusCB.SelectedIndex == 1)
                {
                    status = 0;
                }

                if (edit == 0)
                {
                    Insertion.insertSupplier(SupplierNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, status, Phone2Txt.Text, NTNText.Text);
                    Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
                    MainClass.disable_Reset(LeftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (StatusCB.SelectedIndex == 0)
                        {
                            status = 1;
                        }
                        else if (StatusCB.SelectedIndex == 1)
                        {
                            status = 0;
                        }
                        Updation.updateSupplier(supplierID, SupplierNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, status, Phone2Txt.Text, NTNText.Text);
                        Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV); Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
                        MainClass.disable_Reset(LeftPanel);
                    }
                }
            }
        }

        public static void DeletebtnClick(DataGridView dataGridViewSupplier,DataGridViewColumn suppIDGV, DataGridViewColumn suppNameGV, DataGridViewColumn contactPersonGV, DataGridViewColumn phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn ntnGV, DataGridViewColumn addressGV, DataGridViewColumn StatusGV, int edit,int supplierID)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Deletion.delete(supplierID, "st_deleteSupplier", "@sup_id");
                    Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV); Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
                }
            }
        }

        public static void SearchtxtTextChanged(TextBox Searchtxt,DataGridView dataGridViewSupplier, DataGridViewColumn suppIDGV, DataGridViewColumn suppNameGV, DataGridViewColumn contactPersonGV, DataGridViewColumn phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn ntnGV, DataGridViewColumn addressGV, DataGridViewColumn StatusGV)
        {
            if (Searchtxt.Text != "")
            {
                Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV, Searchtxt.Text);
            }
            else
            {
                Selection.showSupplier(dataGridViewSupplier, suppIDGV, suppNameGV, contactPersonGV, phone1GV, Phone2GV, ntnGV, addressGV, StatusGV);
            }
        }

        public static void dataGridViewSupplierCellClick(Panel LeftPanel, ComboBox StatusCB, TextBox NTNText, TextBox AddressTxt, TextBox Phone2Txt, TextBox Phone1Txt, TextBox ContactPersonTxt, TextBox SupplierNameTxt, int supplierID, DataGridView dataGridViewSupplier, DataGridViewCellEventArgs e, int edit)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewSupplier.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                SupplierNameTxt.Text = row.Cells["suppNameGV"].Value.ToString();
                ContactPersonTxt.Text = row.Cells["contactPersonGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                Phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                AddressTxt.Text = row.Cells["addressGV"].Value.ToString();
                NTNText.Text = row.Cells["ntnGV"].Value.ToString();
                StatusCB.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
