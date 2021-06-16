namespace IMS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.PhoneNotxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.NameEmpErrLabel = new System.Windows.Forms.Label();
            this.EmailEmpErrLabel = new System.Windows.Forms.Label();
            this.PhoneEmpErrLabel = new System.Windows.Forms.Label();
            this.PassEmpErrLabel = new System.Windows.Forms.Label();
            this.UsrNameEmpErrLabel = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserIDGGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusEmpErrLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.Image = global::IMS.Properties.Resources.back;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StatusComboBox);
            this.LeftPanel.Controls.Add(this.StatusLabel);
            this.LeftPanel.Controls.Add(this.Emailtxt);
            this.LeftPanel.Controls.Add(this.UserNametxt);
            this.LeftPanel.Controls.Add(this.EmailLabel);
            this.LeftPanel.Controls.Add(this.PhoneNoLabel);
            this.LeftPanel.Controls.Add(this.PasswordLabel);
            this.LeftPanel.Controls.Add(this.UserNameLabel);
            this.LeftPanel.Controls.Add(this.PhoneNotxt);
            this.LeftPanel.Controls.Add(this.Passwordtxt);
            this.LeftPanel.Controls.Add(this.Nametxt);
            this.LeftPanel.Controls.Add(this.NameLabel);
            this.LeftPanel.Controls.Add(this.NameEmpErrLabel);
            this.LeftPanel.Controls.Add(this.UsrNameEmpErrLabel);
            this.LeftPanel.Controls.Add(this.PassEmpErrLabel);
            this.LeftPanel.Controls.Add(this.PhoneEmpErrLabel);
            this.LeftPanel.Controls.Add(this.EmailEmpErrLabel);
            this.LeftPanel.Controls.Add(this.StatusEmpErrLabel);
            this.LeftPanel.Controls.SetChildIndex(this.StatusEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.EmailEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UsrNameEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Nametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Passwordtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneNotxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserNameLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PasswordLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhoneNoLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.EmailLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserNametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Emailtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusComboBox, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.dataGridViewUsers);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.panel1, 0);
            this.RightPanel.Controls.SetChildIndex(this.dataGridViewUsers, 0);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NameLabel.Location = new System.Drawing.Point(9, 89);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserNameLabel.Location = new System.Drawing.Point(9, 146);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(69, 13);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "User Name";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PasswordLabel.Location = new System.Drawing.Point(9, 204);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PhoneNoLabel.Location = new System.Drawing.Point(7, 260);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(181, 13);
            this.PhoneNoLabel.TabIndex = 4;
            this.PhoneNoLabel.Text = " Phone No, (03XX - XXXXXXX)";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(9, 315);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(37, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // Nametxt
            // 
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxt.Location = new System.Drawing.Point(12, 105);
            this.Nametxt.MaxLength = 40;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(178, 22);
            this.Nametxt.TabIndex = 0;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(12, 220);
            this.Passwordtxt.MaxLength = 20;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(178, 22);
            this.Passwordtxt.TabIndex = 2;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // PhoneNotxt
            // 
            this.PhoneNotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNotxt.Location = new System.Drawing.Point(12, 276);
            this.PhoneNotxt.MaxLength = 12;
            this.PhoneNotxt.Name = "PhoneNotxt";
            this.PhoneNotxt.Size = new System.Drawing.Size(178, 22);
            this.PhoneNotxt.TabIndex = 3;
            // 
            // UserNametxt
            // 
            this.UserNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.Location = new System.Drawing.Point(12, 162);
            this.UserNametxt.MaxLength = 30;
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(178, 22);
            this.UserNametxt.TabIndex = 1;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(12, 331);
            this.Emailtxt.MaxLength = 30;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(178, 22);
            this.Emailtxt.TabIndex = 4;
            // 
            // NameEmpErrLabel
            // 
            this.NameEmpErrLabel.AutoSize = true;
            this.NameEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.NameEmpErrLabel.Location = new System.Drawing.Point(43, 91);
            this.NameEmpErrLabel.Name = "NameEmpErrLabel";
            this.NameEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.NameEmpErrLabel.TabIndex = 6;
            this.NameEmpErrLabel.Text = "*";
            this.NameEmpErrLabel.Visible = false;
            // 
            // EmailEmpErrLabel
            // 
            this.EmailEmpErrLabel.AutoSize = true;
            this.EmailEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailEmpErrLabel.Location = new System.Drawing.Point(39, 316);
            this.EmailEmpErrLabel.Name = "EmailEmpErrLabel";
            this.EmailEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.EmailEmpErrLabel.TabIndex = 7;
            this.EmailEmpErrLabel.Text = "*";
            this.EmailEmpErrLabel.Visible = false;
            // 
            // PhoneEmpErrLabel
            // 
            this.PhoneEmpErrLabel.AutoSize = true;
            this.PhoneEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneEmpErrLabel.Location = new System.Drawing.Point(160, 261);
            this.PhoneEmpErrLabel.Name = "PhoneEmpErrLabel";
            this.PhoneEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.PhoneEmpErrLabel.TabIndex = 8;
            this.PhoneEmpErrLabel.Text = "*";
            this.PhoneEmpErrLabel.Visible = false;
            // 
            // PassEmpErrLabel
            // 
            this.PassEmpErrLabel.AutoSize = true;
            this.PassEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.PassEmpErrLabel.Location = new System.Drawing.Point(60, 206);
            this.PassEmpErrLabel.Name = "PassEmpErrLabel";
            this.PassEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.PassEmpErrLabel.TabIndex = 9;
            this.PassEmpErrLabel.Text = "*";
            this.PassEmpErrLabel.Visible = false;
            // 
            // UsrNameEmpErrLabel
            // 
            this.UsrNameEmpErrLabel.AutoSize = true;
            this.UsrNameEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrNameEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.UsrNameEmpErrLabel.Location = new System.Drawing.Point(67, 148);
            this.UsrNameEmpErrLabel.Name = "UsrNameEmpErrLabel";
            this.UsrNameEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.UsrNameEmpErrLabel.TabIndex = 10;
            this.UsrNameEmpErrLabel.Text = "*";
            this.UsrNameEmpErrLabel.Visible = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDGGV,
            this.NameGV,
            this.UserNameGV,
            this.PasswordGV,
            this.EmailGV,
            this.PhoneNoGV,
            this.StatusGV});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(600, 370);
            this.dataGridViewUsers.TabIndex = 2;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // UserIDGGV
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDGGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserIDGGV.HeaderText = "User ID";
            this.UserIDGGV.Name = "UserIDGGV";
            this.UserIDGGV.ReadOnly = true;
            this.UserIDGGV.Visible = false;
            // 
            // NameGV
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.UserNameGV.HeaderText = "User Name";
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Password";
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // EmailGV
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneNoGV
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PhoneNoGV.HeaderText = "Phone";
            this.PhoneNoGV.Name = "PhoneNoGV";
            this.PhoneNoGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StatusLabel.Location = new System.Drawing.Point(12, 374);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.StatusComboBox.Location = new System.Drawing.Point(12, 391);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(178, 24);
            this.StatusComboBox.TabIndex = 12;
            // 
            // StatusEmpErrLabel
            // 
            this.StatusEmpErrLabel.AutoSize = true;
            this.StatusEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusEmpErrLabel.Location = new System.Drawing.Point(48, 376);
            this.StatusEmpErrLabel.Name = "StatusEmpErrLabel";
            this.StatusEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.StatusEmpErrLabel.TabIndex = 13;
            this.StatusEmpErrLabel.Text = "*";
            this.StatusEmpErrLabel.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PhoneNotxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label NameEmpErrLabel;
        private System.Windows.Forms.Label UsrNameEmpErrLabel;
        private System.Windows.Forms.Label PassEmpErrLabel;
        private System.Windows.Forms.Label PhoneEmpErrLabel;
        private System.Windows.Forms.Label EmailEmpErrLabel;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusEmpErrLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDGGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}