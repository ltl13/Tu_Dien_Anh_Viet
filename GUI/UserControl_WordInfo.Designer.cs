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
            this.splitContainer_WordInfo = new System.Windows.Forms.SplitContainer();
            this.xuiButton_Interest = new XanderUI.XUIButton();
            this.xuiButton_NotInterest = new XanderUI.XUIButton();
            this.metroTile_Back = new MetroFramework.Controls.MetroTile();
            this.metroTile_Speaker = new MetroFramework.Controls.MetroTile();
            this.label_Word = new System.Windows.Forms.Label();
            this.metroTabControl_WordInfo = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Meaning = new System.Windows.Forms.TabPage();
            this.rtb_vietnamese = new System.Windows.Forms.RichTextBox();
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
            this.splitContainer_WordInfo.Size = new System.Drawing.Size(670, 555);
            this.splitContainer_WordInfo.SplitterDistance = 123;
            this.splitContainer_WordInfo.TabIndex = 0;
            // 
            // xuiButton_Interest
            // 
            this.xuiButton_Interest.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ButtonImage = global::GUI.Properties.Resources.star_yellow;
            this.xuiButton_Interest.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Interest.ButtonText = "";
            this.xuiButton_Interest.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.CornerRadius = 5;
            this.xuiButton_Interest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Interest.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Interest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Interest.Location = new System.Drawing.Point(617, 72);
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
            this.xuiButton_NotInterest.ButtonImage = global::GUI.Properties.Resources.star_white;
            this.xuiButton_NotInterest.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_NotInterest.ButtonText = "";
            this.xuiButton_NotInterest.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.CornerRadius = 5;
            this.xuiButton_NotInterest.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_NotInterest.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_NotInterest.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_NotInterest.Location = new System.Drawing.Point(617, 72);
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
            this.metroTile_Back.Location = new System.Drawing.Point(603, 3);
            this.metroTile_Back.Name = "metroTile_Back";
            this.metroTile_Back.Size = new System.Drawing.Size(64, 43);
            this.metroTile_Back.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Back.TabIndex = 3;
            this.metroTile_Back.TileImage = global::GUI.Properties.Resources.back_arrow;
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
            this.metroTile_Speaker.Location = new System.Drawing.Point(562, 75);
            this.metroTile_Speaker.Name = "metroTile_Speaker";
            this.metroTile_Speaker.Size = new System.Drawing.Size(42, 39);
            this.metroTile_Speaker.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Speaker.TabIndex = 1;
            this.metroTile_Speaker.TileImage = global::GUI.Properties.Resources.volume;
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
            this.label_Word.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_Word.Size = new System.Drawing.Size(670, 123);
            this.label_Word.TabIndex = 0;
            this.label_Word.Text = "English";
            // 
            // metroTabControl_WordInfo
            // 
            this.metroTabControl_WordInfo.Controls.Add(this.tabPage_Meaning);
            this.metroTabControl_WordInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_WordInfo.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl_WordInfo.Name = "metroTabControl_WordInfo";
            this.metroTabControl_WordInfo.SelectedIndex = 0;
            this.metroTabControl_WordInfo.Size = new System.Drawing.Size(670, 428);
            this.metroTabControl_WordInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl_WordInfo.TabIndex = 0;
            this.metroTabControl_WordInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl_WordInfo.UseSelectable = true;
            // 
            // tabPage_Meaning
            // 
            this.tabPage_Meaning.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Meaning.Controls.Add(this.rtb_vietnamese);
            this.tabPage_Meaning.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Meaning.Name = "tabPage_Meaning";
            this.tabPage_Meaning.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tabPage_Meaning.Size = new System.Drawing.Size(662, 386);
            this.tabPage_Meaning.TabIndex = 3;
            this.tabPage_Meaning.Text = "Nghĩa";
            // 
            // rtb_vietnamese
            // 
            this.rtb_vietnamese.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_vietnamese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_vietnamese.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_vietnamese.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_vietnamese.Location = new System.Drawing.Point(10, 0);
            this.rtb_vietnamese.Name = "rtb_vietnamese";
            this.rtb_vietnamese.ReadOnly = true;
            this.rtb_vietnamese.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_vietnamese.Size = new System.Drawing.Size(652, 386);
            this.rtb_vietnamese.TabIndex = 0;
            this.rtb_vietnamese.Text = "";
            // 
            // UserControl_WordInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer_WordInfo);
            this.Name = "UserControl_WordInfo";
            this.Size = new System.Drawing.Size(670, 555);
            this.Load += new System.EventHandler(this.UserControl_WordInfo_Load);
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
        private System.Windows.Forms.TabPage tabPage_Meaning;
        private XanderUI.XUIButton xuiButton_Interest;
        private XanderUI.XUIButton xuiButton_NotInterest;
        private System.Windows.Forms.RichTextBox rtb_vietnamese;
        private MetroFramework.Controls.MetroTile metroTile_Back;
    }
}
