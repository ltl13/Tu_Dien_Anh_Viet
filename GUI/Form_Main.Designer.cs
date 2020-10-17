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
            this.panel_Read = new System.Windows.Forms.Panel();
            this.label_Read = new System.Windows.Forms.Label();
            this.pictureBox_Read = new System.Windows.Forms.PictureBox();
            this.timer_PanelRead = new System.Windows.Forms.Timer(this.components);
            this.panel_Exam = new System.Windows.Forms.Panel();
            this.label_Exam = new System.Windows.Forms.Label();
            this.pictureBox_Exam = new System.Windows.Forms.PictureBox();
            this.timer_PanelExam = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.label_User = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.timer_LabelUser = new System.Windows.Forms.Timer(this.components);
            this.timer_PanelUser = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.panel_Search.SuspendLayout();
            this.panel_Grammar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grammar)).BeginInit();
            this.panel_ComboWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).BeginInit();
            this.panel_Flashcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flashcard)).BeginInit();
            this.panel_Read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Read)).BeginInit();
            this.panel_Exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).BeginInit();
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
            this.panel_Grammar.Location = new System.Drawing.Point(0, 157);
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
            // panel_Read
            // 
            this.panel_Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel_Read.Controls.Add(this.label_Read);
            this.panel_Read.Controls.Add(this.pictureBox_Read);
            this.panel_Read.Location = new System.Drawing.Point(0, 406);
            this.panel_Read.MaximumSize = new System.Drawing.Size(250, 77);
            this.panel_Read.MinimumSize = new System.Drawing.Size(85, 77);
            this.panel_Read.Name = "panel_Read";
            this.panel_Read.Size = new System.Drawing.Size(85, 77);
            this.panel_Read.TabIndex = 10;
            this.panel_Read.Click += new System.EventHandler(this.panel_Read_Click);
            this.panel_Read.MouseEnter += new System.EventHandler(this.panel_Read_MouseEnter);
            this.panel_Read.MouseLeave += new System.EventHandler(this.panel_Read_MouseLeave);
            // 
            // label_Read
            // 
            this.label_Read.AutoSize = true;
            this.label_Read.BackColor = System.Drawing.Color.Transparent;
            this.label_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Read.Location = new System.Drawing.Point(118, 24);
            this.label_Read.Name = "label_Read";
            this.label_Read.Size = new System.Drawing.Size(98, 29);
            this.label_Read.TabIndex = 1;
            this.label_Read.Text = "Bài đọc";
            this.label_Read.Click += new System.EventHandler(this.label_Read_Click);
            this.label_Read.MouseEnter += new System.EventHandler(this.label_Read_MouseEnter);
            // 
            // pictureBox_Read
            // 
            this.pictureBox_Read.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Read.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Read.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Read.Image")));
            this.pictureBox_Read.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Read.InitialImage")));
            this.pictureBox_Read.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Read.Name = "pictureBox_Read";
            this.pictureBox_Read.Size = new System.Drawing.Size(85, 77);
            this.pictureBox_Read.TabIndex = 0;
            this.pictureBox_Read.TabStop = false;
            this.pictureBox_Read.Click += new System.EventHandler(this.pictureBox_Read_Click);
            this.pictureBox_Read.MouseEnter += new System.EventHandler(this.pictureBox_Read_MouseEnter);
            this.pictureBox_Read.MouseLeave += new System.EventHandler(this.pictureBox_Read_MouseLeave);
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
            // pictureBox_User
            // 
            this.pictureBox_User.BackColor = System.Drawing.Color.White;
            this.pictureBox_User.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_User.Image")));
            this.pictureBox_User.Location = new System.Drawing.Point(0, 6);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(45, 41);
            this.pictureBox_User.TabIndex = 12;
            this.pictureBox_User.TabStop = false;
            this.pictureBox_User.Click += new System.EventHandler(this.pictureBox_User_Click);
            this.pictureBox_User.MouseEnter += new System.EventHandler(this.pictureBox_User_MouseEnter);
            this.pictureBox_User.MouseLeave += new System.EventHandler(this.pictureBox_User_MouseLeave);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_User.Location = new System.Drawing.Point(-135, 22);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(158, 25);
            this.label_User.TabIndex = 15;
            this.label_User.Text = "Quản lí tài khoản";
            this.label_User.Click += new System.EventHandler(this.label_User_Click);
            this.label_User.MouseEnter += new System.EventHandler(this.label_User_MouseEnter);
            this.label_User.MouseLeave += new System.EventHandler(this.label_User_MouseLeave);
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel_User.Location = new System.Drawing.Point(0, 47);
            this.panel_User.MaximumSize = new System.Drawing.Size(216, 270);
            this.panel_User.MinimumSize = new System.Drawing.Size(216, 0);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(216, 0);
            this.panel_User.TabIndex = 16;
            this.panel_User.MouseEnter += new System.EventHandler(this.panel_User_MouseEnter);
            this.panel_User.MouseLeave += new System.EventHandler(this.panel_User_MouseLeave);
            // 
            // timer_LabelUser
            // 
            this.timer_LabelUser.Interval = 1;
            this.timer_LabelUser.Tick += new System.EventHandler(this.timer_LabelUser_Tick);
            // 
            // timer_PanelUser
            // 
            this.timer_PanelUser.Interval = 1;
            this.timer_PanelUser.Tick += new System.EventHandler(this.timer_PanelUser_Tick);

            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.panel_User);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.panel_Exam);
            this.Controls.Add(this.panel_Read);
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
            this.Text = "Từ điển Anh-Việt";
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
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
            this.panel_Read.ResumeLayout(false);
            this.panel_Read.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Read)).EndInit();
            this.panel_Exam.ResumeLayout(false);
            this.panel_Exam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exam)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_Read;
        private System.Windows.Forms.Label label_Read;
        private System.Windows.Forms.PictureBox pictureBox_Read;
        private System.Windows.Forms.Timer timer_PanelRead;
        private System.Windows.Forms.Panel panel_Exam;
        private System.Windows.Forms.Label label_Exam;
        private System.Windows.Forms.PictureBox pictureBox_Exam;
        private System.Windows.Forms.Timer timer_PanelExam;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Timer timer_LabelUser;
        private System.Windows.Forms.Timer timer_PanelUser;
    }
}

