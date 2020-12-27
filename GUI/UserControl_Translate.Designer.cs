namespace GUI
{
    partial class UserControl_Translate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Translate));
            this.richTextBox_From = new System.Windows.Forms.RichTextBox();
            this.richTextBox_To = new System.Windows.Forms.RichTextBox();
            this.xuiButton_Translate = new XanderUI.XUIButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_From
            // 
            this.richTextBox_From.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_From.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_From.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_From.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_From.Name = "richTextBox_From";
            this.richTextBox_From.Size = new System.Drawing.Size(630, 222);
            this.richTextBox_From.TabIndex = 0;
            this.richTextBox_From.Text = "";
            // 
            // richTextBox_To
            // 
            this.richTextBox_To.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_To.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_To.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_To.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_To.Location = new System.Drawing.Point(0, 293);
            this.richTextBox_To.Name = "richTextBox_To";
            this.richTextBox_To.ReadOnly = true;
            this.richTextBox_To.Size = new System.Drawing.Size(630, 222);
            this.richTextBox_To.TabIndex = 1;
            this.richTextBox_To.Text = "";
            // 
            // xuiButton_Translate
            // 
            this.xuiButton_Translate.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_Translate.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Translate.ButtonImage")));
            this.xuiButton_Translate.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton_Translate.ButtonText = "Translate";
            this.xuiButton_Translate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton_Translate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Translate.CornerRadius = 5;
            this.xuiButton_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_Translate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Translate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton_Translate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Translate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Translate.Location = new System.Drawing.Point(214, 234);
            this.xuiButton_Translate.Margin = new System.Windows.Forms.Padding(2);
            this.xuiButton_Translate.Name = "xuiButton_Translate";
            this.xuiButton_Translate.Size = new System.Drawing.Size(203, 46);
            this.xuiButton_Translate.TabIndex = 2;
            this.xuiButton_Translate.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Translate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Translate.Click += new System.EventHandler(this.xuiButton_Translate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.xuiButton_Translate);
            this.panel1.Controls.Add(this.richTextBox_To);
            this.panel1.Controls.Add(this.richTextBox_From);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 515);
            this.panel1.TabIndex = 3;
            // 
            // UserControl_Translate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_Translate";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(670, 555);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public XanderUI.XUIButton xuiButton_Translate;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RichTextBox richTextBox_From;
        public System.Windows.Forms.RichTextBox richTextBox_To;
    }
}
