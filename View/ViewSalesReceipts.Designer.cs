namespace IMS
{
    partial class ViewSalesReceipts
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
            this.SelectDateTxt = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
            this.SalesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.LoadBtn);
            this.LeftPanel.Controls.Add(this.DatePicker);
            this.LeftPanel.Controls.Add(this.SelectDateTxt);
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SelectDateTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DatePicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LoadBtn, 0);
            // 
            // LeftPanelTop
            // 
            this.LeftPanelTop.Controls.Add(this.BackBtn);
            this.LeftPanelTop.Controls.SetChildIndex(this.BackBtn, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewReceipts);
            this.RightPanel.Size = new System.Drawing.Size(786, 450);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewReceipts, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(786, 40);
            // 
            // SelectDateTxt
            // 
            this.SelectDateTxt.AutoSize = true;
            this.SelectDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDateTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectDateTxt.Location = new System.Drawing.Point(13, 56);
            this.SelectDateTxt.Name = "SelectDateTxt";
            this.SelectDateTxt.Size = new System.Drawing.Size(74, 13);
            this.SelectDateTxt.TabIndex = 1;
            this.SelectDateTxt.Text = "Select Date";
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.CustomFormat = "dd-MMM-yyyy";
            this.DatePicker.Location = new System.Drawing.Point(15, 73);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(169, 20);
            this.DatePicker.TabIndex = 2;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoadBtn.ForeColor = System.Drawing.Color.Black;
            this.LoadBtn.Location = new System.Drawing.Point(15, 103);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(169, 31);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // dataGridViewReceipts
            // 
            this.dataGridViewReceipts.AllowUserToAddRows = false;
            this.dataGridViewReceipts.AllowUserToDeleteRows = false;
            this.dataGridViewReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesIDGV,
            this.UserIDGV,
            this.UserGV,
            this.TotalAmountGV,
            this.TotalDiscountGV,
            this.AmountGivenGV,
            this.ReturnedAmountGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReceipts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReceipts.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewReceipts.Name = "dataGridViewReceipts";
            this.dataGridViewReceipts.ReadOnly = true;
            this.dataGridViewReceipts.RowHeadersVisible = false;
            this.dataGridViewReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReceipts.Size = new System.Drawing.Size(786, 410);
            this.dataGridViewReceipts.TabIndex = 7;
 //           this.dataGridViewReceipts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipts_CellDoubleClick);
            // 
            // SalesIDGV
            // 
            this.SalesIDGV.HeaderText = "Sales ID";
            this.SalesIDGV.Name = "SalesIDGV";
            this.SalesIDGV.ReadOnly = true;
            // 
            // UserIDGV
            // 
            this.UserIDGV.HeaderText = "User ID";
            this.UserIDGV.Name = "UserIDGV";
            this.UserIDGV.ReadOnly = true;
            this.UserIDGV.Visible = false;
            // 
            // UserGV
            // 
            this.UserGV.HeaderText = "User";
            this.UserGV.Name = "UserGV";
            this.UserGV.ReadOnly = true;
            // 
            // TotalAmountGV
            // 
            this.TotalAmountGV.HeaderText = "Total Amount";
            this.TotalAmountGV.Name = "TotalAmountGV";
            this.TotalAmountGV.ReadOnly = true;
            // 
            // TotalDiscountGV
            // 
            this.TotalDiscountGV.HeaderText = "Total Discount";
            this.TotalDiscountGV.Name = "TotalDiscountGV";
            this.TotalDiscountGV.ReadOnly = true;
            // 
            // AmountGivenGV
            // 
            this.AmountGivenGV.HeaderText = "Amount Given";
            this.AmountGivenGV.Name = "AmountGivenGV";
            this.AmountGivenGV.ReadOnly = true;
            // 
            // ReturnedAmountGV
            // 
            this.ReturnedAmountGV.HeaderText = "Returned Amount";
            this.ReturnedAmountGV.Name = "ReturnedAmountGV";
            this.ReturnedAmountGV.ReadOnly = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = global::IMS.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(50, 40);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ViewSalesReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Name = "ViewSalesReceipts";
            this.Text = "ViewSalesReceipts";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectDateTxt;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridView dataGridViewReceipts;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedAmountGV;
    }
}