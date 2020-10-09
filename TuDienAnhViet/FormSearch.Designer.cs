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
            this.buttonPractise = new System.Windows.Forms.Button();
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
            this.panelSelect.SuspendLayout();
            this.panelSearchbox.SuspendLayout();
            this.panelListRead.SuspendLayout();
            this.tableLayoutPanelGrammar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.Orchid;
            this.panelSelect.Controls.Add(this.buttonFlashcard);
            this.panelSelect.Controls.Add(this.buttonPractise);
            this.panelSelect.Controls.Add(this.buttonComboWord);
            this.panelSelect.Controls.Add(this.buttonGrammar);
            this.panelSelect.Controls.Add(this.buttonRead);
            this.panelSelect.Controls.Add(this.buttonSearch);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 0);
            this.panelSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(165, 388);
            this.panelSelect.TabIndex = 2;
            // 
            // buttonFlashcard
            // 
            this.buttonFlashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlashcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFlashcard.Location = new System.Drawing.Point(0, 230);
            this.buttonFlashcard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFlashcard.Name = "buttonFlashcard";
            this.buttonFlashcard.Size = new System.Drawing.Size(165, 46);
            this.buttonFlashcard.TabIndex = 9;
            this.buttonFlashcard.Text = "Flash card";
            this.buttonFlashcard.UseVisualStyleBackColor = true;
            // 
            // buttonPractise
            // 
            this.buttonPractise.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPractise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPractise.Location = new System.Drawing.Point(0, 184);
            this.buttonPractise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPractise.Name = "buttonPractise";
            this.buttonPractise.Size = new System.Drawing.Size(165, 46);
            this.buttonPractise.TabIndex = 8;
            this.buttonPractise.Text = "Luyện tập";
            this.buttonPractise.UseVisualStyleBackColor = true;
            // 
            // buttonComboWord
            // 
            this.buttonComboWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonComboWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonComboWord.Location = new System.Drawing.Point(0, 138);
            this.buttonComboWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComboWord.Name = "buttonComboWord";
            this.buttonComboWord.Size = new System.Drawing.Size(165, 46);
            this.buttonComboWord.TabIndex = 7;
            this.buttonComboWord.Text = "Bộ từ vựng";
            this.buttonComboWord.UseVisualStyleBackColor = true;
            // 
            // buttonGrammar
            // 
            this.buttonGrammar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGrammar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGrammar.Location = new System.Drawing.Point(0, 92);
            this.buttonGrammar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGrammar.Name = "buttonGrammar";
            this.buttonGrammar.Size = new System.Drawing.Size(165, 46);
            this.buttonGrammar.TabIndex = 6;
            this.buttonGrammar.Text = "Ngữ pháp";
            this.buttonGrammar.UseVisualStyleBackColor = true;
            this.buttonGrammar.Click += new System.EventHandler(this.buttonGrammar_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRead.Location = new System.Drawing.Point(0, 46);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(165, 46);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Bài đọc";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(165, 46);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tra từ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // timerSearchList
            // 
            this.timerSearchList.Interval = 1;
            this.timerSearchList.Tick += new System.EventHandler(this.timerSearchList_Tick);
            // 
            // panelSearchbox
            // 
            this.panelSearchbox.Controls.Add(this.lsbListSearch);
            this.panelSearchbox.Controls.Add(this.rtbSearch);
            this.panelSearchbox.Location = new System.Drawing.Point(259, 90);
            this.panelSearchbox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panelSearchbox.MaximumSize = new System.Drawing.Size(253, 227);
            this.panelSearchbox.MinimumSize = new System.Drawing.Size(253, 24);
            this.panelSearchbox.Name = "panelSearchbox";
            this.panelSearchbox.Size = new System.Drawing.Size(253, 24);
            this.panelSearchbox.TabIndex = 1;
            // 
            // lsbListSearch
            // 
            this.lsbListSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsbListSearch.FormattingEnabled = true;
            this.lsbListSearch.ItemHeight = 20;
            this.lsbListSearch.Location = new System.Drawing.Point(0, 29);
            this.lsbListSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbListSearch.MaximumSize = new System.Drawing.Size(254, 227);
            this.lsbListSearch.MinimumSize = new System.Drawing.Size(254, 4);
            this.lsbListSearch.Name = "lsbListSearch";
            this.lsbListSearch.Size = new System.Drawing.Size(254, 224);
            this.lsbListSearch.TabIndex = 1;
            this.lsbListSearch.Click += new System.EventHandler(this.lsbListSearch_Click);
            // 
            // rtbSearch
            // 
            this.rtbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbSearch.Location = new System.Drawing.Point(0, 0);
            this.rtbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSearch.MaxLength = 50;
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(253, 29);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.Text = "";
            this.rtbSearch.Click += new System.EventHandler(this.rtbSearch_Click);
            this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
            // 
            // panelListRead
            // 
            this.panelListRead.Controls.Add(this.listboxRead);
            this.panelListRead.Location = new System.Drawing.Point(276, 58);
            this.panelListRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelListRead.Name = "panelListRead";
            this.panelListRead.Size = new System.Drawing.Size(214, 265);
            this.panelListRead.TabIndex = 0;
            // 
            // listboxRead
            // 
            this.listboxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listboxRead.FormattingEnabled = true;
            this.listboxRead.ItemHeight = 20;
            this.listboxRead.Location = new System.Drawing.Point(0, 0);
            this.listboxRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxRead.Name = "listboxRead";
            this.listboxRead.Size = new System.Drawing.Size(214, 265);
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
            this.tableLayoutPanelGrammar.Location = new System.Drawing.Point(189, 10);
            this.tableLayoutPanelGrammar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelGrammar.Name = "tableLayoutPanelGrammar";
            this.tableLayoutPanelGrammar.RowCount = 5;
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelGrammar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelGrammar.Size = new System.Drawing.Size(395, 368);
            this.tableLayoutPanelGrammar.TabIndex = 3;
            // 
            // buttonBai18
            // 
            this.buttonBai18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai18.Location = new System.Drawing.Point(110, 307);
            this.buttonBai18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai18.Name = "buttonBai18";
            this.buttonBai18.Size = new System.Drawing.Size(74, 45);
            this.buttonBai18.TabIndex = 19;
            this.buttonBai18.Text = "Bài 18";
            this.buttonBai18.UseVisualStyleBackColor = true;
            // 
            // buttonBai17
            // 
            this.buttonBai17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai17.Location = new System.Drawing.Point(12, 307);
            this.buttonBai17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai17.Name = "buttonBai17";
            this.buttonBai17.Size = new System.Drawing.Size(74, 45);
            this.buttonBai17.TabIndex = 18;
            this.buttonBai17.Text = "Bài 17";
            this.buttonBai17.UseVisualStyleBackColor = true;
            // 
            // buttonBai20
            // 
            this.buttonBai20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai20.Location = new System.Drawing.Point(307, 307);
            this.buttonBai20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai20.Name = "buttonBai20";
            this.buttonBai20.Size = new System.Drawing.Size(74, 45);
            this.buttonBai20.TabIndex = 17;
            this.buttonBai20.Text = "Bài 20";
            this.buttonBai20.UseVisualStyleBackColor = true;
            // 
            // buttonBai19
            // 
            this.buttonBai19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai19.Location = new System.Drawing.Point(208, 307);
            this.buttonBai19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai19.Name = "buttonBai19";
            this.buttonBai19.Size = new System.Drawing.Size(74, 45);
            this.buttonBai19.TabIndex = 12;
            this.buttonBai19.Text = "Bài 19";
            this.buttonBai19.UseVisualStyleBackColor = true;
            // 
            // buttonBai10
            // 
            this.buttonBai10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai10.Location = new System.Drawing.Point(110, 160);
            this.buttonBai10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai10.Name = "buttonBai10";
            this.buttonBai10.Size = new System.Drawing.Size(74, 45);
            this.buttonBai10.TabIndex = 9;
            this.buttonBai10.Text = "Bài 10";
            this.buttonBai10.UseVisualStyleBackColor = true;
            // 
            // buttonBai9
            // 
            this.buttonBai9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai9.Location = new System.Drawing.Point(12, 160);
            this.buttonBai9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai9.Name = "buttonBai9";
            this.buttonBai9.Size = new System.Drawing.Size(74, 45);
            this.buttonBai9.TabIndex = 8;
            this.buttonBai9.Text = "Bài 9";
            this.buttonBai9.UseVisualStyleBackColor = true;
            // 
            // buttonBai8
            // 
            this.buttonBai8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai8.Location = new System.Drawing.Point(307, 87);
            this.buttonBai8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai8.Name = "buttonBai8";
            this.buttonBai8.Size = new System.Drawing.Size(74, 45);
            this.buttonBai8.TabIndex = 7;
            this.buttonBai8.Text = "Bài 8";
            this.buttonBai8.UseVisualStyleBackColor = true;
            // 
            // buttonBai7
            // 
            this.buttonBai7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai7.Location = new System.Drawing.Point(208, 87);
            this.buttonBai7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai7.Name = "buttonBai7";
            this.buttonBai7.Size = new System.Drawing.Size(74, 45);
            this.buttonBai7.TabIndex = 6;
            this.buttonBai7.Text = "Bài 7";
            this.buttonBai7.UseVisualStyleBackColor = true;
            // 
            // buttonBai6
            // 
            this.buttonBai6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai6.Location = new System.Drawing.Point(110, 87);
            this.buttonBai6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai6.Name = "buttonBai6";
            this.buttonBai6.Size = new System.Drawing.Size(74, 45);
            this.buttonBai6.TabIndex = 5;
            this.buttonBai6.Text = "Bài 6";
            this.buttonBai6.UseVisualStyleBackColor = true;
            // 
            // buttonBai5
            // 
            this.buttonBai5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai5.Location = new System.Drawing.Point(12, 87);
            this.buttonBai5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai5.Name = "buttonBai5";
            this.buttonBai5.Size = new System.Drawing.Size(74, 45);
            this.buttonBai5.TabIndex = 4;
            this.buttonBai5.Text = "Bài 5";
            this.buttonBai5.UseVisualStyleBackColor = true;
            // 
            // buttonBai4
            // 
            this.buttonBai4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai4.Location = new System.Drawing.Point(307, 14);
            this.buttonBai4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai4.Name = "buttonBai4";
            this.buttonBai4.Size = new System.Drawing.Size(74, 45);
            this.buttonBai4.TabIndex = 3;
            this.buttonBai4.Text = "Bài 4";
            this.buttonBai4.UseVisualStyleBackColor = true;
            // 
            // buttonBai3
            // 
            this.buttonBai3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai3.Location = new System.Drawing.Point(208, 14);
            this.buttonBai3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai3.Name = "buttonBai3";
            this.buttonBai3.Size = new System.Drawing.Size(74, 45);
            this.buttonBai3.TabIndex = 2;
            this.buttonBai3.Text = "Bài 3";
            this.buttonBai3.UseVisualStyleBackColor = true;
            // 
            // buttonBai2
            // 
            this.buttonBai2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai2.Location = new System.Drawing.Point(110, 14);
            this.buttonBai2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai2.Name = "buttonBai2";
            this.buttonBai2.Size = new System.Drawing.Size(74, 45);
            this.buttonBai2.TabIndex = 1;
            this.buttonBai2.Text = "Bài 2";
            this.buttonBai2.UseVisualStyleBackColor = true;
            // 
            // buttonBai1
            // 
            this.buttonBai1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai1.Location = new System.Drawing.Point(12, 14);
            this.buttonBai1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai1.Name = "buttonBai1";
            this.buttonBai1.Size = new System.Drawing.Size(74, 45);
            this.buttonBai1.TabIndex = 0;
            this.buttonBai1.Text = "Bài 1";
            this.buttonBai1.UseVisualStyleBackColor = true;
            // 
            // buttonBai11
            // 
            this.buttonBai11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai11.Location = new System.Drawing.Point(208, 160);
            this.buttonBai11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai11.Name = "buttonBai11";
            this.buttonBai11.Size = new System.Drawing.Size(74, 45);
            this.buttonBai11.TabIndex = 10;
            this.buttonBai11.Text = "Bài 11";
            this.buttonBai11.UseVisualStyleBackColor = true;
            // 
            // buttonBai14
            // 
            this.buttonBai14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai14.Location = new System.Drawing.Point(110, 233);
            this.buttonBai14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai14.Name = "buttonBai14";
            this.buttonBai14.Size = new System.Drawing.Size(74, 45);
            this.buttonBai14.TabIndex = 14;
            this.buttonBai14.Text = "Bài 14";
            this.buttonBai14.UseVisualStyleBackColor = true;
            // 
            // buttonBai13
            // 
            this.buttonBai13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai13.Location = new System.Drawing.Point(12, 233);
            this.buttonBai13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai13.Name = "buttonBai13";
            this.buttonBai13.Size = new System.Drawing.Size(74, 45);
            this.buttonBai13.TabIndex = 13;
            this.buttonBai13.Text = "Bài 13";
            this.buttonBai13.UseVisualStyleBackColor = true;
            // 
            // buttonBai12
            // 
            this.buttonBai12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai12.Location = new System.Drawing.Point(307, 160);
            this.buttonBai12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai12.Name = "buttonBai12";
            this.buttonBai12.Size = new System.Drawing.Size(74, 45);
            this.buttonBai12.TabIndex = 11;
            this.buttonBai12.Text = "Bài 12";
            this.buttonBai12.UseVisualStyleBackColor = true;
            // 
            // buttonBai15
            // 
            this.buttonBai15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai15.Location = new System.Drawing.Point(208, 233);
            this.buttonBai15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai15.Name = "buttonBai15";
            this.buttonBai15.Size = new System.Drawing.Size(74, 45);
            this.buttonBai15.TabIndex = 15;
            this.buttonBai15.Text = "Bài 15";
            this.buttonBai15.UseVisualStyleBackColor = true;
            // 
            // buttonBai16
            // 
            this.buttonBai16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBai16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBai16.Location = new System.Drawing.Point(307, 233);
            this.buttonBai16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBai16.Name = "buttonBai16";
            this.buttonBai16.Size = new System.Drawing.Size(74, 45);
            this.buttonBai16.TabIndex = 16;
            this.buttonBai16.Text = "Bài 16";
            this.buttonBai16.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.tableLayoutPanelGrammar);
            this.Controls.Add(this.panelSearchbox);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelListRead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 434);
            this.Name = "FormSearch";
            this.Text = "Từ điển Anh-Việt";
            this.panelSelect.ResumeLayout(false);
            this.panelSearchbox.ResumeLayout(false);
            this.panelListRead.ResumeLayout(false);
            this.tableLayoutPanelGrammar.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonPractise;
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
    }
}

