namespace IMS
{
    partial class ProductPricing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductCategoryCB = new System.Windows.Forms.ComboBox();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductCategoryEmpErrLabel = new System.Windows.Forms.Label();
            this.dataGridViewProductPricing = new System.Windows.Forms.DataGridView();
            this.CheckBoxGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalSellingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductPricing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(772, 40);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(120, 20);
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ProductCategoryCB);
            this.LeftPanel.Controls.Add(this.ProductCategoryLabel);
            this.LeftPanel.Controls.Add(this.ProductCategoryEmpErrLabel);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryCB, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewProductPricing);
            this.RightPanel.Size = new System.Drawing.Size(772, 450);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewProductPricing, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(772, 40);
            // 
            // ProductCategoryCB
            // 
            this.ProductCategoryCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryCB.FormattingEnabled = true;
            this.ProductCategoryCB.Location = new System.Drawing.Point(10, 91);
            this.ProductCategoryCB.Name = "ProductCategoryCB";
            this.ProductCategoryCB.Size = new System.Drawing.Size(181, 24);
            this.ProductCategoryCB.TabIndex = 15;
            this.ProductCategoryCB.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryCB_SelectedIndexChanged);
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(9, 74);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(57, 13);
            this.ProductCategoryLabel.TabIndex = 16;
            this.ProductCategoryLabel.Text = "Category";
            // 
            // ProductCategoryEmpErrLabel
            // 
            this.ProductCategoryEmpErrLabel.AutoSize = true;
            this.ProductCategoryEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.ProductCategoryEmpErrLabel.Location = new System.Drawing.Point(57, 77);
            this.ProductCategoryEmpErrLabel.Name = "ProductCategoryEmpErrLabel";
            this.ProductCategoryEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.ProductCategoryEmpErrLabel.TabIndex = 17;
            this.ProductCategoryEmpErrLabel.Text = "*";
            this.ProductCategoryEmpErrLabel.Visible = false;
            // 
            // dataGridViewProductPricing
            // 
            this.dataGridViewProductPricing.AllowUserToAddRows = false;
            this.dataGridViewProductPricing.AllowUserToDeleteRows = false;
            this.dataGridViewProductPricing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductPricing.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductPricing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductPricing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductPricing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductPricing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxGV,
            this.prodIDGV,
            this.prodNameGV,
            this.BuyingPriceGV,
            this.ProfitMarginGV,
            this.DiscountGV,
            this.FinalSellingPriceGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductPricing.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductPricing.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProductPricing.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewProductPricing.Name = "dataGridViewProductPricing";
            this.dataGridViewProductPricing.RowHeadersVisible = false;
            this.dataGridViewProductPricing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductPricing.Size = new System.Drawing.Size(772, 370);
            this.dataGridViewProductPricing.TabIndex = 7;
            this.dataGridViewProductPricing.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductPricing_CellEndEdit);
            this.dataGridViewProductPricing.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductPricing_CellEnter);
            // 
            // CheckBoxGV
            // 
            this.CheckBoxGV.FalseValue = "0";
            this.CheckBoxGV.HeaderText = "";
            this.CheckBoxGV.Name = "CheckBoxGV";
            this.CheckBoxGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckBoxGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBoxGV.TrueValue = "1";
            // 
            // prodIDGV
            // 
            this.prodIDGV.HeaderText = "Product ID";
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            this.prodNameGV.HeaderText = "Product";
            this.prodNameGV.Name = "prodNameGV";
            // 
            // BuyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.BuyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyingPriceGV.HeaderText = "Buying Price";
            this.BuyingPriceGV.Name = "BuyingPriceGV";
            // 
            // ProfitMarginGV
            // 
            this.ProfitMarginGV.HeaderText = "Profit Margin %";
            this.ProfitMarginGV.Name = "ProfitMarginGV";
            // 
            // DiscountGV
            // 
            this.DiscountGV.HeaderText = "Discount %";
            this.DiscountGV.Name = "DiscountGV";
            // 
            // FinalSellingPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.FinalSellingPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.FinalSellingPriceGV.HeaderText = "Final Selling Price";
            this.FinalSellingPriceGV.Name = "FinalSellingPriceGV";
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Name = "ProductPricing";
            this.Text = "ProductPricing";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductPricing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCategoryCB;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductCategoryEmpErrLabel;
        private System.Windows.Forms.DataGridView dataGridViewProductPricing;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalSellingPriceGV;
    }
}