namespace TuDienAnhViet
{
    partial class UserControl_Search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Search));
            this.metroTextBox_Searchbar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel_Searchbox = new MetroFramework.Controls.MetroPanel();
            this.listBox_Search = new System.Windows.Forms.ListBox();
            this.timer_SearchDrop = new System.Windows.Forms.Timer(this.components);
            this.metroPanel_Searchbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox_Searchbar
            // 
            this.metroTextBox_Searchbar.AllowDrop = true;
            // 
            // 
            // 
            this.metroTextBox_Searchbar.CustomButton.Image = null;
            this.metroTextBox_Searchbar.CustomButton.Location = new System.Drawing.Point(331, 2);
            this.metroTextBox_Searchbar.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox_Searchbar.CustomButton.Name = "";
            this.metroTextBox_Searchbar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.CustomButton.TabIndex = 1;
            this.metroTextBox_Searchbar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Searchbar.CustomButton.UseSelectable = true;
            this.metroTextBox_Searchbar.CustomButton.Visible = false;
            this.metroTextBox_Searchbar.DisplayIcon = true;
            this.metroTextBox_Searchbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTextBox_Searchbar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Searchbar.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Searchbar.Icon")));
            this.metroTextBox_Searchbar.Lines = new string[0];
            this.metroTextBox_Searchbar.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox_Searchbar.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox_Searchbar.MaxLength = 32;
            this.metroTextBox_Searchbar.Name = "metroTextBox_Searchbar";
            this.metroTextBox_Searchbar.PasswordChar = '\0';
            this.metroTextBox_Searchbar.PromptText = "Search...";
            this.metroTextBox_Searchbar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Searchbar.SelectedText = "";
            this.metroTextBox_Searchbar.SelectionLength = 0;
            this.metroTextBox_Searchbar.SelectionStart = 0;
            this.metroTextBox_Searchbar.ShortcutsEnabled = true;
            this.metroTextBox_Searchbar.Size = new System.Drawing.Size(363, 34);
            this.metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextBox_Searchbar.TabIndex = 0;
            this.metroTextBox_Searchbar.UseSelectable = true;
            this.metroTextBox_Searchbar.WaterMark = "Search...";
            this.metroTextBox_Searchbar.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.metroTextBox_Searchbar.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.metroTextBox_Searchbar.TextChanged += new System.EventHandler(this.metroTextBox_Searchbar_TextChanged);
            // 
            // metroPanel_Searchbox
            // 
            this.metroPanel_Searchbox.Controls.Add(this.listBox_Search);
            this.metroPanel_Searchbox.Controls.Add(this.metroTextBox_Searchbar);
            this.metroPanel_Searchbox.HorizontalScrollbarBarColor = true;
            this.metroPanel_Searchbox.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Searchbox.HorizontalScrollbarSize = 12;
            this.metroPanel_Searchbox.Location = new System.Drawing.Point(126, 124);
            this.metroPanel_Searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel_Searchbox.MaximumSize = new System.Drawing.Size(363, 283);
            this.metroPanel_Searchbox.MinimumSize = new System.Drawing.Size(363, 36);
            this.metroPanel_Searchbox.Name = "metroPanel_Searchbox";
            this.metroPanel_Searchbox.Size = new System.Drawing.Size(363, 36);
            this.metroPanel_Searchbox.TabIndex = 1;
            this.metroPanel_Searchbox.VerticalScrollbarBarColor = true;
            this.metroPanel_Searchbox.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Searchbox.VerticalScrollbarSize = 13;
            // 
            // listBox_Search
            // 
            this.listBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listBox_Search.FormattingEnabled = true;
            this.listBox_Search.ItemHeight = 22;
            this.listBox_Search.Location = new System.Drawing.Point(0, 34);
            this.listBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Search.Name = "listBox_Search";
            this.listBox_Search.Size = new System.Drawing.Size(363, 244);
            this.listBox_Search.TabIndex = 2;
            this.listBox_Search.Click += new System.EventHandler(this.listBox_Search_Click);
            // 
            // timer_SearchDrop
            // 
            this.timer_SearchDrop.Interval = 1;
            this.timer_SearchDrop.Tick += new System.EventHandler(this.timer_SearchDrop_Tick);
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel_Searchbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(624, 516);
            this.metroPanel_Searchbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_Searchbar;
        private MetroFramework.Controls.MetroPanel metroPanel_Searchbox;
        private System.Windows.Forms.ListBox listBox_Search;
        private System.Windows.Forms.Timer timer_SearchDrop;
    }
}
