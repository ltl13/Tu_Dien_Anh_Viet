namespace GUI {
    partial class Form_Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbMotto = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbCreateNewAccount = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.xuiFlatProgressBar_Login = new XanderUI.XUIFlatProgressBar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.lbMotto);
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Controls.Add(this.icon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(290, 148);
            this.pnlHeader.TabIndex = 9;
            // 
            // lbMotto
            // 
            this.lbMotto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMotto.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotto.Location = new System.Drawing.Point(0, 98);
            this.lbMotto.Name = "lbMotto";
            this.lbMotto.Size = new System.Drawing.Size(290, 50);
            this.lbMotto.TabIndex = 2;
            this.lbMotto.Text = "Your english, your future";
            this.lbMotto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(100, 45);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(171, 29);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Daily Dictionary";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Image = global::GUI.Properties.Resources.dictionary;
            this.icon.Location = new System.Drawing.Point(30, 25);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(65, 65);
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
            this.btLogin.Location = new System.Drawing.Point(20, 221);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(115, 45);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.lbPassword.Location = new System.Drawing.Point(38, 122);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 21);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(42, 150);
            this.tbPassword.MaxLength = 64;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(216, 22);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(42, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(216, 22);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btExit.Location = new System.Drawing.Point(155, 221);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(115, 45);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lbError);
            this.pnlFooter.Controls.Add(this.lbUsername);
            this.pnlFooter.Controls.Add(this.tbUsername);
            this.pnlFooter.Controls.Add(this.lbPassword);
            this.pnlFooter.Controls.Add(this.tbPassword);
            this.pnlFooter.Controls.Add(this.btLogin);
            this.pnlFooter.Controls.Add(this.btExit);
            this.pnlFooter.Controls.Add(this.lbCreateNewAccount);
            this.pnlFooter.Controls.Add(this.pnlUsername);
            this.pnlFooter.Controls.Add(this.pnlPassword);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(20, 178);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(290, 352);
            this.pnlFooter.TabIndex = 12;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(39, 183);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(51, 17);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "lbError";
            this.lbError.Visible = false;
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            this.lbError.VisibleChanged += new System.EventHandler(this.lbError_VisibleChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.lbUsername.Location = new System.Drawing.Point(38, 30);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 21);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // lbCreateNewAccount
            // 
            this.lbCreateNewAccount.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateNewAccount.Location = new System.Drawing.Point(0, 298);
            this.lbCreateNewAccount.Name = "lbCreateNewAccount";
            this.lbCreateNewAccount.Size = new System.Drawing.Size(290, 23);
            this.lbCreateNewAccount.TabIndex = 12;
            this.lbCreateNewAccount.Text = "Create new account";
            this.lbCreateNewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCreateNewAccount.Click += new System.EventHandler(this.lbCreateNewAccount_Click);
            this.lbCreateNewAccount.MouseLeave += new System.EventHandler(this.lbCreateNewAccount_MouseLeave);
            this.lbCreateNewAccount.MouseHover += new System.EventHandler(this.lbCreateNewAccount_MouseHover);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.DarkGray;
            this.pnlUsername.Location = new System.Drawing.Point(42, 80);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(216, 1);
            this.pnlUsername.TabIndex = 2;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPassword.Location = new System.Drawing.Point(42, 172);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(216, 1);
            this.pnlPassword.TabIndex = 3;
            // 
            // xuiFlatProgressBar_Login
            // 
            this.xuiFlatProgressBar_Login.BarStyle = XanderUI.XUIFlatProgressBar.Style.Flat;
            this.xuiFlatProgressBar_Login.BarThickness = 5;
            this.xuiFlatProgressBar_Login.CompleteColor = System.Drawing.Color.LightSeaGreen;
            this.xuiFlatProgressBar_Login.InocmpletedColor = System.Drawing.Color.Transparent;
            this.xuiFlatProgressBar_Login.Location = new System.Drawing.Point(-7, 542);
            this.xuiFlatProgressBar_Login.MaxValue = 100;
            this.xuiFlatProgressBar_Login.Name = "xuiFlatProgressBar_Login";
            this.xuiFlatProgressBar_Login.Size = new System.Drawing.Size(345, 10);
            this.xuiFlatProgressBar_Login.TabIndex = 14;
            this.xuiFlatProgressBar_Login.Value = 0;
            // 
            // Form_Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(330, 550);
            this.ControlBox = false;
            this.Controls.Add(this.xuiFlatProgressBar_Login);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(330, 550);
            this.MinimumSize = new System.Drawing.Size(330, 550);
            this.Name = "Form_Login";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.VisibleChanged += new System.EventHandler(this.Form_Login_VisibleChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbMotto;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lbCreateNewAccount;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar_Login;
        private System.Windows.Forms.Label lbError;
    }
}