namespace GUI
{
    partial class UserControl_Flashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Flashcard));
            this.panel_Viet = new System.Windows.Forms.Panel();
            this.label_Viet = new System.Windows.Forms.Label();
            this.panel_Eng = new System.Windows.Forms.Panel();
            this.label_Eng = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.panel_Number = new System.Windows.Forms.Panel();
            this.pictureBox_Next = new System.Windows.Forms.PictureBox();
            this.pictureBox_Prev = new System.Windows.Forms.PictureBox();
            this.panel_Position = new System.Windows.Forms.Panel();
            this.xuiButton_Delete = new XanderUI.XUIButton();
            this.xuiButton_Panel = new XanderUI.XUIButton();
            this.panel_Viet.SuspendLayout();
            this.panel_Eng.SuspendLayout();
            this.panel_Number.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prev)).BeginInit();
            this.panel_Position.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Viet
            // 
            this.panel_Viet.BackColor = System.Drawing.Color.Transparent;
            this.panel_Viet.Controls.Add(this.label_Viet);
            this.panel_Viet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Viet.Location = new System.Drawing.Point(60, 30);
            this.panel_Viet.Name = "panel_Viet";
            this.panel_Viet.Size = new System.Drawing.Size(550, 400);
            this.panel_Viet.TabIndex = 4;
            // 
            // label_Viet
            // 
            this.label_Viet.BackColor = System.Drawing.Color.White;
            this.label_Viet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Viet.Location = new System.Drawing.Point(0, 0);
            this.label_Viet.Name = "label_Viet";
            this.label_Viet.Size = new System.Drawing.Size(550, 400);
            this.label_Viet.TabIndex = 2;
            this.label_Viet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Viet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Viet_MouseDown);
            this.label_Viet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Viet_MouseUp);
            // 
            // panel_Eng
            // 
            this.panel_Eng.BackColor = System.Drawing.Color.Transparent;
            this.panel_Eng.Controls.Add(this.label_Eng);
            this.panel_Eng.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Eng.Location = new System.Drawing.Point(60, 30);
            this.panel_Eng.Name = "panel_Eng";
            this.panel_Eng.Size = new System.Drawing.Size(550, 400);
            this.panel_Eng.TabIndex = 3;
            // 
            // label_Eng
            // 
            this.label_Eng.BackColor = System.Drawing.Color.White;
            this.label_Eng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Eng.Location = new System.Drawing.Point(0, 0);
            this.label_Eng.Name = "label_Eng";
            this.label_Eng.Size = new System.Drawing.Size(550, 400);
            this.label_Eng.TabIndex = 2;
            this.label_Eng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Eng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Eng_MouseDown);
            this.label_Eng.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Eng_MouseUp);
            // 
            // label_Number
            // 
            this.label_Number.BackColor = System.Drawing.Color.White;
            this.label_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Number.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(0, 0);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(220, 45);
            this.label_Number.TabIndex = 6;
            this.label_Number.Text = "1000/1000";
            this.label_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Number.TextChanged += new System.EventHandler(this.label_Number_TextChanged);
            // 
            // panel_Number
            // 
            this.panel_Number.Controls.Add(this.pictureBox_Next);
            this.panel_Number.Controls.Add(this.pictureBox_Prev);
            this.panel_Number.Controls.Add(this.label_Number);
            this.panel_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Number.Location = new System.Drawing.Point(0, 0);
            this.panel_Number.Name = "panel_Number";
            this.panel_Number.Size = new System.Drawing.Size(220, 45);
            this.panel_Number.TabIndex = 7;
            // 
            // pictureBox_Next
            // 
            this.pictureBox_Next.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Next.Image = global::GUI.Properties.Resources.right_arrow;
            this.pictureBox_Next.Location = new System.Drawing.Point(175, 0);
            this.pictureBox_Next.Name = "pictureBox_Next";
            this.pictureBox_Next.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Next.TabIndex = 10;
            this.pictureBox_Next.TabStop = false;
            this.pictureBox_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Next_MouseDown);
            this.pictureBox_Next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Next_MouseUp);
            // 
            // pictureBox_Prev
            // 
            this.pictureBox_Prev.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Prev.Image = global::GUI.Properties.Resources.left_arrow;
            this.pictureBox_Prev.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Prev.Name = "pictureBox_Prev";
            this.pictureBox_Prev.Size = new System.Drawing.Size(45, 45);
            this.pictureBox_Prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prev.TabIndex = 9;
            this.pictureBox_Prev.TabStop = false;
            this.pictureBox_Prev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Prev_MouseDown);
            this.pictureBox_Prev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Prev_MouseUp);
            // 
            // panel_Position
            // 
            this.panel_Position.Controls.Add(this.panel_Number);
            this.panel_Position.Location = new System.Drawing.Point(225, 475);
            this.panel_Position.Name = "panel_Position";
            this.panel_Position.Size = new System.Drawing.Size(220, 45);
            this.panel_Position.TabIndex = 8;
            // 
            // xuiButton_Delete
            // 
            this.xuiButton_Delete.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Delete.ButtonImage")));
            this.xuiButton_Delete.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton_Delete.ButtonText = "Button";
            this.xuiButton_Delete.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_Delete.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.CornerRadius = 5;
            this.xuiButton_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Delete.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_Delete.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Delete.Location = new System.Drawing.Point(587, 477);
            this.xuiButton_Delete.Name = "xuiButton_Delete";
            this.xuiButton_Delete.Size = new System.Drawing.Size(33, 32);
            this.xuiButton_Delete.TabIndex = 4;
            this.xuiButton_Delete.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Delete.Click += new System.EventHandler(this.xuiButton_Delete_Click);
            // 
            // xuiButton_Panel
            // 
            this.xuiButton_Panel.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_Panel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Panel.ButtonImage")));
            this.xuiButton_Panel.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_Panel.ButtonText = "";
            this.xuiButton_Panel.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton_Panel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Panel.CornerRadius = 5;
            this.xuiButton_Panel.Enabled = false;
            this.xuiButton_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_Panel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Panel.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton_Panel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Panel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Panel.Location = new System.Drawing.Point(50, 20);
            this.xuiButton_Panel.Name = "xuiButton_Panel";
            this.xuiButton_Panel.Size = new System.Drawing.Size(570, 420);
            this.xuiButton_Panel.TabIndex = 5;
            this.xuiButton_Panel.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Panel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // UserControl_Flashcard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Eng);
            this.Controls.Add(this.panel_Viet);
            this.Controls.Add(this.xuiButton_Delete);
            this.Controls.Add(this.xuiButton_Panel);
            this.Controls.Add(this.panel_Position);
            this.Name = "UserControl_Flashcard";
            this.Size = new System.Drawing.Size(670, 555);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Flashcard_VisibleChanged);
            this.panel_Viet.ResumeLayout(false);
            this.panel_Eng.ResumeLayout(false);
            this.panel_Number.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prev)).EndInit();
            this.panel_Position.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIButton xuiButton_Delete;
        private System.Windows.Forms.Panel panel_Eng;
        private System.Windows.Forms.Label label_Eng;
        private System.Windows.Forms.Panel panel_Viet;
        private System.Windows.Forms.Label label_Viet;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Panel panel_Number;
        private XanderUI.XUIButton xuiButton_Panel;
        private System.Windows.Forms.Panel panel_Position;
        private System.Windows.Forms.PictureBox pictureBox_Next;
        private System.Windows.Forms.PictureBox pictureBox_Prev;
    }
}
