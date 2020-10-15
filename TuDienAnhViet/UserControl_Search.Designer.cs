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
            this.timer_SearchDrop = new System.Windows.Forms.Timer(this.components);
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
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
            this.metroTextBox_Searchbar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Searchbar.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Searchbar.Icon")));
            this.metroTextBox_Searchbar.Lines = new string[0];
            this.metroTextBox_Searchbar.Location = new System.Drawing.Point(126, 122);
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
            // timer_SearchDrop
            // 
            this.timer_SearchDrop.Interval = 1;
            this.timer_SearchDrop.Tick += new System.EventHandler(this.timer_SearchDrop_Tick);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.DropDownHeight = 150;
            this.comboBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.IntegralHeight = false;
            this.comboBox_Search.Location = new System.Drawing.Point(126, 163);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(363, 28);
            this.comboBox_Search.TabIndex = 1;
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox_Searchbar);
            this.Controls.Add(this.comboBox_Search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(624, 516);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_Searchbar;
        private System.Windows.Forms.Timer timer_SearchDrop;
        private System.Windows.Forms.ComboBox comboBox_Search;
    }
}
