namespace GUI
{
    partial class UserControl_Exam_Combo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Exam_Combo));
            this.comboBox_Main = new System.Windows.Forms.ComboBox();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.metroTextBox_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_Number = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_Time = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Time = new MetroFramework.Controls.MetroTextBox();
            this.xuiButton_Start = new XanderUI.XUIButton();
            this.metroLabel_Combo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // comboBox_Main
            // 
            this.comboBox_Main.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Main.FormattingEnabled = true;
            this.comboBox_Main.Location = new System.Drawing.Point(288, 63);
            this.comboBox_Main.Name = "comboBox_Main";
            this.comboBox_Main.Size = new System.Drawing.Size(242, 30);
            this.comboBox_Main.TabIndex = 0;
            this.comboBox_Main.SelectedValueChanged += new System.EventHandler(this.comboBox_Main_SelectedValueChanged);
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(288, 129);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(242, 30);
            this.comboBox_Branch.TabIndex = 4;
            this.comboBox_Branch.SelectedValueChanged += new System.EventHandler(this.comboBox_Branch_SelectedValueChanged);
            // 
            // metroTextBox_Number
            // 
            // 
            // 
            // 
            this.metroTextBox_Number.CustomButton.Image = null;
            this.metroTextBox_Number.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.metroTextBox_Number.CustomButton.Name = "";
            this.metroTextBox_Number.CustomButton.Size = new System.Drawing.Size(14, 14);
            this.metroTextBox_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Number.CustomButton.TabIndex = 1;
            this.metroTextBox_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Number.CustomButton.UseSelectable = true;
            this.metroTextBox_Number.CustomButton.Visible = false;
            this.metroTextBox_Number.Lines = new string[0];
            this.metroTextBox_Number.Location = new System.Drawing.Point(288, 227);
            this.metroTextBox_Number.MaxLength = 32767;
            this.metroTextBox_Number.Name = "metroTextBox_Number";
            this.metroTextBox_Number.PasswordChar = '\0';
            this.metroTextBox_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Number.SelectedText = "";
            this.metroTextBox_Number.SelectionLength = 0;
            this.metroTextBox_Number.SelectionStart = 0;
            this.metroTextBox_Number.ShortcutsEnabled = true;
            this.metroTextBox_Number.Size = new System.Drawing.Size(114, 30);
            this.metroTextBox_Number.TabIndex = 5;
            this.metroTextBox_Number.UseSelectable = true;
            this.metroTextBox_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Number.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel_Number
            // 
            this.metroLabel_Number.AutoSize = true;
            this.metroLabel_Number.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel_Number.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_Number.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_Number.Location = new System.Drawing.Point(159, 227);
            this.metroLabel_Number.Name = "metroLabel_Number";
            this.metroLabel_Number.Size = new System.Drawing.Size(72, 25);
            this.metroLabel_Number.TabIndex = 6;
            this.metroLabel_Number.Text = "Số câu:";
            // 
            // metroLabel_Time
            // 
            this.metroLabel_Time.AutoSize = true;
            this.metroLabel_Time.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel_Time.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_Time.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_Time.Location = new System.Drawing.Point(47, 291);
            this.metroLabel_Time.Name = "metroLabel_Time";
            this.metroLabel_Time.Size = new System.Drawing.Size(167, 25);
            this.metroLabel_Time.TabIndex = 8;
            this.metroLabel_Time.Text = "Thời gian mỗi câu:";
            // 
            // metroTextBox_Time
            // 
            // 
            // 
            // 
            this.metroTextBox_Time.CustomButton.Image = null;
            this.metroTextBox_Time.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.metroTextBox_Time.CustomButton.Name = "";
            this.metroTextBox_Time.CustomButton.Size = new System.Drawing.Size(14, 14);
            this.metroTextBox_Time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Time.CustomButton.TabIndex = 1;
            this.metroTextBox_Time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Time.CustomButton.UseSelectable = true;
            this.metroTextBox_Time.CustomButton.Visible = false;
            this.metroTextBox_Time.Lines = new string[0];
            this.metroTextBox_Time.Location = new System.Drawing.Point(288, 291);
            this.metroTextBox_Time.MaxLength = 32767;
            this.metroTextBox_Time.Name = "metroTextBox_Time";
            this.metroTextBox_Time.PasswordChar = '\0';
            this.metroTextBox_Time.PromptText = "seconds";
            this.metroTextBox_Time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Time.SelectedText = "";
            this.metroTextBox_Time.SelectionLength = 0;
            this.metroTextBox_Time.SelectionStart = 0;
            this.metroTextBox_Time.ShortcutsEnabled = true;
            this.metroTextBox_Time.Size = new System.Drawing.Size(114, 30);
            this.metroTextBox_Time.TabIndex = 7;
            this.metroTextBox_Time.UseSelectable = true;
            this.metroTextBox_Time.WaterMark = "seconds";
            this.metroTextBox_Time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Time.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Time_KeyPress);
            // 
            // xuiButton_Start
            // 
            this.xuiButton_Start.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton_Start.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Start.ButtonImage")));
            this.xuiButton_Start.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton_Start.ButtonText = "Start";
            this.xuiButton_Start.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Start.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Start.CornerRadius = 5;
            this.xuiButton_Start.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton_Start.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Start.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Start.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton_Start.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Start.Location = new System.Drawing.Point(234, 386);
            this.xuiButton_Start.Name = "xuiButton_Start";
            this.xuiButton_Start.Size = new System.Drawing.Size(136, 49);
            this.xuiButton_Start.TabIndex = 9;
            this.xuiButton_Start.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Start.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Start.Click += new System.EventHandler(this.xuiButton_Start_Click);
            // 
            // metroLabel_Combo
            // 
            this.metroLabel_Combo.AutoSize = true;
            this.metroLabel_Combo.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel_Combo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_Combo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_Combo.Location = new System.Drawing.Point(121, 63);
            this.metroLabel_Combo.Name = "metroLabel_Combo";
            this.metroLabel_Combo.Size = new System.Drawing.Size(110, 25);
            this.metroLabel_Combo.TabIndex = 10;
            this.metroLabel_Combo.Text = "Chọn bộ từ:";
            // 
            // UserControl_Exam_Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel_Combo);
            this.Controls.Add(this.xuiButton_Start);
            this.Controls.Add(this.metroLabel_Time);
            this.Controls.Add(this.metroTextBox_Time);
            this.Controls.Add(this.metroLabel_Number);
            this.Controls.Add(this.metroTextBox_Number);
            this.Controls.Add(this.comboBox_Branch);
            this.Controls.Add(this.comboBox_Main);
            this.Name = "UserControl_Exam_Combo";
            this.Size = new System.Drawing.Size(624, 516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox_Main;
        public System.Windows.Forms.ComboBox comboBox_Branch;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Number;
        private MetroFramework.Controls.MetroLabel metroLabel_Number;
        private MetroFramework.Controls.MetroLabel metroLabel_Time;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Time;
        private XanderUI.XUIButton xuiButton_Start;
        private MetroFramework.Controls.MetroLabel metroLabel_Combo;
    }
}
