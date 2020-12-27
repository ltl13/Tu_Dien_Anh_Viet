namespace GUI
{
    partial class Form_Game_BuildBridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game_BuildBridge));
            this.panel_Question = new System.Windows.Forms.Panel();
            this.label_Question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numOfQuestion = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.xuiButton_Back = new XanderUI.XUIButton();
            this.xuiButton_Music = new XanderUI.XUIButton();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.timer_Bridge = new System.Windows.Forms.Timer(this.components);
            this.timer_countDown = new System.Windows.Forms.Timer(this.components);
            this.xuiButton_retry = new XanderUI.XUIButton();
            this.panel_Question.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Question
            // 
            this.panel_Question.BackColor = System.Drawing.Color.Transparent;
            this.panel_Question.Controls.Add(this.label_Question);
            this.panel_Question.Location = new System.Drawing.Point(201, 118);
            this.panel_Question.Name = "panel_Question";
            this.panel_Question.Size = new System.Drawing.Size(415, 73);
            this.panel_Question.TabIndex = 0;
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Question.Location = new System.Drawing.Point(0, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(415, 73);
            this.label_Question.TabIndex = 1;
            this.label_Question.Text = "question";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Question";
            // 
            // label_numOfQuestion
            // 
            this.label_numOfQuestion.AutoSize = true;
            this.label_numOfQuestion.Location = new System.Drawing.Point(626, 51);
            this.label_numOfQuestion.Name = "label_numOfQuestion";
            this.label_numOfQuestion.Size = new System.Drawing.Size(53, 25);
            this.label_numOfQuestion.TabIndex = 4;
            this.label_numOfQuestion.Text = "num";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(529, 51);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(52, 25);
            this.label_Time.TabIndex = 5;
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
            this.xuiButton_Back.Location = new System.Drawing.Point(817, 12);
            this.xuiButton_Back.Name = "xuiButton_Back";
            this.xuiButton_Back.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_Back.TabIndex = 6;
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
            this.xuiButton_Music.Location = new System.Drawing.Point(770, 12);
            this.xuiButton_Music.Name = "xuiButton_Music";
            this.xuiButton_Music.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_Music.TabIndex = 7;
            this.xuiButton_Music.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Music.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Music.Click += new System.EventHandler(this.xuiButton_Music_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(297, 452);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(221, 31);
            this.textBox_Answer.TabIndex = 8;
            this.textBox_Answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Answer_KeyDown);
            // 
            // timer_Bridge
            // 
            this.timer_Bridge.Tick += new System.EventHandler(this.timer_Bridge_Tick);
            // 
            // timer_countDown
            // 
            this.timer_countDown.Interval = 1000;
            this.timer_countDown.Tick += new System.EventHandler(this.timer_countDown_Tick);
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
            this.xuiButton_retry.Location = new System.Drawing.Point(720, 12);
            this.xuiButton_retry.Name = "xuiButton_retry";
            this.xuiButton_retry.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_retry.TabIndex = 9;
            this.xuiButton_retry.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_retry.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_retry.Click += new System.EventHandler(this.xuiButton_retry_Click);
            // 
            // Form_Game_BuildBridge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.brokesky;
            this.ClientSize = new System.Drawing.Size(860, 850);
            this.ControlBox = false;
            this.Controls.Add(this.xuiButton_retry);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.xuiButton_Music);
            this.Controls.Add(this.xuiButton_Back);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_numOfQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Question);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Game_BuildBridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Game_BuildBridge";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_BuildBridge_Paint);
            this.panel_Question.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Question;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numOfQuestion;
        private System.Windows.Forms.Label label_Time;
        private XanderUI.XUIButton xuiButton_Back;
        private XanderUI.XUIButton xuiButton_Music;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Timer timer_Bridge;
        private System.Windows.Forms.Timer timer_countDown;
        private XanderUI.XUIButton xuiButton_retry;
    }
}