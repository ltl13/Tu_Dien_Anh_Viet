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
            this.button_Game2 = new System.Windows.Forms.Button();
            this.button_Game1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Game2
            // 
            this.button_Game2.BackgroundImage = global::GUI.Properties.Resources.imageedit_7_7290431428;
            this.button_Game2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Game2.Location = new System.Drawing.Point(241, 290);
            this.button_Game2.Name = "button_Game2";
            this.button_Game2.Size = new System.Drawing.Size(371, 238);
            this.button_Game2.TabIndex = 1;
            this.button_Game2.UseVisualStyleBackColor = true;
            // 
            // button_Game1
            // 
            this.button_Game1.BackgroundImage = global::GUI.Properties.Resources.imageedit_1_5530705358;
            this.button_Game1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Game1.Location = new System.Drawing.Point(51, 26);
            this.button_Game1.Name = "button_Game1";
            this.button_Game1.Size = new System.Drawing.Size(371, 238);
            this.button_Game1.TabIndex = 0;
            this.button_Game1.UseVisualStyleBackColor = true;
            // 
            // UserControl_Grammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Game2);
            this.Controls.Add(this.button_Game1);
            this.Name = "UserControl_Grammar";
            this.Size = new System.Drawing.Size(670, 555);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Game1;
        private System.Windows.Forms.Button button_Game2;
    }
}
