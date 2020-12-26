namespace GUI
{
    partial class UserControl_Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Exam));
            this.splitContainer_Exam = new System.Windows.Forms.SplitContainer();
            this.metroTile_ComboWord = new MetroFramework.Controls.MetroTile();
            this.pictureBox_ComboWord = new System.Windows.Forms.PictureBox();
            this.label_ComboWord = new System.Windows.Forms.Label();
            this.metroTile_Favorite = new MetroFramework.Controls.MetroTile();
            this.pictureBox_Favorite = new System.Windows.Forms.PictureBox();
            this.label_Favorite = new System.Windows.Forms.Label();
            this.panel_Lock = new System.Windows.Forms.Panel();
            this.label_Lock = new System.Windows.Forms.Label();
            this.pictureBox_Lock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Exam)).BeginInit();
            this.splitContainer_Exam.Panel1.SuspendLayout();
            this.splitContainer_Exam.Panel2.SuspendLayout();
            this.splitContainer_Exam.SuspendLayout();
            this.metroTile_ComboWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).BeginInit();
            this.metroTile_Favorite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favorite)).BeginInit();
            this.panel_Lock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lock)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_Exam
            // 
            this.splitContainer_Exam.Location = new System.Drawing.Point(35, 109);
            this.splitContainer_Exam.Name = "splitContainer_Exam";
            // 
            // splitContainer_Exam.Panel1
            // 
            this.splitContainer_Exam.Panel1.Controls.Add(this.metroTile_ComboWord);
            // 
            // splitContainer_Exam.Panel2
            // 
            this.splitContainer_Exam.Panel2.Controls.Add(this.metroTile_Favorite);
            this.splitContainer_Exam.Size = new System.Drawing.Size(600, 300);
            this.splitContainer_Exam.SplitterDistance = 288;
            this.splitContainer_Exam.SplitterWidth = 20;
            this.splitContainer_Exam.TabIndex = 0;
            // 
            // metroTile_ComboWord
            // 
            this.metroTile_ComboWord.ActiveControl = null;
            this.metroTile_ComboWord.Controls.Add(this.pictureBox_ComboWord);
            this.metroTile_ComboWord.Controls.Add(this.label_ComboWord);
            this.metroTile_ComboWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile_ComboWord.Location = new System.Drawing.Point(0, 0);
            this.metroTile_ComboWord.Name = "metroTile_ComboWord";
            this.metroTile_ComboWord.Size = new System.Drawing.Size(288, 300);
            this.metroTile_ComboWord.TabIndex = 0;
            this.metroTile_ComboWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_ComboWord.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_ComboWord.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_ComboWord.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_ComboWord.UseSelectable = true;
            this.metroTile_ComboWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroTile_ComboWord_MouseDown);
            // 
            // pictureBox_ComboWord
            // 
            this.pictureBox_ComboWord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ComboWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_ComboWord.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ComboWord.Image")));
            this.pictureBox_ComboWord.Location = new System.Drawing.Point(0, 130);
            this.pictureBox_ComboWord.Name = "pictureBox_ComboWord";
            this.pictureBox_ComboWord.Size = new System.Drawing.Size(288, 76);
            this.pictureBox_ComboWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_ComboWord.TabIndex = 0;
            this.pictureBox_ComboWord.TabStop = false;
            this.pictureBox_ComboWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ComboWord_MouseDown);
            // 
            // label_ComboWord
            // 
            this.label_ComboWord.AutoSize = true;
            this.label_ComboWord.BackColor = System.Drawing.Color.Transparent;
            this.label_ComboWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ComboWord.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ComboWord.ForeColor = System.Drawing.Color.White;
            this.label_ComboWord.Location = new System.Drawing.Point(0, 0);
            this.label_ComboWord.MaximumSize = new System.Drawing.Size(288, 130);
            this.label_ComboWord.MinimumSize = new System.Drawing.Size(288, 130);
            this.label_ComboWord.Name = "label_ComboWord";
            this.label_ComboWord.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.label_ComboWord.Size = new System.Drawing.Size(288, 130);
            this.label_ComboWord.TabIndex = 1;
            this.label_ComboWord.Text = "Bộ từ vựng";
            this.label_ComboWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ComboWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_ComboWord_MouseDown);
            // 
            // metroTile_Favorite
            // 
            this.metroTile_Favorite.ActiveControl = null;
            this.metroTile_Favorite.Controls.Add(this.pictureBox_Favorite);
            this.metroTile_Favorite.Controls.Add(this.label_Favorite);
            this.metroTile_Favorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTile_Favorite.Location = new System.Drawing.Point(0, 0);
            this.metroTile_Favorite.Name = "metroTile_Favorite";
            this.metroTile_Favorite.Size = new System.Drawing.Size(292, 300);
            this.metroTile_Favorite.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile_Favorite.TabIndex = 1;
            this.metroTile_Favorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Favorite.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile_Favorite.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_Favorite.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_Favorite.UseSelectable = true;
            this.metroTile_Favorite.UseStyleColors = true;
            this.metroTile_Favorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroTile_Favorite_MouseDown);
            // 
            // pictureBox_Favorite
            // 
            this.pictureBox_Favorite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Favorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Favorite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Favorite.Image")));
            this.pictureBox_Favorite.Location = new System.Drawing.Point(0, 130);
            this.pictureBox_Favorite.Name = "pictureBox_Favorite";
            this.pictureBox_Favorite.Size = new System.Drawing.Size(292, 71);
            this.pictureBox_Favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Favorite.TabIndex = 0;
            this.pictureBox_Favorite.TabStop = false;
            this.pictureBox_Favorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Favorite_MouseDown);
            // 
            // label_Favorite
            // 
            this.label_Favorite.BackColor = System.Drawing.Color.Transparent;
            this.label_Favorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Favorite.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Favorite.ForeColor = System.Drawing.Color.White;
            this.label_Favorite.Location = new System.Drawing.Point(0, 0);
            this.label_Favorite.MaximumSize = new System.Drawing.Size(288, 130);
            this.label_Favorite.MinimumSize = new System.Drawing.Size(288, 130);
            this.label_Favorite.Name = "label_Favorite";
            this.label_Favorite.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.label_Favorite.Size = new System.Drawing.Size(288, 130);
            this.label_Favorite.TabIndex = 1;
            this.label_Favorite.Text = "Từ yêu thích";
            this.label_Favorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Favorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Favorite_MouseDown);
            // 
            // panel_Lock
            // 
            this.panel_Lock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel_Lock.Controls.Add(this.label_Lock);
            this.panel_Lock.Controls.Add(this.pictureBox_Lock);
            this.panel_Lock.Location = new System.Drawing.Point(388, 160);
            this.panel_Lock.Name = "panel_Lock";
            this.panel_Lock.Size = new System.Drawing.Size(209, 204);
            this.panel_Lock.TabIndex = 2;
            // 
            // label_Lock
            // 
            this.label_Lock.BackColor = System.Drawing.Color.Transparent;
            this.label_Lock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Lock.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lock.ForeColor = System.Drawing.Color.White;
            this.label_Lock.Location = new System.Drawing.Point(0, 90);
            this.label_Lock.Name = "label_Lock";
            this.label_Lock.Size = new System.Drawing.Size(209, 114);
            this.label_Lock.TabIndex = 1;
            this.label_Lock.Text = "Cần ít nhất 10 từ trong danh sách yêu thích để mở khóa tính năng";
            this.label_Lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Lock
            // 
            this.pictureBox_Lock.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Lock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_Lock.Image = global::GUI.Properties.Resources.lock1;
            this.pictureBox_Lock.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Lock.Name = "pictureBox_Lock";
            this.pictureBox_Lock.Size = new System.Drawing.Size(209, 90);
            this.pictureBox_Lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Lock.TabIndex = 0;
            this.pictureBox_Lock.TabStop = false;
            // 
            // UserControl_Exam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Lock);
            this.Controls.Add(this.splitContainer_Exam);
            this.Name = "UserControl_Exam";
            this.Size = new System.Drawing.Size(670, 555);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Exam_VisibleChanged);
            this.splitContainer_Exam.Panel1.ResumeLayout(false);
            this.splitContainer_Exam.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Exam)).EndInit();
            this.splitContainer_Exam.ResumeLayout(false);
            this.metroTile_ComboWord.ResumeLayout(false);
            this.metroTile_ComboWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ComboWord)).EndInit();
            this.metroTile_Favorite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Favorite)).EndInit();
            this.panel_Lock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Exam;
        private MetroFramework.Controls.MetroTile metroTile_ComboWord;
        private System.Windows.Forms.PictureBox pictureBox_ComboWord;
        private System.Windows.Forms.Label label_ComboWord;
        private MetroFramework.Controls.MetroTile metroTile_Favorite;
        private System.Windows.Forms.Label label_Favorite;
        private System.Windows.Forms.PictureBox pictureBox_Favorite;
        private System.Windows.Forms.Panel panel_Lock;
        private System.Windows.Forms.Label label_Lock;
        private System.Windows.Forms.PictureBox pictureBox_Lock;
    }
}
