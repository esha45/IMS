using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent(); 
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(File.Exists(path+"\\connect"))
            {
                Login log = new Login();
                MainClass.showwindow(log, this);
            }
            else
            {
                //Setting obj = new Setting();
                //MainClass.showwindow(obj, this);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Setting obj = new Setting();
            //MainClass.showwindow(obj, this);
        }
    }
}
