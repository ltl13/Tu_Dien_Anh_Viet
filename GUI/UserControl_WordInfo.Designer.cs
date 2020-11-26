namespace GUI
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
            this.xuiButton_Interest = new XanderUI.XUIButton();
            this.xuiButton_NotInterest = new XanderUI.XUIButton();
            this.metroTile_Back = new MetroFramework.Controls.MetroTile();
            this.metroTile_Speaker = new MetroFramework.Controls.MetroTile();
            this.label_Word = new System.Windows.Forms.Label();
            this.metroTabControl_WordInfo = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Meaning = new System.Windows.Forms.TabPage();
            this.rtb_vietnamese = new System.Windows.Forms.RichTextBox();
            this.tabPage_Synonymous = new System.Windows.Forms.TabPage();
            this.tabPage_Antonym = new System.Windows.Forms.TabPage();
            this.tabPage_Technical = new System.Windows.Forms.TabPage();
            this.tabPage_Image = new System.Windows.Forms.TabPage();
            this.tabPage_Note = new System.Windows.Forms.TabPage();
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
            this.splitContainer_WordInfo.SplitterDistance = 115;
            this.splitContainer_WordInfo.TabIndex = 0;
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
            this.label_Word.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label_Word.Location = new System.Drawing.Point(0, 0);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(624, 115);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "English";
            // 
            // metroTabControl_WordInfo
            // 
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Meaning);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Synonymous);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Antonym);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Technical);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Image);
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Note);
            this.metroTabControl_WordInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_WordInfo.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl_WordInfo.Name = "metroTabControl_WordInfo";
            this.metroTabControl_WordInfo.SelectedIndex = 0;
            this.metroTabControl_WordInfo.Size = new System.Drawing.Size(624, 397);
            this.metroTabControl_WordInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl_WordInfo.TabIndex = 0;
            this.metroTabControl_WordInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl_WordInfo.UseSelectable = true;
            // 
            // tabPage_Meaning
            // 
            this.tabPage_Meaning.Controls.Add(this.rtb_vietnamese);
            this.tabPage_Meaning.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Meaning.Name = "tabPage_Meaning";
            this.tabPage_Meaning.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Meaning.TabIndex = 3;
            this.tabPage_Meaning.Text = "Nghĩa";
            // 
            // rtb_vietnamese
            // 
            this.rtb_vietnamese.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_vietnamese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_vietnamese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_vietnamese.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_vietnamese.Location = new System.Drawing.Point(0, 0);
            this.rtb_vietnamese.Name = "rtb_vietnamese";
            this.rtb_vietnamese.ReadOnly = true;
            this.rtb_vietnamese.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_vietnamese.Size = new System.Drawing.Size(616, 355);
            this.rtb_vietnamese.TabIndex = 0;
            this.rtb_vietnamese.Text = "";
            // 
            // tabPage_Synonymous
            // 
            this.tabPage_Synonymous.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Synonymous.Name = "tabPage_Synonymous";
            this.tabPage_Synonymous.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Synonymous.TabIndex = 2;
            this.tabPage_Synonymous.Text = "Đồng nghĩa";
            // 
            // tabPage_Antonym
            // 
            this.tabPage_Antonym.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Antonym.Name = "tabPage_Antonym";
            this.tabPage_Antonym.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Antonym.TabIndex = 4;
            this.tabPage_Antonym.Text = "Trái nghĩa";
            // 
            // tabPage_Technical
            // 
            this.tabPage_Technical.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.tabPage_Technical.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Technical.Name = "tabPage_Technical";
            this.tabPage_Technical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_Technical.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Technical.TabIndex = 1;
            this.tabPage_Technical.Text = "Chuyên ngành";
            // 
            // tabPage_Image
            // 
            this.tabPage_Image.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Image.Name = "tabPage_Image";
            this.tabPage_Image.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Image.TabIndex = 6;
            this.tabPage_Image.Text = "Ảnh minh họa";
            // 
            // tabPage_Note
            // 
            this.tabPage_Note.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Note.Name = "tabPage_Note";
            this.tabPage_Note.Size = new System.Drawing.Size(616, 355);
            this.tabPage_Note.TabIndex = 5;
            this.tabPage_Note.Text = "Ghi chú";
            // 
            // UserControl_WordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_WordInfo);
            this.Name = "UserControl_WordInfo";
            this.Size = new System.Drawing.Size(624, 516);
            this.splitContainer_WordInfo.Panel1.ResumeLayout(false);
            this.splitContainer_WordInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_WordInfo)).EndInit();
            this.splitContainer_WordInfo.ResumeLayout(false);
            this.metroTabControl_WordInfo.ResumeLayout(false);
            this.tabPage_Meaning.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_WordInfo;
        private MetroFramework.Controls.MetroTile metroTile_Speaker;
        private System.Windows.Forms.Label label_Word;
        private MetroFramework.Controls.MetroTabControl metroTabControl_WordInfo;
        private System.Windows.Forms.TabPage tabPage_Synonymous;
        private System.Windows.Forms.TabPage tabPage_Meaning;
        private System.Windows.Forms.TabPage tabPage_Antonym;
        private System.Windows.Forms.TabPage tabPage_Technical;
        private System.Windows.Forms.TabPage tabPage_Note;
        private System.Windows.Forms.TabPage tabPage_Image;
        private MetroFramework.Controls.MetroTile metroTile_Back;
        private XanderUI.XUIButton xuiButton_Interest;
        private XanderUI.XUIButton xuiButton_NotInterest;
        private System.Windows.Forms.RichTextBox rtb_vietnamese;
    }
}
