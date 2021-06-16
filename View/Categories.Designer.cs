namespace IMS
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryNametxt = new System.Windows.Forms.TextBox();
            this.CategoryActiveCB = new System.Windows.Forms.ComboBox();
            this.CategoryActiveCBLabel = new System.Windows.Forms.Label();
            this.CategoryNameEmpErrLabel = new System.Windows.Forms.Label();
            this.IsActiveCBErrLabel = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.CategoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CategoryActiveCBLabel);
            this.LeftPanel.Controls.Add(this.CategoryActiveCB);
            this.LeftPanel.Controls.Add(this.CategoryNametxt);
            this.LeftPanel.Controls.Add(this.CategoryNameLabel);
            this.LeftPanel.Controls.Add(this.CategoryNameEmpErrLabel);
            this.LeftPanel.Controls.Add(this.IsActiveCBErrLabel);
            this.LeftPanel.Controls.SetChildIndex(this.IsActiveCBErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryNameEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryNameLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryNametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryActiveCB, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryActiveCBLabel, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewCategories);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewCategories, 0);
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CategoryNameLabel.Location = new System.Drawing.Point(9, 81);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(93, 13);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "Category Name";
            // 
            // CategoryNametxt
            // 
            this.CategoryNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNametxt.Location = new System.Drawing.Point(10, 97);
            this.CategoryNametxt.Name = "CategoryNametxt";
            this.CategoryNametxt.Size = new System.Drawing.Size(182, 22);
            this.CategoryNametxt.TabIndex = 2;
            // 
            // CategoryActiveCB
            // 
            this.CategoryActiveCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryActiveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryActiveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryActiveCB.FormattingEnabled = true;
            this.CategoryActiveCB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CategoryActiveCB.Location = new System.Drawing.Point(10, 155);
            this.CategoryActiveCB.Name = "CategoryActiveCB";
            this.CategoryActiveCB.Size = new System.Drawing.Size(182, 24);
            this.CategoryActiveCB.TabIndex = 3;
            // 
            // CategoryActiveCBLabel
            // 
            this.CategoryActiveCBLabel.AutoSize = true;
            this.CategoryActiveCBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryActiveCBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CategoryActiveCBLabel.Location = new System.Drawing.Point(9, 139);
            this.CategoryActiveCBLabel.Name = "CategoryActiveCBLabel";
            this.CategoryActiveCBLabel.Size = new System.Drawing.Size(57, 13);
            this.CategoryActiveCBLabel.TabIndex = 4;
            this.CategoryActiveCBLabel.Text = "Is-Active";
            // 
            // CategoryNameEmpErrLabel
            // 
            this.CategoryNameEmpErrLabel.AutoSize = true;
            this.CategoryNameEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.CategoryNameEmpErrLabel.Location = new System.Drawing.Point(85, 84);
            this.CategoryNameEmpErrLabel.Name = "CategoryNameEmpErrLabel";
            this.CategoryNameEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.CategoryNameEmpErrLabel.TabIndex = 15;
            this.CategoryNameEmpErrLabel.Text = "*";
            this.CategoryNameEmpErrLabel.Visible = false;
            // 
            // IsActiveCBErrLabel
            // 
            this.IsActiveCBErrLabel.AutoSize = true;
            this.IsActiveCBErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveCBErrLabel.ForeColor = System.Drawing.Color.Red;
            this.IsActiveCBErrLabel.Location = new System.Drawing.Point(55, 142);
            this.IsActiveCBErrLabel.Name = "IsActiveCBErrLabel";
            this.IsActiveCBErrLabel.Size = new System.Drawing.Size(15, 18);
            this.IsActiveCBErrLabel.TabIndex = 16;
            this.IsActiveCBErrLabel.Text = "*";
            this.IsActiveCBErrLabel.Visible = false;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryIDGV,
            this.CategoryNameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersVisible = false;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(600, 370);
            this.dataGridViewCategories.TabIndex = 3;
            this.dataGridViewCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellClick);
            // 
            // CategoryIDGV
            // 
            this.CategoryIDGV.HeaderText = "Category ID";
            this.CategoryIDGV.Name = "CategoryIDGV";
            this.CategoryIDGV.ReadOnly = true;
            this.CategoryIDGV.Visible = false;
            // 
            // CategoryNameGV
            // 
            this.CategoryNameGV.HeaderText = "Category Name";
            this.CategoryNameGV.Name = "CategoryNameGV";
            this.CategoryNameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.ComboBox CategoryActiveCB;
        private System.Windows.Forms.TextBox CategoryNametxt;
        private System.Windows.Forms.Label CategoryActiveCBLabel;
        private System.Windows.Forms.Label CategoryNameEmpErrLabel;
        private System.Windows.Forms.Label IsActiveCBErrLabel;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}