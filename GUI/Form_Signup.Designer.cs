namespace GUI {
    partial class Form_Signup {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Signup));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbMotto = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.xuiFlatProgressBar_Login = new XanderUI.XUIFlatProgressBar();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.Transparent;
            this.panel_Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Header.Controls.Add(this.lbMotto);
            this.panel_Header.Controls.Add(this.lbTitle);
            this.panel_Header.Controls.Add(this.icon);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(20, 30);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(290, 148);
            this.panel_Header.TabIndex = 10;
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
            // panel_Footer
            // 
            this.panel_Footer.Controls.Add(this.lbError);
            this.panel_Footer.Controls.Add(this.tbName);
            this.panel_Footer.Controls.Add(this.pnlName);
            this.panel_Footer.Controls.Add(this.lbUsername);
            this.panel_Footer.Controls.Add(this.tbUsername);
            this.panel_Footer.Controls.Add(this.lbPassword);
            this.panel_Footer.Controls.Add(this.tbPassword);
            this.panel_Footer.Controls.Add(this.lbConfirm);
            this.panel_Footer.Controls.Add(this.tbConfirm);
            this.panel_Footer.Controls.Add(this.lbName);
            this.panel_Footer.Controls.Add(this.btRegister);
            this.panel_Footer.Controls.Add(this.btBack);
            this.panel_Footer.Controls.Add(this.pnlConfirm);
            this.panel_Footer.Controls.Add(this.pnlUsername);
            this.panel_Footer.Controls.Add(this.pnlPassword);
            this.panel_Footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Footer.Location = new System.Drawing.Point(20, 178);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Size = new System.Drawing.Size(290, 352);
            this.panel_Footer.TabIndex = 13;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(39, 281);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(51, 17);
            this.lbError.TabIndex = 15;
            this.lbError.Text = "lbError";
            this.lbError.Visible = false;
            this.lbError.TextChanged += new System.EventHandler(this.lbError_TextChanged);
            this.lbError.VisibleChanged += new System.EventHandler(this.lbError_VisibleChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(42, 248);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(216, 22);
            this.tbName.TabIndex = 3;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlName.Location = new System.Drawing.Point(42, 274);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(216, 1);
            this.pnlName.TabIndex = 14;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbUsername.Location = new System.Drawing.Point(38, 10);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 21);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(42, 38);
            this.tbUsername.MaxLength = 50;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(216, 22);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbPassword.Location = new System.Drawing.Point(38, 80);
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
            this.tbPassword.Location = new System.Drawing.Point(42, 108);
            this.tbPassword.MaxLength = 64;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(216, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseDown);
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbConfirm.Location = new System.Drawing.Point(38, 150);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(137, 21);
            this.lbConfirm.TabIndex = 11;
            this.lbConfirm.Text = "Confirm password";
            // 
            // tbConfirm
            // 
            this.tbConfirm.BackColor = System.Drawing.Color.White;
            this.tbConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirm.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(42, 178);
            this.tbConfirm.MaxLength = 64;
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(216, 22);
            this.tbConfirm.TabIndex = 2;
            this.tbConfirm.UseSystemPasswordChar = true;
            this.tbConfirm.TextChanged += new System.EventHandler(this.tbConfirm_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbName.Location = new System.Drawing.Point(38, 220);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 21);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Name";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btRegister.Location = new System.Drawing.Point(20, 303);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(115, 45);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btBack.Location = new System.Drawing.Point(155, 303);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(115, 45);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlConfirm.Location = new System.Drawing.Point(42, 204);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(216, 1);
            this.pnlConfirm.TabIndex = 4;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUsername.Location = new System.Drawing.Point(42, 60);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(216, 1);
            this.pnlUsername.TabIndex = 2;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlPassword.Location = new System.Drawing.Point(42, 130);
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
            this.xuiFlatProgressBar_Login.Location = new System.Drawing.Point(0, 541);
            this.xuiFlatProgressBar_Login.MaxValue = 100;
            this.xuiFlatProgressBar_Login.Name = "xuiFlatProgressBar_Login";
            this.xuiFlatProgressBar_Login.Size = new System.Drawing.Size(335, 10);
            this.xuiFlatProgressBar_Login.TabIndex = 16;
            this.xuiFlatProgressBar_Login.Value = 0;
            this.xuiFlatProgressBar_Login.Visible = false;
            // 
            // Form_Signup
            // 
            this.AcceptButton = this.btRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btBack;
            this.ClientSize = new System.Drawing.Size(330, 550);
            this.ControlBox = false;
            this.Controls.Add(this.xuiFlatProgressBar_Login);
            this.Controls.Add(this.panel_Footer);
            this.Controls.Add(this.panel_Header);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form_Signup";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Form_Signup";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel_Footer.ResumeLayout(false);
            this.panel_Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbMotto;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panel_Footer;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lbError;
        private XanderUI.XUIFlatProgressBar xuiFlatProgressBar_Login;
    }
}