namespace IMS
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.HomeScreenLayout = new System.Windows.Forms.TableLayoutPanel();
            this.poductsbtn = new System.Windows.Forms.Button();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.PurchaseInvoicebtn = new System.Windows.Forms.Button();
            this.Salesbtn = new System.Windows.Forms.Button();
            this.Usersbtn = new System.Windows.Forms.Button();
            this.CategoriesBtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.ProductPricingBtn = new System.Windows.Forms.Button();
            this.SalesReturnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRigthPanel.SuspendLayout();
            this.HomeScreenLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Size = new System.Drawing.Size(200, 533);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.HomeScreenLayout);
            this.RightPanel.Size = new System.Drawing.Size(791, 533);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.HomeScreenLayout, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Controls.Add(this.logoutBtn);
            this.TopRigthPanel.Size = new System.Drawing.Size(791, 40);
            this.TopRigthPanel.Controls.SetChildIndex(this.logoutBtn, 0);
            // 
            // HomeScreenLayout
            // 
            this.HomeScreenLayout.ColumnCount = 5;
            this.HomeScreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.Controls.Add(this.poductsbtn, 1, 0);
            this.HomeScreenLayout.Controls.Add(this.SupplierBtn, 2, 0);
            this.HomeScreenLayout.Controls.Add(this.PurchaseInvoicebtn, 3, 0);
            this.HomeScreenLayout.Controls.Add(this.Salesbtn, 4, 0);
            this.HomeScreenLayout.Controls.Add(this.Usersbtn, 0, 0);
            this.HomeScreenLayout.Controls.Add(this.CategoriesBtn, 0, 1);
            this.HomeScreenLayout.Controls.Add(this.StockBtn, 1, 1);
            this.HomeScreenLayout.Controls.Add(this.ProductPricingBtn, 2, 1);
            this.HomeScreenLayout.Controls.Add(this.SalesReturnBtn, 3, 1);
            this.HomeScreenLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeScreenLayout.Location = new System.Drawing.Point(0, 40);
            this.HomeScreenLayout.Name = "HomeScreenLayout";
            this.HomeScreenLayout.RowCount = 5;
            this.HomeScreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HomeScreenLayout.Size = new System.Drawing.Size(791, 493);
            this.HomeScreenLayout.TabIndex = 1;
            // 
            // poductsbtn
            // 
            this.poductsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poductsbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poductsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poductsbtn.Image = ((System.Drawing.Image)(resources.GetObject("poductsbtn.Image")));
            this.poductsbtn.Location = new System.Drawing.Point(161, 3);
            this.poductsbtn.Name = "poductsbtn";
            this.poductsbtn.Size = new System.Drawing.Size(152, 92);
            this.poductsbtn.TabIndex = 1;
            this.poductsbtn.Text = "Products";
            this.poductsbtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.poductsbtn.UseVisualStyleBackColor = true;
            this.poductsbtn.Click += new System.EventHandler(this.poductsbtn_Click);
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierBtn.Image = global::IMS.Properties.Resources.supply;
            this.SupplierBtn.Location = new System.Drawing.Point(319, 3);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Size = new System.Drawing.Size(152, 92);
            this.SupplierBtn.TabIndex = 2;
            this.SupplierBtn.Text = "Supplier";
            this.SupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SupplierBtn.UseVisualStyleBackColor = true;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // PurchaseInvoicebtn
            // 
            this.PurchaseInvoicebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseInvoicebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseInvoicebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInvoicebtn.Image = ((System.Drawing.Image)(resources.GetObject("PurchaseInvoicebtn.Image")));
            this.PurchaseInvoicebtn.Location = new System.Drawing.Point(477, 3);
            this.PurchaseInvoicebtn.Name = "PurchaseInvoicebtn";
            this.PurchaseInvoicebtn.Size = new System.Drawing.Size(152, 92);
            this.PurchaseInvoicebtn.TabIndex = 3;
            this.PurchaseInvoicebtn.Text = "Purchase Invoice";
            this.PurchaseInvoicebtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PurchaseInvoicebtn.UseVisualStyleBackColor = true;
            this.PurchaseInvoicebtn.Click += new System.EventHandler(this.PurchaseInvoicebtn_Click);
            // 
            // Salesbtn
            // 
            this.Salesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Salesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salesbtn.Image = global::IMS.Properties.Resources.sales;
            this.Salesbtn.Location = new System.Drawing.Point(635, 3);
            this.Salesbtn.Name = "Salesbtn";
            this.Salesbtn.Size = new System.Drawing.Size(153, 92);
            this.Salesbtn.TabIndex = 4;
            this.Salesbtn.Text = "Sales";
            this.Salesbtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Salesbtn.UseVisualStyleBackColor = true;
            this.Salesbtn.Click += new System.EventHandler(this.Salesbtn_Click);
            // 
            // Usersbtn
            // 
            this.Usersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usersbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersbtn.Image = ((System.Drawing.Image)(resources.GetObject("Usersbtn.Image")));
            this.Usersbtn.Location = new System.Drawing.Point(3, 3);
            this.Usersbtn.Name = "Usersbtn";
            this.Usersbtn.Size = new System.Drawing.Size(152, 92);
            this.Usersbtn.TabIndex = 5;
            this.Usersbtn.Text = "Users";
            this.Usersbtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Usersbtn.UseVisualStyleBackColor = true;
            this.Usersbtn.Click += new System.EventHandler(this.Usersbtn_Click);
            // 
            // CategoriesBtn
            // 
            this.CategoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoriesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesBtn.Image = global::IMS.Properties.Resources.categories;
            this.CategoriesBtn.Location = new System.Drawing.Point(3, 101);
            this.CategoriesBtn.Name = "CategoriesBtn";
            this.CategoriesBtn.Size = new System.Drawing.Size(152, 92);
            this.CategoriesBtn.TabIndex = 6;
            this.CategoriesBtn.Text = "Categories";
            this.CategoriesBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CategoriesBtn.UseVisualStyleBackColor = true;
            this.CategoriesBtn.Click += new System.EventHandler(this.CategoriesBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockBtn.Image = global::IMS.Properties.Resources.stock;
            this.StockBtn.Location = new System.Drawing.Point(161, 101);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(152, 92);
            this.StockBtn.TabIndex = 7;
            this.StockBtn.Text = "Stock";
            this.StockBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.StockBtn.UseVisualStyleBackColor = true;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // ProductPricingBtn
            // 
            this.ProductPricingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPricingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPricingBtn.Image = global::IMS.Properties.Resources.pricing;
            this.ProductPricingBtn.Location = new System.Drawing.Point(319, 101);
            this.ProductPricingBtn.Name = "ProductPricingBtn";
            this.ProductPricingBtn.Size = new System.Drawing.Size(152, 92);
            this.ProductPricingBtn.TabIndex = 8;
            this.ProductPricingBtn.Text = "Product Pricing";
            this.ProductPricingBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ProductPricingBtn.UseVisualStyleBackColor = true;
            this.ProductPricingBtn.Click += new System.EventHandler(this.ProductPricingBtn_Click);
            // 
            // SalesReturnBtn
            // 
            this.SalesReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesReturnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReturnBtn.Image = global::IMS.Properties.Resources.refund;
            this.SalesReturnBtn.Location = new System.Drawing.Point(477, 101);
            this.SalesReturnBtn.Name = "SalesReturnBtn";
            this.SalesReturnBtn.Size = new System.Drawing.Size(152, 92);
            this.SalesReturnBtn.TabIndex = 9;
            this.SalesReturnBtn.Text = "Sales Return";
            this.SalesReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SalesReturnBtn.UseVisualStyleBackColor = true;
            this.SalesReturnBtn.Click += new System.EventHandler(this.SalesReturnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(20, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bradley Hand ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(26, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "System";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Gray;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = global::IMS.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(674, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(117, 40);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Name = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.TopRigthPanel.ResumeLayout(false);
            this.TopRigthPanel.PerformLayout();
            this.HomeScreenLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HomeScreenLayout;
        private System.Windows.Forms.Button poductsbtn;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Button PurchaseInvoicebtn;
        private System.Windows.Forms.Button Salesbtn;
        private System.Windows.Forms.Button Usersbtn;
        private System.Windows.Forms.Button CategoriesBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button ProductPricingBtn;
        private System.Windows.Forms.Button SalesReturnBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}