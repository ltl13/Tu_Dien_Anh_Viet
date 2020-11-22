namespace GUI
{
    partial class UserControl_ComboWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ComboWord));
            this.button_ComboWord1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel_ComboWord = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_ComboWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ComboWord1
            // 
            this.button_ComboWord1.BackColor = System.Drawing.Color.Transparent;
            this.button_ComboWord1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ComboWord1.BackgroundImage")));
            this.button_ComboWord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ComboWord1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ComboWord1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ComboWord1.ForeColor = System.Drawing.Color.Black;
            this.button_ComboWord1.Location = new System.Drawing.Point(3, 3);
            this.button_ComboWord1.Name = "button_ComboWord1";
            this.button_ComboWord1.Size = new System.Drawing.Size(481, 79);
            this.button_ComboWord1.TabIndex = 0;
            this.button_ComboWord1.Text = "Animal";
            this.button_ComboWord1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel_ComboWord
            // 
            this.flowLayoutPanel_ComboWord.Controls.Add(this.button_ComboWord1);
            this.flowLayoutPanel_ComboWord.Location = new System.Drawing.Point(73, 20);
            this.flowLayoutPanel_ComboWord.Name = "flowLayoutPanel_ComboWord";
            this.flowLayoutPanel_ComboWord.Size = new System.Drawing.Size(485, 476);
            this.flowLayoutPanel_ComboWord.TabIndex = 1;
            // 
            // UserControl_ComboWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel_ComboWord);
            this.Name = "UserControl_ComboWord";
            this.Size = new System.Drawing.Size(624, 516);
            this.flowLayoutPanel_ComboWord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ComboWord1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ComboWord;
    }
}
