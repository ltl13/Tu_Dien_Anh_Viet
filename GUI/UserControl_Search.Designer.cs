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
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.tb_sensten = new System.Windows.Forms.TextBox();
            this.tb_translate = new System.Windows.Forms.TextBox();
            this.bt_trans_EngToViet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_dich_VietToEng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroTextBox_Searchbar
            // 
            this.metroTextBox_Searchbar.AllowDrop = true;
            // 
            // 
            // 
            this.metroTextBox_Searchbar.CustomButton.Image = null;
            this.metroTextBox_Searchbar.CustomButton.Location = new System.Drawing.Point(674, 2);
            this.metroTextBox_Searchbar.CustomButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.metroTextBox_Searchbar.CustomButton.Name = "";
            this.metroTextBox_Searchbar.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.CustomButton.TabIndex = 1;
            this.metroTextBox_Searchbar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Searchbar.CustomButton.UseSelectable = true;
            this.metroTextBox_Searchbar.CustomButton.Visible = false;
            this.metroTextBox_Searchbar.DisplayIcon = true;
            this.metroTextBox_Searchbar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Searchbar.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox_Searchbar.Icon")));
            this.metroTextBox_Searchbar.Lines = new string[0];
            this.metroTextBox_Searchbar.Location = new System.Drawing.Point(274, 287);
            this.metroTextBox_Searchbar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.metroTextBox_Searchbar.MaxLength = 32;
            this.metroTextBox_Searchbar.Name = "metroTextBox_Searchbar";
            this.metroTextBox_Searchbar.PasswordChar = '\0';
            this.metroTextBox_Searchbar.PromptText = "Search...";
            this.metroTextBox_Searchbar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Searchbar.SelectedText = "";
            this.metroTextBox_Searchbar.SelectionLength = 0;
            this.metroTextBox_Searchbar.SelectionStart = 0;
            this.metroTextBox_Searchbar.ShortcutsEnabled = true;
            this.metroTextBox_Searchbar.Size = new System.Drawing.Size(738, 66);
            this.metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Searchbar.TabIndex = 0;
            this.metroTextBox_Searchbar.UseSelectable = true;
            this.metroTextBox_Searchbar.WaterMark = "Search...";
            this.metroTextBox_Searchbar.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.metroTextBox_Searchbar.WaterMarkFont = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.metroTextBox_Searchbar.TextChanged += new System.EventHandler(this.metroTextBox_Searchbar_TextChanged);
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.DropDownHeight = 150;
            this.comboBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.IntegralHeight = false;
            this.comboBox_Search.Location = new System.Drawing.Point(274, 287);
            this.comboBox_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(722, 46);
            this.comboBox_Search.TabIndex = 1;
            this.comboBox_Search.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Search_SelectionChangeCommitted);
            // 
            // tb_sensten
            // 
            this.tb_sensten.Location = new System.Drawing.Point(95, 505);
            this.tb_sensten.Multiline = true;
            this.tb_sensten.Name = "tb_sensten";
            this.tb_sensten.Size = new System.Drawing.Size(419, 352);
            this.tb_sensten.TabIndex = 2;
            // 
            // tb_translate
            // 
            this.tb_translate.Location = new System.Drawing.Point(717, 505);
            this.tb_translate.Multiline = true;
            this.tb_translate.Name = "tb_translate";
            this.tb_translate.Size = new System.Drawing.Size(419, 352);
            this.tb_translate.TabIndex = 3;
            // 
            // bt_trans_EngToViet
            // 
            this.bt_trans_EngToViet.Location = new System.Drawing.Point(529, 561);
            this.bt_trans_EngToViet.Name = "bt_trans_EngToViet";
            this.bt_trans_EngToViet.Size = new System.Drawing.Size(170, 65);
            this.bt_trans_EngToViet.TabIndex = 4;
            this.bt_trans_EngToViet.Text = "Translate";
            this.bt_trans_EngToViet.UseVisualStyleBackColor = true;
            this.bt_trans_EngToViet.Click += new System.EventHandler(this.bt_trans_EngToViet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(886, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // bt_dich_VietToEng
            // 
            this.bt_dich_VietToEng.Location = new System.Drawing.Point(529, 695);
            this.bt_dich_VietToEng.Name = "bt_dich_VietToEng";
            this.bt_dich_VietToEng.Size = new System.Drawing.Size(170, 65);
            this.bt_dich_VietToEng.TabIndex = 7;
            this.bt_dich_VietToEng.Text = "Dịch";
            this.bt_dich_VietToEng.UseVisualStyleBackColor = true;
            this.bt_dich_VietToEng.Click += new System.EventHandler(this.bt_dich_VietToEng_Click);
            // 
            // UserControl_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_dich_VietToEng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_trans_EngToViet);
            this.Controls.Add(this.tb_translate);
            this.Controls.Add(this.tb_sensten);
            this.Controls.Add(this.metroTextBox_Searchbar);
            this.Controls.Add(this.comboBox_Search);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "UserControl_Search";
            this.Size = new System.Drawing.Size(1248, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_Searchbar;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.TextBox tb_translate;
        private System.Windows.Forms.Button bt_trans_EngToViet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_dich_VietToEng;
        private System.Windows.Forms.TextBox tb_sensten;
    }
}
