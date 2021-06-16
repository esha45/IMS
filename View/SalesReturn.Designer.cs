namespace IMS
{
    partial class SalesReturn
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
            this.dataGridViewSalesReturn = new System.Windows.Forms.DataGridView();
            this.SalesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerProductDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerProductTotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesIDLabel = new System.Windows.Forms.Label();
            this.SalesIDTxt = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PaymentTypeTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.RefundTxt = new System.Windows.Forms.TextBox();
            this.AmountRefundLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(817, 40);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Size = new System.Drawing.Size(125, 20);
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.BarcodeLabel);
            this.LeftPanel.Controls.Add(this.RefundTxt);
            this.LeftPanel.Controls.Add(this.AmountRefundLabel);
            this.LeftPanel.Controls.Add(this.DatePicker);
            this.LeftPanel.Controls.Add(this.UserTxt);
            this.LeftPanel.Controls.Add(this.PaymentTypeTxt);
            this.LeftPanel.Controls.Add(this.DateLabel);
            this.LeftPanel.Controls.Add(this.UserLabel);
            this.LeftPanel.Controls.Add(this.PaymentTypeLabel);
            this.LeftPanel.Controls.Add(this.LoadBtn);
            this.LeftPanel.Controls.Add(this.SalesIDTxt);
            this.LeftPanel.Controls.Add(this.SalesIDLabel);
            this.LeftPanel.Size = new System.Drawing.Size(200, 535);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SalesIDLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SalesIDTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LoadBtn, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PaymentTypeLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DateLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PaymentTypeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DatePicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AmountRefundLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.RefundTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewSalesReturn);
            this.RightPanel.Controls.Add(this.textBox2);
            this.RightPanel.Controls.Add(this.label3);
            this.RightPanel.Size = new System.Drawing.Size(817, 535);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.label3, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.textBox2, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewSalesReturn, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(817, 40);
            // 
            // dataGridViewSalesReturn
            // 
            this.dataGridViewSalesReturn.AllowUserToAddRows = false;
            this.dataGridViewSalesReturn.AllowUserToDeleteRows = false;
            this.dataGridViewSalesReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesReturn.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalesReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalesReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalesReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesIDGV,
            this.ProdIDGV,
            this.BarcodeGV,
            this.ProductNameGV,
            this.QuantityGV,
            this.ProductPriceGV,
            this.PerProductDiscountGV,
            this.PerProductTotalGV,
            this.TotalDiscountGV,
            this.TotalAmountGV,
            this.AmountGivenGV,
            this.ReturnedAmountGV,
            this.DateGV,
            this.PaymentTypeGV,
            this.UserNameGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSalesReturn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalesReturn.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewSalesReturn.Name = "dataGridViewSalesReturn";
            this.dataGridViewSalesReturn.ReadOnly = true;
            this.dataGridViewSalesReturn.RowHeadersVisible = false;
            this.dataGridViewSalesReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesReturn.Size = new System.Drawing.Size(817, 455);
            this.dataGridViewSalesReturn.TabIndex = 8;
            this.dataGridViewSalesReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesReturn_CellContentClick);
            // 
            // SalesIDGV
            // 
            this.SalesIDGV.HeaderText = "Sales ID";
            this.SalesIDGV.Name = "SalesIDGV";
            this.SalesIDGV.ReadOnly = true;
            this.SalesIDGV.Visible = false;
            // 
            // ProdIDGV
            // 
            this.ProdIDGV.HeaderText = "Product ID";
            this.ProdIDGV.Name = "ProdIDGV";
            this.ProdIDGV.ReadOnly = true;
            this.ProdIDGV.Visible = false;
            // 
            // BarcodeGV
            // 
            this.BarcodeGV.HeaderText = "Barcode";
            this.BarcodeGV.Name = "BarcodeGV";
            this.BarcodeGV.ReadOnly = true;
            // 
            // ProductNameGV
            // 
            this.ProductNameGV.HeaderText = "Product";
            this.ProductNameGV.Name = "ProductNameGV";
            this.ProductNameGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // ProductPriceGV
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.ProductPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductPriceGV.HeaderText = "Product Price";
            this.ProductPriceGV.Name = "ProductPriceGV";
            this.ProductPriceGV.ReadOnly = true;
            // 
            // PerProductDiscountGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.PerProductDiscountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PerProductDiscountGV.HeaderText = "Per Product Discount";
            this.PerProductDiscountGV.Name = "PerProductDiscountGV";
            this.PerProductDiscountGV.ReadOnly = true;
            // 
            // PerProductTotalGV
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.PerProductTotalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.PerProductTotalGV.HeaderText = "Per Product Total";
            this.PerProductTotalGV.Name = "PerProductTotalGV";
            this.PerProductTotalGV.ReadOnly = true;
            // 
            // TotalDiscountGV
            // 
            this.TotalDiscountGV.HeaderText = "Total Discount";
            this.TotalDiscountGV.Name = "TotalDiscountGV";
            this.TotalDiscountGV.ReadOnly = true;
            this.TotalDiscountGV.Visible = false;
            // 
            // TotalAmountGV
            // 
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            this.TotalAmountGV.Visible = false;
            // 
            // AmountGivenGV
            // 
            this.AmountGivenGV.HeaderText = "Amount Given";
            this.AmountGivenGV.Name = "AmountGivenGV";
            this.AmountGivenGV.ReadOnly = true;
            this.AmountGivenGV.Visible = false;
            // 
            // ReturnedAmountGV
            // 
            this.ReturnedAmountGV.HeaderText = "Returned Amount";
            this.ReturnedAmountGV.Name = "ReturnedAmountGV";
            this.ReturnedAmountGV.ReadOnly = true;
            this.ReturnedAmountGV.Visible = false;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            this.DateGV.Visible = false;
            // 
            // PaymentTypeGV
            // 
            this.PaymentTypeGV.HeaderText = "Payment Type";
            this.PaymentTypeGV.Name = "PaymentTypeGV";
            this.PaymentTypeGV.ReadOnly = true;
            this.PaymentTypeGV.Visible = false;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "User";
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            this.UserNameGV.Visible = false;
            // 
            // SalesIDLabel
            // 
            this.SalesIDLabel.AutoSize = true;
            this.SalesIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SalesIDLabel.Location = new System.Drawing.Point(13, 79);
            this.SalesIDLabel.Name = "SalesIDLabel";
            this.SalesIDLabel.Size = new System.Drawing.Size(89, 13);
            this.SalesIDLabel.TabIndex = 1;
            this.SalesIDLabel.Text = "Enter Sales ID";
            // 
            // SalesIDTxt
            // 
            this.SalesIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesIDTxt.Location = new System.Drawing.Point(13, 96);
            this.SalesIDTxt.Name = "SalesIDTxt";
            this.SalesIDTxt.Size = new System.Drawing.Size(169, 22);
            this.SalesIDTxt.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoadBtn.ForeColor = System.Drawing.Color.Black;
            this.LoadBtn.Location = new System.Drawing.Point(13, 122);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(169, 31);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PaymentTypeLabel.Location = new System.Drawing.Point(13, 270);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.PaymentTypeLabel.TabIndex = 12;
            this.PaymentTypeLabel.Text = "PaymentType";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserLabel.Location = new System.Drawing.Point(13, 225);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(33, 13);
            this.UserLabel.TabIndex = 13;
            this.UserLabel.Text = "User";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DateLabel.Location = new System.Drawing.Point(13, 180);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(34, 13);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date";
            // 
            // PaymentTypeTxt
            // 
            this.PaymentTypeTxt.Enabled = false;
            this.PaymentTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeTxt.Location = new System.Drawing.Point(16, 286);
            this.PaymentTypeTxt.Name = "PaymentTypeTxt";
            this.PaymentTypeTxt.Size = new System.Drawing.Size(169, 22);
            this.PaymentTypeTxt.TabIndex = 15;
            // 
            // UserTxt
            // 
            this.UserTxt.Enabled = false;
            this.UserTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxt.Location = new System.Drawing.Point(16, 241);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(169, 22);
            this.UserTxt.TabIndex = 16;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd-MMM-yyyy hh:mm:ss tt";
            this.DatePicker.Enabled = false;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(16, 197);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(166, 20);
            this.DatePicker.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(122, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Amount Returned";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxt.Location = new System.Drawing.Point(17, 330);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(169, 22);
            this.BarcodeTxt.TabIndex = 25;
            this.BarcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.BarcodeTxt_Validating);
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.AutoSize = true;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BarcodeLabel.Location = new System.Drawing.Point(14, 314);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(88, 13);
            this.BarcodeLabel.TabIndex = 24;
            this.BarcodeLabel.Text = "Enter Barcode";
            // 
            // RefundTxt
            // 
            this.RefundTxt.Enabled = false;
            this.RefundTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundTxt.Location = new System.Drawing.Point(16, 375);
            this.RefundTxt.Name = "RefundTxt";
            this.RefundTxt.Size = new System.Drawing.Size(169, 22);
            this.RefundTxt.TabIndex = 23;
            // 
            // AmountRefundLabel
            // 
            this.AmountRefundLabel.AutoSize = true;
            this.AmountRefundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountRefundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AmountRefundLabel.Location = new System.Drawing.Point(14, 358);
            this.AmountRefundLabel.Name = "AmountRefundLabel";
            this.AmountRefundLabel.Size = new System.Drawing.Size(113, 13);
            this.AmountRefundLabel.TabIndex = 22;
            this.AmountRefundLabel.Text = "Amount To Refund";
            // 
            // SalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 535);
            this.Name = "SalesReturn";
            this.Text = "SalesReturn";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalesReturn;
        private System.Windows.Forms.TextBox SalesIDTxt;
        private System.Windows.Forms.Label SalesIDLabel;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PaymentTypeTxt;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox RefundTxt;
        private System.Windows.Forms.Label AmountRefundLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerProductDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerProductTotalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
    }
}