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
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.timerSearchList = new System.Windows.Forms.Timer(this.components);
            this.panelSearchbox = new System.Windows.Forms.Panel();
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.lsbListSearch = new System.Windows.Forms.ListBox();
            this.panelListRead = new System.Windows.Forms.Panel();
            this.listboxRead = new System.Windows.Forms.ListBox();
            this.panelSelect.SuspendLayout();
            this.panelSearchbox.SuspendLayout();
            this.panelListRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.Orchid;
            this.panelSelect.Controls.Add(this.buttonRead);
            this.panelSelect.Controls.Add(this.buttonSearch);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(220, 478);
            this.panelSelect.TabIndex = 2;
            // 
            // buttonRead
            // 
            this.buttonRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRead.Location = new System.Drawing.Point(0, 56);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(220, 56);
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
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(220, 56);
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
            this.panelSearchbox.Location = new System.Drawing.Point(345, 111);
            this.panelSearchbox.Margin = new System.Windows.Forms.Padding(10);
            this.panelSearchbox.MaximumSize = new System.Drawing.Size(337, 279);
            this.panelSearchbox.MinimumSize = new System.Drawing.Size(337, 29);
            this.panelSearchbox.Name = "panelSearchbox";
            this.panelSearchbox.Size = new System.Drawing.Size(337, 29);
            this.panelSearchbox.TabIndex = 1;
            // 
            // rtbSearch
            // 
            this.rtbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbSearch.Location = new System.Drawing.Point(0, 0);
            this.rtbSearch.MaxLength = 50;
            this.rtbSearch.Name = "rtbSearch";
            this.rtbSearch.Size = new System.Drawing.Size(337, 35);
            this.rtbSearch.TabIndex = 0;
            this.rtbSearch.Text = "";
            this.rtbSearch.Click += new System.EventHandler(this.rtbSearch_Click);
            this.rtbSearch.TextChanged += new System.EventHandler(this.rtbSearch_TextChanged);
            // 
            // lsbListSearch
            // 
            this.lsbListSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbListSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsbListSearch.FormattingEnabled = true;
            this.lsbListSearch.ItemHeight = 25;
            this.lsbListSearch.Location = new System.Drawing.Point(0, 35);
            this.lsbListSearch.MaximumSize = new System.Drawing.Size(337, 279);
            this.lsbListSearch.MinimumSize = new System.Drawing.Size(337, 4);
            this.lsbListSearch.Name = "lsbListSearch";
            this.lsbListSearch.Size = new System.Drawing.Size(337, 279);
            this.lsbListSearch.TabIndex = 1;
            this.lsbListSearch.Click += new System.EventHandler(this.lsbListSearch_Click);
            // 
            // panelListRead
            // 
            this.panelListRead.Controls.Add(this.listboxRead);
            this.panelListRead.Location = new System.Drawing.Point(368, 71);
            this.panelListRead.Name = "panelListRead";
            this.panelListRead.Size = new System.Drawing.Size(286, 326);
            this.panelListRead.TabIndex = 0;
            // 
            // listboxRead
            // 
            this.listboxRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listboxRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listboxRead.FormattingEnabled = true;
            this.listboxRead.ItemHeight = 25;
            this.listboxRead.Location = new System.Drawing.Point(0, 0);
            this.listboxRead.Name = "listboxRead";
            this.listboxRead.Size = new System.Drawing.Size(286, 326);
            this.listboxRead.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.panelSearchbox);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelListRead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 525);
            this.Name = "FormSearch";
            this.Text = "Từ điển Anh-Việt";
            this.panelSelect.ResumeLayout(false);
            this.panelSearchbox.ResumeLayout(false);
            this.panelListRead.ResumeLayout(false);
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
    }
}

