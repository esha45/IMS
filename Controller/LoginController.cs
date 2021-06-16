using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class LoginController
    {
        public static void login(TextBox UserNametxt,TextBox Passwordtxt, Label userNameEmpErrLabel, Label passwordEmpErrLabel)
        {
            if (UserNametxt.Text == "") { userNameEmpErrLabel.Visible = true; } else { userNameEmpErrLabel.Visible = false; }
            if (Passwordtxt.Text == "") { passwordEmpErrLabel.Visible = true; } else { passwordEmpErrLabel.Visible = false; }

            if (userNameEmpErrLabel.Visible || passwordEmpErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                if (Selection.getLoginDetails(UserNametxt.Text, Passwordtxt.Text))
                {
                    HomeScreen obj = new HomeScreen();
                    Login obj1 = new Login();
                    MainClass.showwindow(obj, obj1, MDI.ActiveForm);
                }
            }
        }
    }
}
