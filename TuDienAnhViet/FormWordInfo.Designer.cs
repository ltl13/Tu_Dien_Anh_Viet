namespace TuDienAnhViet
{
    partial class FormWordInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWordInfo));
            this.labelWord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tapcrlWordInfo = new System.Windows.Forms.TabControl();
            this.tabNghia = new System.Windows.Forms.TabPage();
            this.buttonSpeaker = new System.Windows.Forms.Button();
            this.tabViDu = new System.Windows.Forms.TabPage();
            this.tabChuyenNganh = new System.Windows.Forms.TabPage();
            this.tabDongTraiNghia = new System.Windows.Forms.TabPage();
            this.tabGhiChu = new System.Windows.Forms.TabPage();
            this.tabAnh = new System.Windows.Forms.TabPage();
            this.textboxNghia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tapcrlWordInfo.SuspendLayout();
            this.tabNghia.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelWord.ForeColor = System.Drawing.Color.Black;
            this.labelWord.Location = new System.Drawing.Point(16, 24);
            this.labelWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(92, 31);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.tapcrlWordInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 312);
            this.panel1.TabIndex = 1;
            // 
            // tapcrlWordInfo
            // 
            this.tapcrlWordInfo.Controls.Add(this.tabNghia);
            this.tapcrlWordInfo.Controls.Add(this.tabViDu);
            this.tapcrlWordInfo.Controls.Add(this.tabChuyenNganh);
            this.tapcrlWordInfo.Controls.Add(this.tabDongTraiNghia);
            this.tapcrlWordInfo.Controls.Add(this.tabGhiChu);
            this.tapcrlWordInfo.Controls.Add(this.tabAnh);
            this.tapcrlWordInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tapcrlWordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tapcrlWordInfo.Location = new System.Drawing.Point(0, 0);
            this.tapcrlWordInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tapcrlWordInfo.Name = "tapcrlWordInfo";
            this.tapcrlWordInfo.SelectedIndex = 0;
            this.tapcrlWordInfo.Size = new System.Drawing.Size(465, 312);
            this.tapcrlWordInfo.TabIndex = 0;
            // 
            // tabNghia
            // 
            this.tabNghia.BackColor = System.Drawing.Color.White;
            this.tabNghia.Controls.Add(this.textboxNghia);
            this.tabNghia.Location = new System.Drawing.Point(4, 24);
            this.tabNghia.Margin = new System.Windows.Forms.Padding(2);
            this.tabNghia.Name = "tabNghia";
            this.tabNghia.Padding = new System.Windows.Forms.Padding(2);
            this.tabNghia.Size = new System.Drawing.Size(457, 284);
            this.tabNghia.TabIndex = 0;
            this.tabNghia.Text = "Nghĩa";
            // 
            // buttonSpeaker
            // 
            this.buttonSpeaker.BackColor = System.Drawing.Color.White;
            this.buttonSpeaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSpeaker.BackgroundImage")));
            this.buttonSpeaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSpeaker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpeaker.Image")));
            this.buttonSpeaker.Location = new System.Drawing.Point(413, 14);
            this.buttonSpeaker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSpeaker.Name = "buttonSpeaker";
            this.buttonSpeaker.Size = new System.Drawing.Size(41, 41);
            this.buttonSpeaker.TabIndex = 2;
            this.buttonSpeaker.UseVisualStyleBackColor = false;
            this.buttonSpeaker.Click += new System.EventHandler(this.buttonSpeaker_Click);
            // 
            // tabViDu
            // 
            this.tabViDu.BackColor = System.Drawing.Color.White;
            this.tabViDu.Location = new System.Drawing.Point(4, 24);
            this.tabViDu.Margin = new System.Windows.Forms.Padding(2);
            this.tabViDu.Name = "tabViDu";
            this.tabViDu.Padding = new System.Windows.Forms.Padding(2);
            this.tabViDu.Size = new System.Drawing.Size(457, 284);
            this.tabViDu.TabIndex = 1;
            this.tabViDu.Text = "Ví dụ";
            // 
            // tabChuyenNganh
            // 
            this.tabChuyenNganh.Location = new System.Drawing.Point(4, 24);
            this.tabChuyenNganh.Margin = new System.Windows.Forms.Padding(2);
            this.tabChuyenNganh.Name = "tabChuyenNganh";
            this.tabChuyenNganh.Padding = new System.Windows.Forms.Padding(2);
            this.tabChuyenNganh.Size = new System.Drawing.Size(457, 284);
            this.tabChuyenNganh.TabIndex = 2;
            this.tabChuyenNganh.Text = "Chuyên ngành";
            this.tabChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // tabDongTraiNghia
            // 
            this.tabDongTraiNghia.Location = new System.Drawing.Point(4, 24);
            this.tabDongTraiNghia.Margin = new System.Windows.Forms.Padding(2);
            this.tabDongTraiNghia.Name = "tabDongTraiNghia";
            this.tabDongTraiNghia.Size = new System.Drawing.Size(457, 284);
            this.tabDongTraiNghia.TabIndex = 3;
            this.tabDongTraiNghia.Text = "Đồng nghĩa - Trái nghĩa";
            this.tabDongTraiNghia.UseVisualStyleBackColor = true;
            // 
            // tabGhiChu
            // 
            this.tabGhiChu.Location = new System.Drawing.Point(4, 24);
            this.tabGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.tabGhiChu.Name = "tabGhiChu";
            this.tabGhiChu.Size = new System.Drawing.Size(457, 284);
            this.tabGhiChu.TabIndex = 4;
            this.tabGhiChu.Text = "Ghi chú";
            this.tabGhiChu.UseVisualStyleBackColor = true;
            // 
            // tabAnh
            // 
            this.tabAnh.Location = new System.Drawing.Point(4, 24);
            this.tabAnh.Margin = new System.Windows.Forms.Padding(2);
            this.tabAnh.Name = "tabAnh";
            this.tabAnh.Size = new System.Drawing.Size(457, 284);
            this.tabAnh.TabIndex = 6;
            this.tabAnh.Text = "Ảnh minh họa";
            this.tabAnh.UseVisualStyleBackColor = true;
            // 
            // textboxNghia
            // 
            this.textboxNghia.Location = new System.Drawing.Point(8, 15);
            this.textboxNghia.Name = "textboxNghia";
            this.textboxNghia.Size = new System.Drawing.Size(400, 21);
            this.textboxNghia.TabIndex = 3;
            // 
            // FormWordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(465, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSpeaker);
            this.Controls.Add(this.labelWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormWordInfo";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tapcrlWordInfo.ResumeLayout(false);
            this.tabNghia.ResumeLayout(false);
            this.tabNghia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tapcrlWordInfo;
        private System.Windows.Forms.TabPage tabNghia;
        private System.Windows.Forms.TabPage tabViDu;
        private System.Windows.Forms.TabPage tabChuyenNganh;
        private System.Windows.Forms.TabPage tabDongTraiNghia;
        private System.Windows.Forms.TabPage tabGhiChu;
        private System.Windows.Forms.TabPage tabAnh;
        private System.Windows.Forms.Button buttonSpeaker;
        private System.Windows.Forms.TextBox textboxNghia;
    }
}