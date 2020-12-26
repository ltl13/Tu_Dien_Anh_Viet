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
            this.listBox_Search = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTextBox_Searchbar = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Search
            // 
            this.listBox_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Search.FormattingEnabled = true;
            this.listBox_Search.ItemHeight = 20;
            this.listBox_Search.Location = new System.Drawing.Point(146, 158);
            this.listBox_Search.Name = "listBox_Search";
            this.listBox_Search.Size = new System.Drawing.Size(369, 244);
            this.listBox_Search.TabIndex = 8;
            this.listBox_Search.Click += new System.EventHandler(this.listBox_Search_Click);
            this.listBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Search_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Search);
            this.panel1.Controls.Add(this.metroTextBox_Searchbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 555);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // metroTextBox_Searchbar
            // 
            this.metroTextBox_Searchbar.AllowDrop = true;
            this.metroTextBox_Searchbar.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.metroTextBox_Searchbar.CustomButton.Image = null;
            this.metroTextBox_Searchbar.CustomButton.Location = new System.Drawing.Point(338, 2);
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
            this.metroTextBox_Searchbar.Lines = new string[0];
            this.metroTextBox_Searchbar.Location = new System.Drawing.Point(146, 124);
            this.metroTextBox_Searchbar.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox_Searchbar.MaxLength = 32;
            this.metroTextBox_Searchbar.Name = "metroTextBox_Searchbar";
            this.metroTextBox_Searchbar.PasswordChar = '\0';            this.metroTextBox_Searchbar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Searchbar.SelectedText = "";
            this.metroTextBox_Searchbar.SelectionLength = 0;
            this.metroTextBox_Searchbar.SelectionStart = 0;
            this.metroTextBox_Searchbar.ShortcutsEnabled = true;
            this.metroTextBox_Searchbar.Size = new System.Drawing.Size(370, 34);
            this.metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.TabIndex = 0;
            this.metroTextBox_Searchbar.UseSelectable = true;
            this.metroTextBox_Searchbar.WaterMark = "Search...";
            this.metroTextBox_Searchbar.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.metroTextBox_Searchbar.WaterMarkFont = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox_Searchbar.TextChanged += new System.EventHandler(this.metroTextBox_Searchbar_TextChanged);
            this.metroTextBox_Searchbar.Enter += new System.EventHandler(this.metroTextBox_Searchbar_Enter);
            this.metroTextBox_Searchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox_Searchbar_KeyDown);
            // 
            // UserControl_Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(670, 555);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Search_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_Searchbar;
        private System.Windows.Forms.ListBox listBox_Search;
        private System.Windows.Forms.Panel panel1;
    }
}
