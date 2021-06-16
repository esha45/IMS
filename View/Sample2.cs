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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void Backbtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showwindow(obj, this, MDI.ActiveForm);
        }

        public virtual void Addbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void Editbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void Savebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
