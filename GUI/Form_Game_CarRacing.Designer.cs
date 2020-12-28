﻿namespace GUI
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
            this.label_NumQues = new System.Windows.Forms.Label();
            this.panel_question = new System.Windows.Forms.Panel();
            this.label_Question = new System.Windows.Forms.Label();
            this.xuiButton_A = new XanderUI.XUIButton();
            this.xuiButton_B = new XanderUI.XUIButton();
            this.xuiButton_C = new XanderUI.XUIButton();
            this.xuiButton_D = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.xuiButton_Back = new XanderUI.XUIButton();
            this.xuiButton_Music = new XanderUI.XUIButton();
            this.xuiButton_retry = new XanderUI.XUIButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_question.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_carRacing
            // 
            this.timer_carRacing.Tick += new System.EventHandler(this.timer_carRacing_Tick);
            // 
            // label_NumQues
            // 
            this.label_NumQues.AutoSize = true;
            this.label_NumQues.Location = new System.Drawing.Point(1082, 47);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1082, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(971, 47);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(52, 25);
            this.label_Time.TabIndex = 14;
            this.label_Time.Text = "time";
            // 
            // xuiButton_Back
            // 
            this.xuiButton_Back.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Back.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Back.ButtonImage")));
            this.xuiButton_Back.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton_Back.ButtonText = "";
            this.xuiButton_Back.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_Back.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.CornerRadius = 5;
            this.xuiButton_Back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Back.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_Back.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Back.Location = new System.Drawing.Point(1470, 12);
            this.xuiButton_Back.Name = "xuiButton_Back";
            this.xuiButton_Back.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_Back.TabIndex = 15;
            this.xuiButton_Back.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Back.Click += new System.EventHandler(this.xuiButton_Back_Click);
            // 
            // xuiButton_Music
            // 
            this.xuiButton_Music.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Music.ButtonImage = global::GUI.Properties.Resources.volume;
            this.xuiButton_Music.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton_Music.ButtonText = "";
            this.xuiButton_Music.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_Music.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Music.CornerRadius = 5;
            this.xuiButton_Music.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Music.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_Music.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Music.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Music.Location = new System.Drawing.Point(1408, 12);
            this.xuiButton_Music.Name = "xuiButton_Music";
            this.xuiButton_Music.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_Music.TabIndex = 16;
            this.xuiButton_Music.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Music.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Music.Click += new System.EventHandler(this.xuiButton_Music_Click);
            // 
            // xuiButton_retry
            // 
            this.xuiButton_retry.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_retry.ButtonImage = global::GUI.Properties.Resources.refresh;
            this.xuiButton_retry.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton_retry.ButtonText = "";
            this.xuiButton_retry.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_retry.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_retry.CornerRadius = 5;
            this.xuiButton_retry.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_retry.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_retry.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_retry.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_retry.Location = new System.Drawing.Point(1346, 12);
            this.xuiButton_retry.Name = "xuiButton_retry";
            this.xuiButton_retry.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_retry.TabIndex = 17;
            this.xuiButton_retry.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_retry.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_retry.Click += new System.EventHandler(this.xuiButton_retry_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Game_CarRacing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.road;
            this.ClientSize = new System.Drawing.Size(1526, 500);
            this.ControlBox = false;
            this.Controls.Add(this.xuiButton_retry);
            this.Controls.Add(this.xuiButton_Music);
            this.Controls.Add(this.xuiButton_Back);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuiButton_D);
            this.Controls.Add(this.xuiButton_C);
            this.Controls.Add(this.xuiButton_B);
            this.Controls.Add(this.xuiButton_A);
            this.Controls.Add(this.panel_question);
            this.Controls.Add(this.label_NumQues);
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
        private System.Windows.Forms.Label label_NumQues;
        private System.Windows.Forms.Panel panel_question;
        private System.Windows.Forms.Label label_Question;
        private XanderUI.XUIButton xuiButton_A;
        private XanderUI.XUIButton xuiButton_B;
        private XanderUI.XUIButton xuiButton_C;
        private XanderUI.XUIButton xuiButton_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Time;
        private XanderUI.XUIButton xuiButton_Back;
        private XanderUI.XUIButton xuiButton_Music;
        private XanderUI.XUIButton xuiButton_retry;
        private System.Windows.Forms.Timer timer1;
    }
}