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
            this.rtbSearch = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelSearchbox = new System.Windows.Forms.Panel();
            this.lsbListSearch = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerSearchList = new System.Windows.Forms.Timer(this.components);
            this.panelSearchbox.SuspendLayout();
            this.SuspendLayout();
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
            // panelSearchbox
            // 
            this.panelSearchbox.Controls.Add(this.lsbListSearch);
            this.panelSearchbox.Controls.Add(this.rtbSearch);
            this.panelSearchbox.Location = new System.Drawing.Point(356, 79);
            this.panelSearchbox.MaximumSize = new System.Drawing.Size(337, 279);
            this.panelSearchbox.MinimumSize = new System.Drawing.Size(337, 29);
            this.panelSearchbox.Name = "panelSearchbox";
            this.panelSearchbox.Size = new System.Drawing.Size(337, 29);
            this.panelSearchbox.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 478);
            this.panel2.TabIndex = 2;
            // 
            // timerSearchList
            // 
            this.timerSearchList.Interval = 1;
            this.timerSearchList.Tick += new System.EventHandler(this.timerSearchList_Tick);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSearchbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearch";
            this.Text = "Từ điển Anh-Việt";
            this.panelSearchbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSearchbox;
        private System.Windows.Forms.ListBox lsbListSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerSearchList;
    }
}

