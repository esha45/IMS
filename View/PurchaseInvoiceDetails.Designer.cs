namespace IMS
{
    partial class PurchaseInvoiceDetails
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
            this.SelectDateLabel = new System.Windows.Forms.Label();
            this.SelectPurchaseInvoiceLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.PurchaseInvoiceCB = new System.Windows.Forms.ComboBox();
            this.dataGridViewPurchaseInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.mPIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrossTotalTextLabel = new System.Windows.Forms.Label();
            this.GrossTotalLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseInvoiceDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.PurchaseInvoiceCB);
            this.LeftPanel.Controls.Add(this.DatePicker);
            this.LeftPanel.Controls.Add(this.SelectPurchaseInvoiceLabel);
            this.LeftPanel.Controls.Add(this.SelectDateLabel);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SelectDateLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SelectPurchaseInvoiceLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DatePicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PurchaseInvoiceCB, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel2);
            this.RightPanel.Controls.Add(this.dataGridViewPurchaseInvoiceDetails);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewPurchaseInvoiceDetails, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // SelectDateLabel
            // 
            this.SelectDateLabel.AutoSize = true;
            this.SelectDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectDateLabel.Location = new System.Drawing.Point(12, 76);
            this.SelectDateLabel.Name = "SelectDateLabel";
            this.SelectDateLabel.Size = new System.Drawing.Size(74, 13);
            this.SelectDateLabel.TabIndex = 1;
            this.SelectDateLabel.Text = "Select Date";
            // 
            // SelectPurchaseInvoiceLabel
            // 
            this.SelectPurchaseInvoiceLabel.AutoSize = true;
            this.SelectPurchaseInvoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPurchaseInvoiceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectPurchaseInvoiceLabel.Location = new System.Drawing.Point(9, 140);
            this.SelectPurchaseInvoiceLabel.Name = "SelectPurchaseInvoiceLabel";
            this.SelectPurchaseInvoiceLabel.Size = new System.Drawing.Size(146, 13);
            this.SelectPurchaseInvoiceLabel.TabIndex = 2;
            this.SelectPurchaseInvoiceLabel.Text = "Select Purchase Invoice";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "MMMM-yyy";
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(12, 93);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(178, 22);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // PurchaseInvoiceCB
            // 
            this.PurchaseInvoiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurchaseInvoiceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseInvoiceCB.FormattingEnabled = true;
            this.PurchaseInvoiceCB.Location = new System.Drawing.Point(12, 157);
            this.PurchaseInvoiceCB.Name = "PurchaseInvoiceCB";
            this.PurchaseInvoiceCB.Size = new System.Drawing.Size(178, 24);
            this.PurchaseInvoiceCB.TabIndex = 4;
            this.PurchaseInvoiceCB.SelectedIndexChanged += new System.EventHandler(this.PurchaseInvoiceCB_SelectedIndexChanged);
            // 
            // dataGridViewPurchaseInvoiceDetails
            // 
            this.dataGridViewPurchaseInvoiceDetails.AllowUserToAddRows = false;
            this.dataGridViewPurchaseInvoiceDetails.AllowUserToDeleteRows = false;
            this.dataGridViewPurchaseInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchaseInvoiceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPurchaseInvoiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurchaseInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPurchaseInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseInvoiceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mPIDgv,
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
            this.dataGridViewPurchaseInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPurchaseInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPurchaseInvoiceDetails.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewPurchaseInvoiceDetails.Name = "dataGridViewPurchaseInvoiceDetails";
            this.dataGridViewPurchaseInvoiceDetails.ReadOnly = true;
            this.dataGridViewPurchaseInvoiceDetails.RowHeadersVisible = false;
            this.dataGridViewPurchaseInvoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchaseInvoiceDetails.Size = new System.Drawing.Size(600, 289);
            this.dataGridViewPurchaseInvoiceDetails.TabIndex = 5;
            this.dataGridViewPurchaseInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseInvoiceDetails_CellClick);
            // 
            // mPIDgv
            // 
            this.mPIDgv.HeaderText = "mPID";
            this.mPIDgv.Name = "mPIDgv";
            this.mPIDgv.ReadOnly = true;
            this.mPIDgv.Visible = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.GrossTotalTextLabel);
            this.panel2.Controls.Add(this.GrossTotalLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 81);
            this.panel2.TabIndex = 6;
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
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "PurchaseInvoiceDetails";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseInvoiceDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectDateLabel;
        private System.Windows.Forms.ComboBox PurchaseInvoiceCB;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label SelectPurchaseInvoiceLabel;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseInvoiceDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GrossTotalTextLabel;
        private System.Windows.Forms.Label GrossTotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
    }
}