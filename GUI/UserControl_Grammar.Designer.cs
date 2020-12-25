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
            this.button_Game2.FlatAppearance.BorderSize = 0;
            this.button_Game2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Game2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Game2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(186)))), ((int)(((byte)(3)))));
            this.button_Game2.Location = new System.Drawing.Point(76, 299);
            this.button_Game2.Name = "button_Game2";
            this.button_Game2.Padding = new System.Windows.Forms.Padding(20);
            this.button_Game2.Size = new System.Drawing.Size(539, 238);
            this.button_Game2.TabIndex = 1;
            this.button_Game2.UseCompatibleTextRendering = true;
            this.button_Game2.UseVisualStyleBackColor = true;
            // 
            // button_Game1
            // 
            this.button_Game1.BackgroundImage = global::GUI.Properties.Resources.imageedit_1_5530705358;
            this.button_Game1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Game1.FlatAppearance.BorderSize = 0;
            this.button_Game1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Game1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Game1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(213)))));
            this.button_Game1.Location = new System.Drawing.Point(76, 36);
            this.button_Game1.Name = "button_Game1";
            this.button_Game1.Size = new System.Drawing.Size(539, 238);
            this.button_Game1.TabIndex = 0;
            this.button_Game1.UseCompatibleTextRendering = true;
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
            this.Load += new System.EventHandler(this.UserControl_Grammar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Game1;
        private System.Windows.Forms.Button button_Game2;
    }
}
