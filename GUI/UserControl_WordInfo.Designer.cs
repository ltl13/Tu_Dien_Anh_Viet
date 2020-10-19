﻿namespace GUI
{
    partial class UserControl_WordInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_WordInfo));
            this.splitContainer_WordInfo = new System.Windows.Forms.SplitContainer();
            this.metroTile_Back = new MetroFramework.Controls.MetroTile();
            this.metroTile_Speaker = new MetroFramework.Controls.MetroTile();
            this.label_Word = new System.Windows.Forms.Label();
            this.metroTabControl_WordInfo = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Meaning = new MetroFramework.Controls.MetroTabPage();
            this.label_VietNamese = new System.Windows.Forms.Label();
            this.tabPage_Example = new System.Windows.Forms.TabPage();
            this.tabPage_Synonym = new System.Windows.Forms.TabPage();
            this.tabPage_Antonym = new System.Windows.Forms.TabPage();
            this.tabPage_Technical = new System.Windows.Forms.TabPage();
            this.tabPage_Note = new System.Windows.Forms.TabPage();
            this.tabPage_Image = new System.Windows.Forms.TabPage();
            this.xuiButton_NotInterest = new XanderUI.XUIButton();
            this.xuiButton_Interest = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_WordInfo)).BeginInit();
            this.splitContainer_WordInfo.Panel1.SuspendLayout();
            this.splitContainer_WordInfo.Panel2.SuspendLayout();
            this.splitContainer_WordInfo.SuspendLayout();
            this.metroTabControl_WordInfo.SuspendLayout();
            this.tabPage_Meaning.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_WordInfo
            // 
            this.splitContainer_WordInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_WordInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_WordInfo.Name = "splitContainer_WordInfo";
            this.splitContainer_WordInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_WordInfo.Panel1
            // 
            this.splitContainer_WordInfo.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer_WordInfo.Panel1.Controls.Add(this.xuiButton_Interest);
            this.splitContainer_WordInfo.Panel1.Controls.Add(this.xuiButton_NotInterest);
            this.splitContainer_WordInfo.Panel1.Controls.Add(this.metroTile_Back);
            this.splitContainer_WordInfo.Panel1.Controls.Add(this.metroTile_Speaker);
            this.splitContainer_WordInfo.Panel1.Controls.Add(this.label_Word);
            // 
            // splitContainer_WordInfo.Panel2
            // 
            this.splitContainer_WordInfo.Panel2.Controls.Add(this.metroTabControl_WordInfo);
            this.splitContainer_WordInfo.Size = new System.Drawing.Size(624, 516);
            this.splitContainer_WordInfo.SplitterDistance = 116;
            this.splitContainer_WordInfo.TabIndex = 0;
            // 
            // metroTile_Back
            // 
            this.metroTile_Back.ActiveControl = null;
            this.metroTile_Back.Location = new System.Drawing.Point(556, 3);
            this.metroTile_Back.Name = "metroTile_Back";
            this.metroTile_Back.Size = new System.Drawing.Size(64, 43);
            this.metroTile_Back.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Back.TabIndex = 3;
            this.metroTile_Back.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Back.TileImage")));
            this.metroTile_Back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Back.UseSelectable = true;
            this.metroTile_Back.UseTileImage = true;
            this.metroTile_Back.Click += new System.EventHandler(this.metroTile_Back_Click);
            this.metroTile_Back.MouseEnter += new System.EventHandler(this.metroTile_Back_MouseEnter);
            this.metroTile_Back.MouseLeave += new System.EventHandler(this.metroTile_Back_MouseLeave);
            // 
            // metroTile_Speaker
            // 
            this.metroTile_Speaker.ActiveControl = null;
            this.metroTile_Speaker.Location = new System.Drawing.Point(525, 75);
            this.metroTile_Speaker.Name = "metroTile_Speaker";
            this.metroTile_Speaker.Size = new System.Drawing.Size(42, 39);
            this.metroTile_Speaker.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Speaker.TabIndex = 1;
            this.metroTile_Speaker.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Speaker.TileImage")));
            this.metroTile_Speaker.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Speaker.UseSelectable = true;
            this.metroTile_Speaker.UseTileImage = true;
            this.metroTile_Speaker.Click += new System.EventHandler(this.metroTile_Speaker_Click);
            // 
            // label_Word
            // 
            this.label_Word.AutoSize = true;
            this.label_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_Word.Location = new System.Drawing.Point(16, 17);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(151, 46);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "English";
            // 
            // metroTabControl_WordInfo
            // 
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Meaning);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Example);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Synonym);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Antonym);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Technical);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Note);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Image);
            this.metroTabControl_WordInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_WordInfo.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl_WordInfo.Name = "metroTabControl_WordInfo";
            this.metroTabControl_WordInfo.SelectedIndex = 0;
            this.metroTabControl_WordInfo.Size = new System.Drawing.Size(624, 396);
            this.metroTabControl_WordInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl_WordInfo.TabIndex = 0;
            this.metroTabControl_WordInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl_WordInfo.UseSelectable = true;
            // 
            // tabPage_Meaning
            // 
            this.tabPage_Meaning.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Meaning.Controls.Add(this.label_VietNamese);
            this.tabPage_Meaning.HorizontalScrollbarBarColor = true;
            this.tabPage_Meaning.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_Meaning.HorizontalScrollbarSize = 10;
            this.tabPage_Meaning.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Meaning.Name = "tabPage_Meaning";
            this.tabPage_Meaning.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Meaning.TabIndex = 0;
            this.tabPage_Meaning.Text = "Nghĩa";
            this.tabPage_Meaning.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabPage_Meaning.VerticalScrollbarBarColor = true;
            this.tabPage_Meaning.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_Meaning.VerticalScrollbarSize = 10;
            // 
            // label_VietNamese
            // 
            this.label_VietNamese.AutoSize = true;
            this.label_VietNamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_VietNamese.Location = new System.Drawing.Point(3, 28);
            this.label_VietNamese.Name = "label_VietNamese";
            this.label_VietNamese.Size = new System.Drawing.Size(237, 46);
            this.label_VietNamese.TabIndex = 4;
            this.label_VietNamese.Text = "VietNamese";
            // 
            // tabPage_Example
            // 
            this.tabPage_Example.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Example.Name = "tabPage_Example";
            this.tabPage_Example.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Example.TabIndex = 2;
            this.tabPage_Example.Text = "Ví dụ";
            // 
            // tabPage_Synonym
            // 
            this.tabPage_Synonym.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Synonym.Name = "tabPage_Synonym";
            this.tabPage_Synonym.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Synonym.TabIndex = 3;
            this.tabPage_Synonym.Text = "Đồng nghĩa";
            // 
            // tabPage_Antonym
            // 
            this.tabPage_Antonym.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Antonym.Name = "tabPage_Antonym";
            this.tabPage_Antonym.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Antonym.TabIndex = 4;
            this.tabPage_Antonym.Text = "Trái nghĩa";
            // 
            // tabPage_Technical
            // 
            this.tabPage_Technical.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.tabPage_Technical.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Technical.Name = "tabPage_Technical";
            this.tabPage_Technical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_Technical.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Technical.TabIndex = 1;
            this.tabPage_Technical.Text = "Chuyên ngành";
            // 
            // tabPage_Note
            // 
            this.tabPage_Note.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Note.Name = "tabPage_Note";
            this.tabPage_Note.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Note.TabIndex = 5;
            this.tabPage_Note.Text = "Ghi chú";
            // 
            // tabPage_Image
            // 
            this.tabPage_Image.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Image.Name = "tabPage_Image";
            this.tabPage_Image.Size = new System.Drawing.Size(616, 354);
            this.tabPage_Image.TabIndex = 6;
            this.tabPage_Image.Text = "Ảnh minh họa";
            // 
            // xuiButton_NotInterest
            // 
            this.xuiButton_NotInterest.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_NotInterest.ButtonImage")));
            this.xuiButton_NotInterest.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_NotInterest.ButtonText = "";
            this.xuiButton_NotInterest.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.CornerRadius = 5;
            this.xuiButton_NotInterest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_NotInterest.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_NotInterest.Location = new System.Drawing.Point(580, 72);
            this.xuiButton_NotInterest.Name = "xuiButton_NotInterest";
            this.xuiButton_NotInterest.Size = new System.Drawing.Size(40, 41);
            this.xuiButton_NotInterest.TabIndex = 4;
            this.xuiButton_NotInterest.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_NotInterest.Click += new System.EventHandler(this.xuiButton_NotInterest_Click);
            // 
            // xuiButton_Interest
            // 
            this.xuiButton_Interest.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Interest.ButtonImage")));
            this.xuiButton_Interest.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Interest.ButtonText = "";
            this.xuiButton_Interest.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.CornerRadius = 5;
            this.xuiButton_Interest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Interest.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Interest.Location = new System.Drawing.Point(580, 72);
            this.xuiButton_Interest.Name = "xuiButton_Interest";
            this.xuiButton_Interest.Size = new System.Drawing.Size(40, 41);
            this.xuiButton_Interest.TabIndex = 5;
            this.xuiButton_Interest.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Interest.Visible = false;
            this.xuiButton_Interest.Click += new System.EventHandler(this.xuiButton_Interest_Click);
            // 
            // UserControl_WordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_WordInfo);
            this.Name = "UserControl_WordInfo";
            this.Size = new System.Drawing.Size(624, 516);
            this.splitContainer_WordInfo.Panel1.ResumeLayout(false);
            this.splitContainer_WordInfo.Panel1.PerformLayout();
            this.splitContainer_WordInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_WordInfo)).EndInit();
            this.splitContainer_WordInfo.ResumeLayout(false);
            this.metroTabControl_WordInfo.ResumeLayout(false);
            this.tabPage_Meaning.ResumeLayout(false);
            this.tabPage_Meaning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_WordInfo;
        private MetroFramework.Controls.MetroTile metroTile_Speaker;
        private System.Windows.Forms.Label label_Word;
        private MetroFramework.Controls.MetroTabControl metroTabControl_WordInfo;
        private MetroFramework.Controls.MetroTabPage tabPage_Meaning;
        private System.Windows.Forms.TabPage tabPage_Example;
        private System.Windows.Forms.TabPage tabPage_Synonym;
        private System.Windows.Forms.TabPage tabPage_Antonym;
        private System.Windows.Forms.TabPage tabPage_Technical;
        private System.Windows.Forms.TabPage tabPage_Note;
        private System.Windows.Forms.TabPage tabPage_Image;
        private MetroFramework.Controls.MetroTile metroTile_Back;
        private System.Windows.Forms.Label label_VietNamese;
        private XanderUI.XUIButton xuiButton_Interest;
        private XanderUI.XUIButton xuiButton_NotInterest;
    }
}
