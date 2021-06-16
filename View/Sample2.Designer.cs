namespace IMS
{
    partial class Sample2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            // 
            // LeftPanelTop
            // 
            this.LeftPanelTop.Controls.Add(this.Backbtn);
            this.LeftPanelTop.Controls.SetChildIndex(this.Backbtn, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.panel1);
            this.RightPanel.Size = new System.Drawing.Size(600, 450);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(600, 40);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.Deletebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Savebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Editbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchGroupBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewBtn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Image = global::IMS.Properties.Resources.delete;
            this.Deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebtn.Location = new System.Drawing.Point(300, 3);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(93, 34);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Image = global::IMS.Properties.Resources.save;
            this.Savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.Location = new System.Drawing.Point(201, 3);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(93, 34);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.Image = global::IMS.Properties.Resources.edit;
            this.Editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editbtn.Location = new System.Drawing.Point(102, 3);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(93, 34);
            this.Editbtn.TabIndex = 1;
            this.Editbtn.Text = "EDIT";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Image = global::IMS.Properties.Resources.add;
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.Location = new System.Drawing.Point(3, 3);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(93, 34);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.Searchtxt);
            this.SearchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(498, 3);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(99, 34);
            this.SearchGroupBox.TabIndex = 4;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            this.SearchGroupBox.Enter += new System.EventHandler(this.SearchGroupBox_Enter);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Searchtxt.Location = new System.Drawing.Point(3, 16);
            this.Searchtxt.MaxLength = 100;
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(93, 20);
            this.Searchtxt.TabIndex = 0;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // viewBtn
            // 
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Image = global::IMS.Properties.Resources.view;
            this.viewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBtn.Location = new System.Drawing.Point(399, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(93, 34);
            this.viewBtn.TabIndex = 5;
            this.viewBtn.Text = "VIEW";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Image = global::IMS.Properties.Resources.back;
            this.Backbtn.Location = new System.Drawing.Point(0, 0);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(45, 40);
            this.Backbtn.TabIndex = 0;
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Sample2";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Button Deletebtn;
        protected System.Windows.Forms.Button Savebtn;
        protected System.Windows.Forms.Button Editbtn;
        protected System.Windows.Forms.Button Addbtn;
        protected System.Windows.Forms.GroupBox SearchGroupBox;
        protected System.Windows.Forms.TextBox Searchtxt;
        protected System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button viewBtn;
    }
}