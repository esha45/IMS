using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Controller
{
    class CategoriesController
    {
        public static void save(TextBox CategoryNametxt, Label CategoryNameEmpErrLabel, ComboBox CategoryActiveCB, Label IsActiveCBErrLabel, short status, int edit, DataGridView dataGridViewCategories, DataGridViewColumn CategoryIDGV, DataGridViewColumn CategoryNameGV, DataGridViewColumn StatusGV, Panel LeftPanel, int CategoryID)

        {
            if (CategoryNametxt.Text == "") { CategoryNameEmpErrLabel.Visible = true; } else { CategoryNameEmpErrLabel.Visible = false; }
            if (CategoryActiveCB.SelectedIndex == -1) { IsActiveCBErrLabel.Visible = true; } else { IsActiveCBErrLabel.Visible = false; }

            if (CategoryNameEmpErrLabel.Visible || IsActiveCBErrLabel.Visible)
            {
                MainClass.showMsg("Fields with * are Mandatory", "Stop", "Error");
            }
            else
            {
                if (CategoryActiveCB.SelectedIndex == 0)
                {
                    status = 1;
                }
                else if (CategoryActiveCB.SelectedIndex == 1)
                {
                    status = 0;
                }

                if (edit == 0)
                {
                    Insertion.insertCategory(CategoryNametxt.Text, status);
                    Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
                    MainClass.disable_Reset(LeftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Updation.updateCategory(CategoryID, CategoryNametxt.Text, status);
                        Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
                        MainClass.disable_Reset(LeftPanel);
                    }
                }
            }

        }

        public static void delete(int edit, int CategoryID, DataGridView dataGridViewCategories, DataGridViewColumn CategoryIDGV, DataGridViewColumn CategoryNameGV, DataGridViewColumn StatusGV)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Deletion.delete(CategoryID, "st_deleteCategory", "@id");
                    Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
                }
            }
        }

        public static void searchText(TextBox Searchtxt, DataGridView dataGridViewCategories, DataGridViewColumn CategoryIDGV, DataGridViewColumn CategoryNameGV, DataGridViewColumn StatusGV)
        {
            if (Searchtxt.Text != "")
            {
                Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV, Searchtxt.Text);
            }
            else
            {
                Selection.showCategories(dataGridViewCategories, CategoryIDGV, CategoryNameGV, StatusGV);
            }
        }

        public static void cellClick(DataGridViewCellEventArgs e,int edit, DataGridView dataGridViewCategories, int CategoryID, TextBox CategoryNametxt, ComboBox CategoryActiveCB, Panel LeftPanel)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridViewCategories.Rows[e.RowIndex];
                CategoryID = Convert.ToInt32(row.Cells["CategoryIDGV"].Value.ToString());
                CategoryNametxt.Text = row.Cells["CategoryNameGV"].Value.ToString();
                CategoryActiveCB.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
