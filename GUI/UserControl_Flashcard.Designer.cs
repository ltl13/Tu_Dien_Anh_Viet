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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.xuiButton_Next = new XanderUI.XUIButton();
            this.xuiButton_Previous = new XanderUI.XUIButton();
            this.metroLabel_Number = new MetroFramework.Controls.MetroLabel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(61, 47);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(504, 309);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Transparent;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(532, 452);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(33, 32);
            this.xuiButton1.TabIndex = 4;
            this.xuiButton1.TextColor = System.Drawing.Color.Transparent;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // UserControl_Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.metroLabel_Number);
            this.Controls.Add(this.xuiButton_Previous);
            this.Controls.Add(this.xuiButton_Next);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UserControl_Flashcard";
            this.Size = new System.Drawing.Size(624, 516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private XanderUI.XUIButton xuiButton_Next;
        private XanderUI.XUIButton xuiButton_Previous;
        private MetroFramework.Controls.MetroLabel metroLabel_Number;
        private XanderUI.XUIButton xuiButton1;
    }
}
