namespace GUI
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.metroStyleManager_FormMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.label_Search = new System.Windows.Forms.Label();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.panel_Exam = new System.Windows.Forms.Panel();
            this.label_Exam = new System.Windows.Forms.Label();
            this.pictureBox_Exam = new System.Windows.Forms.PictureBox();
            this.panel_ComboWord = new System.Windows.Forms.Panel();
            this.label_ComboWord = new System.Windows.Forms.Label();
            this.pictureBox_ComboWord = new System.Windows.Forms.PictureBox();
            this.panel_FlashCard = new System.Windows.Forms.Panel();
            this.label_FlashCard = new System.Windows.Forms.Label();
            this.pictureBox_FlashCard = new System.Windows.Forms.PictureBox();
            this.panel_Translate = new System.Windows.Forms.Panel();
            this.label_Translate = new System.Windows.Forms.Label();
            this.pictureBox_Translate = new System.Windows.Forms.PictureBox();
            this.panel_Game = new System.Windows.Forms.Panel();
            this.label_Game = new System.Windows.Forms.Label();
            this.pictureBox_Game = new System.Windows.Forms.PictureBox();
            this.panel_Account = new System.Windows.Forms.Panel();
            this.xuiButton_Account = new XanderUI.XUIButton();
            this.xuiButton_UpdateInfo = new XanderUI.XUIButton();
            this.xuiButton_FindUser = new XanderUI.XUIButton();
            this.xuiButton_ListAccount = new XanderUI.XUIButton();
            this.xuiButton_DeleteAccount = new XanderUI.XUIButton();
            this.xuiButton_Logout = new XanderUI.XUIButton();
            this.timer_MenuAccount = new System.Windows.Forms.Timer(this.components);
            this.xuiSwitch_Language = new XanderUI.XUISwitch();
            this.label_English = new System.Windows.Forms.Label();
            this.label_Vietnamese = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Choice = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Language = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).BeginInit();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.panel_Exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).BeginInit();
            this.panel_ComboWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).BeginInit();
            this.panel_FlashCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FlashCard)).BeginInit();
            this.panel_Translate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Translate)).BeginInit();
            this.panel_Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).BeginInit();
            this.panel_Account.SuspendLayout();
            this.panel_Choice.SuspendLayout();
            this.panel_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager_FormMain
            // 
            this.metroStyleManager_FormMain.Owner = null;
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(861, 5);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(35, 35);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.LightCyan;
            this.panel_Search.Controls.Add(this.label_Search);
            this.panel_Search.Controls.Add(this.pictureBox_Search);
            this.panel_Search.Location = new System.Drawing.Point(0, 0);
            this.panel_Search.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Search.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(206, 77);
            this.panel_Search.TabIndex = 6;
            // 
            // label_Search
            // 
            this.label_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Search.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(77, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(129, 77);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Tra từ";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Search_MouseDown);
            this.label_Search.MouseEnter += new System.EventHandler(this.label_Search_MouseEnter);
            this.label_Search.MouseLeave += new System.EventHandler(this.label_Search_MouseLeave);
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Search.Image = global::GUI.Properties.Resources.list_searching_variant;
            this.pictureBox_Search.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Search.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox_Search.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Search.TabIndex = 0;
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Search_MouseDown);
            this.pictureBox_Search.MouseEnter += new System.EventHandler(this.pictureBox_Search_MouseEnter);
            this.pictureBox_Search.MouseLeave += new System.EventHandler(this.pictureBox_Search_MouseLeave);
            // 
            // panel_Exam
            // 
            this.panel_Exam.BackColor = System.Drawing.Color.LightCyan;
            this.panel_Exam.Controls.Add(this.label_Exam);
            this.panel_Exam.Controls.Add(this.pictureBox_Exam);
            this.panel_Exam.Location = new System.Drawing.Point(0, 360);
            this.panel_Exam.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Exam.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Exam.Name = "panel_Exam";
            this.panel_Exam.Size = new System.Drawing.Size(206, 77);
            this.panel_Exam.TabIndex = 7;
            // 
            // label_Exam
            // 
            this.label_Exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Exam.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exam.Location = new System.Drawing.Point(77, 0);
            this.label_Exam.Name = "label_Exam";
            this.label_Exam.Size = new System.Drawing.Size(129, 77);
            this.label_Exam.TabIndex = 3;
            this.label_Exam.Text = "Luyện tập";
            this.label_Exam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Exam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Exam_MouseDown);
            this.label_Exam.MouseEnter += new System.EventHandler(this.label_Exam_MouseEnter);
            this.label_Exam.MouseLeave += new System.EventHandler(this.label_Exam_MouseLeave);
            // 
            // pictureBox_Exam
            // 
            this.pictureBox_Exam.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Exam.Image = global::GUI.Properties.Resources.exam;
            this.pictureBox_Exam.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Exam.Name = "pictureBox_Exam";
            this.pictureBox_Exam.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_Exam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Exam.TabIndex = 2;
            this.pictureBox_Exam.TabStop = false;
            this.pictureBox_Exam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Exam_MouseDown);
            this.pictureBox_Exam.MouseEnter += new System.EventHandler(this.pictureBox_Exam_MouseEnter);
            this.pictureBox_Exam.MouseLeave += new System.EventHandler(this.pictureBox_Exam_MouseLeave);
            // 
            // panel_ComboWord
            // 
            this.panel_ComboWord.BackColor = System.Drawing.Color.LightCyan;
            this.panel_ComboWord.Controls.Add(this.label_ComboWord);
            this.panel_ComboWord.Controls.Add(this.pictureBox_ComboWord);
            this.panel_ComboWord.Location = new System.Drawing.Point(0, 180);
            this.panel_ComboWord.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_ComboWord.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_ComboWord.Name = "panel_ComboWord";
            this.panel_ComboWord.Size = new System.Drawing.Size(206, 77);
            this.panel_ComboWord.TabIndex = 8;
            // 
            // label_ComboWord
            // 
            this.label_ComboWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ComboWord.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ComboWord.Location = new System.Drawing.Point(77, 0);
            this.label_ComboWord.Name = "label_ComboWord";
            this.label_ComboWord.Size = new System.Drawing.Size(129, 77);
            this.label_ComboWord.TabIndex = 3;
            this.label_ComboWord.Text = "Từ vựng";
            this.label_ComboWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ComboWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_ComboWord_MouseDown);
            this.label_ComboWord.MouseEnter += new System.EventHandler(this.label_ComboWord_MouseEnter);
            this.label_ComboWord.MouseLeave += new System.EventHandler(this.label_ComboWord_MouseLeave);
            // 
            // pictureBox_ComboWord
            // 
            this.pictureBox_ComboWord.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_ComboWord.Image = global::GUI.Properties.Resources.book;
            this.pictureBox_ComboWord.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ComboWord.Name = "pictureBox_ComboWord";
            this.pictureBox_ComboWord.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_ComboWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_ComboWord.TabIndex = 2;
            this.pictureBox_ComboWord.TabStop = false;
            this.pictureBox_ComboWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ComboWord_MouseDown);
            this.pictureBox_ComboWord.MouseEnter += new System.EventHandler(this.pictureBox_ComboWord_MouseEnter);
            this.pictureBox_ComboWord.MouseLeave += new System.EventHandler(this.pictureBox_ComboWord_MouseLeave);
            // 
            // panel_FlashCard
            // 
            this.panel_FlashCard.BackColor = System.Drawing.Color.LightCyan;
            this.panel_FlashCard.Controls.Add(this.label_FlashCard);
            this.panel_FlashCard.Controls.Add(this.pictureBox_FlashCard);
            this.panel_FlashCard.Location = new System.Drawing.Point(0, 270);
            this.panel_FlashCard.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_FlashCard.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_FlashCard.Name = "panel_FlashCard";
            this.panel_FlashCard.Size = new System.Drawing.Size(206, 77);
            this.panel_FlashCard.TabIndex = 9;
            // 
            // label_FlashCard
            // 
            this.label_FlashCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FlashCard.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FlashCard.Location = new System.Drawing.Point(77, 0);
            this.label_FlashCard.Name = "label_FlashCard";
            this.label_FlashCard.Size = new System.Drawing.Size(129, 77);
            this.label_FlashCard.TabIndex = 3;
            this.label_FlashCard.Text = "Flash card";
            this.label_FlashCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_FlashCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_FlashCard_MouseDown);
            this.label_FlashCard.MouseEnter += new System.EventHandler(this.label_FlashCard_MouseEnter);
            this.label_FlashCard.MouseLeave += new System.EventHandler(this.label_FlashCard_MouseLeave);
            // 
            // pictureBox_FlashCard
            // 
            this.pictureBox_FlashCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_FlashCard.Image = global::GUI.Properties.Resources.stationery_stack;
            this.pictureBox_FlashCard.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_FlashCard.Name = "pictureBox_FlashCard";
            this.pictureBox_FlashCard.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_FlashCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_FlashCard.TabIndex = 2;
            this.pictureBox_FlashCard.TabStop = false;
            this.pictureBox_FlashCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_FlashCard_MouseDown);
            this.pictureBox_FlashCard.MouseEnter += new System.EventHandler(this.pictureBox_FlashCard_MouseEnter);
            this.pictureBox_FlashCard.MouseLeave += new System.EventHandler(this.pictureBox_FlashCard_MouseLeave);
            // 
            // panel_Translate
            // 
            this.panel_Translate.BackColor = System.Drawing.Color.LightCyan;
            this.panel_Translate.Controls.Add(this.label_Translate);
            this.panel_Translate.Controls.Add(this.pictureBox_Translate);
            this.panel_Translate.Location = new System.Drawing.Point(0, 90);
            this.panel_Translate.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Translate.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Translate.Name = "panel_Translate";
            this.panel_Translate.Size = new System.Drawing.Size(206, 77);
            this.panel_Translate.TabIndex = 10;
            // 
            // label_Translate
            // 
            this.label_Translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Translate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Translate.Location = new System.Drawing.Point(77, 0);
            this.label_Translate.Name = "label_Translate";
            this.label_Translate.Size = new System.Drawing.Size(129, 77);
            this.label_Translate.TabIndex = 3;
            this.label_Translate.Text = "Dịch";
            this.label_Translate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Translate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Translate_MouseDown);
            this.label_Translate.MouseEnter += new System.EventHandler(this.label_Translate_MouseEnter);
            this.label_Translate.MouseLeave += new System.EventHandler(this.label_Translate_MouseLeave);
            // 
            // pictureBox_Translate
            // 
            this.pictureBox_Translate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Translate.Image = global::GUI.Properties.Resources.translation;
            this.pictureBox_Translate.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Translate.Name = "pictureBox_Translate";
            this.pictureBox_Translate.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_Translate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Translate.TabIndex = 2;
            this.pictureBox_Translate.TabStop = false;
            this.pictureBox_Translate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Translate_MouseDown);
            this.pictureBox_Translate.MouseEnter += new System.EventHandler(this.pictureBox_Translate_MouseEnter);
            this.pictureBox_Translate.MouseLeave += new System.EventHandler(this.pictureBox_Translate_MouseLeave);
            // 
            // panel_Game
            // 
            this.panel_Game.BackColor = System.Drawing.Color.LightCyan;
            this.panel_Game.Controls.Add(this.label_Game);
            this.panel_Game.Controls.Add(this.pictureBox_Game);
            this.panel_Game.Location = new System.Drawing.Point(0, 450);
            this.panel_Game.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Game.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.Size = new System.Drawing.Size(206, 77);
            this.panel_Game.TabIndex = 11;
            // 
            // label_Game
            // 
            this.label_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Game.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Game.Location = new System.Drawing.Point(77, 0);
            this.label_Game.Name = "label_Game";
            this.label_Game.Size = new System.Drawing.Size(129, 77);
            this.label_Game.TabIndex = 3;
            this.label_Game.Text = "Game";
            this.label_Game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Game_MouseDown);
            this.label_Game.MouseEnter += new System.EventHandler(this.label_Game_MouseEnter);
            this.label_Game.MouseLeave += new System.EventHandler(this.label_Game_MouseLeave);
            // 
            // pictureBox_Game
            // 
            this.pictureBox_Game.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Game.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Game.Image")));
            this.pictureBox_Game.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Game.Name = "pictureBox_Game";
            this.pictureBox_Game.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_Game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Game.TabIndex = 2;
            this.pictureBox_Game.TabStop = false;
            this.pictureBox_Game.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Game_MouseDown);
            this.pictureBox_Game.MouseEnter += new System.EventHandler(this.pictureBox_Game_MouseEnter);
            this.pictureBox_Game.MouseLeave += new System.EventHandler(this.pictureBox_Game_MouseLeave);
            // 
            // panel_Account
            // 
            this.panel_Account.BackColor = System.Drawing.Color.White;
            this.panel_Account.Controls.Add(this.xuiButton_Account);
            this.panel_Account.Controls.Add(this.xuiButton_UpdateInfo);
            this.panel_Account.Controls.Add(this.xuiButton_FindUser);
            this.panel_Account.Controls.Add(this.xuiButton_ListAccount);
            this.panel_Account.Controls.Add(this.xuiButton_DeleteAccount);
            this.panel_Account.Controls.Add(this.xuiButton_Logout);
            this.panel_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel_Account.Location = new System.Drawing.Point(10, 12);
            this.panel_Account.MaximumSize = new System.Drawing.Size(206, 200);
            this.panel_Account.MinimumSize = new System.Drawing.Size(206, 25);
            this.panel_Account.Name = "panel_Account";
            this.panel_Account.Size = new System.Drawing.Size(206, 25);
            this.panel_Account.TabIndex = 12;
            this.panel_Account.MouseEnter += new System.EventHandler(this.panel_Account_MouseEnter);
            this.panel_Account.MouseLeave += new System.EventHandler(this.panel_Account_MouseLeave);
            // 
            // xuiButton_Account
            // 
            this.xuiButton_Account.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_Account.ButtonImage = global::GUI.Properties.Resources.user;
            this.xuiButton_Account.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Account.ButtonText = "Quản lí tài khoản";
            this.xuiButton_Account.ClickBackColor = System.Drawing.SystemColors.Highlight;
            this.xuiButton_Account.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton_Account.CornerRadius = 5;
            this.xuiButton_Account.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_Account.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Account.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_Account.HoverTextColor = System.Drawing.Color.Black;
            this.xuiButton_Account.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Account.Location = new System.Drawing.Point(0, 0);
            this.xuiButton_Account.Name = "xuiButton_Account";
            this.xuiButton_Account.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_Account.TabIndex = 0;
            this.xuiButton_Account.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Account.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Account.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_Account_MouseDown);
            this.xuiButton_Account.MouseLeave += new System.EventHandler(this.xuiButton_Account_MouseLeave);
            // 
            // xuiButton_UpdateInfo
            // 
            this.xuiButton_UpdateInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_UpdateInfo.ButtonImage = global::GUI.Properties.Resources.update;
            this.xuiButton_UpdateInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_UpdateInfo.ButtonText = "Update infomation";
            this.xuiButton_UpdateInfo.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_UpdateInfo.CornerRadius = 5;
            this.xuiButton_UpdateInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_UpdateInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_UpdateInfo.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_UpdateInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_UpdateInfo.Location = new System.Drawing.Point(0, 35);
            this.xuiButton_UpdateInfo.Name = "xuiButton_UpdateInfo";
            this.xuiButton_UpdateInfo.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_UpdateInfo.TabIndex = 1;
            this.xuiButton_UpdateInfo.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_UpdateInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_UpdateInfo_MouseDown);
            this.xuiButton_UpdateInfo.MouseEnter += new System.EventHandler(this.xuiButton_UpdateInfo_MouseEnter);
            this.xuiButton_UpdateInfo.MouseLeave += new System.EventHandler(this.xuiButton_UpdateInfo_MouseLeave);
            // 
            // xuiButton_FindUser
            // 
            this.xuiButton_FindUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_FindUser.ButtonImage = global::GUI.Properties.Resources.find_user;
            this.xuiButton_FindUser.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_FindUser.ButtonText = "Find user";
            this.xuiButton_FindUser.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_FindUser.CornerRadius = 5;
            this.xuiButton_FindUser.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_FindUser.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_FindUser.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_FindUser.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_FindUser.Location = new System.Drawing.Point(0, 70);
            this.xuiButton_FindUser.Name = "xuiButton_FindUser";
            this.xuiButton_FindUser.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_FindUser.TabIndex = 2;
            this.xuiButton_FindUser.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_FindUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_FindUser_MouseDown);
            this.xuiButton_FindUser.MouseEnter += new System.EventHandler(this.xuiButton_FindUser_MouseEnter);
            this.xuiButton_FindUser.MouseLeave += new System.EventHandler(this.xuiButton_FindUser_MouseLeave);
            // 
            // xuiButton_ListAccount
            // 
            this.xuiButton_ListAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_ListAccount.ButtonImage = global::GUI.Properties.Resources.to_do_list;
            this.xuiButton_ListAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_ListAccount.ButtonText = "List account";
            this.xuiButton_ListAccount.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_ListAccount.CornerRadius = 5;
            this.xuiButton_ListAccount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_ListAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ListAccount.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_ListAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_ListAccount.Location = new System.Drawing.Point(0, 105);
            this.xuiButton_ListAccount.Name = "xuiButton_ListAccount";
            this.xuiButton_ListAccount.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_ListAccount.TabIndex = 4;
            this.xuiButton_ListAccount.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ListAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_ListAccount_MouseDown);
            this.xuiButton_ListAccount.MouseEnter += new System.EventHandler(this.xuiButton_ListAccount_MouseEnter);
            this.xuiButton_ListAccount.MouseLeave += new System.EventHandler(this.xuiButton_ListAccount_MouseLeave);
            // 
            // xuiButton_DeleteAccount
            // 
            this.xuiButton_DeleteAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_DeleteAccount.ButtonImage = global::GUI.Properties.Resources.delete_user;
            this.xuiButton_DeleteAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_DeleteAccount.ButtonText = "Delete account";
            this.xuiButton_DeleteAccount.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_DeleteAccount.CornerRadius = 5;
            this.xuiButton_DeleteAccount.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_DeleteAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_DeleteAccount.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_DeleteAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_DeleteAccount.Location = new System.Drawing.Point(0, 140);
            this.xuiButton_DeleteAccount.Name = "xuiButton_DeleteAccount";
            this.xuiButton_DeleteAccount.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_DeleteAccount.TabIndex = 3;
            this.xuiButton_DeleteAccount.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_DeleteAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_DeleteAccount_MouseDown);
            this.xuiButton_DeleteAccount.MouseEnter += new System.EventHandler(this.xuiButton_DeleteAccount_MouseEnter);
            this.xuiButton_DeleteAccount.MouseLeave += new System.EventHandler(this.xuiButton_DeleteAccount_MouseLeave);
            // 
            // xuiButton_Logout
            // 
            this.xuiButton_Logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_Logout.ButtonImage = global::GUI.Properties.Resources.sign_out;
            this.xuiButton_Logout.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Logout.ButtonText = "Logout";
            this.xuiButton_Logout.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Logout.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_Logout.CornerRadius = 5;
            this.xuiButton_Logout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_Logout.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Logout.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Logout.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_Logout.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Logout.Location = new System.Drawing.Point(0, 175);
            this.xuiButton_Logout.Name = "xuiButton_Logout";
            this.xuiButton_Logout.Size = new System.Drawing.Size(205, 25);
            this.xuiButton_Logout.TabIndex = 5;
            this.xuiButton_Logout.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Logout.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Logout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xuiButton_Logout_MouseClick);
            this.xuiButton_Logout.MouseEnter += new System.EventHandler(this.xuiButton_Logout_MouseEnter);
            this.xuiButton_Logout.MouseLeave += new System.EventHandler(this.xuiButton_Logout_MouseLeave);
            // 
            // timer_MenuAccount
            // 
            this.timer_MenuAccount.Interval = 1;
            this.timer_MenuAccount.Tick += new System.EventHandler(this.timer_MenuAccount_Tick);
            // 
            // xuiSwitch_Language
            // 
            this.xuiSwitch_Language.BackColor = System.Drawing.Color.Transparent;
            this.xuiSwitch_Language.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiSwitch_Language.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.xuiSwitch_Language.Location = new System.Drawing.Point(28, -1);
            this.xuiSwitch_Language.Name = "xuiSwitch_Language";
            this.xuiSwitch_Language.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiSwitch_Language.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSwitch_Language.Size = new System.Drawing.Size(70, 33);
            this.xuiSwitch_Language.SwitchState = XanderUI.XUISwitch.State.On;
            this.xuiSwitch_Language.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitch_Language.TabIndex = 13;
            this.xuiSwitch_Language.Text = "xuiSwitch1";
            this.xuiSwitch_Language.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiSwitch_Language_MouseDown);
            // 
            // label_English
            // 
            this.label_English.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_English.Location = new System.Drawing.Point(99, 0);
            this.label_English.Name = "label_English";
            this.label_English.Size = new System.Drawing.Size(37, 33);
            this.label_English.TabIndex = 14;
            this.label_English.Text = "EN";
            this.label_English.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Vietnamese
            // 
            this.label_Vietnamese.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Vietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Vietnamese.Location = new System.Drawing.Point(0, 0);
            this.label_Vietnamese.Name = "label_Vietnamese";
            this.label_Vietnamese.Size = new System.Drawing.Size(27, 33);
            this.label_Vietnamese.TabIndex = 15;
            this.label_Vietnamese.Text = "VI";
            this.label_Vietnamese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title
            // 
            this.label_Title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(348, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(200, 35);
            this.label_Title.TabIndex = 16;
            this.label_Title.Text = "Daily Dictionary";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Choice
            // 
            this.panel_Choice.Controls.Add(this.panel_Search);
            this.panel_Choice.Controls.Add(this.panel_Translate);
            this.panel_Choice.Controls.Add(this.panel_ComboWord);
            this.panel_Choice.Controls.Add(this.panel_FlashCard);
            this.panel_Choice.Controls.Add(this.panel_Exam);
            this.panel_Choice.Controls.Add(this.panel_Game);
            this.panel_Choice.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Choice.Location = new System.Drawing.Point(10, 45);
            this.panel_Choice.Name = "panel_Choice";
            this.panel_Choice.Size = new System.Drawing.Size(206, 555);
            this.panel_Choice.TabIndex = 18;
            // 
            // panel_Main
            // 
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(216, 45);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(670, 555);
            this.panel_Main.TabIndex = 19;
            // 
            // panel_Language
            // 
            this.panel_Language.Controls.Add(this.label_Vietnamese);
            this.panel_Language.Controls.Add(this.label_English);
            this.panel_Language.Controls.Add(this.xuiSwitch_Language);
            this.panel_Language.Location = new System.Drawing.Point(703, 9);
            this.panel_Language.Name = "panel_Language";
            this.panel_Language.Size = new System.Drawing.Size(136, 33);
            this.panel_Language.TabIndex = 20;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Account);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Choice);
            this.Controls.Add(this.panel_Language);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_Title);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(896, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(896, 610);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(10, 45, 10, 10);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).EndInit();
            this.panel_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.panel_Exam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).EndInit();
            this.panel_ComboWord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).EndInit();
            this.panel_FlashCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FlashCard)).EndInit();
            this.panel_Translate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Translate)).EndInit();
            this.panel_Game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).EndInit();
            this.panel_Account.ResumeLayout(false);
            this.panel_Choice.ResumeLayout(false);
            this.panel_Language.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager_FormMain;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Panel panel_Exam;
        private System.Windows.Forms.Panel panel_ComboWord;
        private System.Windows.Forms.Panel panel_FlashCard;
        private System.Windows.Forms.Panel panel_Translate;
        private System.Windows.Forms.Panel panel_Game;
        private System.Windows.Forms.Panel panel_Account;
        private System.Windows.Forms.Timer timer_MenuAccount;
        private XanderUI.XUIButton xuiButton_Logout;
        private XanderUI.XUISwitch xuiSwitch_Language;
        private System.Windows.Forms.Label label_English;
        private System.Windows.Forms.Label label_Vietnamese;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.PictureBox pictureBox_Exam;
        private System.Windows.Forms.PictureBox pictureBox_ComboWord;
        private System.Windows.Forms.PictureBox pictureBox_FlashCard;
        private System.Windows.Forms.PictureBox pictureBox_Game;
        private System.Windows.Forms.Label label_Exam;
        private System.Windows.Forms.Label label_ComboWord;
        private System.Windows.Forms.Label label_FlashCard;
        private System.Windows.Forms.Label label_Translate;
        private System.Windows.Forms.PictureBox pictureBox_Translate;
        private System.Windows.Forms.Label label_Game;
        private System.Windows.Forms.Panel panel_Choice;
        private System.Windows.Forms.Label label_Search;
        public System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Language;
        public XanderUI.XUIButton xuiButton_UpdateInfo;
        public XanderUI.XUIButton xuiButton_FindUser;
        public XanderUI.XUIButton xuiButton_DeleteAccount;
        public XanderUI.XUIButton xuiButton_ListAccount;
        public XanderUI.XUIButton xuiButton_Account;
    }
}

