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
            this.metroButton_A = new MetroFramework.Controls.MetroButton();
            this.metroButton_B = new MetroFramework.Controls.MetroButton();
            this.metroButton_C = new MetroFramework.Controls.MetroButton();
            this.metroButton_D = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // timer_carRacing
            // 
            this.timer_carRacing.Tick += new System.EventHandler(this.timer_carRacing_Tick);
            // 
            // metroButton_Back
            // 
            this.metroButton_Back.Location = new System.Drawing.Point(702, 12);
            this.metroButton_Back.Name = "metroButton_Back";
            this.metroButton_Back.Size = new System.Drawing.Size(138, 60);
            this.metroButton_Back.TabIndex = 0;
            this.metroButton_Back.Text = "Back";
            this.metroButton_Back.UseSelectable = true;
            this.metroButton_Back.Click += new System.EventHandler(this.metroButton_Back_Click);
            // 
            // metroButton_Music
            // 
            this.metroButton_Music.Location = new System.Drawing.Point(558, 12);
            this.metroButton_Music.Name = "metroButton_Music";
            this.metroButton_Music.Size = new System.Drawing.Size(138, 60);
            this.metroButton_Music.TabIndex = 1;
            this.metroButton_Music.Text = "Music";
            this.metroButton_Music.UseSelectable = true;
            this.metroButton_Music.Click += new System.EventHandler(this.metroButton_Music_Click);
            // 
            // metroButton_A
            // 
            this.metroButton_A.Location = new System.Drawing.Point(271, 271);
            this.metroButton_A.Name = "metroButton_A";
            this.metroButton_A.Size = new System.Drawing.Size(138, 60);
            this.metroButton_A.TabIndex = 2;
            this.metroButton_A.Text = "Music";
            this.metroButton_A.UseSelectable = true;
            this.metroButton_A.Click += new System.EventHandler(this.metroButton_A_Click);
            // 
            // metroButton_B
            // 
            this.metroButton_B.Location = new System.Drawing.Point(489, 271);
            this.metroButton_B.Name = "metroButton_B";
            this.metroButton_B.Size = new System.Drawing.Size(138, 60);
            this.metroButton_B.TabIndex = 3;
            this.metroButton_B.Text = "Music";
            this.metroButton_B.UseSelectable = true;
            this.metroButton_B.Click += new System.EventHandler(this.metroButton_B_Click);
            // 
            // metroButton_C
            // 
            this.metroButton_C.Location = new System.Drawing.Point(271, 352);
            this.metroButton_C.Name = "metroButton_C";
            this.metroButton_C.Size = new System.Drawing.Size(138, 60);
            this.metroButton_C.TabIndex = 4;
            this.metroButton_C.Text = "Music";
            this.metroButton_C.UseSelectable = true;
            this.metroButton_C.Click += new System.EventHandler(this.metroButton_C_Click);
            // 
            // metroButton_D
            // 
            this.metroButton_D.Location = new System.Drawing.Point(489, 352);
            this.metroButton_D.Name = "metroButton_D";
            this.metroButton_D.Size = new System.Drawing.Size(138, 60);
            this.metroButton_D.TabIndex = 5;
            this.metroButton_D.Text = "Music";
            this.metroButton_D.UseSelectable = true;
            this.metroButton_D.Click += new System.EventHandler(this.metroButton_D_Click);
            // 
            // Form_Game_CarRacing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUI.Properties.Resources.road;
            this.ClientSize = new System.Drawing.Size(852, 480);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton_D);
            this.Controls.Add(this.metroButton_C);
            this.Controls.Add(this.metroButton_B);
            this.Controls.Add(this.metroButton_A);
            this.Controls.Add(this.metroButton_Music);
            this.Controls.Add(this.metroButton_Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game_CarRacing";
            this.Text = "Form_Game_CarRacing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Game_CarRacing_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_carRacing;
        private MetroFramework.Controls.MetroButton metroButton_Back;
        private MetroFramework.Controls.MetroButton metroButton_Music;
        private MetroFramework.Controls.MetroButton metroButton_A;
        private MetroFramework.Controls.MetroButton metroButton_B;
        private MetroFramework.Controls.MetroButton metroButton_C;
        private MetroFramework.Controls.MetroButton metroButton_D;
    }
}