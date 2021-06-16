namespace IMS
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrossTotalTextLabel = new System.Windows.Forms.Label();
            this.GrossTotalLabel = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PaymentsGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.PaymentTypeCB = new System.Windows.Forms.ComboBox();
            this.TotalDiscountTxt = new System.Windows.Forms.TextBox();
            this.AmountGivenTxt = new System.Windows.Forms.TextBox();
            this.ChangetoGiveTxt = new System.Windows.Forms.TextBox();
            this.GrossTotalTxt = new System.Windows.Forms.TextBox();
            this.ChangetoGiveLabel = new System.Windows.Forms.Label();
            this.AmountGivenLabel = new System.Windows.Forms.Label();
            this.TotalDiscountLabel = new System.Windows.Forms.Label();
            this.GrossTotalPaymentLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.panel3.SuspendLayout();
            this.PaymentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.PaymentsGroupBox);
            this.LeftPanel.Controls.Add(this.panel3);
            this.LeftPanel.Size = new System.Drawing.Size(200, 552);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PaymentsGroupBox, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel2);
            this.RightPanel.Controls.Add(this.dataGridViewSales);
            this.RightPanel.Size = new System.Drawing.Size(600, 552);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewSales, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GrossTotalTextLabel);
            this.panel2.Controls.Add(this.GrossTotalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 118);
            this.panel2.TabIndex = 7;
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
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDGV,
            this.prodNameGV,
            this.QuantityGV,
            this.PerUnitPriceGV,
            this.DiscountGV,
            this.TotalAmountGV,
            this.DeleteGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSales.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersVisible = false;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(600, 354);
            this.dataGridViewSales.TabIndex = 6;
            this.dataGridViewSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSales_CellClick);
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
            // PerUnitPriceGV
            // 
            this.PerUnitPriceGV.HeaderText = "Per Unit Price";
            this.PerUnitPriceGV.Name = "PerUnitPriceGV";
            this.PerUnitPriceGV.ReadOnly = true;
            // 
            // DiscountGV
            // 
            this.DiscountGV.HeaderText = "Discount";
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.TotalAmountGV.DefaultCellStyle = dataGridViewCellStyle2;
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
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BarcodeLabel.Location = new System.Drawing.Point(8, 41);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(88, 13);
            this.BarcodeLabel.TabIndex = 1;
            this.BarcodeLabel.Text = "Enter Barcode";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxt.Location = new System.Drawing.Point(10, 58);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(181, 22);
            this.BarcodeTxt.TabIndex = 2;
            this.BarcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.BarcodeTxt_Validating);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BarcodeTxt);
            this.panel3.Controls.Add(this.BarcodeLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 84);
            this.panel3.TabIndex = 3;
            // 
            // PaymentsGroupBox
            // 
            this.PaymentsGroupBox.Controls.Add(this.CheckoutBtn);
            this.PaymentsGroupBox.Controls.Add(this.PaymentTypeLabel);
            this.PaymentsGroupBox.Controls.Add(this.PayBtn);
            this.PaymentsGroupBox.Controls.Add(this.PaymentTypeCB);
            this.PaymentsGroupBox.Controls.Add(this.TotalDiscountTxt);
            this.PaymentsGroupBox.Controls.Add(this.AmountGivenTxt);
            this.PaymentsGroupBox.Controls.Add(this.ChangetoGiveTxt);
            this.PaymentsGroupBox.Controls.Add(this.GrossTotalTxt);
            this.PaymentsGroupBox.Controls.Add(this.ChangetoGiveLabel);
            this.PaymentsGroupBox.Controls.Add(this.AmountGivenLabel);
            this.PaymentsGroupBox.Controls.Add(this.TotalDiscountLabel);
            this.PaymentsGroupBox.Controls.Add(this.GrossTotalPaymentLabel);
            this.PaymentsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentsGroupBox.Location = new System.Drawing.Point(0, 124);
            this.PaymentsGroupBox.Name = "PaymentsGroupBox";
            this.PaymentsGroupBox.Size = new System.Drawing.Size(200, 428);
            this.PaymentsGroupBox.TabIndex = 4;
            this.PaymentsGroupBox.TabStop = false;
            this.PaymentsGroupBox.Text = "Payments";
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CheckoutBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckoutBtn.Location = new System.Drawing.Point(13, 274);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(177, 31);
            this.CheckoutBtn.TabIndex = 12;
            this.CheckoutBtn.Text = "CHECKOUT";
            this.CheckoutBtn.UseVisualStyleBackColor = false;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PaymentTypeLabel.Location = new System.Drawing.Point(12, 116);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(87, 13);
            this.PaymentTypeLabel.TabIndex = 11;
            this.PaymentTypeLabel.Text = "Payment Type";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PayBtn.ForeColor = System.Drawing.Color.Black;
            this.PayBtn.Location = new System.Drawing.Point(13, 307);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(177, 31);
            this.PayBtn.TabIndex = 10;
            this.PayBtn.Text = "PAY";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // PaymentTypeCB
            // 
            this.PaymentTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeCB.FormattingEnabled = true;
            this.PaymentTypeCB.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.PaymentTypeCB.Location = new System.Drawing.Point(12, 135);
            this.PaymentTypeCB.Name = "PaymentTypeCB";
            this.PaymentTypeCB.Size = new System.Drawing.Size(178, 24);
            this.PaymentTypeCB.TabIndex = 9;
            // 
            // TotalDiscountTxt
            // 
            this.TotalDiscountTxt.Enabled = false;
            this.TotalDiscountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTxt.Location = new System.Drawing.Point(12, 85);
            this.TotalDiscountTxt.Name = "TotalDiscountTxt";
            this.TotalDiscountTxt.Size = new System.Drawing.Size(178, 22);
            this.TotalDiscountTxt.TabIndex = 8;
            // 
            // AmountGivenTxt
            // 
            this.AmountGivenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountGivenTxt.Location = new System.Drawing.Point(12, 184);
            this.AmountGivenTxt.Name = "AmountGivenTxt";
            this.AmountGivenTxt.Size = new System.Drawing.Size(178, 22);
            this.AmountGivenTxt.TabIndex = 7;
            this.AmountGivenTxt.TextChanged += new System.EventHandler(this.AmountGivenTxt_TextChanged);
            this.AmountGivenTxt.Validating += new System.ComponentModel.CancelEventHandler(this.AmountGivenTxt_Validating);
            // 
            // ChangetoGiveTxt
            // 
            this.ChangetoGiveTxt.Enabled = false;
            this.ChangetoGiveTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangetoGiveTxt.Location = new System.Drawing.Point(12, 235);
            this.ChangetoGiveTxt.Name = "ChangetoGiveTxt";
            this.ChangetoGiveTxt.Size = new System.Drawing.Size(178, 22);
            this.ChangetoGiveTxt.TabIndex = 6;
            // 
            // GrossTotalTxt
            // 
            this.GrossTotalTxt.Enabled = false;
            this.GrossTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossTotalTxt.Location = new System.Drawing.Point(12, 37);
            this.GrossTotalTxt.Name = "GrossTotalTxt";
            this.GrossTotalTxt.Size = new System.Drawing.Size(178, 22);
            this.GrossTotalTxt.TabIndex = 5;
            // 
            // ChangetoGiveLabel
            // 
            this.ChangetoGiveLabel.AutoSize = true;
            this.ChangetoGiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangetoGiveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangetoGiveLabel.Location = new System.Drawing.Point(10, 219);
            this.ChangetoGiveLabel.Name = "ChangetoGiveLabel";
            this.ChangetoGiveLabel.Size = new System.Drawing.Size(95, 13);
            this.ChangetoGiveLabel.TabIndex = 4;
            this.ChangetoGiveLabel.Text = "Change to Give";
            // 
            // AmountGivenLabel
            // 
            this.AmountGivenLabel.AutoSize = true;
            this.AmountGivenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountGivenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AmountGivenLabel.Location = new System.Drawing.Point(10, 168);
            this.AmountGivenLabel.Name = "AmountGivenLabel";
            this.AmountGivenLabel.Size = new System.Drawing.Size(86, 13);
            this.AmountGivenLabel.TabIndex = 3;
            this.AmountGivenLabel.Text = "Amount Given";
            // 
            // TotalDiscountLabel
            // 
            this.TotalDiscountLabel.AutoSize = true;
            this.TotalDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalDiscountLabel.Location = new System.Drawing.Point(10, 69);
            this.TotalDiscountLabel.Name = "TotalDiscountLabel";
            this.TotalDiscountLabel.Size = new System.Drawing.Size(90, 13);
            this.TotalDiscountLabel.TabIndex = 1;
            this.TotalDiscountLabel.Text = "Total Discount";
            // 
            // GrossTotalPaymentLabel
            // 
            this.GrossTotalPaymentLabel.AutoSize = true;
            this.GrossTotalPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossTotalPaymentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GrossTotalPaymentLabel.Location = new System.Drawing.Point(10, 20);
            this.GrossTotalPaymentLabel.Name = "GrossTotalPaymentLabel";
            this.GrossTotalPaymentLabel.Size = new System.Drawing.Size(72, 13);
            this.GrossTotalPaymentLabel.TabIndex = 0;
            this.GrossTotalPaymentLabel.Text = "Gross Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Name = "Sales";
            this.Text = "Sales";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PaymentsGroupBox.ResumeLayout(false);
            this.PaymentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GrossTotalTextLabel;
        private System.Windows.Forms.Label GrossTotalLabel;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
        private System.Windows.Forms.GroupBox PaymentsGroupBox;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.ComboBox PaymentTypeCB;
        private System.Windows.Forms.TextBox TotalDiscountTxt;
        private System.Windows.Forms.TextBox AmountGivenTxt;
        private System.Windows.Forms.TextBox ChangetoGiveTxt;
        private System.Windows.Forms.TextBox GrossTotalTxt;
        private System.Windows.Forms.Label ChangetoGiveLabel;
        private System.Windows.Forms.Label AmountGivenLabel;
        private System.Windows.Forms.Label TotalDiscountLabel;
        private System.Windows.Forms.Label GrossTotalPaymentLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PaymentTypeLabel;
        public System.Windows.Forms.Button CheckoutBtn;
    }
}