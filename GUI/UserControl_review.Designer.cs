namespace GUI
{
    partial class UserControl_Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Review));
            this.xuiButton_Back = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // xuiButton_Back
            // 
            this.xuiButton_Back.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton_Back.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton_Back.ButtonImage")));
            this.xuiButton_Back.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.xuiButton_Back.ButtonText = "";
            this.xuiButton_Back.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton_Back.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.CornerRadius = 5;
            this.xuiButton_Back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Back.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton_Back.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton_Back.Location = new System.Drawing.Point(620, 15);
            this.xuiButton_Back.Name = "xuiButton_Back";
            this.xuiButton_Back.Size = new System.Drawing.Size(31, 31);
            this.xuiButton_Back.TabIndex = 6;
            this.xuiButton_Back.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton_Back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton_Back.Click += new System.EventHandler(this.xuiButton_Back_Click);
            // 
            // UserControl_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiButton_Back);
            this.Location = new System.Drawing.Point(34, 79);
            this.Name = "UserControl_Review";
            this.Size = new System.Drawing.Size(670, 555);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton xuiButton_Back;
    }
}
