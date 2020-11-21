namespace GUI
{
    partial class UserControl_Translate
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
            this.richTextBox_From = new System.Windows.Forms.RichTextBox();
            this.richTextBox_To = new System.Windows.Forms.RichTextBox();
            this.button_Translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_From
            // 
            this.richTextBox_From.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_From.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_From.Location = new System.Drawing.Point(28, 27);
            this.richTextBox_From.Name = "richTextBox_From";
            this.richTextBox_From.Size = new System.Drawing.Size(564, 199);
            this.richTextBox_From.TabIndex = 0;
            this.richTextBox_From.Text = "";
            // 
            // richTextBox_To
            // 
            this.richTextBox_To.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_To.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_To.Location = new System.Drawing.Point(28, 288);
            this.richTextBox_To.Name = "richTextBox_To";
            this.richTextBox_To.ReadOnly = true;
            this.richTextBox_To.Size = new System.Drawing.Size(564, 199);
            this.richTextBox_To.TabIndex = 1;
            this.richTextBox_To.Text = "";
            // 
            // button_Translate
            // 
            this.button_Translate.BackColor = System.Drawing.Color.MintCream;
            this.button_Translate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Translate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Translate.Location = new System.Drawing.Point(258, 238);
            this.button_Translate.Name = "button_Translate";
            this.button_Translate.Size = new System.Drawing.Size(135, 37);
            this.button_Translate.TabIndex = 2;
            this.button_Translate.Text = "Translate";
            this.button_Translate.UseVisualStyleBackColor = false;
            this.button_Translate.Click += new System.EventHandler(this.button_Translate_Click);
            // 
            // UserControl_Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Translate);
            this.Controls.Add(this.richTextBox_To);
            this.Controls.Add(this.richTextBox_From);
            this.Name = "UserControl_Translate";
            this.Size = new System.Drawing.Size(624, 516);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_From;
        private System.Windows.Forms.RichTextBox richTextBox_To;
        public System.Windows.Forms.Button button_Translate;
    }
}
