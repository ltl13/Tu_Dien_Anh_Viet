namespace GUI
{
    partial class UserControl_Grammar
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
            this.button_Game_BuildBridge = new System.Windows.Forms.Button();
            this.button_Game_CarRacing = new System.Windows.Forms.Button();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiButton_Ok = new XanderUI.XUIButton();
            this.panel_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Game_BuildBridge
            // 
            this.button_Game_BuildBridge.BackgroundImage = global::GUI.Properties.Resources.tadada;
            this.button_Game_BuildBridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Game_BuildBridge.FlatAppearance.BorderSize = 0;
            this.button_Game_BuildBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Game_BuildBridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Game_BuildBridge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.button_Game_BuildBridge.Location = new System.Drawing.Point(260, 541);
            this.button_Game_BuildBridge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Game_BuildBridge.Name = "button_Game_BuildBridge";
            this.button_Game_BuildBridge.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.button_Game_BuildBridge.Size = new System.Drawing.Size(808, 372);
            this.button_Game_BuildBridge.TabIndex = 1;
            this.button_Game_BuildBridge.UseCompatibleTextRendering = true;
            this.button_Game_BuildBridge.UseVisualStyleBackColor = true;
            this.button_Game_BuildBridge.Click += new System.EventHandler(this.button_Game_BuildBridge_Click);
            // 
            // button_Game_CarRacing
            // 
            this.button_Game_CarRacing.BackgroundImage = global::GUI.Properties.Resources.tada;
            this.button_Game_CarRacing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Game_CarRacing.FlatAppearance.BorderSize = 0;
            this.button_Game_CarRacing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Game_CarRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Game_CarRacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(213)))));
            this.button_Game_CarRacing.Location = new System.Drawing.Point(260, 92);
            this.button_Game_CarRacing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Game_CarRacing.Name = "button_Game_CarRacing";
            this.button_Game_CarRacing.Size = new System.Drawing.Size(808, 372);
            this.button_Game_CarRacing.TabIndex = 0;
            this.button_Game_CarRacing.UseCompatibleTextRendering = true;
            this.button_Game_CarRacing.UseVisualStyleBackColor = true;
            this.button_Game_CarRacing.Click += new System.EventHandler(this.button_Game_CarRacing_Click);
            // 
            // panel_Setting
            // 
            this.panel_Setting.Controls.Add(this.xuiButton_Ok);
            this.panel_Setting.Controls.Add(this.label2);
            this.panel_Setting.Controls.Add(this.label1);
            this.panel_Setting.Controls.Add(this.textBox2);
            this.panel_Setting.Controls.Add(this.textBox1);
            this.panel_Setting.Location = new System.Drawing.Point(260, 92);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(808, 821);
            this.panel_Setting.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 380);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "second/ question";
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
            this.xuiButton_Ok.Location = new System.Drawing.Point(583, 695);
            this.xuiButton_Ok.Name = "xuiButton_Ok";
            this.xuiButton_Ok.Size = new System.Drawing.Size(184, 85);
            this.xuiButton_Ok.TabIndex = 4;
            this.xuiButton_Ok.TextColor = System.Drawing.Color.Black;
            this.xuiButton_Ok.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Ok.Click += new System.EventHandler(this.xuiButton_Ok_Click);
            // 
            // UserControl_Grammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.button_Game_BuildBridge);
            this.Controls.Add(this.button_Game_CarRacing);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_Grammar";
            this.Size = new System.Drawing.Size(1218, 1056);
            this.panel_Setting.ResumeLayout(false);
            this.panel_Setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Game_CarRacing;
        private System.Windows.Forms.Button button_Game_BuildBridge;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton xuiButton_Ok;
    }
}
