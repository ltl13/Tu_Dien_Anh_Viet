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
            this.tabViDu = new System.Windows.Forms.TabPage();
            this.tabChuyenNganh = new System.Windows.Forms.TabPage();
            this.tabDongTraiNghia = new System.Windows.Forms.TabPage();
            this.tabGhiChu = new System.Windows.Forms.TabPage();
            this.tabAnh = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tapcrlWordInfo.SuspendLayout();
            this.tabNghia.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelWord.ForeColor = System.Drawing.Color.Black;
            this.labelWord.Location = new System.Drawing.Point(22, 18);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(101, 36);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.tapcrlWordInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 384);
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
            this.tapcrlWordInfo.Location = new System.Drawing.Point(0, 0);
            this.tapcrlWordInfo.Name = "tapcrlWordInfo";
            this.tapcrlWordInfo.SelectedIndex = 0;
            this.tapcrlWordInfo.Size = new System.Drawing.Size(566, 384);
            this.tapcrlWordInfo.TabIndex = 0;
            // 
            // tabNghia
            // 
            this.tabNghia.BackColor = System.Drawing.Color.White;
            this.tabNghia.Controls.Add(this.button1);
            this.tabNghia.Location = new System.Drawing.Point(4, 25);
            this.tabNghia.Name = "tabNghia";
            this.tabNghia.Padding = new System.Windows.Forms.Padding(3);
            this.tabNghia.Size = new System.Drawing.Size(558, 355);
            this.tabNghia.TabIndex = 0;
            this.tabNghia.Text = "Nghĩa";
            // 
            // tabViDu
            // 
            this.tabViDu.BackColor = System.Drawing.Color.White;
            this.tabViDu.Location = new System.Drawing.Point(4, 25);
            this.tabViDu.Name = "tabViDu";
            this.tabViDu.Padding = new System.Windows.Forms.Padding(3);
            this.tabViDu.Size = new System.Drawing.Size(584, 355);
            this.tabViDu.TabIndex = 1;
            this.tabViDu.Text = "Ví dụ";
            // 
            // tabChuyenNganh
            // 
            this.tabChuyenNganh.Location = new System.Drawing.Point(4, 25);
            this.tabChuyenNganh.Name = "tabChuyenNganh";
            this.tabChuyenNganh.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuyenNganh.Size = new System.Drawing.Size(584, 355);
            this.tabChuyenNganh.TabIndex = 2;
            this.tabChuyenNganh.Text = "Chuyên ngành";
            this.tabChuyenNganh.UseVisualStyleBackColor = true;
            // 
            // tabDongTraiNghia
            // 
            this.tabDongTraiNghia.Location = new System.Drawing.Point(4, 25);
            this.tabDongTraiNghia.Name = "tabDongTraiNghia";
            this.tabDongTraiNghia.Size = new System.Drawing.Size(584, 355);
            this.tabDongTraiNghia.TabIndex = 3;
            this.tabDongTraiNghia.Text = "Đồng nghĩa - Trái nghĩa";
            this.tabDongTraiNghia.UseVisualStyleBackColor = true;
            // 
            // tabGhiChu
            // 
            this.tabGhiChu.Location = new System.Drawing.Point(4, 25);
            this.tabGhiChu.Name = "tabGhiChu";
            this.tabGhiChu.Size = new System.Drawing.Size(584, 355);
            this.tabGhiChu.TabIndex = 4;
            this.tabGhiChu.Text = "Ghi chú";
            this.tabGhiChu.UseVisualStyleBackColor = true;
            // 
            // tabAnh
            // 
            this.tabAnh.Location = new System.Drawing.Point(4, 25);
            this.tabAnh.Name = "tabAnh";
            this.tabAnh.Size = new System.Drawing.Size(584, 355);
            this.tabAnh.TabIndex = 6;
            this.tabAnh.Text = "Ảnh minh họa";
            this.tabAnh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(495, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormWordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(167)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWordInfo";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tapcrlWordInfo.ResumeLayout(false);
            this.tabNghia.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
    }
}