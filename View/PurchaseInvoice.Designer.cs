namespace IMS
{
    partial class PurchaseInvoice
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
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.SupplierCB = new System.Windows.Forms.ComboBox();
            this.SelectQuantityLabel = new System.Windows.Forms.Label();
            this.PerUniPriceLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.ProductTxt = new System.Windows.Forms.TextBox();
            this.PerUnitPriceTxt = new System.Windows.Forms.TextBox();
            this.SelectQuantityTxt = new System.Windows.Forms.TextBox();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.TotalAmountTxtLabel = new System.Windows.Forms.Label();
            this.dataGridViewPurchaseInvoice = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrossTotalTextLabel = new System.Windows.Forms.Label();
            this.GrossTotalLabel = new System.Windows.Forms.Label();
            this.SuppEmpErrLabel = new System.Windows.Forms.Label();
            this.QuantityEmpErrLabel = new System.Windows.Forms.Label();
            this.BarcodeEmpErrLabel = new System.Windows.Forms.Label();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(762, 40);
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
            this.LeftPanel.Controls.Add(this.TotalAmountTxtLabel);
            this.LeftPanel.Controls.Add(this.TotalAmountLabel);
            this.LeftPanel.Controls.Add(this.AddToCartBtn);
            this.LeftPanel.Controls.Add(this.SelectQuantityTxt);
            this.LeftPanel.Controls.Add(this.PerUnitPriceTxt);
            this.LeftPanel.Controls.Add(this.ProductTxt);
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.BarcodeLabel);
            this.LeftPanel.Controls.Add(this.ProductLabel);
            this.LeftPanel.Controls.Add(this.PerUniPriceLabel);
            this.LeftPanel.Controls.Add(this.SelectQuantityLabel);
            this.LeftPanel.Controls.Add(this.SupplierCB);
            this.LeftPanel.Controls.Add(this.SupplierLabel);
            this.LeftPanel.Controls.Add(this.SuppEmpErrLabel);
            this.LeftPanel.Controls.Add(this.BarcodeEmpErrLabel);
            this.LeftPanel.Controls.Add(this.QuantityEmpErrLabel);
            this.LeftPanel.Size = new System.Drawing.Size(200, 550);
            this.LeftPanel.Controls.SetChildIndex(this.QuantityEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SuppEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SupplierLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SupplierCB, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SelectQuantityLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PerUniPriceLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PerUnitPriceTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SelectQuantityTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddToCartBtn, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TotalAmountLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TotalAmountTxtLabel, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel2);
            this.RightPanel.Controls.Add(this.dataGridViewPurchaseInvoice);
            this.RightPanel.Size = new System.Drawing.Size(762, 550);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewPurchaseInvoice, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(762, 40);
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SupplierLabel.Location = new System.Drawing.Point(5, 80);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(93, 13);
            this.SupplierLabel.TabIndex = 1;
            this.SupplierLabel.Text = "Select Supplier";
            // 
            // SupplierCB
            // 
            this.SupplierCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCB.FormattingEnabled = true;
            this.SupplierCB.Location = new System.Drawing.Point(8, 97);
            this.SupplierCB.Name = "SupplierCB";
            this.SupplierCB.Size = new System.Drawing.Size(184, 24);
            this.SupplierCB.TabIndex = 2;
            // 
            // SelectQuantityLabel
            // 
            this.SelectQuantityLabel.AutoSize = true;
            this.SelectQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectQuantityLabel.Location = new System.Drawing.Point(5, 302);
            this.SelectQuantityLabel.Name = "SelectQuantityLabel";
            this.SelectQuantityLabel.Size = new System.Drawing.Size(94, 13);
            this.SelectQuantityLabel.TabIndex = 3;
            this.SelectQuantityLabel.Text = "Select Quantity";
            // 
            // PerUniPriceLabel
            // 
            this.PerUniPriceLabel.AutoSize = true;
            this.PerUniPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerUniPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PerUniPriceLabel.Location = new System.Drawing.Point(5, 246);
            this.PerUniPriceLabel.Name = "PerUniPriceLabel";
            this.PerUniPriceLabel.Size = new System.Drawing.Size(86, 13);
            this.PerUniPriceLabel.TabIndex = 4;
            this.PerUniPriceLabel.Text = "Per Unit Price";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ProductLabel.Location = new System.Drawing.Point(5, 190);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(51, 13);
            this.ProductLabel.TabIndex = 5;
            this.ProductLabel.Text = "Product";
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BarcodeLabel.Location = new System.Drawing.Point(5, 136);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(54, 13);
            this.BarcodeLabel.TabIndex = 6;
            this.BarcodeLabel.Text = "Barcode";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxt.Location = new System.Drawing.Point(8, 153);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(184, 22);
            this.BarcodeTxt.TabIndex = 7;
            this.BarcodeTxt.Leave += new System.EventHandler(this.BarcodeTxt_Leave);
            // 
            // ProductTxt
            // 
            this.ProductTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTxt.Location = new System.Drawing.Point(8, 206);
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(184, 22);
            this.ProductTxt.TabIndex = 8;
            // 
            // PerUnitPriceTxt
            // 
            this.PerUnitPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerUnitPriceTxt.Location = new System.Drawing.Point(8, 262);
            this.PerUnitPriceTxt.Name = "PerUnitPriceTxt";
            this.PerUnitPriceTxt.Size = new System.Drawing.Size(184, 22);
            this.PerUnitPriceTxt.TabIndex = 9;
            this.PerUnitPriceTxt.TextChanged += new System.EventHandler(this.PerUnitPriceTxt_TextChanged);
            // 
            // SelectQuantityTxt
            // 
            this.SelectQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectQuantityTxt.Location = new System.Drawing.Point(8, 318);
            this.SelectQuantityTxt.Name = "SelectQuantityTxt";
            this.SelectQuantityTxt.Size = new System.Drawing.Size(184, 22);
            this.SelectQuantityTxt.TabIndex = 10;
            this.SelectQuantityTxt.TextChanged += new System.EventHandler(this.SelectQuantityTxt_TextChanged);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartBtn.ForeColor = System.Drawing.Color.Black;
            this.AddToCartBtn.Location = new System.Drawing.Point(8, 354);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(184, 42);
            this.AddToCartBtn.TabIndex = 11;
            this.AddToCartBtn.Text = "ADD TO CART";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalAmountLabel.Location = new System.Drawing.Point(8, 403);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(82, 13);
            this.TotalAmountLabel.TabIndex = 12;
            this.TotalAmountLabel.Text = "Total Amount";
            // 
            // TotalAmountTxtLabel
            // 
            this.TotalAmountTxtLabel.AutoSize = true;
            this.TotalAmountTxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTxtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalAmountTxtLabel.Location = new System.Drawing.Point(69, 450);
            this.TotalAmountTxtLabel.Name = "TotalAmountTxtLabel";
            this.TotalAmountTxtLabel.Size = new System.Drawing.Size(62, 29);
            this.TotalAmountTxtLabel.TabIndex = 13;
            this.TotalAmountTxtLabel.Text = "0.00";
            // 
            // dataGridViewPurchaseInvoice
            // 
            this.dataGridViewPurchaseInvoice.AllowUserToAddRows = false;
            this.dataGridViewPurchaseInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewPurchaseInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchaseInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPurchaseInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurchaseInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPurchaseInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDGV,
            this.prodNameGV,
            this.QuantityGV,
            this.PerUnitPriceGV,
            this.TotalAmountGV,
            this.DeleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPurchaseInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPurchaseInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPurchaseInvoice.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewPurchaseInvoice.Name = "dataGridViewPurchaseInvoice";
            this.dataGridViewPurchaseInvoice.ReadOnly = true;
            this.dataGridViewPurchaseInvoice.RowHeadersVisible = false;
            this.dataGridViewPurchaseInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchaseInvoice.Size = new System.Drawing.Size(762, 364);
            this.dataGridViewPurchaseInvoice.TabIndex = 4;
            this.dataGridViewPurchaseInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseInvoice_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GrossTotalTextLabel);
            this.panel2.Controls.Add(this.GrossTotalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 106);
            this.panel2.TabIndex = 5;
            // 
            // GrossTotalTextLabel
            // 
            this.GrossTotalTextLabel.AutoSize = true;
            this.GrossTotalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossTotalTextLabel.Location = new System.Drawing.Point(430, 34);
            this.GrossTotalTextLabel.Name = "GrossTotalTextLabel";
            this.GrossTotalTextLabel.Size = new System.Drawing.Size(71, 31);
            this.GrossTotalTextLabel.TabIndex = 15;
            this.GrossTotalTextLabel.Text = "0.00";
            // 
            // GrossTotalLabel
            // 
            this.GrossTotalLabel.AutoSize = true;
            this.GrossTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossTotalLabel.Location = new System.Drawing.Point(156, 34);
            this.GrossTotalLabel.Name = "GrossTotalLabel";
            this.GrossTotalLabel.Size = new System.Drawing.Size(155, 31);
            this.GrossTotalLabel.TabIndex = 14;
            this.GrossTotalLabel.Text = "Gross Total";
            // 
            // SuppEmpErrLabel
            // 
            this.SuppEmpErrLabel.AutoSize = true;
            this.SuppEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.SuppEmpErrLabel.Location = new System.Drawing.Point(81, 83);
            this.SuppEmpErrLabel.Name = "SuppEmpErrLabel";
            this.SuppEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.SuppEmpErrLabel.TabIndex = 14;
            this.SuppEmpErrLabel.Text = "*";
            this.SuppEmpErrLabel.Visible = false;
            // 
            // QuantityEmpErrLabel
            // 
            this.QuantityEmpErrLabel.AutoSize = true;
            this.QuantityEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.QuantityEmpErrLabel.Location = new System.Drawing.Point(80, 305);
            this.QuantityEmpErrLabel.Name = "QuantityEmpErrLabel";
            this.QuantityEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.QuantityEmpErrLabel.TabIndex = 15;
            this.QuantityEmpErrLabel.Text = "*";
            this.QuantityEmpErrLabel.Visible = false;
            // 
            // BarcodeEmpErrLabel
            // 
            this.BarcodeEmpErrLabel.AutoSize = true;
            this.BarcodeEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.BarcodeEmpErrLabel.Location = new System.Drawing.Point(49, 139);
            this.BarcodeEmpErrLabel.Name = "BarcodeEmpErrLabel";
            this.BarcodeEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.BarcodeEmpErrLabel.TabIndex = 16;
            this.BarcodeEmpErrLabel.Text = "*";
            this.BarcodeEmpErrLabel.Visible = false;
            // 
            // prodIDGV
            // 
            this.prodIDGV.HeaderText = "Product ID";
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.ReadOnly = true;
            // 
            // prodNameGV
            // 
            this.prodNameGV.HeaderText = "Product";
            this.prodNameGV.Name = "prodNameGV";
            this.prodNameGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // PerUnitPriceGV
            // 
            this.PerUnitPriceGV.HeaderText = "Per Unit Price";
            this.PerUnitPriceGV.Name = "PerUnitPriceGV";
            this.PerUnitPriceGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            // 
            // DeleteGV
            // 
            this.DeleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteGV.HeaderText = "Action";
            this.DeleteGV.Name = "DeleteGV";
            this.DeleteGV.ReadOnly = true;
            this.DeleteGV.Text = "DELETE";
            this.DeleteGV.UseColumnTextForButtonValue = true;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 550);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.ComboBox SupplierCB;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.TextBox SelectQuantityTxt;
        private System.Windows.Forms.TextBox PerUnitPriceTxt;
        private System.Windows.Forms.TextBox ProductTxt;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PerUniPriceLabel;
        private System.Windows.Forms.Label SelectQuantityLabel;
        private System.Windows.Forms.Label TotalAmountTxtLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GrossTotalTextLabel;
        private System.Windows.Forms.Label GrossTotalLabel;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseInvoice;
        private System.Windows.Forms.Label SuppEmpErrLabel;
        private System.Windows.Forms.Label BarcodeEmpErrLabel;
        private System.Windows.Forms.Label QuantityEmpErrLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
    }
}