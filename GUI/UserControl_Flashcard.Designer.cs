namespace GUI
{
    partial class UserControl_Flashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Flashcard));
            this.metroPanel_Eng = new MetroFramework.Controls.MetroPanel();
            this.xuiButton_Next = new XanderUI.XUIButton();
            this.xuiButton_Previous = new XanderUI.XUIButton();
            this.metroLabel_Number = new MetroFramework.Controls.MetroLabel();
            this.xuiButton_Delete = new XanderUI.XUIButton();
            this.textBox_Eng = new System.Windows.Forms.TextBox();
            this.comboBox_FavoriteList = new System.Windows.Forms.ComboBox();
            this.metroPanel_Eng.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel_Eng
            // 
            this.metroPanel_Eng.Controls.Add(this.textBox_Eng);
            this.metroPanel_Eng.HorizontalScrollbarBarColor = true;
            this.metroPanel_Eng.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_Eng.HorizontalScrollbarSize = 10;
            this.metroPanel_Eng.Location = new System.Drawing.Point(61, 47);
            this.metroPanel_Eng.Name = "metroPanel_Eng";
            this.metroPanel_Eng.Size = new System.Drawing.Size(504, 309);
            this.metroPanel_Eng.TabIndex = 0;
            this.metroPanel_Eng.VerticalScrollbarBarColor = true;
            this.metroPanel_Eng.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_Eng.VerticalScrollbarSize = 10;
            // 
            // xuiButton_Next
            // 
            this.xuiButton_Next.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Next.ButtonImage")));
            this.xuiButton_Next.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Next.ButtonText = "";
            this.xuiButton_Next.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.CornerRadius = 5;
            this.xuiButton_Next.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Next.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Next.Location = new System.Drawing.Point(374, 379);
            this.xuiButton_Next.Name = "xuiButton_Next";
            this.xuiButton_Next.Size = new System.Drawing.Size(46, 45);
            this.xuiButton_Next.TabIndex = 1;
            this.xuiButton_Next.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Next.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton_Previous
            // 
            this.xuiButton_Previous.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Previous.ButtonImage")));
            this.xuiButton_Previous.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Previous.ButtonText = "";
            this.xuiButton_Previous.ClickBackColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.CornerRadius = 5;
            this.xuiButton_Previous.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Previous.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Previous.Location = new System.Drawing.Point(215, 379);
            this.xuiButton_Previous.Name = "xuiButton_Previous";
            this.xuiButton_Previous.Size = new System.Drawing.Size(46, 45);
            this.xuiButton_Previous.TabIndex = 2;
            this.xuiButton_Previous.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Previous.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // metroLabel_Number
            // 
            this.metroLabel_Number.AutoSize = true;
            this.metroLabel_Number.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_Number.Location = new System.Drawing.Point(267, 391);
            this.metroLabel_Number.Name = "metroLabel_Number";
            this.metroLabel_Number.Size = new System.Drawing.Size(79, 20);
            this.metroLabel_Number.TabIndex = 3;
            this.metroLabel_Number.Text = "1000/1000";
            this.metroLabel_Number.WrapToLine = true;
            // 
            // xuiButton_Delete
            // 
            this.xuiButton_Delete.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Delete.ButtonImage")));
            this.xuiButton_Delete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton_Delete.ButtonText = "Button";
            this.xuiButton_Delete.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_Delete.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.CornerRadius = 5;
            this.xuiButton_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Delete.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_Delete.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Delete.Location = new System.Drawing.Point(532, 452);
            this.xuiButton_Delete.Name = "xuiButton_Delete";
            this.xuiButton_Delete.Size = new System.Drawing.Size(33, 32);
            this.xuiButton_Delete.TabIndex = 4;
            this.xuiButton_Delete.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // textBox_Eng
            // 
            this.textBox_Eng.BackColor = System.Drawing.Color.White;
            this.textBox_Eng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Eng.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_Eng.Location = new System.Drawing.Point(61, 125);
            this.textBox_Eng.MaxLength = 32;
            this.textBox_Eng.Name = "textBox_Eng";
            this.textBox_Eng.ReadOnly = true;
            this.textBox_Eng.Size = new System.Drawing.Size(383, 38);
            this.textBox_Eng.TabIndex = 2;
            this.textBox_Eng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_FavoriteList
            // 
            this.comboBox_FavoriteList.DropDownHeight = 150;
            this.comboBox_FavoriteList.FormattingEnabled = true;
            this.comboBox_FavoriteList.IntegralHeight = false;
            this.comboBox_FavoriteList.Location = new System.Drawing.Point(614, 492);
            this.comboBox_FavoriteList.Name = "comboBox_FavoriteList";
            this.comboBox_FavoriteList.Size = new System.Drawing.Size(10, 24);
            this.comboBox_FavoriteList.TabIndex = 5;
            this.comboBox_FavoriteList.Visible = false;
            // 
            // UserControl_Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiButton_Delete);
            this.Controls.Add(this.metroLabel_Number);
            this.Controls.Add(this.xuiButton_Previous);
            this.Controls.Add(this.comboBox_FavoriteList);
            this.Controls.Add(this.xuiButton_Next);
            this.Controls.Add(this.metroPanel_Eng);
            this.Name = "UserControl_Flashcard";
            this.Size = new System.Drawing.Size(624, 516);
            this.metroPanel_Eng.ResumeLayout(false);
            this.metroPanel_Eng.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel_Eng;
        private XanderUI.XUIButton xuiButton_Next;
        private XanderUI.XUIButton xuiButton_Previous;
        private MetroFramework.Controls.MetroLabel metroLabel_Number;
        private XanderUI.XUIButton xuiButton_Delete;
        private System.Windows.Forms.TextBox textBox_Eng;
        private System.Windows.Forms.ComboBox comboBox_FavoriteList;
    }
}
