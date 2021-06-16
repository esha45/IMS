namespace IMS
{
    partial class Products
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductNametxt = new System.Windows.Forms.TextBox();
            this.Barcodetxt = new System.Windows.Forms.TextBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductCategoryCB = new System.Windows.Forms.ComboBox();
            this.ProductNameEmpErrLabel = new System.Windows.Forms.Label();
            this.ProductCategoryEmpErrLabel = new System.Windows.Forms.Label();
            this.ExpiryValidErrLabel = new System.Windows.Forms.Label();
            this.BarcodeEmpErrLabel = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodBarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ProductCategoryCB);
            this.LeftPanel.Controls.Add(this.ExpiryDatePicker);
            this.LeftPanel.Controls.Add(this.Barcodetxt);
            this.LeftPanel.Controls.Add(this.ProductNametxt);
            this.LeftPanel.Controls.Add(this.ProductCategoryLabel);
            this.LeftPanel.Controls.Add(this.ExpiryDateLabel);
            this.LeftPanel.Controls.Add(this.BarcodeLabel);
            this.LeftPanel.Controls.Add(this.ProductNameLabel);
            this.LeftPanel.Controls.Add(this.ProductNameEmpErrLabel);
            this.LeftPanel.Controls.Add(this.BarcodeEmpErrLabel);
            this.LeftPanel.Controls.Add(this.ExpiryValidErrLabel);
            this.LeftPanel.Controls.Add(this.ProductCategoryEmpErrLabel);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryValidErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductNameEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductNameLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryDateLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductNametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Barcodetxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryDatePicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductCategoryCB, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewProducts);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewProducts, 0);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductNameLabel.Location = new System.Drawing.Point(10, 81);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(87, 13);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BarcodeLabel.Location = new System.Drawing.Point(10, 133);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(54, 13);
            this.BarcodeLabel.TabIndex = 3;
            this.BarcodeLabel.Text = "Barcode";
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExpiryDateLabel.Location = new System.Drawing.Point(10, 186);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(72, 13);
            this.ExpiryDateLabel.TabIndex = 5;
            this.ExpiryDateLabel.Text = "Expiry Date";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(9, 238);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(57, 13);
            this.ProductCategoryLabel.TabIndex = 7;
            this.ProductCategoryLabel.Text = "Category";
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNametxt.Location = new System.Drawing.Point(10, 98);
            this.ProductNametxt.MaxLength = 50;
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(181, 22);
            this.ProductNametxt.TabIndex = 0;
            this.ProductNametxt.TextChanged += new System.EventHandler(this.ProductNametxt_TextChanged);
            // 
            // Barcodetxt
            // 
            this.Barcodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcodetxt.Location = new System.Drawing.Point(13, 149);
            this.Barcodetxt.Name = "Barcodetxt";
            this.Barcodetxt.Size = new System.Drawing.Size(178, 22);
            this.Barcodetxt.TabIndex = 5;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Location = new System.Drawing.Point(10, 201);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(181, 22);
            this.ExpiryDatePicker.TabIndex = 3;
            // 
            // ProductCategoryCB
            // 
            this.ProductCategoryCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryCB.FormattingEnabled = true;
            this.ProductCategoryCB.Location = new System.Drawing.Point(10, 255);
            this.ProductCategoryCB.Name = "ProductCategoryCB";
            this.ProductCategoryCB.Size = new System.Drawing.Size(181, 24);
            this.ProductCategoryCB.TabIndex = 4;
            // 
            // ProductNameEmpErrLabel
            // 
            this.ProductNameEmpErrLabel.AutoSize = true;
            this.ProductNameEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.ProductNameEmpErrLabel.Location = new System.Drawing.Point(84, 84);
            this.ProductNameEmpErrLabel.Name = "ProductNameEmpErrLabel";
            this.ProductNameEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.ProductNameEmpErrLabel.TabIndex = 13;
            this.ProductNameEmpErrLabel.Text = "*";
            this.ProductNameEmpErrLabel.Visible = false;
            // 
            // ProductCategoryEmpErrLabel
            // 
            this.ProductCategoryEmpErrLabel.AutoSize = true;
            this.ProductCategoryEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.ProductCategoryEmpErrLabel.Location = new System.Drawing.Point(57, 241);
            this.ProductCategoryEmpErrLabel.Name = "ProductCategoryEmpErrLabel";
            this.ProductCategoryEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.ProductCategoryEmpErrLabel.TabIndex = 14;
            this.ProductCategoryEmpErrLabel.Text = "*";
            this.ProductCategoryEmpErrLabel.Visible = false;
            // 
            // ExpiryValidErrLabel
            // 
            this.ExpiryValidErrLabel.AutoSize = true;
            this.ExpiryValidErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryValidErrLabel.ForeColor = System.Drawing.Color.Red;
            this.ExpiryValidErrLabel.Location = new System.Drawing.Point(69, 188);
            this.ExpiryValidErrLabel.Name = "ExpiryValidErrLabel";
            this.ExpiryValidErrLabel.Size = new System.Drawing.Size(15, 18);
            this.ExpiryValidErrLabel.TabIndex = 16;
            this.ExpiryValidErrLabel.Text = "*";
            this.ExpiryValidErrLabel.Visible = false;
            // 
            // BarcodeEmpErrLabel
            // 
            this.BarcodeEmpErrLabel.AutoSize = true;
            this.BarcodeEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.BarcodeEmpErrLabel.Location = new System.Drawing.Point(55, 136);
            this.BarcodeEmpErrLabel.Name = "BarcodeEmpErrLabel";
            this.BarcodeEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.BarcodeEmpErrLabel.TabIndex = 17;
            this.BarcodeEmpErrLabel.Text = "*";
            this.BarcodeEmpErrLabel.Visible = false;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDGV,
            this.prodNameGV,
            this.expDateGV,
            this.prodBarcodeGV,
            this.catNameGV,
            this.catIDGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 370);
            this.dataGridViewProducts.TabIndex = 3;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // prodIDGV
            // 
            this.prodIDGV.HeaderText = "Product ID";
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.ReadOnly = true;
            this.prodIDGV.Visible = false;
            // 
            // prodNameGV
            // 
            this.prodNameGV.HeaderText = "Product";
            this.prodNameGV.Name = "prodNameGV";
            this.prodNameGV.ReadOnly = true;
            // 
            // expDateGV
            // 
            this.expDateGV.HeaderText = "Expiry";
            this.expDateGV.Name = "expDateGV";
            this.expDateGV.ReadOnly = true;
            // 
            // prodBarcodeGV
            // 
            this.prodBarcodeGV.HeaderText = "Barcode";
            this.prodBarcodeGV.Name = "prodBarcodeGV";
            this.prodBarcodeGV.ReadOnly = true;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Category";
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "Category ID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.ComboBox ProductCategoryCB;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.TextBox Barcodetxt;
        private System.Windows.Forms.TextBox ProductNametxt;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductNameEmpErrLabel;
        private System.Windows.Forms.Label BarcodeEmpErrLabel;
        private System.Windows.Forms.Label ExpiryValidErrLabel;
        private System.Windows.Forms.Label ProductCategoryEmpErrLabel;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodBarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
    }
}