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
            this.metroTextBox_Time = new MetroFramework.Controls.MetroTextBox();
            this.xuiButton_Start = new XanderUI.XUIButton();
            this.label_Combo = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Main
            // 
            this.comboBox_Main.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Main.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Main.FormattingEnabled = true;
            this.comboBox_Main.Location = new System.Drawing.Point(301, 98);
            this.comboBox_Main.Name = "comboBox_Main";
            this.comboBox_Main.Size = new System.Drawing.Size(242, 30);
            this.comboBox_Main.TabIndex = 0;
            this.comboBox_Main.SelectedValueChanged += new System.EventHandler(this.comboBox_Main_SelectedValueChanged);
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Branch.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(301, 163);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(240, 30);
            this.comboBox_Branch.TabIndex = 4;
            this.comboBox_Branch.SelectedValueChanged += new System.EventHandler(this.comboBox_Branch_SelectedValueChanged);
            // 
            // metroTextBox_Number
            // 
            // 
            // 
            // 
            this.metroTextBox_Number.CustomButton.Image = null;
            this.metroTextBox_Number.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.metroTextBox_Number.CustomButton.Name = "";
            this.metroTextBox_Number.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Number.CustomButton.TabIndex = 1;
            this.metroTextBox_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Number.CustomButton.UseSelectable = true;
            this.metroTextBox_Number.CustomButton.Visible = false;
            this.metroTextBox_Number.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Number.Lines = new string[0];
            this.metroTextBox_Number.Location = new System.Drawing.Point(301, 232);
            this.metroTextBox_Number.MaxLength = 3;
            this.metroTextBox_Number.Name = "metroTextBox_Number";
            this.metroTextBox_Number.PasswordChar = '\0';
            this.metroTextBox_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Number.SelectedText = "";
            this.metroTextBox_Number.SelectionLength = 0;
            this.metroTextBox_Number.SelectionStart = 0;
            this.metroTextBox_Number.ShortcutsEnabled = true;
            this.metroTextBox_Number.Size = new System.Drawing.Size(100, 30);
            this.metroTextBox_Number.TabIndex = 5;
            this.metroTextBox_Number.UseSelectable = true;
            this.metroTextBox_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Number.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox_Number.TextChanged += new System.EventHandler(this.metroTextBox_Number_TextChanged);
            this.metroTextBox_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Number_KeyPress);
            // 
            // metroTextBox_Time
            // 
            // 
            // 
            // 
            this.metroTextBox_Time.CustomButton.Image = null;
            this.metroTextBox_Time.CustomButton.Location = new System.Drawing.Point(72, 2);
            this.metroTextBox_Time.CustomButton.Name = "";
            this.metroTextBox_Time.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox_Time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Time.CustomButton.TabIndex = 1;
            this.metroTextBox_Time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Time.CustomButton.UseSelectable = true;
            this.metroTextBox_Time.CustomButton.Visible = false;
            this.metroTextBox_Time.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox_Time.Lines = new string[0];
            this.metroTextBox_Time.Location = new System.Drawing.Point(301, 307);
            this.metroTextBox_Time.MaxLength = 3;
            this.metroTextBox_Time.Name = "metroTextBox_Time";
            this.metroTextBox_Time.PasswordChar = '\0';
            this.metroTextBox_Time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Time.SelectedText = "";
            this.metroTextBox_Time.SelectionLength = 0;
            this.metroTextBox_Time.SelectionStart = 0;
            this.metroTextBox_Time.ShortcutsEnabled = true;
            this.metroTextBox_Time.Size = new System.Drawing.Size(100, 30);
            this.metroTextBox_Time.TabIndex = 7;
            this.metroTextBox_Time.UseSelectable = true;
            this.metroTextBox_Time.WaterMark = "seconds";
            this.metroTextBox_Time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Time.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox_Time.TextChanged += new System.EventHandler(this.metroTextBox_Time_TextChanged);
            this.metroTextBox_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox_Time_KeyPress);
            // 
            // xuiButton_Start
            // 
            this.xuiButton_Start.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton_Start.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Start.ButtonImage")));
            this.xuiButton_Start.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton_Start.ButtonText = "Start";
            this.xuiButton_Start.ClickBackColor = System.Drawing.Color.LightSeaGreen;
            this.xuiButton_Start.ClickTextColor = System.Drawing.Color.LightSeaGreen;
            this.xuiButton_Start.CornerRadius = 5;
            this.xuiButton_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton_Start.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Start.HoverBackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.xuiButton_Start.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton_Start.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Start.Location = new System.Drawing.Point(265, 410);
            this.xuiButton_Start.Name = "xuiButton_Start";
            this.xuiButton_Start.Size = new System.Drawing.Size(140, 50);
            this.xuiButton_Start.TabIndex = 9;
            this.xuiButton_Start.TextColor = System.Drawing.Color.LightSeaGreen;
            this.xuiButton_Start.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Start.Click += new System.EventHandler(this.xuiButton_Start_Click);
            // 
            // label_Combo
            // 
            this.label_Combo.AutoSize = true;
            this.label_Combo.BackColor = System.Drawing.Color.Transparent;
            this.label_Combo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Combo.Location = new System.Drawing.Point(143, 99);
            this.label_Combo.Name = "label_Combo";
            this.label_Combo.Size = new System.Drawing.Size(132, 29);
            this.label_Combo.TabIndex = 11;
            this.label_Combo.Text = "Chọn bộ từ:";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.BackColor = System.Drawing.Color.Transparent;
            this.label_Number.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number.Location = new System.Drawing.Point(143, 233);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(84, 29);
            this.label_Number.TabIndex = 12;
            this.label_Number.Text = "Số câu:";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.Location = new System.Drawing.Point(143, 308);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(113, 29);
            this.label_Time.TabIndex = 13;
            this.label_Time.Text = "Thời gian:";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.BackColor = System.Drawing.Color.Transparent;
            this.label_Error.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(144, 356);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(96, 23);
            this.label_Error.TabIndex = 14;
            this.label_Error.Text = "label_Error";
            this.label_Error.Visible = false;
            this.label_Error.VisibleChanged += new System.EventHandler(this.label_Error_VisibleChanged);
            // 
            // UserControl_Exam_Combo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label_Combo);
            this.Controls.Add(this.xuiButton_Start);
            this.Controls.Add(this.metroTextBox_Time);
            this.Controls.Add(this.metroTextBox_Number);
            this.Controls.Add(this.comboBox_Branch);
            this.Controls.Add(this.comboBox_Main);
            this.Name = "UserControl_Exam_Combo";
            this.Size = new System.Drawing.Size(670, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox_Branch;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Number;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Time;
        private XanderUI.XUIButton xuiButton_Start;
        private System.Windows.Forms.Label label_Combo;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.ComboBox comboBox_Main;
        private System.Windows.Forms.Label label_Error;
    }
}
