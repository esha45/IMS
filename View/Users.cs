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
    public partial class Users : Sample2
    {
        int edit;
        int userID;
        short status;

        public Users()
        {
            InitializeComponent();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
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
            UsersController.SavebtnClick(userID, LeftPanel, dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV, edit, status, StatusEmpErrLabel, EmailEmpErrLabel, PhoneEmpErrLabel, PassEmpErrLabel, UsrNameEmpErrLabel, NameEmpErrLabel, StatusComboBox, Nametxt, UserNametxt, Passwordtxt, PhoneNotxt, Emailtxt);
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {
            UsersController.DeletebtnClick(edit, userID, dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            UsersController.SearchtxtTextChanged(Searchtxt, dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Selection.showUsers(dataGridViewUsers, UserIDGGV, NameGV, UserNameGV, PasswordGV, EmailGV, PhoneNoGV, StatusGV);
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UsersController.dataGridViewUsersCellClick(StatusComboBox, Emailtxt, PhoneNotxt, Passwordtxt, UserNametxt, Nametxt, userID, e, edit, dataGridViewUsers, LeftPanel);
        }
    }
}
