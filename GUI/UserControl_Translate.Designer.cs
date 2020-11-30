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
            this.SuspendLayout();
            // 
            // richTextBox_From
            // 
            this.richTextBox_From.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_From.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_From.Location = new System.Drawing.Point(28, 27);
            this.richTextBox_From.Name = "richTextBox_From";
            this.richTextBox_From.Size = new System.Drawing.Size(564, 199);
            this.richTextBox_From.TabIndex = 0;
            this.richTextBox_From.Text = "";
            // 
            // richTextBox_To
            // 
            this.richTextBox_To.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_To.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_To.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_To.Location = new System.Drawing.Point(28, 288);
            this.richTextBox_To.Name = "richTextBox_To";
            this.richTextBox_To.ReadOnly = true;
            this.richTextBox_To.Size = new System.Drawing.Size(564, 199);
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
            this.xuiButton_Translate.Location = new System.Drawing.Point(211, 234);
            this.xuiButton_Translate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xuiButton_Translate.Name = "xuiButton_Translate";
            this.xuiButton_Translate.Size = new System.Drawing.Size(203, 46);
            this.xuiButton_Translate.TabIndex = 2;
            this.xuiButton_Translate.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Translate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Translate.Click += new System.EventHandler(this.xuiButton_Translate_Click);
            // 
            // UserControl_Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiButton_Translate);
            this.Controls.Add(this.richTextBox_To);
            this.Controls.Add(this.richTextBox_From);
            this.Name = "UserControl_Translate";
            this.Size = new System.Drawing.Size(624, 516);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_From;
        private System.Windows.Forms.RichTextBox richTextBox_To;
        public XanderUI.XUIButton xuiButton_Translate;
    }
}
