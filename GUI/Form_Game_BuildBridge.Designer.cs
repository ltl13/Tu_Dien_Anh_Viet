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
            this.groupBox_Question = new System.Windows.Forms.GroupBox();
            this.label_Question = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Question.SuspendLayout();
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
            // groupBox_Question
            // 
            this.groupBox_Question.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Question.Controls.Add(this.label_Question);
            this.groupBox_Question.Location = new System.Drawing.Point(92, 87);
            this.groupBox_Question.Name = "groupBox_Question";
            this.groupBox_Question.Size = new System.Drawing.Size(657, 111);
            this.groupBox_Question.TabIndex = 3;
            this.groupBox_Question.TabStop = false;
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.Color.White;
            this.label_Question.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Question.Location = new System.Drawing.Point(3, 27);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(651, 70);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "Question";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Game_BuildBridge
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.brokesky;
            this.ClientSize = new System.Drawing.Size(850, 850);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_Question);
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
            this.groupBox_Question.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Answer;
        private MetroFramework.Controls.MetroButton metroButton_Back;
        private MetroFramework.Controls.MetroButton metroButton_Music;
        private System.Windows.Forms.GroupBox groupBox_Question;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Timer timer;
    }
}