namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Search));
            this.metroTextBox_Searchbar = new MetroFramework.Controls.MetroTextBox();
            this.listBox_Search = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // metroTextBox_Searchbar
            // 
            this.metroTextBox_Searchbar.AllowDrop = true;
            // 
            // 
            // 
            this.metroTextBox_Searchbar.CustomButton.Image = null;
            this.metroTextBox_Searchbar.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.metroTextBox_Searchbar.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox_Searchbar.CustomButton.Name = "";
            this.metroTextBox_Searchbar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.CustomButton.TabIndex = 1;
            this.metroTextBox_Searchbar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Searchbar.CustomButton.UseSelectable = true;
            this.metroTextBox_Searchbar.CustomButton.Visible = false;
            this.metroTextBox_Searchbar.DisplayIcon = true;
            this.metroTextBox_Searchbar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Searchbar.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Searchbar.Icon")));
            this.metroTextBox_Searchbar.Lines = new string[0];
            this.metroTextBox_Searchbar.Location = new System.Drawing.Point(137, 129);
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
            this.metroTextBox_Searchbar.Size = new System.Drawing.Size(369, 34);
            this.metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.TabIndex = 0;
            this.metroTextBox_Searchbar.UseSelectable = true;
            this.metroTextBox_Searchbar.WaterMark = "Search...";
            this.metroTextBox_Searchbar.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.metroTextBox_Searchbar.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.metroTextBox_Searchbar.TextChanged += new System.EventHandler(this.metroTextBox_Searchbar_TextChanged);
            // 
            // listBox_Search
            // 
            this.listBox_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Search.FormattingEnabled = true;
            this.listBox_Search.ItemHeight = 20;
            this.listBox_Search.Location = new System.Drawing.Point(137, 161);
            this.listBox_Search.Name = "listBox_Search";
            this.listBox_Search.Size = new System.Drawing.Size(366, 244);
            this.listBox_Search.TabIndex = 8;
            this.listBox_Search.Click += new System.EventHandler(this.listBox_Search_Click);
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox_Search);
            this.Controls.Add(this.metroTextBox_Searchbar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(624, 516);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Search_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_Searchbar;
        private System.Windows.Forms.ListBox listBox_Search;
    }
}
