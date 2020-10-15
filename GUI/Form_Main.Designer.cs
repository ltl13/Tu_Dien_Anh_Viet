namespace GUI
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.timer_PanelSearch = new System.Windows.Forms.Timer(this.components);
            this.panel_Search = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.panel_Search.SuspendLayout();
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
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Location = new System.Drawing.Point(249, 74);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(624, 516);
            this.panel_Main.TabIndex = 5;
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.Image")));
            this.pictureBox_Search.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.InitialImage")));
            this.pictureBox_Search.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(81, 77);
            this.pictureBox_Search.TabIndex = 0;
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.MouseEnter += new System.EventHandler(this.pictureBox_Search_MouseEnter);
            this.pictureBox_Search.MouseLeave += new System.EventHandler(this.pictureBox_Search_MouseLeave);
            // 
            // timer_PanelSearch
            // 
            this.timer_PanelSearch.Interval = 1;
            this.timer_PanelSearch.Tick += new System.EventHandler(this.timer_PanelSearch_Tick);
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel_Search.Controls.Add(this.pictureBox_Search);
            this.panel_Search.Location = new System.Drawing.Point(23, 74);
            this.panel_Search.MaximumSize = new System.Drawing.Size(227, 77);
            this.panel_Search.MinimumSize = new System.Drawing.Size(81, 77);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(81, 77);
            this.panel_Search.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.panel_Main);
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager_FormMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager_FormMain;
        private System.Windows.Forms.Button button_Exit;
        public System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.Timer timer_PanelSearch;
        private System.Windows.Forms.Panel panel_Search;
    }
}

