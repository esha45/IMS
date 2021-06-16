using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class UsersController
    {
        public static void SavebtnClick(int userID, Panel LeftPanel, DataGridView dataGridViewUsers, DataGridViewColumn UserIDGGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PasswordGV, DataGridViewColumn EmailGV, DataGridViewColumn PhoneNoGV,DataGridViewColumn StatusGV , int edit, short status, Label StatusEmpErrLabel, Label EmailEmpErrLabel, Label PhoneEmpErrLabel, Label PassEmpErrLabel, Label UsrNameEmpErrLabel, Label NameEmpErrLabel, ComboBox StatusComboBox, TextBox Nametxt, TextBox UserNametxt, TextBox Passwordtxt, TextBox PhoneNotxt, TextBox Emailtxt)
        {
            if (Nametxt.Text == "") { NameEmpErrLabel.Visible = true; } else { NameEmpErrLabel.Visible = false; }
            if (UserNametxt.Text == "") { UsrNameEmpErrLabel.Visible = true; } else { UsrNameEmpErrLabel.Visible = false; }
            if (Passwordtxt.Text == "") { PassEmpErrLabel.Visible = true; } else { PassEmpErrLabel.Visible = false; }
            if (PhoneNotxt.Text == "") { PhoneEmpErrLabel.Visible = true; } else { PhoneEmpErrLabel.Visible = false; }
            if (Emailtxt.Text == "") { EmailEmpErrLabel.Visible = true; } else { EmailEmpErrLabel.Visible = false; }
            if (StatusComboBox.SelectedIndex == -1) { StatusEmpErrLabel.Visible = true; } else { StatusEmpErrLabel.Visible = false; }

            if (NameEmpErrLabel.Visible || UsrNameEmpErrLabel.Visible || PassEmpErrLabel.Visible || PhoneEmpErrLabel.Visible || EmailEmpErrLabel.Visible || StatusEmpErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                if (StatusComboBox.SelectedIndex == 0)
                {
                    status = 1;
                }
                else if (StatusComboBox.SelectedIndex == 1)
                {
                    status = 0;
                }

                if (edit == 0)
                {
                    Insertion.insertUser(Nametxt.Text, UserNametxt.Text, Passwordtxt.Text, Emailtxt.Text, PhoneNotxt.Text, status);
                    Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
                    MainClass.disable_Reset(LeftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation.updateUser(userID, Nametxt.Text, UserNametxt.Text, Passwordtxt.Text, Emailtxt.Text, PhoneNotxt.Text, status);
                        Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
                        MainClass.disable_Reset(LeftPanel);
                    }
                }
            }
        }

        public static void DeletebtnClick(int edit,int userID, DataGridView dataGridViewUsers, DataGridViewColumn UserIDGGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PasswordGV, DataGridViewColumn EmailGV, DataGridViewColumn PhoneNoGV, DataGridViewColumn StatusGV)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Deletion.delete(userID, "st_deleteUsers", "@id");
                    Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
                }
            }
        }

        public static void SearchtxtTextChanged(TextBox Searchtxt, DataGridView dataGridViewUsers, DataGridViewColumn UserIDGGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PasswordGV, DataGridViewColumn EmailGV, DataGridViewColumn PhoneNoGV, DataGridViewColumn StatusGV)
        {
            if (Searchtxt.Text != "")
            {
                Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV, Searchtxt.Text);
            }
            else
            {
                Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
            }
        }

        public static void dataGridViewUsersCellClick(ComboBox StatusComboBox, TextBox Emailtxt, TextBox PhoneNotxt, TextBox Passwordtxt, TextBox UserNametxt, TextBox Nametxt, int userID, DataGridViewCellEventArgs e,int edit,DataGridView dataGridViewUsers,Panel LeftPanel)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["UserIDGGV"].Value.ToString());
                Nametxt.Text = row.Cells["NameGV"].Value.ToString();
                UserNametxt.Text = row.Cells["UserNameGV"].Value.ToString();
                Passwordtxt.Text = row.Cells["PasswordGV"].Value.ToString();
                PhoneNotxt.Text = row.Cells["PhoneNoGV"].Value.ToString();
                Emailtxt.Text = row.Cells["EmailGV"].Value.ToString();
                StatusComboBox.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
