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
            this.tabPage_Meaning = new MetroFramework.Controls.MetroTabPage();
            this.tabPage_Example = new System.Windows.Forms.TabPage();
            this.tabPage_Synonym = new System.Windows.Forms.TabPage();
            this.tabPage_Antonym = new System.Windows.Forms.TabPage();
            this.tabPage_Technical = new System.Windows.Forms.TabPage();
            this.tabPage_Note = new System.Windows.Forms.TabPage();
            this.tabPage_Image = new System.Windows.Forms.TabPage();
            this.tb_vietnamese = new System.Windows.Forms.TextBox();
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
            this.splitContainer_WordInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.splitContainer_WordInfo.Size = new System.Drawing.Size(1092, 935);
            this.splitContainer_WordInfo.SplitterDistance = 210;
            this.splitContainer_WordInfo.SplitterWidth = 7;
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
            this.xuiButton_Interest.Location = new System.Drawing.Point(1015, 130);
            this.xuiButton_Interest.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.xuiButton_Interest.Name = "xuiButton_Interest";
            this.xuiButton_Interest.Size = new System.Drawing.Size(70, 74);
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
            this.xuiButton_NotInterest.Location = new System.Drawing.Point(1015, 130);
            this.xuiButton_NotInterest.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.xuiButton_NotInterest.Name = "xuiButton_NotInterest";
            this.xuiButton_NotInterest.Size = new System.Drawing.Size(70, 74);
            this.xuiButton_NotInterest.TabIndex = 4;
            this.xuiButton_NotInterest.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_NotInterest.Click += new System.EventHandler(this.xuiButton_NotInterest_Click);
            // 
            // metroTile_Back
            // 
            this.metroTile_Back.ActiveControl = null;
            this.metroTile_Back.Location = new System.Drawing.Point(973, 5);
            this.metroTile_Back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.metroTile_Back.Name = "metroTile_Back";
            this.metroTile_Back.Size = new System.Drawing.Size(112, 78);
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
            this.metroTile_Speaker.Location = new System.Drawing.Point(919, 136);
            this.metroTile_Speaker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.metroTile_Speaker.Name = "metroTile_Speaker";
            this.metroTile_Speaker.Size = new System.Drawing.Size(74, 71);
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
            this.label_Word.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(1092, 210);
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
            this.metroTabControl_WordInfo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.metroTabControl_WordInfo.Name = "metroTabControl_WordInfo";
            this.metroTabControl_WordInfo.SelectedIndex = 0;
            this.metroTabControl_WordInfo.Size = new System.Drawing.Size(1092, 718);
            this.metroTabControl_WordInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl_WordInfo.TabIndex = 0;
            this.metroTabControl_WordInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl_WordInfo.UseSelectable = true;
            // 
            // tabPage_Meaning
            // 
            this.tabPage_Meaning.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Meaning.Controls.Add(this.tb_vietnamese);
            this.tabPage_Meaning.HorizontalScrollbarBarColor = true;
            this.tabPage_Meaning.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_Meaning.HorizontalScrollbarSize = 18;
            this.tabPage_Meaning.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Meaning.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Meaning.Name = "tabPage_Meaning";
            this.tabPage_Meaning.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Meaning.TabIndex = 0;
            this.tabPage_Meaning.Text = "Nghĩa";
            this.tabPage_Meaning.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabPage_Meaning.VerticalScrollbarBarColor = true;
            this.tabPage_Meaning.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_Meaning.VerticalScrollbarSize = 18;
            // 
            // tabPage_Example
            // 
            this.tabPage_Example.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Example.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Example.Name = "tabPage_Example";
            this.tabPage_Example.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Example.TabIndex = 2;
            this.tabPage_Example.Text = "Ví dụ";
            // 
            // tabPage_Synonym
            // 
            this.tabPage_Synonym.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Synonym.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Synonym.Name = "tabPage_Synonym";
            this.tabPage_Synonym.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Synonym.TabIndex = 3;
            this.tabPage_Synonym.Text = "Đồng nghĩa";
            // 
            // tabPage_Antonym
            // 
            this.tabPage_Antonym.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Antonym.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Antonym.Name = "tabPage_Antonym";
            this.tabPage_Antonym.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Antonym.TabIndex = 4;
            this.tabPage_Antonym.Text = "Trái nghĩa";
            // 
            // tabPage_Technical
            // 
            this.tabPage_Technical.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.tabPage_Technical.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Technical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Technical.Name = "tabPage_Technical";
            this.tabPage_Technical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_Technical.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Technical.TabIndex = 1;
            this.tabPage_Technical.Text = "Chuyên ngành";
            // 
            // tabPage_Note
            // 
            this.tabPage_Note.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Note.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Note.Name = "tabPage_Note";
            this.tabPage_Note.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Note.TabIndex = 5;
            this.tabPage_Note.Text = "Ghi chú";
            // 
            // tabPage_Image
            // 
            this.tabPage_Image.Location = new System.Drawing.Point(10, 43);
            this.tabPage_Image.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage_Image.Name = "tabPage_Image";
            this.tabPage_Image.Size = new System.Drawing.Size(1072, 665);
            this.tabPage_Image.TabIndex = 6;
            this.tabPage_Image.Text = "Ảnh minh họa";
            // 
            // tb_vietnamese
            // 
            this.tb_vietnamese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_vietnamese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vietnamese.Location = new System.Drawing.Point(0, 0);
            this.tb_vietnamese.Multiline = true;
            this.tb_vietnamese.Name = "tb_vietnamese";
            this.tb_vietnamese.ReadOnly = true;
            this.tb_vietnamese.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_vietnamese.Size = new System.Drawing.Size(1072, 665);
            this.tb_vietnamese.TabIndex = 2;
            // 
            // UserControl_WordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_WordInfo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UserControl_WordInfo";
            this.Size = new System.Drawing.Size(1092, 935);
            this.splitContainer_WordInfo.Panel1.ResumeLayout(false);
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
        private XanderUI.XUIButton xuiButton_Interest;
        private XanderUI.XUIButton xuiButton_NotInterest;
        private System.Windows.Forms.TextBox tb_vietnamese;
    }
}
