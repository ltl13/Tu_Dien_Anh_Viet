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
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.metroButton_Back = new MetroFramework.Controls.MetroButton();
            this.metroButton_Music = new MetroFramework.Controls.MetroButton();
            this.label_Question = new System.Windows.Forms.Label();
            this.timer_Bridge = new System.Windows.Forms.Timer(this.components);
            this.label_numOfQuestion = new System.Windows.Forms.Label();
            this.panel_Question = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer_countDown = new System.Windows.Forms.Timer(this.components);
            this.panel_Question.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Answer.Location = new System.Drawing.Point(342, 453);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(156, 37);
            this.textBox_Answer.TabIndex = 0;
            this.textBox_Answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Answer_KeyDown);
            // 
            // metroButton_Back
            // 
            this.metroButton_Back.Location = new System.Drawing.Point(648, 15);
            this.metroButton_Back.Name = "metroButton_Back";
            this.metroButton_Back.Size = new System.Drawing.Size(135, 43);
            this.metroButton_Back.TabIndex = 1;
            this.metroButton_Back.Text = "Back";
            this.metroButton_Back.UseSelectable = true;
            this.metroButton_Back.Click += new System.EventHandler(this.metroButton_Back_Click);
            // 
            // metroButton_Music
            // 
            this.metroButton_Music.Location = new System.Drawing.Point(492, 15);
            this.metroButton_Music.Name = "metroButton_Music";
            this.metroButton_Music.Size = new System.Drawing.Size(135, 43);
            this.metroButton_Music.TabIndex = 2;
            this.metroButton_Music.Text = "Music";
            this.metroButton_Music.UseSelectable = true;
            this.metroButton_Music.Click += new System.EventHandler(this.metroButton_Music_Click);
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.Color.White;
            this.label_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(0, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(552, 69);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "Question";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Bridge
            // 
            this.timer_Bridge.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_numOfQuestion
            // 
            this.label_numOfQuestion.AutoSize = true;
            this.label_numOfQuestion.BackColor = System.Drawing.Color.Transparent;
            this.label_numOfQuestion.Location = new System.Drawing.Point(382, 33);
            this.label_numOfQuestion.Name = "label_numOfQuestion";
            this.label_numOfQuestion.Size = new System.Drawing.Size(76, 25);
            this.label_numOfQuestion.TabIndex = 4;
            this.label_numOfQuestion.Text = "so cau";
            // 
            // panel_Question
            // 
            this.panel_Question.BackColor = System.Drawing.Color.Transparent;
            this.panel_Question.Controls.Add(this.label_Question);
            this.panel_Question.Location = new System.Drawing.Point(145, 108);
            this.panel_Question.Name = "panel_Question";
            this.panel_Question.Size = new System.Drawing.Size(552, 69);
            this.panel_Question.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(353, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(258, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time left";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Location = new System.Drawing.Point(271, 33);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(52, 25);
            this.label_Time.TabIndex = 8;
            this.label_Time.Text = "time";
            // 
            // timer_countDown
            // 
            this.timer_countDown.Interval = 1000;
            this.timer_countDown.Tick += new System.EventHandler(this.timer_countDown_Tick);
            // 
            // Form_Game_BuildBridge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.brokesky;
            this.ClientSize = new System.Drawing.Size(850, 850);
            this.ControlBox = false;
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Question);
            this.Controls.Add(this.label_numOfQuestion);
            this.Controls.Add(this.metroButton_Music);
            this.Controls.Add(this.metroButton_Back);
            this.Controls.Add(this.textBox_Answer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game_BuildBridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Game_BuildBridge";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_BuildBridge_Paint);
            this.panel_Question.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Answer;
        private MetroFramework.Controls.MetroButton metroButton_Back;
        private MetroFramework.Controls.MetroButton metroButton_Music;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Timer timer_Bridge;
        private System.Windows.Forms.Label label_numOfQuestion;
        private System.Windows.Forms.Panel panel_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer_countDown;
    }
}