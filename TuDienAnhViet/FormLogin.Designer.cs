namespace TuDienAnhViet {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMotto = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lbCreateNewAccount = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lbMotto);
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Controls.Add(this.icon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 190);
            this.panel3.TabIndex = 9;
            // 
            // lbMotto
            // 
            this.lbMotto.AutoSize = true;
            this.lbMotto.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotto.Location = new System.Drawing.Point(52, 123);
            this.lbMotto.Name = "lbMotto";
            this.lbMotto.Size = new System.Drawing.Size(196, 23);
            this.lbMotto.TabIndex = 2;
            this.lbMotto.Text = "Your english, your future";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(108, 76);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(135, 23);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Daily Dictionary";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(47, 63);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogin.Location = new System.Drawing.Point(27, 380);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(115, 35);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbUsername.Location = new System.Drawing.Point(50, 212);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 21);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbPassword.Location = new System.Drawing.Point(50, 302);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 21);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(42, 326);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(216, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(42, 236);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(216, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(42, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 1);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(42, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 1);
            this.panel1.TabIndex = 2;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btExit.Location = new System.Drawing.Point(158, 380);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(115, 35);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbCreateNewAccount
            // 
            this.lbCreateNewAccount.AutoSize = true;
            this.lbCreateNewAccount.Font = new System.Drawing.Font("Calibri Light", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateNewAccount.Location = new System.Drawing.Point(74, 420);
            this.lbCreateNewAccount.Name = "lbCreateNewAccount";
            this.lbCreateNewAccount.Size = new System.Drawing.Size(152, 23);
            this.lbCreateNewAccount.TabIndex = 11;
            this.lbCreateNewAccount.Text = "Create new accout";
            this.lbCreateNewAccount.Click += new System.EventHandler(this.lbCreateNewAccount_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.lbCreateNewAccount);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMotto;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbCreateNewAccount;
    }
}