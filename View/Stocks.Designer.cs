namespace IMS
{
    partial class Stocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(747, 40);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(115, 20);
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewStocks);
            this.RightPanel.Size = new System.Drawing.Size(747, 450);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewStocks, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(747, 40);
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.AllowUserToAddRows = false;
            this.dataGridViewStocks.AllowUserToDeleteRows = false;
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStocks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDGV,
            this.prodNameGV,
            this.QuantityGV,
            this.BarcodeGV,
            this.ExpiryGV,
            this.BuyingPriceGV,
            this.SellingPriceGV,
            this.CategoryGV,
            this.TotalAmountGV,
            this.StatusGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStocks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStocks.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.ReadOnly = true;
            this.dataGridViewStocks.RowHeadersVisible = false;
            this.dataGridViewStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStocks.Size = new System.Drawing.Size(747, 289);
            this.dataGridViewStocks.TabIndex = 6;
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
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // BarcodeGV
            // 
            this.BarcodeGV.HeaderText = "Barcode";
            this.BarcodeGV.Name = "BarcodeGV";
            this.BarcodeGV.ReadOnly = true;
            // 
            // ExpiryGV
            // 
            this.ExpiryGV.HeaderText = "Expiry";
            this.ExpiryGV.Name = "ExpiryGV";
            this.ExpiryGV.ReadOnly = true;
            // 
            // BuyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.BuyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyingPriceGV.HeaderText = "Buying Price";
            this.BuyingPriceGV.Name = "BuyingPriceGV";
            this.BuyingPriceGV.ReadOnly = true;
            // 
            // SellingPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SellingPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellingPriceGV.HeaderText = "Selling Price";
            this.SellingPriceGV.Name = "SellingPriceGV";
            this.SellingPriceGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            this.CategoryGV.HeaderText = "Category";
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.TotalAmountGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}