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
            this.button_Game_BuildBridge.Location = new System.Drawing.Point(173, 346);
            this.button_Game_BuildBridge.Name = "button_Game_BuildBridge";
            this.button_Game_BuildBridge.Padding = new System.Windows.Forms.Padding(20);
            this.button_Game_BuildBridge.Size = new System.Drawing.Size(539, 238);
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
            this.button_Game_CarRacing.Location = new System.Drawing.Point(173, 59);
            this.button_Game_CarRacing.Name = "button_Game_CarRacing";
            this.button_Game_CarRacing.Size = new System.Drawing.Size(539, 238);
            this.button_Game_CarRacing.TabIndex = 0;
            this.button_Game_CarRacing.UseCompatibleTextRendering = true;
            this.button_Game_CarRacing.UseVisualStyleBackColor = true;
            this.button_Game_CarRacing.Click += new System.EventHandler(this.button_Game_CarRacing_Click);
            // 
            // UserControl_Grammar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Game_BuildBridge);
            this.Controls.Add(this.button_Game_CarRacing);
            this.Name = "UserControl_Grammar";
            this.Size = new System.Drawing.Size(812, 676);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Game_CarRacing;
        private System.Windows.Forms.Button button_Game_BuildBridge;
    }
}
