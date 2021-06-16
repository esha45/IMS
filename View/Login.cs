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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginController.login(UserNametxt, Passwordtxt, userNameEmpErrLabel, passwordEmpErrLabel);
        }
    }
}
