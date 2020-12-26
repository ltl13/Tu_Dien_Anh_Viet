namespace GUI {
    partial class UserControl_UserDashboard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label_NewPass = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.textBox_Confirm = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_NewPassConfirm = new System.Windows.Forms.Label();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Upload = new System.Windows.Forms.Button();
            this.pictureBox_UserPic = new System.Windows.Forms.PictureBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.panel_Header.SuspendLayout();
            this.panel_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.MaximumSize = new System.Drawing.Size(650, 120);
            this.label_Title.MinimumSize = new System.Drawing.Size(650, 120);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(650, 120);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "label_Title";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.label_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(10, 10);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(650, 120);
            this.panel_Header.TabIndex = 9;
            // 
            // label_NewPass
            // 
            this.label_NewPass.AutoSize = true;
            this.label_NewPass.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label_NewPass.Location = new System.Drawing.Point(28, 120);
            this.label_NewPass.Name = "label_NewPass";
            this.label_NewPass.Size = new System.Drawing.Size(161, 29);
            this.label_NewPass.TabIndex = 3;
            this.label_NewPass.Text = "New Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(33, 72);
            this.textBox_Password.MaxLength = 64;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(230, 28);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_NewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NewPass.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPass.Location = new System.Drawing.Point(33, 152);
            this.textBox_NewPass.MaxLength = 64;
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.Size = new System.Drawing.Size(230, 28);
            this.textBox_NewPass.TabIndex = 7;
            this.textBox_NewPass.UseSystemPasswordChar = true;
            // 
            // textBox_Confirm
            // 
            this.textBox_Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Confirm.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Confirm.Location = new System.Drawing.Point(33, 242);
            this.textBox_Confirm.MaxLength = 64;
            this.textBox_Confirm.Name = "textBox_Confirm";
            this.textBox_Confirm.Size = new System.Drawing.Size(230, 28);
            this.textBox_Confirm.TabIndex = 8;
            this.textBox_Confirm.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(28, 40);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(111, 29);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // label_NewPassConfirm
            // 
            this.label_NewPassConfirm.AutoSize = true;
            this.label_NewPassConfirm.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label_NewPassConfirm.Location = new System.Drawing.Point(28, 210);
            this.label_NewPassConfirm.Name = "label_NewPassConfirm";
            this.label_NewPassConfirm.Size = new System.Drawing.Size(98, 29);
            this.label_NewPassConfirm.TabIndex = 4;
            this.label_NewPassConfirm.Text = "Confirm:";
            // 
            // panel_Footer
            // 
            this.panel_Footer.Controls.Add(this.button_Save);
            this.panel_Footer.Controls.Add(this.button_Upload);
            this.panel_Footer.Controls.Add(this.pictureBox_UserPic);
            this.panel_Footer.Controls.Add(this.textBox_Name);
            this.panel_Footer.Controls.Add(this.textBox_Confirm);
            this.panel_Footer.Controls.Add(this.textBox_NewPass);
            this.panel_Footer.Controls.Add(this.textBox_Password);
            this.panel_Footer.Controls.Add(this.label_Name);
            this.panel_Footer.Controls.Add(this.label_NewPassConfirm);
            this.panel_Footer.Controls.Add(this.label_Password);
            this.panel_Footer.Controls.Add(this.label_NewPass);
            this.panel_Footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Footer.Location = new System.Drawing.Point(10, 130);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Size = new System.Drawing.Size(650, 415);
            this.panel_Footer.TabIndex = 9;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(516, 361);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(119, 34);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_Upload
            // 
            this.button_Upload.Location = new System.Drawing.Point(340, 361);
            this.button_Upload.Name = "button_Upload";
            this.button_Upload.Size = new System.Drawing.Size(119, 34);
            this.button_Upload.TabIndex = 11;
            this.button_Upload.Text = "Upload";
            this.button_Upload.UseVisualStyleBackColor = true;
            // 
            // pictureBox_UserPic
            // 
            this.pictureBox_UserPic.BackColor = System.Drawing.Color.White;
            this.pictureBox_UserPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_UserPic.Image = global::GUI.Properties.Resources.user_picture;
            this.pictureBox_UserPic.InitialImage = global::GUI.Properties.Resources.user_picture;
            this.pictureBox_UserPic.Location = new System.Drawing.Point(340, 40);
            this.pictureBox_UserPic.Name = "pictureBox_UserPic";
            this.pictureBox_UserPic.Size = new System.Drawing.Size(295, 295);
            this.pictureBox_UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UserPic.TabIndex = 6;
            this.pictureBox_UserPic.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(33, 322);
            this.textBox_Name.MaxLength = 20;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(230, 28);
            this.textBox_Name.TabIndex = 10;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label_Name.Location = new System.Drawing.Point(28, 290);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(78, 29);
            this.label_Name.TabIndex = 9;
            this.label_Name.Text = "Name:";
            // 
            // UserControl_UserDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Footer);
            this.Controls.Add(this.panel_Header);
            this.Name = "UserControl_UserDashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(670, 555);
            this.VisibleChanged += new System.EventHandler(this.UserControl_UserDashboard_VisibleChanged);
            this.panel_Header.ResumeLayout(false);
            this.panel_Footer.ResumeLayout(false);
            this.panel_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label_NewPass;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_UserPic;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.TextBox textBox_Confirm;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_NewPassConfirm;
        private System.Windows.Forms.Panel panel_Footer;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Upload;
    }
}
