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
            this.label_Question = new System.Windows.Forms.Label();
            this.timer_Bridge = new System.Windows.Forms.Timer(this.components);
            this.label_numOfQuestion = new System.Windows.Forms.Label();
            this.panel_Question = new System.Windows.Forms.Panel();
            this.metroTile_Back = new MetroFramework.Controls.MetroTile();
            this.metroTile_Music = new MetroFramework.Controls.MetroTile();
            this.label_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_countDown = new System.Windows.Forms.Timer(this.components);
            this.metroTile_BackOfGb = new MetroFramework.Controls.MetroTile();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xuiButton_Ok = new XanderUI.XUIButton();
            this.metroTextBox_NumOfQues = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Time = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Percent = new MetroFramework.Controls.MetroTextBox();
            this.groupBox_Setting = new System.Windows.Forms.GroupBox();
            this.panel_Question.SuspendLayout();
            this.groupBox_Setting.SuspendLayout();
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
            this.label_numOfQuestion.Location = new System.Drawing.Point(631, 31);
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
            // metroTile_Back
            // 
            this.metroTile_Back.ActiveControl = null;
            this.metroTile_Back.Location = new System.Drawing.Point(789, 15);
            this.metroTile_Back.Name = "metroTile_Back";
            this.metroTile_Back.Size = new System.Drawing.Size(59, 37);
            this.metroTile_Back.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Back.TabIndex = 7;
            this.metroTile_Back.TileImage = global::GUI.Properties.Resources.back_arrow;
            this.metroTile_Back.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Back.UseSelectable = true;
            this.metroTile_Back.UseTileImage = true;
            this.metroTile_Back.Click += new System.EventHandler(this.metroTile_Back_Click);
            // 
            // metroTile_Music
            // 
            this.metroTile_Music.ActiveControl = null;
            this.metroTile_Music.Location = new System.Drawing.Point(713, 13);
            this.metroTile_Music.Name = "metroTile_Music";
            this.metroTile_Music.Size = new System.Drawing.Size(64, 43);
            this.metroTile_Music.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_Music.TabIndex = 8;
            this.metroTile_Music.TileImage = global::GUI.Properties.Resources.music;
            this.metroTile_Music.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_Music.UseSelectable = true;
            this.metroTile_Music.UseTileImage = true;
            this.metroTile_Music.Click += new System.EventHandler(this.metroTile_Music_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.Location = new System.Drawing.Point(549, 31);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(52, 25);
            this.label_time.TabIndex = 9;
            this.label_time.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(631, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "so cau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(540, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Time left";
            // 
            // timer_countDown
            // 
            this.timer_countDown.Interval = 1000;
            this.timer_countDown.Tick += new System.EventHandler(this.timer_countDown_Tick);
            // 
            // metroTile_BackOfGb
            // 
            this.metroTile_BackOfGb.ActiveControl = null;
            this.metroTile_BackOfGb.Location = new System.Drawing.Point(276, 11);
            this.metroTile_BackOfGb.Name = "metroTile_BackOfGb";
            this.metroTile_BackOfGb.Size = new System.Drawing.Size(33, 31);
            this.metroTile_BackOfGb.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile_BackOfGb.TabIndex = 4;
            this.metroTile_BackOfGb.TileImage = global::GUI.Properties.Resources.back_arrow;
            this.metroTile_BackOfGb.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_BackOfGb.UseSelectable = true;
            this.metroTile_BackOfGb.UseTileImage = true;
            this.metroTile_BackOfGb.Click += new System.EventHandler(this.metroTile_BackOfGb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Second/question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pass persent";
            // 
            // xuiButton_Ok
            // 
            this.xuiButton_Ok.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_Ok.ButtonImage = null;
            this.xuiButton_Ok.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton_Ok.ButtonText = "Ok";
            this.xuiButton_Ok.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton_Ok.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton_Ok.CornerRadius = 5;
            this.xuiButton_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_Ok.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Ok.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton_Ok.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_Ok.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Ok.Location = new System.Drawing.Point(215, 246);
            this.xuiButton_Ok.Name = "xuiButton_Ok";
            this.xuiButton_Ok.Size = new System.Drawing.Size(85, 50);
            this.xuiButton_Ok.TabIndex = 14;
            this.xuiButton_Ok.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Ok.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Ok.Click += new System.EventHandler(this.xuiButton_Ok_Click);
            // 
            // metroTextBox_NumOfQues
            // 
            // 
            // 
            // 
            this.metroTextBox_NumOfQues.CustomButton.Image = null;
            this.metroTextBox_NumOfQues.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox_NumOfQues.CustomButton.Name = "";
            this.metroTextBox_NumOfQues.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.metroTextBox_NumOfQues.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_NumOfQues.CustomButton.TabIndex = 1;
            this.metroTextBox_NumOfQues.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_NumOfQues.CustomButton.UseSelectable = true;
            this.metroTextBox_NumOfQues.CustomButton.Visible = false;
            this.metroTextBox_NumOfQues.Lines = new string[0];
            this.metroTextBox_NumOfQues.Location = new System.Drawing.Point(204, 62);
            this.metroTextBox_NumOfQues.MaxLength = 32767;
            this.metroTextBox_NumOfQues.Name = "metroTextBox_NumOfQues";
            this.metroTextBox_NumOfQues.PasswordChar = '\0';
            this.metroTextBox_NumOfQues.PromptText = "smaller than 170";
            this.metroTextBox_NumOfQues.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_NumOfQues.SelectedText = "";
            this.metroTextBox_NumOfQues.SelectionLength = 0;
            this.metroTextBox_NumOfQues.SelectionStart = 0;
            this.metroTextBox_NumOfQues.ShortcutsEnabled = true;
            this.metroTextBox_NumOfQues.Size = new System.Drawing.Size(102, 45);
            this.metroTextBox_NumOfQues.TabIndex = 15;
            this.metroTextBox_NumOfQues.UseSelectable = true;
            this.metroTextBox_NumOfQues.WaterMark = "smaller than 170";
            this.metroTextBox_NumOfQues.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_NumOfQues.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_Time
            // 
            // 
            // 
            // 
            this.metroTextBox_Time.CustomButton.Image = null;
            this.metroTextBox_Time.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox_Time.CustomButton.Name = "";
            this.metroTextBox_Time.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.metroTextBox_Time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Time.CustomButton.TabIndex = 1;
            this.metroTextBox_Time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Time.CustomButton.UseSelectable = true;
            this.metroTextBox_Time.CustomButton.Visible = false;
            this.metroTextBox_Time.Lines = new string[0];
            this.metroTextBox_Time.Location = new System.Drawing.Point(204, 128);
            this.metroTextBox_Time.MaxLength = 32767;
            this.metroTextBox_Time.Name = "metroTextBox_Time";
            this.metroTextBox_Time.PasswordChar = '\0';
            this.metroTextBox_Time.PromptText = "smaller than 60";
            this.metroTextBox_Time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Time.SelectedText = "";
            this.metroTextBox_Time.SelectionLength = 0;
            this.metroTextBox_Time.SelectionStart = 0;
            this.metroTextBox_Time.ShortcutsEnabled = true;
            this.metroTextBox_Time.Size = new System.Drawing.Size(102, 45);
            this.metroTextBox_Time.TabIndex = 16;
            this.metroTextBox_Time.UseSelectable = true;
            this.metroTextBox_Time.WaterMark = "smaller than 60";
            this.metroTextBox_Time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_Percent
            // 
            // 
            // 
            // 
            this.metroTextBox_Percent.CustomButton.Image = null;
            this.metroTextBox_Percent.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.metroTextBox_Percent.CustomButton.Name = "";
            this.metroTextBox_Percent.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.metroTextBox_Percent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Percent.CustomButton.TabIndex = 1;
            this.metroTextBox_Percent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Percent.CustomButton.UseSelectable = true;
            this.metroTextBox_Percent.CustomButton.Visible = false;
            this.metroTextBox_Percent.Lines = new string[0];
            this.metroTextBox_Percent.Location = new System.Drawing.Point(202, 191);
            this.metroTextBox_Percent.MaxLength = 32767;
            this.metroTextBox_Percent.Name = "metroTextBox_Percent";
            this.metroTextBox_Percent.PasswordChar = '\0';
            this.metroTextBox_Percent.PromptText = "0  < X < 1";
            this.metroTextBox_Percent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Percent.SelectedText = "";
            this.metroTextBox_Percent.SelectionLength = 0;
            this.metroTextBox_Percent.SelectionStart = 0;
            this.metroTextBox_Percent.ShortcutsEnabled = true;
            this.metroTextBox_Percent.Size = new System.Drawing.Size(104, 45);
            this.metroTextBox_Percent.TabIndex = 17;
            this.metroTextBox_Percent.UseSelectable = true;
            this.metroTextBox_Percent.WaterMark = "0  < X < 1";
            this.metroTextBox_Percent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Percent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox_Setting
            // 
            this.groupBox_Setting.Controls.Add(this.metroTextBox_Percent);
            this.groupBox_Setting.Controls.Add(this.metroTextBox_Time);
            this.groupBox_Setting.Controls.Add(this.metroTextBox_NumOfQues);
            this.groupBox_Setting.Controls.Add(this.xuiButton_Ok);
            this.groupBox_Setting.Controls.Add(this.label5);
            this.groupBox_Setting.Controls.Add(this.label4);
            this.groupBox_Setting.Controls.Add(this.label3);
            this.groupBox_Setting.Controls.Add(this.metroTile_BackOfGb);
            this.groupBox_Setting.Location = new System.Drawing.Point(12, 535);
            this.groupBox_Setting.Name = "groupBox_Setting";
            this.groupBox_Setting.Size = new System.Drawing.Size(315, 312);
            this.groupBox_Setting.TabIndex = 6;
            this.groupBox_Setting.TabStop = false;
            this.groupBox_Setting.Text = ".";
            // 
            // Form_Game_BuildBridge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.brokesky;
            this.ClientSize = new System.Drawing.Size(850, 850);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.metroTile_Music);
            this.Controls.Add(this.metroTile_Back);
            this.Controls.Add(this.panel_Question);
            this.Controls.Add(this.label_numOfQuestion);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.groupBox_Setting);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game_BuildBridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Game_BuildBridge";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_BuildBridge_Paint);
            this.panel_Question.ResumeLayout(false);
            this.groupBox_Setting.ResumeLayout(false);
            this.groupBox_Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Timer timer_Bridge;
        private System.Windows.Forms.Label label_numOfQuestion;
        private System.Windows.Forms.Panel panel_Question;
        private MetroFramework.Controls.MetroTile metroTile_Back;
        private MetroFramework.Controls.MetroTile metroTile_Music;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_countDown;
        private MetroFramework.Controls.MetroTile metroTile_BackOfGb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton xuiButton_Ok;
        private MetroFramework.Controls.MetroTextBox metroTextBox_NumOfQues;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Time;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Percent;
        private System.Windows.Forms.GroupBox groupBox_Setting;
    }
}