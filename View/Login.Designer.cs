namespace IMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.userNameEmpErrLabel = new System.Windows.Forms.Label();
            this.passwordEmpErrLabel = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.Loginbtn);
            this.LeftPanel.Controls.Add(this.Passwordtxt);
            this.LeftPanel.Controls.Add(this.PasswordLabel);
            this.LeftPanel.Controls.Add(this.UserNametxt);
            this.LeftPanel.Controls.Add(this.UserNameLabel);
            this.LeftPanel.Controls.Add(this.userNameEmpErrLabel);
            this.LeftPanel.Controls.Add(this.passwordEmpErrLabel);
            this.LeftPanel.Size = new System.Drawing.Size(200, 538);
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            this.LeftPanel.Controls.SetChildIndex(this.passwordEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.userNameEmpErrLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LeftPanelTop, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserNameLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserNametxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PasswordLabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Passwordtxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Loginbtn, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.button1);
            this.RightPanel.Size = new System.Drawing.Size(767, 538);
            this.RightPanel.Controls.SetChildIndex(this.TopRigthPanel, 0);
            this.RightPanel.Controls.SetChildIndex(this.button1, 0);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.Size = new System.Drawing.Size(767, 40);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserNameLabel.Location = new System.Drawing.Point(12, 130);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Username";
            // 
            // UserNametxt
            // 
            this.UserNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.Location = new System.Drawing.Point(12, 146);
            this.UserNametxt.MaxLength = 20;
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(182, 22);
            this.UserNametxt.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 193);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(12, 210);
            this.Passwordtxt.MaxLength = 20;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(182, 22);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // userNameEmpErrLabel
            // 
            this.userNameEmpErrLabel.AutoSize = true;
            this.userNameEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.userNameEmpErrLabel.Location = new System.Drawing.Point(69, 132);
            this.userNameEmpErrLabel.Name = "userNameEmpErrLabel";
            this.userNameEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.userNameEmpErrLabel.TabIndex = 7;
            this.userNameEmpErrLabel.Text = "*";
            this.userNameEmpErrLabel.Visible = false;
            // 
            // passwordEmpErrLabel
            // 
            this.passwordEmpErrLabel.AutoSize = true;
            this.passwordEmpErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEmpErrLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordEmpErrLabel.Location = new System.Drawing.Point(70, 196);
            this.passwordEmpErrLabel.Name = "passwordEmpErrLabel";
            this.passwordEmpErrLabel.Size = new System.Drawing.Size(15, 18);
            this.passwordEmpErrLabel.TabIndex = 8;
            this.passwordEmpErrLabel.Text = "*";
            this.passwordEmpErrLabel.Visible = false;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Loginbtn.ForeColor = System.Drawing.Color.Black;
            this.Loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("Loginbtn.Image")));
            this.Loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loginbtn.Location = new System.Drawing.Point(32, 254);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(132, 36);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::IMS.Properties.Resources.homescreen;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(767, 498);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 538);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label userNameEmpErrLabel;
        private System.Windows.Forms.Label passwordEmpErrLabel;
        private System.Windows.Forms.Button button1;
    }
}