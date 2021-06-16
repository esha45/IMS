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
    public partial class Categories : Sample2
    {
        int edit;
        int CategoryID;
        short status;

        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
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
            CategoriesController.save(CategoryNametxt, CategoryNameEmpErrLabel, CategoryActiveCB, IsActiveCBErrLabel, status, edit, dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV, LeftPanel, CategoryID);
        }

        public override void Deletebtn_Click(object sender, EventArgs e)
        {
            CategoriesController.delete(edit, CategoryID, dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            CategoriesController.searchText(Searchtxt, dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
        }

        public void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriesController.cellClick(e, edit, dataGridViewCategories, CategoryID, CategoryNametxt, CategoryActiveCB, LeftPanel);
        }

    }
}
