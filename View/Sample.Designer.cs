namespace IMS
{
    partial class Sample
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftPanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopRigthPanel = new System.Windows.Forms.Panel();
            this.userWelcomeLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftPanelTop.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRigthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftPanel.Controls.Add(this.LeftPanelTop);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 484);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftPanelTop
            // 
            this.LeftPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftPanelTop.Controls.Add(this.label1);
            this.LeftPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanelTop.ForeColor = System.Drawing.Color.White;
            this.LeftPanelTop.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelTop.Name = "LeftPanelTop";
            this.LeftPanelTop.Size = new System.Drawing.Size(200, 40);
            this.LeftPanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // RightPanel
            // 
            this.RightPanel.AutoSize = true;
            this.RightPanel.Controls.Add(this.TopRigthPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(200, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(784, 484);
            this.RightPanel.TabIndex = 1;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            // 
            // TopRigthPanel
            // 
            this.TopRigthPanel.BackColor = System.Drawing.Color.DarkGray;
            this.TopRigthPanel.Controls.Add(this.userWelcomeLabel);
            this.TopRigthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRigthPanel.Location = new System.Drawing.Point(0, 0);
            this.TopRigthPanel.Name = "TopRigthPanel";
            this.TopRigthPanel.Size = new System.Drawing.Size(784, 40);
            this.TopRigthPanel.TabIndex = 0;
            // 
            // userWelcomeLabel
            // 
            this.userWelcomeLabel.AutoSize = true;
            this.userWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWelcomeLabel.Location = new System.Drawing.Point(16, 8);
            this.userWelcomeLabel.Name = "userWelcomeLabel";
            this.userWelcomeLabel.Size = new System.Drawing.Size(61, 25);
            this.userWelcomeLabel.TabIndex = 0;
            this.userWelcomeLabel.Text = "User";
            this.userWelcomeLabel.Click += new System.EventHandler(this.userWelcomeLabel_Click);
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.ControlBox = false;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sample";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanelTop.ResumeLayout(false);
            this.LeftPanelTop.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.TopRigthPanel.ResumeLayout(false);
            this.TopRigthPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel LeftPanel;
        protected System.Windows.Forms.Panel LeftPanelTop;
        protected System.Windows.Forms.Panel RightPanel;
        protected System.Windows.Forms.Panel TopRigthPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userWelcomeLabel;
    }
}