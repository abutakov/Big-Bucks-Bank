namespace Big_Bucks_Bank
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtErrorBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.cboShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUserId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserId.Location = new System.Drawing.Point(81, 196);
            this.txtUserId.MaxLength = 8;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(115, 20);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.TabStop = false;
            this.txtUserId.Click += new System.EventHandler(this.txtUserId_Click);
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            this.txtUserId.Leave += new System.EventHandler(this.txtUserIf_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(81, 232);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtErrorBox
            // 
            this.txtErrorBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtErrorBox.Location = new System.Drawing.Point(56, 382);
            this.txtErrorBox.Multiline = true;
            this.txtErrorBox.Name = "txtErrorBox";
            this.txtErrorBox.ReadOnly = true;
            this.txtErrorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorBox.Size = new System.Drawing.Size(166, 92);
            this.txtErrorBox.TabIndex = 3;
            this.txtErrorBox.TabStop = false;
            this.txtErrorBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(56, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(147, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(81, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(102, 333);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 9;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // cboShow
            // 
            this.cboShow.AutoSize = true;
            this.cboShow.BackColor = System.Drawing.Color.Transparent;
            this.cboShow.Location = new System.Drawing.Point(81, 259);
            this.cboShow.Name = "cboShow";
            this.cboShow.Size = new System.Drawing.Size(53, 17);
            this.cboShow.TabIndex = 10;
            this.cboShow.Text = "Show";
            this.cboShow.UseVisualStyleBackColor = false;
            this.cboShow.CheckedChanged += new System.EventHandler(this.cbChecked_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(275, 486);
            this.Controls.Add(this.cboShow);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtErrorBox);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.LoginForm_HelpButtonClicked);
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtErrorBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.CheckBox cboShow;
    }
}

