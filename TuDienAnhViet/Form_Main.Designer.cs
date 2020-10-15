namespace TuDienAnhViet
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
            this.metroTile_Exam = new MetroFramework.Controls.MetroTile();
            this.metroTile_Reading = new MetroFramework.Controls.MetroTile();
            this.metroTile_Flashcard = new MetroFramework.Controls.MetroTile();
            this.metroTile_ComboWords = new MetroFramework.Controls.MetroTile();
            this.metroTile_Grammar = new MetroFramework.Controls.MetroTile();
            this.metroTile_Search = new MetroFramework.Controls.MetroTile();
            this.metroPanel_Main = new MetroFramework.Controls.MetroPanel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Selection = new System.Windows.Forms.Panel();
            this.panel_SelectedCursor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager_FormMain
            // 
            this.metroStyleManager_FormMain.Owner = null;
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_Exit.Location = new System.Drawing.Point(852, 9);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(40, 44);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            // 
            // metroTile_Exam
            // 
            this.metroTile_Exam.ActiveControl = null;
            this.metroTile_Exam.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_Exam.Location = new System.Drawing.Point(0, 430);
            this.metroTile_Exam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_Exam.Name = "metroTile_Exam";
            this.metroTile_Exam.Size = new System.Drawing.Size(200, 86);
            this.metroTile_Exam.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Exam.TabIndex = 8;
            this.metroTile_Exam.Text = "Luyện tập";
            this.metroTile_Exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Exam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile_Exam.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Exam.TileImage")));
            this.metroTile_Exam.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_Exam.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Exam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Exam.UseSelectable = true;
            this.metroTile_Exam.UseTileImage = true;
            this.metroTile_Exam.Click += new System.EventHandler(this.metroTile_Exam_Click);
            // 
            // metroTile_Reading
            // 
            this.metroTile_Reading.ActiveControl = null;
            this.metroTile_Reading.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_Reading.Location = new System.Drawing.Point(0, 344);
            this.metroTile_Reading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_Reading.Name = "metroTile_Reading";
            this.metroTile_Reading.Size = new System.Drawing.Size(200, 86);
            this.metroTile_Reading.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile_Reading.TabIndex = 7;
            this.metroTile_Reading.Text = "Bài đọc";
            this.metroTile_Reading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Reading.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile_Reading.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Reading.TileImage")));
            this.metroTile_Reading.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_Reading.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Reading.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Reading.UseSelectable = true;
            this.metroTile_Reading.UseTileImage = true;
            this.metroTile_Reading.Click += new System.EventHandler(this.metroTile_Reading_Click);
            // 
            // metroTile_Flashcard
            // 
            this.metroTile_Flashcard.ActiveControl = null;
            this.metroTile_Flashcard.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_Flashcard.Location = new System.Drawing.Point(0, 258);
            this.metroTile_Flashcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_Flashcard.Name = "metroTile_Flashcard";
            this.metroTile_Flashcard.Size = new System.Drawing.Size(200, 86);
            this.metroTile_Flashcard.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Flashcard.TabIndex = 6;
            this.metroTile_Flashcard.Text = "Flash card";
            this.metroTile_Flashcard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Flashcard.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile_Flashcard.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Flashcard.TileImage")));
            this.metroTile_Flashcard.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_Flashcard.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Flashcard.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Flashcard.UseSelectable = true;
            this.metroTile_Flashcard.UseTileImage = true;
            this.metroTile_Flashcard.Click += new System.EventHandler(this.metroTile_Flashcard_Click);
            // 
            // metroTile_ComboWords
            // 
            this.metroTile_ComboWords.ActiveControl = null;
            this.metroTile_ComboWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_ComboWords.Location = new System.Drawing.Point(0, 172);
            this.metroTile_ComboWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_ComboWords.Name = "metroTile_ComboWords";
            this.metroTile_ComboWords.Size = new System.Drawing.Size(200, 86);
            this.metroTile_ComboWords.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile_ComboWords.TabIndex = 5;
            this.metroTile_ComboWords.Text = "Bộ từ vựng";
            this.metroTile_ComboWords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_ComboWords.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile_ComboWords.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_ComboWords.TileImage")));
            this.metroTile_ComboWords.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_ComboWords.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_ComboWords.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_ComboWords.UseSelectable = true;
            this.metroTile_ComboWords.UseTileImage = true;
            this.metroTile_ComboWords.Click += new System.EventHandler(this.metroTile_ComboWords_Click);
            // 
            // metroTile_Grammar
            // 
            this.metroTile_Grammar.ActiveControl = null;
            this.metroTile_Grammar.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_Grammar.Location = new System.Drawing.Point(0, 86);
            this.metroTile_Grammar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_Grammar.Name = "metroTile_Grammar";
            this.metroTile_Grammar.Size = new System.Drawing.Size(200, 86);
            this.metroTile_Grammar.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Grammar.TabIndex = 4;
            this.metroTile_Grammar.Text = "Ngữ pháp";
            this.metroTile_Grammar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Grammar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile_Grammar.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Grammar.TileImage")));
            this.metroTile_Grammar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_Grammar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Grammar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Grammar.UseSelectable = true;
            this.metroTile_Grammar.UseTileImage = true;
            this.metroTile_Grammar.Click += new System.EventHandler(this.metroTile_Grammar_Click);
            // 
            // metroTile_Search
            // 
            this.metroTile_Search.ActiveControl = null;
            this.metroTile_Search.BackColor = System.Drawing.Color.Yellow;
            this.metroTile_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile_Search.Location = new System.Drawing.Point(0, 0);
            this.metroTile_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile_Search.Name = "metroTile_Search";
            this.metroTile_Search.Size = new System.Drawing.Size(200, 86);
            this.metroTile_Search.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile_Search.TabIndex = 3;
            this.metroTile_Search.Text = "Tra từ";
            this.metroTile_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Search.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile_Search.TileImage")));
            this.metroTile_Search.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile_Search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Search.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Search.UseSelectable = true;
            this.metroTile_Search.UseStyleColors = true;
            this.metroTile_Search.UseTileImage = true;
            this.metroTile_Search.Click += new System.EventHandler(this.metroTile_Search_Click);
            // 
            // metroPanel_Main
            // 
            this.metroPanel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel_Main.HorizontalScrollbarBarColor = true;
            this.metroPanel_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Main.HorizontalScrollbarSize = 10;
            this.metroPanel_Main.Location = new System.Drawing.Point(252, 74);
            this.metroPanel_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel_Main.Name = "metroPanel_Main";
            this.metroPanel_Main.Size = new System.Drawing.Size(624, 516);
            this.metroPanel_Main.TabIndex = 3;
            this.metroPanel_Main.VerticalScrollbarBarColor = true;
            this.metroPanel_Main.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Main.VerticalScrollbarSize = 11;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.metroTile_Exam);
            this.panel_Menu.Controls.Add(this.metroTile_Reading);
            this.panel_Menu.Controls.Add(this.metroTile_Flashcard);
            this.panel_Menu.Controls.Add(this.metroTile_ComboWords);
            this.panel_Menu.Controls.Add(this.metroTile_Grammar);
            this.panel_Menu.Controls.Add(this.metroTile_Search);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(20, 74);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 516);
            this.panel_Menu.TabIndex = 4;
            // 
            // panel_Selection
            // 
            this.panel_Selection.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Selection.Location = new System.Drawing.Point(220, 74);
            this.panel_Selection.Name = "panel_Selection";
            this.panel_Selection.Size = new System.Drawing.Size(32, 516);
            this.panel_Selection.TabIndex = 5;
            // 
            // panel_SelectedCursor
            // 
            this.panel_SelectedCursor.Location = new System.Drawing.Point(230, 74);
            this.panel_SelectedCursor.Name = "panel_SelectedCursor";
            this.panel_SelectedCursor.Size = new System.Drawing.Size(12, 86);
            this.panel_SelectedCursor.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.panel_SelectedCursor);
            this.Controls.Add(this.metroPanel_Main);
            this.Controls.Add(this.panel_Selection);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.panel_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(896, 610);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(896, 610);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Từ điển Anh-Việt";
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            this.MouseLeave += new System.EventHandler(this.Form_Main_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager_FormMain;
        private System.Windows.Forms.Button button_Exit;
        private MetroFramework.Controls.MetroTile metroTile_Search;
        private MetroFramework.Controls.MetroTile metroTile_Exam;
        private MetroFramework.Controls.MetroTile metroTile_Reading;
        private MetroFramework.Controls.MetroTile metroTile_Flashcard;
        private MetroFramework.Controls.MetroTile metroTile_ComboWords;
        private MetroFramework.Controls.MetroTile metroTile_Grammar;
        public MetroFramework.Controls.MetroPanel metroPanel_Main;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Selection;
        private System.Windows.Forms.Panel panel_SelectedCursor;
    }
}

