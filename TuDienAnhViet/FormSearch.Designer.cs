namespace TuDienAnhViet
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.buttonFlashcard = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonComboWord = new System.Windows.Forms.Button();
            this.buttonGrammar = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.timerSearchList = new System.Windows.Forms.Timer(this.components);
            this.panelSearchbox = new System.Windows.Forms.Panel();
            this.lsbListSearch = new System.Windows.Forms.ListBox();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.panelListRead = new System.Windows.Forms.Panel();
            this.listboxRead = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelGrammar = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBai18 = new System.Windows.Forms.Button();
            this.buttonBai17 = new System.Windows.Forms.Button();
            this.buttonBai20 = new System.Windows.Forms.Button();
            this.buttonBai19 = new System.Windows.Forms.Button();
            this.buttonBai10 = new System.Windows.Forms.Button();
            this.buttonBai9 = new System.Windows.Forms.Button();
            this.buttonBai8 = new System.Windows.Forms.Button();
            this.buttonBai7 = new System.Windows.Forms.Button();
            this.buttonBai6 = new System.Windows.Forms.Button();
            this.buttonBai5 = new System.Windows.Forms.Button();
            this.buttonBai4 = new System.Windows.Forms.Button();
            this.buttonBai3 = new System.Windows.Forms.Button();
            this.buttonBai2 = new System.Windows.Forms.Button();
            this.buttonBai1 = new System.Windows.Forms.Button();
            this.buttonBai11 = new System.Windows.Forms.Button();
            this.buttonBai14 = new System.Windows.Forms.Button();
            this.buttonBai13 = new System.Windows.Forms.Button();
            this.buttonBai12 = new System.Windows.Forms.Button();
            this.buttonBai15 = new System.Windows.Forms.Button();
            this.buttonBai16 = new System.Windows.Forms.Button();
            this.panelComboWords = new System.Windows.Forms.Panel();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radiobuttonCW1 = new System.Windows.Forms.RadioButton();
            this.splitcontainerFlashcard = new System.Windows.Forms.SplitContainer();
            this.buttonFlashcardAdd = new System.Windows.Forms.Button();
            this.panelSearchToAdd = new System.Windows.Forms.Panel();
            this.listboxSearchToAdd = new System.Windows.Forms.ListBox();
            this.textboxSearchToAdd = new System.Windows.Forms.TextBox();
            this.buttonMyFlashcard_Learn = new System.Windows.Forms.Button();
            this.buttonMyFlashcard_Delete = new System.Windows.Forms.Button();
            this.buttonMyFlashcard_Clear = new System.Windows.Forms.Button();
            this.listboxMyFlashcard = new System.Windows.Forms.ListBox();
            this.labelMyFlashcard = new System.Windows.Forms.Label();
            this.panelSelect.SuspendLayout();
            this.panelSearchbox.SuspendLayout();
            this.panelListRead.SuspendLayout();
            this.tableLayoutPanelGrammar.SuspendLayout();
            this.panelComboWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerFlashcard)).BeginInit();
            this.splitcontainerFlashcard.Panel1.SuspendLayout();
            this.splitcontainerFlashcard.Panel2.SuspendLayout();
            this.splitcontainerFlashcard.SuspendLayout();
            this.panelSearchToAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.Orchid;
            this.panelSelect.Controls.Add(this.buttonFlashcard);
            this.panelSelect.Controls.Add(this.buttonTest);
            this.panelSelect.Controls.Add(this.buttonComboWord);
            this.panelSelect.Controls.Add(this.buttonGrammar);
            this.panelSelect.Controls.Add(this.buttonRead);
            this.panelSelect.Controls.Add(this.buttonSearch);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 0);
            this.panelSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(220, 476);
            this.panelSelect.TabIndex = 2;
            // 
            // buttonFlashcard
            // 
            this.buttonFlashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlashcard.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.buttonFlashcard.FlatAppearance.BorderSize = 0;
            this.buttonFlashcard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFlashcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFlashcard.Location = new System.Drawing.Point(0, 285);
            this.buttonFlashcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFlashcard.Name = "buttonFlashcard";
            this.buttonFlashcard.Size = new System.Drawing.Size(220, 57);
            this.buttonFlashcard.TabIndex = 9;
            this.buttonFlashcard.Text = "Flash card";
            this.buttonFlashcard.UseVisualStyleBackColor = true;
            this.buttonFlashcard.Click += new System.EventHandler(this.buttonFlashcard_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.buttonTest.FlatAppearance.BorderSize = 0;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTest.Location = new System.Drawing.Point(0, 228);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(220, 57);
            this.buttonTest.TabIndex = 8;
            this.buttonTest.Text = "Luyện tập";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // buttonComboWord
            // 
            this.buttonComboWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonComboWord.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.buttonComboWord.FlatAppearance.BorderSize = 0;
            this.buttonComboWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComboWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonComboWord.Location = new System.Drawing.Point(0, 171);
            this.buttonComboWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComboWord.Name = "buttonComboWord";
            this.buttonComboWord.Size = new System.Drawing.Size(220, 57);
            this.buttonComboWord.TabIndex = 7;
            this.buttonComboWord.Text = "Bộ từ vựng";
            this.buttonComboWord.UseVisualStyleBackColor = true;
            this.buttonComboWord.Click += new System.EventHandler(this.buttonComboWord_Click);
            // 
            // buttonGrammar
            // 
            this.buttonGrammar.BackColor = System.Drawing.Color.Orchid;
            this.buttonGrammar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGrammar.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.buttonGrammar.FlatAppearance.BorderSize = 0;
            this.buttonGrammar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGrammar.Location = new System.Drawing.Point(0, 114);
            this.buttonGrammar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGrammar.Name = "buttonGrammar";
            this.buttonGrammar.Size = new System.Drawing.Size(220, 57);
            this.buttonGrammar.TabIndex = 6;
            this.buttonGrammar.Text = "Ngữ pháp";
            this.buttonGrammar.UseVisualStyleBackColor = false;
            this.buttonGrammar.Click += new System.EventHandler(this.buttonGrammar_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Orchid;
            this.buttonRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRead.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.buttonRead.FlatAppearance.BorderSize = 0;
            this.buttonRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRead.Location = new System.Drawing.Point(0, 57);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(220, 57);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Bài đọc";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Orchid;
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(220, 57);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tra từ";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // timerSearchList
            // 
            this.timerSearchList.Interval = 1;
            this.timerSearchList.Tick += new System.EventHandler(this.timerSearchList_Tick);
            // 
            // panelSearchbox
            // 
            this.panelSearchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchbox.Controls.Add(this.lsbListSearch);
            this.panelSearchbox.Controls.Add(this.rtbSearch);
            this.panelSearchbox.Location = new System.Drawing.Point(345, 111);
            this.panelSearchbox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelSearchbox.MaximumSize = new System.Drawing.Size(337, 279);
            this.panelSearchbox.MinimumSize = new System.Drawing.Size(337, 30);
            this.panelSearchbox.Name = "panelSearchbox";
            this.panelSearchbox.Size = new System.Drawing.Size(337, 30);
            this.panelSearchbox.TabIndex = 1;
            // 
            // lsbListSearch
            // 
            this.lsbListSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsbListSearch.FormattingEnabled = true;
            this.lsbListSearch.ItemHeight = 25;
            this.lsbListSearch.Location = new System.Drawing.Point(0, 35);
            this.lsbListSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbListSearch.MaximumSize = new System.Drawing.Size(337, 278);
            this.lsbListSearch.MinimumSize = new System.Drawing.Size(337, 4);
            this.lsbListSearch.Name = "lsbListSearch";
            this.lsbListSearch.Size = new System.Drawing.Size(337, 254);
            this.lsbListSearch.TabIndex = 1;
            this.lsbListSearch.Click += new System.EventHandler(this.lsbListSearch_Click);
            // 
            // rtbSearch
            // 
            this.rtbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbSearch.Location = new System.Drawing.Point(0, 0);
            this.rtbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSearch.MaxLength = 50;
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(337, 35);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.Text = "";
            this.rtbSearch.Click += new System.EventHandler(this.rtbSearch_Click);
            this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
            // 
            // panelListRead
            // 
            this.panelListRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListRead.Controls.Add(this.listboxRead);
            this.panelListRead.Location = new System.Drawing.Point(368, 71);
            this.panelListRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelListRead.Name = "panelListRead";
            this.panelListRead.Size = new System.Drawing.Size(285, 326);
            this.panelListRead.TabIndex = 0;
            // 
            // listboxRead
            // 
            this.listboxRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.listboxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listboxRead.FormattingEnabled = true;
            this.listboxRead.ItemHeight = 25;
            this.listboxRead.Location = new System.Drawing.Point(0, 0);
            this.listboxRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxRead.Name = "listboxRead";
            this.listboxRead.Size = new System.Drawing.Size(285, 326);
            this.listboxRead.TabIndex = 0;
            // 
            // tableLayoutPanelGrammar
            // 
            this.tableLayoutPanelGrammar.ColumnCount = 4;
            this.tableLayoutPanelGrammar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGrammar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGrammar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGrammar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai18, 0, 4);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai17, 0, 4);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai20, 0, 4);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai19, 0, 4);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai10, 1, 2);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai9, 0, 2);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai8, 3, 1);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai7, 2, 1);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai6, 1, 1);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai5, 0, 1);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai4, 3, 0);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai3, 2, 0);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai2, 1, 0);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai1, 0, 0);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai11, 2, 2);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai14, 1, 3);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai13, 0, 3);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai12, 3, 2);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai15, 2, 3);
            this.tableLayoutPanelGrammar.Controls.Add(this.buttonBai16, 3, 3);
            this.tableLayoutPanelGrammar.Location = new System.Drawing.Point(249, 12);
            this.tableLayoutPanelGrammar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelGrammar.Name = "tableLayoutPanelGrammar";
            this.tableLayoutPanelGrammar.RowCount = 5;
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGrammar.Size = new System.Drawing.Size(527, 453);
            this.tableLayoutPanelGrammar.TabIndex = 3;
            this.tableLayoutPanelGrammar.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelGrammar_Paint);
            // 
            // buttonBai18
            // 
            this.buttonBai18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai18.Location = new System.Drawing.Point(147, 379);
            this.buttonBai18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai18.Name = "buttonBai18";
            this.buttonBai18.Size = new System.Drawing.Size(99, 55);
            this.buttonBai18.TabIndex = 19;
            this.buttonBai18.Text = "Bài 18";
            this.buttonBai18.UseVisualStyleBackColor = true;
            // 
            // buttonBai17
            // 
            this.buttonBai17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai17.Location = new System.Drawing.Point(16, 379);
            this.buttonBai17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai17.Name = "buttonBai17";
            this.buttonBai17.Size = new System.Drawing.Size(99, 55);
            this.buttonBai17.TabIndex = 18;
            this.buttonBai17.Text = "Bài 17";
            this.buttonBai17.UseVisualStyleBackColor = true;
            // 
            // buttonBai20
            // 
            this.buttonBai20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai20.Location = new System.Drawing.Point(410, 379);
            this.buttonBai20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai20.Name = "buttonBai20";
            this.buttonBai20.Size = new System.Drawing.Size(99, 55);
            this.buttonBai20.TabIndex = 17;
            this.buttonBai20.Text = "Bài 20";
            this.buttonBai20.UseVisualStyleBackColor = true;
            // 
            // buttonBai19
            // 
            this.buttonBai19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai19.Location = new System.Drawing.Point(278, 379);
            this.buttonBai19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai19.Name = "buttonBai19";
            this.buttonBai19.Size = new System.Drawing.Size(99, 55);
            this.buttonBai19.TabIndex = 12;
            this.buttonBai19.Text = "Bài 19";
            this.buttonBai19.UseVisualStyleBackColor = true;
            // 
            // buttonBai10
            // 
            this.buttonBai10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai10.Location = new System.Drawing.Point(147, 197);
            this.buttonBai10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai10.Name = "buttonBai10";
            this.buttonBai10.Size = new System.Drawing.Size(99, 55);
            this.buttonBai10.TabIndex = 9;
            this.buttonBai10.Text = "Bài 10";
            this.buttonBai10.UseVisualStyleBackColor = true;
            // 
            // buttonBai9
            // 
            this.buttonBai9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai9.Location = new System.Drawing.Point(16, 197);
            this.buttonBai9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai9.Name = "buttonBai9";
            this.buttonBai9.Size = new System.Drawing.Size(99, 55);
            this.buttonBai9.TabIndex = 8;
            this.buttonBai9.Text = "Bài 9";
            this.buttonBai9.UseVisualStyleBackColor = true;
            // 
            // buttonBai8
            // 
            this.buttonBai8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai8.Location = new System.Drawing.Point(410, 107);
            this.buttonBai8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai8.Name = "buttonBai8";
            this.buttonBai8.Size = new System.Drawing.Size(99, 55);
            this.buttonBai8.TabIndex = 7;
            this.buttonBai8.Text = "Bài 8";
            this.buttonBai8.UseVisualStyleBackColor = true;
            // 
            // buttonBai7
            // 
            this.buttonBai7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai7.Location = new System.Drawing.Point(278, 107);
            this.buttonBai7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai7.Name = "buttonBai7";
            this.buttonBai7.Size = new System.Drawing.Size(99, 55);
            this.buttonBai7.TabIndex = 6;
            this.buttonBai7.Text = "Bài 7";
            this.buttonBai7.UseVisualStyleBackColor = true;
            // 
            // buttonBai6
            // 
            this.buttonBai6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai6.Location = new System.Drawing.Point(147, 107);
            this.buttonBai6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai6.Name = "buttonBai6";
            this.buttonBai6.Size = new System.Drawing.Size(99, 55);
            this.buttonBai6.TabIndex = 5;
            this.buttonBai6.Text = "Bài 6";
            this.buttonBai6.UseVisualStyleBackColor = true;
            // 
            // buttonBai5
            // 
            this.buttonBai5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai5.Location = new System.Drawing.Point(16, 107);
            this.buttonBai5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai5.Name = "buttonBai5";
            this.buttonBai5.Size = new System.Drawing.Size(99, 55);
            this.buttonBai5.TabIndex = 4;
            this.buttonBai5.Text = "Bài 5";
            this.buttonBai5.UseVisualStyleBackColor = true;
            // 
            // buttonBai4
            // 
            this.buttonBai4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai4.Location = new System.Drawing.Point(410, 17);
            this.buttonBai4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai4.Name = "buttonBai4";
            this.buttonBai4.Size = new System.Drawing.Size(99, 55);
            this.buttonBai4.TabIndex = 3;
            this.buttonBai4.Text = "Bài 4";
            this.buttonBai4.UseVisualStyleBackColor = true;
            // 
            // buttonBai3
            // 
            this.buttonBai3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai3.Location = new System.Drawing.Point(278, 17);
            this.buttonBai3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai3.Name = "buttonBai3";
            this.buttonBai3.Size = new System.Drawing.Size(99, 55);
            this.buttonBai3.TabIndex = 2;
            this.buttonBai3.Text = "Bài 3";
            this.buttonBai3.UseVisualStyleBackColor = true;
            // 
            // buttonBai2
            // 
            this.buttonBai2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai2.Location = new System.Drawing.Point(147, 17);
            this.buttonBai2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai2.Name = "buttonBai2";
            this.buttonBai2.Size = new System.Drawing.Size(99, 55);
            this.buttonBai2.TabIndex = 1;
            this.buttonBai2.Text = "Bài 2";
            this.buttonBai2.UseVisualStyleBackColor = true;
            // 
            // buttonBai1
            // 
            this.buttonBai1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai1.Location = new System.Drawing.Point(16, 17);
            this.buttonBai1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai1.Name = "buttonBai1";
            this.buttonBai1.Size = new System.Drawing.Size(99, 55);
            this.buttonBai1.TabIndex = 0;
            this.buttonBai1.Text = "Bài 1";
            this.buttonBai1.UseVisualStyleBackColor = true;
            // 
            // buttonBai11
            // 
            this.buttonBai11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai11.Location = new System.Drawing.Point(278, 197);
            this.buttonBai11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai11.Name = "buttonBai11";
            this.buttonBai11.Size = new System.Drawing.Size(99, 55);
            this.buttonBai11.TabIndex = 10;
            this.buttonBai11.Text = "Bài 11";
            this.buttonBai11.UseVisualStyleBackColor = true;
            // 
            // buttonBai14
            // 
            this.buttonBai14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai14.Location = new System.Drawing.Point(147, 287);
            this.buttonBai14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai14.Name = "buttonBai14";
            this.buttonBai14.Size = new System.Drawing.Size(99, 55);
            this.buttonBai14.TabIndex = 14;
            this.buttonBai14.Text = "Bài 14";
            this.buttonBai14.UseVisualStyleBackColor = true;
            // 
            // buttonBai13
            // 
            this.buttonBai13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai13.Location = new System.Drawing.Point(16, 287);
            this.buttonBai13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai13.Name = "buttonBai13";
            this.buttonBai13.Size = new System.Drawing.Size(99, 55);
            this.buttonBai13.TabIndex = 13;
            this.buttonBai13.Text = "Bài 13";
            this.buttonBai13.UseVisualStyleBackColor = true;
            // 
            // buttonBai12
            // 
            this.buttonBai12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai12.Location = new System.Drawing.Point(410, 197);
            this.buttonBai12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai12.Name = "buttonBai12";
            this.buttonBai12.Size = new System.Drawing.Size(99, 55);
            this.buttonBai12.TabIndex = 11;
            this.buttonBai12.Text = "Bài 12";
            this.buttonBai12.UseVisualStyleBackColor = true;
            // 
            // buttonBai15
            // 
            this.buttonBai15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai15.Location = new System.Drawing.Point(278, 287);
            this.buttonBai15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai15.Name = "buttonBai15";
            this.buttonBai15.Size = new System.Drawing.Size(99, 55);
            this.buttonBai15.TabIndex = 15;
            this.buttonBai15.Text = "Bài 15";
            this.buttonBai15.UseVisualStyleBackColor = true;
            // 
            // buttonBai16
            // 
            this.buttonBai16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai16.Location = new System.Drawing.Point(410, 287);
            this.buttonBai16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBai16.Name = "buttonBai16";
            this.buttonBai16.Size = new System.Drawing.Size(99, 55);
            this.buttonBai16.TabIndex = 16;
            this.buttonBai16.Text = "Bài 16";
            this.buttonBai16.UseVisualStyleBackColor = true;
            // 
            // panelComboWords
            // 
            this.panelComboWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComboWords.Controls.Add(this.buttonPractice);
            this.panelComboWords.Controls.Add(this.buttonLearn);
            this.panelComboWords.Controls.Add(this.radioButton4);
            this.panelComboWords.Controls.Add(this.radioButton3);
            this.panelComboWords.Controls.Add(this.radioButton2);
            this.panelComboWords.Controls.Add(this.radioButton1);
            this.panelComboWords.Controls.Add(this.radiobuttonCW1);
            this.panelComboWords.Location = new System.Drawing.Point(345, 57);
            this.panelComboWords.Name = "panelComboWords";
            this.panelComboWords.Size = new System.Drawing.Size(337, 349);
            this.panelComboWords.TabIndex = 4;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPractice.Location = new System.Drawing.Point(200, 291);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(133, 46);
            this.buttonPractice.TabIndex = 15;
            this.buttonPractice.Text = "Luyện tập";
            this.buttonPractice.UseVisualStyleBackColor = true;
            // 
            // buttonLearn
            // 
            this.buttonLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLearn.Location = new System.Drawing.Point(0, 291);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(133, 46);
            this.buttonLearn.TabIndex = 14;
            this.buttonLearn.Text = "Học từ";
            this.buttonLearn.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioButton4.Location = new System.Drawing.Point(0, 220);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.radioButton4.Size = new System.Drawing.Size(337, 55);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Irregular Verbs";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioButton3.Location = new System.Drawing.Point(0, 165);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.radioButton3.Size = new System.Drawing.Size(337, 55);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TOEFL Words";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioButton2.Location = new System.Drawing.Point(0, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.radioButton2.Size = new System.Drawing.Size(337, 55);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TOEIC Words";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioButton1.Location = new System.Drawing.Point(0, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.radioButton1.Size = new System.Drawing.Size(337, 55);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IELTS Words";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radiobuttonCW1
            // 
            this.radiobuttonCW1.AutoSize = true;
            this.radiobuttonCW1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radiobuttonCW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radiobuttonCW1.Location = new System.Drawing.Point(0, 0);
            this.radiobuttonCW1.Name = "radiobuttonCW1";
            this.radiobuttonCW1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.radiobuttonCW1.Size = new System.Drawing.Size(337, 55);
            this.radiobuttonCW1.TabIndex = 9;
            this.radiobuttonCW1.TabStop = true;
            this.radiobuttonCW1.Text = "3000 Oxford Words";
            this.radiobuttonCW1.UseVisualStyleBackColor = true;
            // 
            // splitcontainerFlashcard
            // 
            this.splitcontainerFlashcard.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitcontainerFlashcard.Location = new System.Drawing.Point(220, 0);
            this.splitcontainerFlashcard.Name = "splitcontainerFlashcard";
            // 
            // splitcontainerFlashcard.Panel1
            // 
            this.splitcontainerFlashcard.Panel1.Controls.Add(this.buttonFlashcardAdd);
            this.splitcontainerFlashcard.Panel1.Controls.Add(this.panelSearchToAdd);
            // 
            // splitcontainerFlashcard.Panel2
            // 
            this.splitcontainerFlashcard.Panel2.Controls.Add(this.buttonMyFlashcard_Learn);
            this.splitcontainerFlashcard.Panel2.Controls.Add(this.buttonMyFlashcard_Delete);
            this.splitcontainerFlashcard.Panel2.Controls.Add(this.buttonMyFlashcard_Clear);
            this.splitcontainerFlashcard.Panel2.Controls.Add(this.listboxMyFlashcard);
            this.splitcontainerFlashcard.Panel2.Controls.Add(this.labelMyFlashcard);
            this.splitcontainerFlashcard.Size = new System.Drawing.Size(573, 476);
            this.splitcontainerFlashcard.SplitterDistance = 365;
            this.splitcontainerFlashcard.TabIndex = 5;
            // 
            // buttonFlashcardAdd
            // 
            this.buttonFlashcardAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFlashcardAdd.Location = new System.Drawing.Point(151, 359);
            this.buttonFlashcardAdd.Name = "buttonFlashcardAdd";
            this.buttonFlashcardAdd.Size = new System.Drawing.Size(66, 34);
            this.buttonFlashcardAdd.TabIndex = 0;
            this.buttonFlashcardAdd.Text = "Add";
            this.buttonFlashcardAdd.UseVisualStyleBackColor = true;
            // 
            // panelSearchToAdd
            // 
            this.panelSearchToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchToAdd.Controls.Add(this.listboxSearchToAdd);
            this.panelSearchToAdd.Controls.Add(this.textboxSearchToAdd);
            this.panelSearchToAdd.Location = new System.Drawing.Point(53, 89);
            this.panelSearchToAdd.Name = "panelSearchToAdd";
            this.panelSearchToAdd.Size = new System.Drawing.Size(257, 237);
            this.panelSearchToAdd.TabIndex = 0;
            // 
            // listboxSearchToAdd
            // 
            this.listboxSearchToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxSearchToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listboxSearchToAdd.FormattingEnabled = true;
            this.listboxSearchToAdd.ItemHeight = 25;
            this.listboxSearchToAdd.Location = new System.Drawing.Point(0, 30);
            this.listboxSearchToAdd.Name = "listboxSearchToAdd";
            this.listboxSearchToAdd.Size = new System.Drawing.Size(257, 207);
            this.listboxSearchToAdd.TabIndex = 1;
            // 
            // textboxSearchToAdd
            // 
            this.textboxSearchToAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxSearchToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxSearchToAdd.Location = new System.Drawing.Point(0, 0);
            this.textboxSearchToAdd.Name = "textboxSearchToAdd";
            this.textboxSearchToAdd.Size = new System.Drawing.Size(257, 30);
            this.textboxSearchToAdd.TabIndex = 0;
            // 
            // buttonMyFlashcard_Learn
            // 
            this.buttonMyFlashcard_Learn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMyFlashcard_Learn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMyFlashcard_Learn.Location = new System.Drawing.Point(0, 439);
            this.buttonMyFlashcard_Learn.Name = "buttonMyFlashcard_Learn";
            this.buttonMyFlashcard_Learn.Size = new System.Drawing.Size(204, 37);
            this.buttonMyFlashcard_Learn.TabIndex = 5;
            this.buttonMyFlashcard_Learn.Text = "Start";
            this.buttonMyFlashcard_Learn.UseVisualStyleBackColor = true;
            // 
            // buttonMyFlashcard_Delete
            // 
            this.buttonMyFlashcard_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMyFlashcard_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMyFlashcard_Delete.Location = new System.Drawing.Point(8, 387);
            this.buttonMyFlashcard_Delete.Name = "buttonMyFlashcard_Delete";
            this.buttonMyFlashcard_Delete.Size = new System.Drawing.Size(78, 30);
            this.buttonMyFlashcard_Delete.TabIndex = 4;
            this.buttonMyFlashcard_Delete.Text = "Delete";
            this.buttonMyFlashcard_Delete.UseVisualStyleBackColor = true;
            // 
            // buttonMyFlashcard_Clear
            // 
            this.buttonMyFlashcard_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMyFlashcard_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMyFlashcard_Clear.Location = new System.Drawing.Point(114, 387);
            this.buttonMyFlashcard_Clear.Name = "buttonMyFlashcard_Clear";
            this.buttonMyFlashcard_Clear.Size = new System.Drawing.Size(78, 30);
            this.buttonMyFlashcard_Clear.TabIndex = 3;
            this.buttonMyFlashcard_Clear.Text = "Clear";
            this.buttonMyFlashcard_Clear.UseVisualStyleBackColor = true;
            // 
            // listboxMyFlashcard
            // 
            this.listboxMyFlashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.listboxMyFlashcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listboxMyFlashcard.FormattingEnabled = true;
            this.listboxMyFlashcard.ItemHeight = 20;
            this.listboxMyFlashcard.Location = new System.Drawing.Point(0, 46);
            this.listboxMyFlashcard.Name = "listboxMyFlashcard";
            this.listboxMyFlashcard.Size = new System.Drawing.Size(204, 324);
            this.listboxMyFlashcard.TabIndex = 1;
            // 
            // labelMyFlashcard
            // 
            this.labelMyFlashcard.AutoSize = true;
            this.labelMyFlashcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.labelMyFlashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMyFlashcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelMyFlashcard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyFlashcard.Location = new System.Drawing.Point(0, 0);
            this.labelMyFlashcard.Name = "labelMyFlashcard";
            this.labelMyFlashcard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelMyFlashcard.Size = new System.Drawing.Size(194, 46);
            this.labelMyFlashcard.TabIndex = 0;
            this.labelMyFlashcard.Text = "My Flashcard";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.splitcontainerFlashcard);
            this.Controls.Add(this.panelComboWords);
            this.Controls.Add(this.panelSearchbox);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelListRead);
            this.Controls.Add(this.tableLayoutPanelGrammar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 523);
            this.Name = "FormSearch";
            this.Text = "Từ điển Anh-Việt";
            this.panelSelect.ResumeLayout(false);
            this.panelSearchbox.ResumeLayout(false);
            this.panelListRead.ResumeLayout(false);
            this.tableLayoutPanelGrammar.ResumeLayout(false);
            this.panelComboWords.ResumeLayout(false);
            this.panelComboWords.PerformLayout();
            this.splitcontainerFlashcard.Panel1.ResumeLayout(false);
            this.splitcontainerFlashcard.Panel2.ResumeLayout(false);
            this.splitcontainerFlashcard.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainerFlashcard)).EndInit();
            this.splitcontainerFlashcard.ResumeLayout(false);
            this.panelSearchToAdd.ResumeLayout(false);
            this.panelSearchToAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Timer timerSearchList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Panel panelSearchbox;
        private System.Windows.Forms.ListBox lsbListSearch;
        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.Windows.Forms.Panel panelListRead;
        private System.Windows.Forms.ListBox listboxRead;
        private System.Windows.Forms.Button buttonFlashcard;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonComboWord;
        private System.Windows.Forms.Button buttonGrammar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrammar;
        private System.Windows.Forms.Button buttonBai18;
        private System.Windows.Forms.Button buttonBai17;
        private System.Windows.Forms.Button buttonBai20;
        private System.Windows.Forms.Button buttonBai19;
        private System.Windows.Forms.Button buttonBai10;
        private System.Windows.Forms.Button buttonBai9;
        private System.Windows.Forms.Button buttonBai8;
        private System.Windows.Forms.Button buttonBai7;
        private System.Windows.Forms.Button buttonBai6;
        private System.Windows.Forms.Button buttonBai5;
        private System.Windows.Forms.Button buttonBai4;
        private System.Windows.Forms.Button buttonBai3;
        private System.Windows.Forms.Button buttonBai2;
        private System.Windows.Forms.Button buttonBai1;
        private System.Windows.Forms.Button buttonBai11;
        private System.Windows.Forms.Button buttonBai14;
        private System.Windows.Forms.Button buttonBai13;
        private System.Windows.Forms.Button buttonBai12;
        private System.Windows.Forms.Button buttonBai15;
        private System.Windows.Forms.Button buttonBai16;
        private System.Windows.Forms.Panel panelComboWords;
        private System.Windows.Forms.RadioButton radiobuttonCW1;
        private System.Windows.Forms.Button buttonPractice;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.SplitContainer splitcontainerFlashcard;
        private System.Windows.Forms.Panel panelSearchToAdd;
        private System.Windows.Forms.TextBox textboxSearchToAdd;
        private System.Windows.Forms.ListBox listboxSearchToAdd;
        private System.Windows.Forms.Button buttonFlashcardAdd;
        private System.Windows.Forms.Label labelMyFlashcard;
        private System.Windows.Forms.ListBox listboxMyFlashcard;
        private System.Windows.Forms.Button buttonMyFlashcard_Learn;
        private System.Windows.Forms.Button buttonMyFlashcard_Delete;
        private System.Windows.Forms.Button buttonMyFlashcard_Clear;
    }
}

