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
            this.metroPanel_Eng = new MetroFramework.Controls.MetroPanel();
            this.panel_Viet = new System.Windows.Forms.Panel();
            this.label_Viet = new System.Windows.Forms.Label();
            this.panel_Eng = new System.Windows.Forms.Panel();
            this.label_Eng = new System.Windows.Forms.Label();
            this.xuiButton_Next = new XanderUI.XUIButton();
            this.xuiButton_Previous = new XanderUI.XUIButton();
            this.xuiButton_Delete = new XanderUI.XUIButton();
            this.label_Number = new System.Windows.Forms.Label();
            this.panel_Number = new System.Windows.Forms.Panel();
            this.metroPanel_Eng.SuspendLayout();
            this.panel_Viet.SuspendLayout();
            this.panel_Eng.SuspendLayout();
            this.panel_Number.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel_Eng
            // 
            this.metroPanel_Eng.Controls.Add(this.panel_Viet);
            this.metroPanel_Eng.Controls.Add(this.panel_Eng);
            this.metroPanel_Eng.HorizontalScrollbarBarColor = true;
            this.metroPanel_Eng.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Eng.HorizontalScrollbarSize = 10;
            this.metroPanel_Eng.Location = new System.Drawing.Point(61, 47);
            this.metroPanel_Eng.Name = "metroPanel_Eng";
            this.metroPanel_Eng.Size = new System.Drawing.Size(504, 309);
            this.metroPanel_Eng.TabIndex = 0;
            this.metroPanel_Eng.VerticalScrollbarBarColor = true;
            this.metroPanel_Eng.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Eng.VerticalScrollbarSize = 10;
            this.metroPanel_Eng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroPanel_Eng_MouseDown);
            // 
            // panel_Viet
            // 
            this.panel_Viet.BackColor = System.Drawing.Color.Transparent;
            this.panel_Viet.Controls.Add(this.label_Viet);
            this.panel_Viet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Viet.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Viet.Location = new System.Drawing.Point(0, 0);
            this.panel_Viet.Name = "panel_Viet";
            this.panel_Viet.Size = new System.Drawing.Size(504, 309);
            this.panel_Viet.TabIndex = 4;
            // 
            // label_Viet
            // 
            this.label_Viet.BackColor = System.Drawing.Color.Transparent;
            this.label_Viet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Viet.Location = new System.Drawing.Point(0, 0);
            this.label_Viet.Name = "label_Viet";
            this.label_Viet.Size = new System.Drawing.Size(504, 309);
            this.label_Viet.TabIndex = 2;
            this.label_Viet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Viet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Viet_MouseDown);
            // 
            // panel_Eng
            // 
            this.panel_Eng.BackColor = System.Drawing.Color.Transparent;
            this.panel_Eng.Controls.Add(this.label_Eng);
            this.panel_Eng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Eng.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Eng.Location = new System.Drawing.Point(0, 0);
            this.panel_Eng.Name = "panel_Eng";
            this.panel_Eng.Size = new System.Drawing.Size(504, 309);
            this.panel_Eng.TabIndex = 3;
            // 
            // label_Eng
            // 
            this.label_Eng.BackColor = System.Drawing.Color.Transparent;
            this.label_Eng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Eng.Location = new System.Drawing.Point(0, 0);
            this.label_Eng.Name = "label_Eng";
            this.label_Eng.Size = new System.Drawing.Size(504, 309);
            this.label_Eng.TabIndex = 2;
            this.label_Eng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Eng.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Eng_MouseDown);
            // 
            // xuiButton_Next
            // 
            this.xuiButton_Next.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Next.ButtonImage")));
            this.xuiButton_Next.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Next.ButtonText = "";
            this.xuiButton_Next.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.CornerRadius = 5;
            this.xuiButton_Next.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Next.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Next.Location = new System.Drawing.Point(374, 379);
            this.xuiButton_Next.Name = "xuiButton_Next";
            this.xuiButton_Next.Size = new System.Drawing.Size(46, 45);
            this.xuiButton_Next.TabIndex = 1;
            this.xuiButton_Next.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_Next_MouseDown);
            // 
            // xuiButton_Previous
            // 
            this.xuiButton_Previous.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Previous.ButtonImage")));
            this.xuiButton_Previous.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Previous.ButtonText = "";
            this.xuiButton_Previous.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.CornerRadius = 5;
            this.xuiButton_Previous.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Previous.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Previous.Location = new System.Drawing.Point(215, 379);
            this.xuiButton_Previous.Name = "xuiButton_Previous";
            this.xuiButton_Previous.Size = new System.Drawing.Size(46, 45);
            this.xuiButton_Previous.TabIndex = 2;
            this.xuiButton_Previous.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Previous.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xuiButton_Previous_MouseDown);
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
            this.xuiButton_Delete.Location = new System.Drawing.Point(532, 452);
            this.xuiButton_Delete.Name = "xuiButton_Delete";
            this.xuiButton_Delete.Size = new System.Drawing.Size(33, 32);
            this.xuiButton_Delete.TabIndex = 4;
            this.xuiButton_Delete.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Delete.Click += new System.EventHandler(this.xuiButton_Delete_Click);
            // 
            // label_Number
            // 
            this.label_Number.BackColor = System.Drawing.SystemColors.Control;
            this.label_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Number.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(0, 0);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(101, 24);
            this.label_Number.TabIndex = 6;
            this.label_Number.Text = "1000/1000";
            this.label_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Number
            // 
            this.panel_Number.Controls.Add(this.label_Number);
            this.panel_Number.Location = new System.Drawing.Point(269, 390);
            this.panel_Number.Name = "panel_Number";
            this.panel_Number.Size = new System.Drawing.Size(101, 24);
            this.panel_Number.TabIndex = 7;
            // 
            // UserControl_Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Number);
            this.Controls.Add(this.xuiButton_Delete);
            this.Controls.Add(this.xuiButton_Previous);
            this.Controls.Add(this.xuiButton_Next);
            this.Controls.Add(this.metroPanel_Eng);
            this.Name = "UserControl_Flashcard";
            this.Size = new System.Drawing.Size(624, 516);
            this.VisibleChanged += new System.EventHandler(this.UserControl_Flashcard_VisibleChanged);
            this.metroPanel_Eng.ResumeLayout(false);
            this.panel_Viet.ResumeLayout(false);
            this.panel_Eng.ResumeLayout(false);
            this.panel_Number.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel_Eng;
        private XanderUI.XUIButton xuiButton_Next;
        private XanderUI.XUIButton xuiButton_Previous;
        private XanderUI.XUIButton xuiButton_Delete;
        private System.Windows.Forms.Panel panel_Eng;
        private System.Windows.Forms.Label label_Eng;
        private System.Windows.Forms.Panel panel_Viet;
        private System.Windows.Forms.Label label_Viet;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Panel panel_Number;
    }
}
