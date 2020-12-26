namespace GUI
{
    partial class Form_Game_CarRacing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game_CarRacing));
            this.timer_carRacing = new System.Windows.Forms.Timer(this.components);
            this.metroButton_Back = new MetroFramework.Controls.MetroButton();
            this.metroButton_Music = new MetroFramework.Controls.MetroButton();
            this.label_NumQues = new System.Windows.Forms.Label();
            this.panel_question = new System.Windows.Forms.Panel();
            this.label_Question = new System.Windows.Forms.Label();
            this.xuiButton_A = new XanderUI.XUIButton();
            this.xuiButton_B = new XanderUI.XUIButton();
            this.xuiButton_C = new XanderUI.XUIButton();
            this.xuiButton_D = new XanderUI.XUIButton();
            this.panel_question.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_carRacing
            // 
            this.timer_carRacing.Tick += new System.EventHandler(this.timer_carRacing_Tick);
            // 
            // metroButton_Back
            // 
            this.metroButton_Back.Location = new System.Drawing.Point(1366, 12);
            this.metroButton_Back.Name = "metroButton_Back";
            this.metroButton_Back.Size = new System.Drawing.Size(138, 60);
            this.metroButton_Back.TabIndex = 0;
            this.metroButton_Back.Text = "Back";
            this.metroButton_Back.UseSelectable = true;
            this.metroButton_Back.Click += new System.EventHandler(this.metroButton_Back_Click);
            // 
            // metroButton_Music
            // 
            this.metroButton_Music.Location = new System.Drawing.Point(1201, 12);
            this.metroButton_Music.Name = "metroButton_Music";
            this.metroButton_Music.Size = new System.Drawing.Size(138, 60);
            this.metroButton_Music.TabIndex = 1;
            this.metroButton_Music.Text = "Music";
            this.metroButton_Music.UseSelectable = true;
            this.metroButton_Music.Click += new System.EventHandler(this.metroButton_Music_Click);
            // 
            // label_NumQues
            // 
            this.label_NumQues.AutoSize = true;
            this.label_NumQues.Location = new System.Drawing.Point(1073, 25);
            this.label_NumQues.Name = "label_NumQues";
            this.label_NumQues.Size = new System.Drawing.Size(104, 25);
            this.label_NumQues.TabIndex = 6;
            this.label_NumQues.Text = "numQues";
            // 
            // panel_question
            // 
            this.panel_question.BackColor = System.Drawing.Color.Transparent;
            this.panel_question.Controls.Add(this.label_Question);
            this.panel_question.Location = new System.Drawing.Point(350, 80);
            this.panel_question.Name = "panel_question";
            this.panel_question.Size = new System.Drawing.Size(989, 88);
            this.panel_question.TabIndex = 7;
            // 
            // label_Question
            // 
            this.label_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(0, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(989, 88);
            this.label_Question.TabIndex = 8;
            this.label_Question.Text = "numQues";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuiButton_A
            // 
            this.xuiButton_A.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_A.ButtonImage = null;
            this.xuiButton_A.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_A.ButtonText = "A";
            this.xuiButton_A.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton_A.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton_A.CornerRadius = 5;
            this.xuiButton_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_A.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_A.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton_A.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton_A.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_A.Location = new System.Drawing.Point(407, 188);
            this.xuiButton_A.Name = "xuiButton_A";
            this.xuiButton_A.Size = new System.Drawing.Size(423, 131);
            this.xuiButton_A.TabIndex = 8;
            this.xuiButton_A.TextColor = System.Drawing.Color.Black;
            this.xuiButton_A.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_A.Click += new System.EventHandler(this.xuiButton_A_Click);
            // 
            // xuiButton_B
            // 
            this.xuiButton_B.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_B.ButtonImage = null;
            this.xuiButton_B.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_B.ButtonText = "B";
            this.xuiButton_B.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton_B.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton_B.CornerRadius = 5;
            this.xuiButton_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_B.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_B.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton_B.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton_B.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_B.Location = new System.Drawing.Point(859, 188);
            this.xuiButton_B.Name = "xuiButton_B";
            this.xuiButton_B.Size = new System.Drawing.Size(423, 131);
            this.xuiButton_B.TabIndex = 9;
            this.xuiButton_B.TextColor = System.Drawing.Color.Black;
            this.xuiButton_B.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_B.Click += new System.EventHandler(this.xuiButton_B_Click);
            // 
            // xuiButton_C
            // 
            this.xuiButton_C.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_C.ButtonImage = null;
            this.xuiButton_C.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_C.ButtonText = "C";
            this.xuiButton_C.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton_C.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton_C.CornerRadius = 5;
            this.xuiButton_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_C.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_C.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton_C.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton_C.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_C.Location = new System.Drawing.Point(407, 325);
            this.xuiButton_C.Name = "xuiButton_C";
            this.xuiButton_C.Size = new System.Drawing.Size(423, 131);
            this.xuiButton_C.TabIndex = 10;
            this.xuiButton_C.TextColor = System.Drawing.Color.Black;
            this.xuiButton_C.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_C.Click += new System.EventHandler(this.xuiButton_C_Click);
            // 
            // xuiButton_D
            // 
            this.xuiButton_D.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_D.ButtonImage = null;
            this.xuiButton_D.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_D.ButtonText = "D";
            this.xuiButton_D.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton_D.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton_D.CornerRadius = 5;
            this.xuiButton_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_D.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_D.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton_D.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton_D.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_D.Location = new System.Drawing.Point(859, 325);
            this.xuiButton_D.Name = "xuiButton_D";
            this.xuiButton_D.Size = new System.Drawing.Size(423, 131);
            this.xuiButton_D.TabIndex = 11;
            this.xuiButton_D.TextColor = System.Drawing.Color.Black;
            this.xuiButton_D.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_D.Click += new System.EventHandler(this.xuiButton_D_Click);
            // 
            // Form_Game_CarRacing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.road;
            this.ClientSize = new System.Drawing.Size(1526, 500);
            this.ControlBox = false;
            this.Controls.Add(this.xuiButton_D);
            this.Controls.Add(this.xuiButton_C);
            this.Controls.Add(this.xuiButton_B);
            this.Controls.Add(this.xuiButton_A);
            this.Controls.Add(this.panel_question);
            this.Controls.Add(this.label_NumQues);
            this.Controls.Add(this.metroButton_Music);
            this.Controls.Add(this.metroButton_Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game_CarRacing";
            this.Text = "Form_Game_CarRacing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_CarRacing_Paint);
            this.panel_question.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_carRacing;
        private MetroFramework.Controls.MetroButton metroButton_Back;
        private MetroFramework.Controls.MetroButton metroButton_Music;
        private System.Windows.Forms.Label label_NumQues;
        private System.Windows.Forms.Panel panel_question;
        private System.Windows.Forms.Label label_Question;
        private XanderUI.XUIButton xuiButton_A;
        private XanderUI.XUIButton xuiButton_B;
        private XanderUI.XUIButton xuiButton_C;
        private XanderUI.XUIButton xuiButton_D;
    }
}