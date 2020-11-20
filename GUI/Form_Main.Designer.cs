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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroStyleManager_FormMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.timer_PanelSearch = new System.Windows.Forms.Timer(this.components);
            this.panel_Search = new System.Windows.Forms.Panel();
            this.label_Search = new System.Windows.Forms.Label();
            this.timer_MainPanel = new System.Windows.Forms.Timer(this.components);
            this.panel_Grammar = new System.Windows.Forms.Panel();
            this.label_Grammar = new System.Windows.Forms.Label();
            this.pictureBox_Grammar = new System.Windows.Forms.PictureBox();
            this.timer_PanelGrammar = new System.Windows.Forms.Timer(this.components);
            this.panel_ComboWord = new System.Windows.Forms.Panel();
            this.label_ComboWord = new System.Windows.Forms.Label();
            this.pictureBox_ComboWord = new System.Windows.Forms.PictureBox();
            this.timer_PanelComboWord = new System.Windows.Forms.Timer(this.components);
            this.panel_Flashcard = new System.Windows.Forms.Panel();
            this.label_Flashcard = new System.Windows.Forms.Label();
            this.pictureBox_Flashcard = new System.Windows.Forms.PictureBox();
            this.timer_PanelFlashcard = new System.Windows.Forms.Timer(this.components);
            this.panel_Translate = new System.Windows.Forms.Panel();
            this.label_Translate = new System.Windows.Forms.Label();
            this.pictureBox_Translate = new System.Windows.Forms.PictureBox();
            this.timer_PanelRead = new System.Windows.Forms.Timer(this.components);
            this.panel_Exam = new System.Windows.Forms.Panel();
            this.label_Exam = new System.Windows.Forms.Label();
            this.pictureBox_Exam = new System.Windows.Forms.PictureBox();
            this.timer_PanelExam = new System.Windows.Forms.Timer(this.components);
            this.panel_Account = new System.Windows.Forms.Panel();
            this.xuiButton_FindUser = new XanderUI.XUIButton();
            this.xuiButton_ListAccount = new XanderUI.XUIButton();
            this.xuiButton_DeleteAccount = new XanderUI.XUIButton();
            this.xuiButton_ResetAccount = new XanderUI.XUIButton();
            this.xuiButton_UpdateInfo = new XanderUI.XUIButton();
            this.xuiButton_Account = new XanderUI.XUIButton();
            this.timer_MenuAccount = new System.Windows.Forms.Timer(this.components);
            this.xuiSwitch_Language = new XanderUI.XUISwitch();
            this.label_English = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.panel_Search.SuspendLayout();
            this.panel_Grammar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grammar)).BeginInit();
            this.panel_ComboWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).BeginInit();
            this.panel_Flashcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flashcard)).BeginInit();
            this.panel_Translate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Translate)).BeginInit();
            this.panel_Exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).BeginInit();
            this.panel_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager_FormMain
            // 
            this.metroStyleManager_FormMain.Owner = null;
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Exit.BackColor = System.Drawing.SystemColors.Window;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Exit.Location = new System.Drawing.Point(855, 6);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(41, 38);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Location = new System.Drawing.Point(249, 74);
            this.panel_Main.MaximumSize = new System.Drawing.Size(624, 516);
            this.panel_Main.MinimumSize = new System.Drawing.Size(0, 516);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(0, 516);
            this.panel_Main.TabIndex = 5;
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.Image")));
            this.pictureBox_Search.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.InitialImage")));
            this.pictureBox_Search.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Search.TabIndex = 0;
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.Click += new System.EventHandler(this.pictureBox_Search_Click);
            this.pictureBox_Search.MouseEnter += new System.EventHandler(this.pictureBox_Search_MouseEnter);
            this.pictureBox_Search.MouseLeave += new System.EventHandler(this.pictureBox_Search_MouseLeave);
            // 
            // timer_PanelSearch
            // 
            this.timer_PanelSearch.Interval = 1;
            this.timer_PanelSearch.Tick += new System.EventHandler(this.timer_PanelSearch_Tick);
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel_Search.Controls.Add(this.label_Search);
            this.panel_Search.Controls.Add(this.pictureBox_Search);
            this.panel_Search.Location = new System.Drawing.Point(0, 74);
            this.panel_Search.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Search.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(85, 77);
            this.panel_Search.TabIndex = 6;
            this.panel_Search.Click += new System.EventHandler(this.panel_Search_Click);
            this.panel_Search.MouseEnter += new System.EventHandler(this.panel_Search_MouseEnter);
            this.panel_Search.MouseLeave += new System.EventHandler(this.panel_Search_MouseLeave);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.BackColor = System.Drawing.Color.Transparent;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Search.Location = new System.Drawing.Point(128, 24);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(78, 29);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Tra từ";
            this.label_Search.Click += new System.EventHandler(this.label_Search_Click);
            this.label_Search.MouseEnter += new System.EventHandler(this.label_Search_MouseEnter);
            // 
            // timer_MainPanel
            // 
            this.timer_MainPanel.Interval = 1;
            this.timer_MainPanel.Tick += new System.EventHandler(this.timer_MainPanel_Tick);
            // 
            // panel_Grammar
            // 
            this.panel_Grammar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(209)))));
            this.panel_Grammar.Controls.Add(this.label_Grammar);
            this.panel_Grammar.Controls.Add(this.pictureBox_Grammar);
            this.panel_Grammar.Location = new System.Drawing.Point(0, 406);
            this.panel_Grammar.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Grammar.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Grammar.Name = "panel_Grammar";
            this.panel_Grammar.Size = new System.Drawing.Size(85, 77);
            this.panel_Grammar.TabIndex = 7;
            this.panel_Grammar.Click += new System.EventHandler(this.panel_Grammar_Click);
            this.panel_Grammar.MouseEnter += new System.EventHandler(this.panel_Grammar_MouseEnter);
            this.panel_Grammar.MouseLeave += new System.EventHandler(this.panel_Grammar_MouseLeave);
            // 
            // label_Grammar
            // 
            this.label_Grammar.AutoSize = true;
            this.label_Grammar.BackColor = System.Drawing.Color.Transparent;
            this.label_Grammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Grammar.Location = new System.Drawing.Point(107, 25);
            this.label_Grammar.Name = "label_Grammar";
            this.label_Grammar.Size = new System.Drawing.Size(122, 29);
            this.label_Grammar.TabIndex = 1;
            this.label_Grammar.Text = "Ngữ pháp";
            this.label_Grammar.Click += new System.EventHandler(this.label_Grammar_Click);
            this.label_Grammar.MouseEnter += new System.EventHandler(this.label_Grammar_MouseEnter);
            // 
            // pictureBox_Grammar
            // 
            this.pictureBox_Grammar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Grammar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Grammar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Grammar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Grammar.Image")));
            this.pictureBox_Grammar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Grammar.InitialImage")));
            this.pictureBox_Grammar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Grammar.Name = "pictureBox_Grammar";
            this.pictureBox_Grammar.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Grammar.TabIndex = 0;
            this.pictureBox_Grammar.TabStop = false;
            this.pictureBox_Grammar.Click += new System.EventHandler(this.pictureBox_Grammar_Click);
            this.pictureBox_Grammar.MouseEnter += new System.EventHandler(this.pictureBox_Grammar_MouseEnter);
            this.pictureBox_Grammar.MouseLeave += new System.EventHandler(this.pictureBox_Grammar_MouseLeave);
            // 
            // timer_PanelGrammar
            // 
            this.timer_PanelGrammar.Interval = 1;
            this.timer_PanelGrammar.Tick += new System.EventHandler(this.timer_PanelGrammar_Tick);
            // 
            // panel_ComboWord
            // 
            this.panel_ComboWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(212)))));
            this.panel_ComboWord.Controls.Add(this.label_ComboWord);
            this.panel_ComboWord.Controls.Add(this.pictureBox_ComboWord);
            this.panel_ComboWord.Location = new System.Drawing.Point(0, 240);
            this.panel_ComboWord.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_ComboWord.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_ComboWord.Name = "panel_ComboWord";
            this.panel_ComboWord.Size = new System.Drawing.Size(85, 77);
            this.panel_ComboWord.TabIndex = 8;
            this.panel_ComboWord.Click += new System.EventHandler(this.panel_ComboWord_Click);
            this.panel_ComboWord.MouseEnter += new System.EventHandler(this.panel_ComboWord_MouseEnter);
            this.panel_ComboWord.MouseLeave += new System.EventHandler(this.panel_ComboWord_MouseLeave);
            // 
            // label_ComboWord
            // 
            this.label_ComboWord.AutoSize = true;
            this.label_ComboWord.BackColor = System.Drawing.Color.Transparent;
            this.label_ComboWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_ComboWord.Location = new System.Drawing.Point(100, 24);
            this.label_ComboWord.Name = "label_ComboWord";
            this.label_ComboWord.Size = new System.Drawing.Size(134, 29);
            this.label_ComboWord.TabIndex = 1;
            this.label_ComboWord.Text = "Bộ từ vựng";
            this.label_ComboWord.Click += new System.EventHandler(this.label_ComboWord_Click);
            this.label_ComboWord.MouseEnter += new System.EventHandler(this.label_ComboWord_MouseEnter);
            // 
            // pictureBox_ComboWord
            // 
            this.pictureBox_ComboWord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ComboWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_ComboWord.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_ComboWord.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ComboWord.Image")));
            this.pictureBox_ComboWord.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_ComboWord.InitialImage")));
            this.pictureBox_ComboWord.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_ComboWord.Name = "pictureBox_ComboWord";
            this.pictureBox_ComboWord.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_ComboWord.TabIndex = 0;
            this.pictureBox_ComboWord.TabStop = false;
            this.pictureBox_ComboWord.Click += new System.EventHandler(this.pictureBox_ComboWord_Click);
            this.pictureBox_ComboWord.MouseEnter += new System.EventHandler(this.pictureBox_ComboWord_MouseEnter);
            this.pictureBox_ComboWord.MouseLeave += new System.EventHandler(this.pictureBox_ComboWord_MouseLeave);
            // 
            // timer_PanelComboWord
            // 
            this.timer_PanelComboWord.Interval = 1;
            this.timer_PanelComboWord.Tick += new System.EventHandler(this.timer_PanelComboWord_Tick);
            // 
            // panel_Flashcard
            // 
            this.panel_Flashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            this.panel_Flashcard.Controls.Add(this.label_Flashcard);
            this.panel_Flashcard.Controls.Add(this.pictureBox_Flashcard);
            this.panel_Flashcard.Location = new System.Drawing.Point(0, 323);
            this.panel_Flashcard.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Flashcard.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Flashcard.Name = "panel_Flashcard";
            this.panel_Flashcard.Size = new System.Drawing.Size(85, 77);
            this.panel_Flashcard.TabIndex = 9;
            this.panel_Flashcard.Click += new System.EventHandler(this.panel_Flashcard_Click);
            this.panel_Flashcard.MouseEnter += new System.EventHandler(this.panel_Flashcard_MouseEnter);
            this.panel_Flashcard.MouseLeave += new System.EventHandler(this.panel_Flashcard_MouseLeave);
            // 
            // label_Flashcard
            // 
            this.label_Flashcard.AutoSize = true;
            this.label_Flashcard.BackColor = System.Drawing.Color.Transparent;
            this.label_Flashcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Flashcard.Location = new System.Drawing.Point(100, 24);
            this.label_Flashcard.Name = "label_Flashcard";
            this.label_Flashcard.Size = new System.Drawing.Size(137, 29);
            this.label_Flashcard.TabIndex = 1;
            this.label_Flashcard.Text = "Flashcards";
            this.label_Flashcard.Click += new System.EventHandler(this.label_Flashcard_Click);
            this.label_Flashcard.MouseEnter += new System.EventHandler(this.label_Flashcard_MouseEnter);
            // 
            // pictureBox_Flashcard
            // 
            this.pictureBox_Flashcard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Flashcard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Flashcard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Flashcard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Flashcard.Image")));
            this.pictureBox_Flashcard.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Flashcard.InitialImage")));
            this.pictureBox_Flashcard.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Flashcard.Name = "pictureBox_Flashcard";
            this.pictureBox_Flashcard.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Flashcard.TabIndex = 0;
            this.pictureBox_Flashcard.TabStop = false;
            this.pictureBox_Flashcard.Click += new System.EventHandler(this.pictureBox_Flashcard_Click);
            this.pictureBox_Flashcard.MouseEnter += new System.EventHandler(this.pictureBox_Flashcard_MouseEnter);
            this.pictureBox_Flashcard.MouseLeave += new System.EventHandler(this.pictureBox_Flashcard_MouseLeave);
            // 
            // timer_PanelFlashcard
            // 
            this.timer_PanelFlashcard.Interval = 1;
            this.timer_PanelFlashcard.Tick += new System.EventHandler(this.timer_PanelFlashcard_Tick);
            // 
            // panel_Translate
            // 
            this.panel_Translate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel_Translate.Controls.Add(this.label_Translate);
            this.panel_Translate.Controls.Add(this.pictureBox_Translate);
            this.panel_Translate.Location = new System.Drawing.Point(0, 157);
            this.panel_Translate.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Translate.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Translate.Name = "panel_Translate";
            this.panel_Translate.Size = new System.Drawing.Size(85, 77);
            this.panel_Translate.TabIndex = 10;
            this.panel_Translate.Click += new System.EventHandler(this.panel_Read_Click);
            this.panel_Translate.MouseEnter += new System.EventHandler(this.panel_Read_MouseEnter);
            this.panel_Translate.MouseLeave += new System.EventHandler(this.panel_Read_MouseLeave);
            // 
            // label_Translate
            // 
            this.label_Translate.AutoSize = true;
            this.label_Translate.BackColor = System.Drawing.Color.Transparent;
            this.label_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Translate.Location = new System.Drawing.Point(136, 20);
            this.label_Translate.Name = "label_Translate";
            this.label_Translate.Size = new System.Drawing.Size(64, 29);
            this.label_Translate.TabIndex = 1;
            this.label_Translate.Text = "Dịch";
            this.label_Translate.Click += new System.EventHandler(this.label_Read_Click);
            this.label_Translate.MouseEnter += new System.EventHandler(this.label_Read_MouseEnter);
            // 
            // pictureBox_Translate
            // 
            this.pictureBox_Translate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Translate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Translate.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Translate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Translate.Image")));
            this.pictureBox_Translate.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Translate.InitialImage")));
            this.pictureBox_Translate.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Translate.Name = "pictureBox_Translate";
            this.pictureBox_Translate.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Translate.TabIndex = 0;
            this.pictureBox_Translate.TabStop = false;
            this.pictureBox_Translate.Click += new System.EventHandler(this.pictureBox_Read_Click);
            this.pictureBox_Translate.MouseEnter += new System.EventHandler(this.pictureBox_Read_MouseEnter);
            this.pictureBox_Translate.MouseLeave += new System.EventHandler(this.pictureBox_Read_MouseLeave);
            // 
            // timer_PanelRead
            // 
            this.timer_PanelRead.Interval = 1;
            this.timer_PanelRead.Tick += new System.EventHandler(this.timer_PanelRead_Tick);
            // 
            // panel_Exam
            // 
            this.panel_Exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panel_Exam.Controls.Add(this.label_Exam);
            this.panel_Exam.Controls.Add(this.pictureBox_Exam);
            this.panel_Exam.Location = new System.Drawing.Point(0, 489);
            this.panel_Exam.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Exam.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Exam.Name = "panel_Exam";
            this.panel_Exam.Size = new System.Drawing.Size(85, 77);
            this.panel_Exam.TabIndex = 11;
            this.panel_Exam.Click += new System.EventHandler(this.panel_Exam_Click);
            this.panel_Exam.MouseEnter += new System.EventHandler(this.panel_Exam_MouseEnter);
            this.panel_Exam.MouseLeave += new System.EventHandler(this.panel_Exam_MouseLeave);
            // 
            // label_Exam
            // 
            this.label_Exam.AutoSize = true;
            this.label_Exam.BackColor = System.Drawing.Color.Transparent;
            this.label_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Exam.Location = new System.Drawing.Point(118, 24);
            this.label_Exam.Name = "label_Exam";
            this.label_Exam.Size = new System.Drawing.Size(124, 29);
            this.label_Exam.TabIndex = 1;
            this.label_Exam.Text = "Luyện tập";
            this.label_Exam.Click += new System.EventHandler(this.label_Exam_Click);
            this.label_Exam.MouseEnter += new System.EventHandler(this.label_Exam_MouseEnter);
            // 
            // pictureBox_Exam
            // 
            this.pictureBox_Exam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Exam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Exam.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Exam.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exam.Image")));
            this.pictureBox_Exam.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exam.InitialImage")));
            this.pictureBox_Exam.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Exam.Name = "pictureBox_Exam";
            this.pictureBox_Exam.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Exam.TabIndex = 0;
            this.pictureBox_Exam.TabStop = false;
            this.pictureBox_Exam.Click += new System.EventHandler(this.pictureBox_Exam_Click);
            this.pictureBox_Exam.MouseEnter += new System.EventHandler(this.pictureBox_Exam_MouseEnter);
            this.pictureBox_Exam.MouseLeave += new System.EventHandler(this.pictureBox_Exam_MouseLeave);
            // 
            // timer_PanelExam
            // 
            this.timer_PanelExam.Interval = 1;
            this.timer_PanelExam.Tick += new System.EventHandler(this.timer_PanelExam_Tick);
            // 
            // panel_Account
            // 
            this.panel_Account.BackColor = System.Drawing.Color.Transparent;
            this.panel_Account.Controls.Add(this.xuiButton_FindUser);
            this.panel_Account.Controls.Add(this.xuiButton_ListAccount);
            this.panel_Account.Controls.Add(this.xuiButton_DeleteAccount);
            this.panel_Account.Controls.Add(this.xuiButton_ResetAccount);
            this.panel_Account.Controls.Add(this.xuiButton_UpdateInfo);
            this.panel_Account.Controls.Add(this.xuiButton_Account);
            this.panel_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel_Account.Location = new System.Drawing.Point(0, 6);
            this.panel_Account.MaximumSize = new System.Drawing.Size(220, 215);
            this.panel_Account.MinimumSize = new System.Drawing.Size(220, 39);
            this.panel_Account.Name = "panel_Account";
            this.panel_Account.Size = new System.Drawing.Size(220, 39);
            this.panel_Account.TabIndex = 12;
            this.panel_Account.MouseLeave += new System.EventHandler(this.panel_Account_MouseLeave);
            // 
            // xuiButton_FindUser
            // 
            this.xuiButton_FindUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_FindUser.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_FindUser.ButtonImage")));
            this.xuiButton_FindUser.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_FindUser.ButtonText = "Find user";
            this.xuiButton_FindUser.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_FindUser.CornerRadius = 5;
            this.xuiButton_FindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_FindUser.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_FindUser.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_FindUser.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_FindUser.Location = new System.Drawing.Point(0, 171);
            this.xuiButton_FindUser.Name = "xuiButton_FindUser";
            this.xuiButton_FindUser.Size = new System.Drawing.Size(200, 25);
            this.xuiButton_FindUser.TabIndex = 5;
            this.xuiButton_FindUser.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_FindUser.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_FindUser.MouseEnter += new System.EventHandler(this.xuiButton_FindUser_MouseEnter);
            // 
            // xuiButton_ListAccount
            // 
            this.xuiButton_ListAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_ListAccount.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_ListAccount.ButtonImage")));
            this.xuiButton_ListAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_ListAccount.ButtonText = "List account";
            this.xuiButton_ListAccount.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_ListAccount.CornerRadius = 5;
            this.xuiButton_ListAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_ListAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ListAccount.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_ListAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_ListAccount.Location = new System.Drawing.Point(0, 140);
            this.xuiButton_ListAccount.Name = "xuiButton_ListAccount";
            this.xuiButton_ListAccount.Size = new System.Drawing.Size(200, 25);
            this.xuiButton_ListAccount.TabIndex = 4;
            this.xuiButton_ListAccount.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ListAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ListAccount.MouseEnter += new System.EventHandler(this.xuiButton_ListAccount_MouseEnter);
            // 
            // xuiButton_DeleteAccount
            // 
            this.xuiButton_DeleteAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_DeleteAccount.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_DeleteAccount.ButtonImage")));
            this.xuiButton_DeleteAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_DeleteAccount.ButtonText = "Delete account";
            this.xuiButton_DeleteAccount.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_DeleteAccount.CornerRadius = 5;
            this.xuiButton_DeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_DeleteAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_DeleteAccount.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_DeleteAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_DeleteAccount.Location = new System.Drawing.Point(0, 109);
            this.xuiButton_DeleteAccount.Name = "xuiButton_DeleteAccount";
            this.xuiButton_DeleteAccount.Size = new System.Drawing.Size(200, 25);
            this.xuiButton_DeleteAccount.TabIndex = 3;
            this.xuiButton_DeleteAccount.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_DeleteAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_DeleteAccount.MouseEnter += new System.EventHandler(this.xuiButton_DeleteAccount_MouseEnter);
            // 
            // xuiButton_ResetAccount
            // 
            this.xuiButton_ResetAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_ResetAccount.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_ResetAccount.ButtonImage")));
            this.xuiButton_ResetAccount.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_ResetAccount.ButtonText = "Reset password";
            this.xuiButton_ResetAccount.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ResetAccount.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_ResetAccount.CornerRadius = 5;
            this.xuiButton_ResetAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_ResetAccount.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ResetAccount.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ResetAccount.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_ResetAccount.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_ResetAccount.Location = new System.Drawing.Point(0, 78);
            this.xuiButton_ResetAccount.Name = "xuiButton_ResetAccount";
            this.xuiButton_ResetAccount.Size = new System.Drawing.Size(200, 25);
            this.xuiButton_ResetAccount.TabIndex = 2;
            this.xuiButton_ResetAccount.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_ResetAccount.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_ResetAccount.MouseEnter += new System.EventHandler(this.xuiButton_ResetAccount_MouseEnter);
            // 
            // xuiButton_UpdateInfo
            // 
            this.xuiButton_UpdateInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_UpdateInfo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_UpdateInfo.ButtonImage")));
            this.xuiButton_UpdateInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_UpdateInfo.ButtonText = "Update infomation";
            this.xuiButton_UpdateInfo.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton_UpdateInfo.CornerRadius = 5;
            this.xuiButton_UpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_UpdateInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_UpdateInfo.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_UpdateInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_UpdateInfo.Location = new System.Drawing.Point(0, 47);
            this.xuiButton_UpdateInfo.Name = "xuiButton_UpdateInfo";
            this.xuiButton_UpdateInfo.Size = new System.Drawing.Size(200, 25);
            this.xuiButton_UpdateInfo.TabIndex = 1;
            this.xuiButton_UpdateInfo.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_UpdateInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_UpdateInfo.MouseEnter += new System.EventHandler(this.xuiButton_UpdateInfo_MouseEnter);
            // 
            // xuiButton_Account
            // 
            this.xuiButton_Account.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton_Account.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Account.ButtonImage")));
            this.xuiButton_Account.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Account.ButtonText = "Quản lí tài khoản";
            this.xuiButton_Account.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_Account.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton_Account.CornerRadius = 5;
            this.xuiButton_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.xuiButton_Account.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Account.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.xuiButton_Account.HoverTextColor = System.Drawing.Color.Black;
            this.xuiButton_Account.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Account.Location = new System.Drawing.Point(0, 5);
            this.xuiButton_Account.Name = "xuiButton_Account";
            this.xuiButton_Account.Size = new System.Drawing.Size(200, 36);
            this.xuiButton_Account.TabIndex = 0;
            this.xuiButton_Account.TextColor = System.Drawing.Color.White;
            this.xuiButton_Account.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Account.Click += new System.EventHandler(this.xuiButton_Account_Click);
            this.xuiButton_Account.MouseEnter += new System.EventHandler(this.xuiButton_Account_MouseEnter);
            this.xuiButton_Account.MouseLeave += new System.EventHandler(this.xuiButton_Account_MouseLeave);
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
            this.xuiSwitch_Language.Location = new System.Drawing.Point(734, 11);
            this.xuiSwitch_Language.Name = "xuiSwitch_Language";
            this.xuiSwitch_Language.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiSwitch_Language.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSwitch_Language.Size = new System.Drawing.Size(70, 33);
            this.xuiSwitch_Language.SwitchState = XanderUI.XUISwitch.State.On;
            this.xuiSwitch_Language.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitch_Language.TabIndex = 13;
            this.xuiSwitch_Language.Text = "xuiSwitch1";
            this.xuiSwitch_Language.Click += new System.EventHandler(this.xuiSwitch_Language_Click);
            // 
            // label_English
            // 
            this.label_English.AutoSize = true;
            this.label_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_English.Location = new System.Drawing.Point(810, 16);
            this.label_English.Name = "label_English";
            this.label_English.Size = new System.Drawing.Size(37, 24);
            this.label_English.TabIndex = 14;
            this.label_English.Text = "EN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(701, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "VI";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_English);
            this.Controls.Add(this.xuiSwitch_Language);
            this.Controls.Add(this.panel_Account);
            this.Controls.Add(this.panel_Exam);
            this.Controls.Add(this.panel_Translate);
            this.Controls.Add(this.panel_Flashcard);
            this.Controls.Add(this.panel_ComboWord);
            this.Controls.Add(this.panel_Grammar);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.panel_Main);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(896, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(896, 610);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(20, 44, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.panel_Grammar.ResumeLayout(false);
            this.panel_Grammar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grammar)).EndInit();
            this.panel_ComboWord.ResumeLayout(false);
            this.panel_ComboWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).EndInit();
            this.panel_Flashcard.ResumeLayout(false);
            this.panel_Flashcard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flashcard)).EndInit();
            this.panel_Translate.ResumeLayout(false);
            this.panel_Translate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Translate)).EndInit();
            this.panel_Exam.ResumeLayout(false);
            this.panel_Exam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).EndInit();
            this.panel_Account.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager_FormMain;
        private System.Windows.Forms.Button button_Exit;
        public System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.Timer timer_PanelSearch;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Timer timer_MainPanel;
        private System.Windows.Forms.Panel panel_Grammar;
        private System.Windows.Forms.Label label_Grammar;
        private System.Windows.Forms.PictureBox pictureBox_Grammar;
        private System.Windows.Forms.Timer timer_PanelGrammar;
        private System.Windows.Forms.Panel panel_ComboWord;
        private System.Windows.Forms.Label label_ComboWord;
        private System.Windows.Forms.PictureBox pictureBox_ComboWord;
        private System.Windows.Forms.Timer timer_PanelComboWord;
        private System.Windows.Forms.Panel panel_Flashcard;
        private System.Windows.Forms.Label label_Flashcard;
        private System.Windows.Forms.PictureBox pictureBox_Flashcard;
        private System.Windows.Forms.Timer timer_PanelFlashcard;
        private System.Windows.Forms.Panel panel_Translate;
        private System.Windows.Forms.Label label_Translate;
        private System.Windows.Forms.PictureBox pictureBox_Translate;
        private System.Windows.Forms.Timer timer_PanelRead;
        private System.Windows.Forms.Panel panel_Exam;
        private System.Windows.Forms.Label label_Exam;
        private System.Windows.Forms.PictureBox pictureBox_Exam;
        private System.Windows.Forms.Timer timer_PanelExam;
        private System.Windows.Forms.Panel panel_Account;
        private XanderUI.XUIButton xuiButton_Account;
        private System.Windows.Forms.Timer timer_MenuAccount;
        private XanderUI.XUIButton xuiButton_UpdateInfo;
        private XanderUI.XUIButton xuiButton_ResetAccount;
        private XanderUI.XUIButton xuiButton_DeleteAccount;
        private XanderUI.XUIButton xuiButton_FindUser;
        private XanderUI.XUIButton xuiButton_ListAccount;
        private XanderUI.XUISwitch xuiSwitch_Language;
        private System.Windows.Forms.Label label_English;
        private System.Windows.Forms.Label label1;
    }
}

