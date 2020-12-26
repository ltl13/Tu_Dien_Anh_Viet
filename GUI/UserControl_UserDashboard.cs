using BUS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_UserDashboard : UserControl {
        Form_Main father;
        DataGridView dataGridView = new DataGridView();
        string path;

        public UserControl_UserDashboard(Form_Main fMain) {
            InitializeComponent();
            father = fMain;
        }

        private void UserControl_UserDashboard_VisibleChanged(object sender, EventArgs e) {
            byte[] byteArrayIn = AccountBUS.Instance.LoadImage(father.LoginAccount.ID);

            using (var ms = new MemoryStream(byteArrayIn)) {
                this.pictureBox_UserPic.Image = Image.FromStream(ms);
            }

            label_Password.Visible = false;
            label_NewPass.Visible = false;
            label_NewPassConfirm.Visible = false;
            label_Name.Visible = false;
            textBox_Password.Visible = false;
            textBox_NewPass.Visible = false;
            textBox_Confirm.Visible = false;
            textBox_Name.Visible = false;
            button_Save.Visible = false;
            button_Upload.Visible = false;
            pictureBox_UserPic.Visible = false;
            dataGridView.Visible = false;
            label_Error.Visible = false;
            textBox_Password.UseSystemPasswordChar = true;
            label_Password.Text = "Password (required):";
            label_Error.Text = "label_Error";

            switch (father.Choice) {
                case 1:
                    UpdateInfo();
                    break;
                case 2:
                    FindUser();
                    break;
                case 3:
                    ListAccount();
                    break;
                case 4:
                    DeleteAccount();
                    break;
            }
        }

        private void UpdateInfo() {
            label_Title.Text = father.xuiButton_UpdateInfo.ButtonText.ToUpper();

            label_Password.Visible = true;
            label_NewPass.Visible = true;
            label_NewPassConfirm.Visible = true;
            label_Name.Visible = true;
            textBox_Password.Visible = true;
            textBox_NewPass.Visible = true;
            textBox_Confirm.Visible = true;
            textBox_Name.Visible = true;
            pictureBox_UserPic.Visible = true;
            button_Save.Visible = true;
            button_Upload.Visible = true;
        }

        private void FindUser() {
            label_Title.Text = father.xuiButton_FindUser.ButtonText.ToUpper();
            label_Password.Text = "Nhập ID cần tìm:";
            label_Password.Visible = true;
            textBox_Password.Visible = true;
            textBox_Password.UseSystemPasswordChar = false;
        }

        private void ListAccount() {
            label_Title.Text = father.xuiButton_ListAccount.ButtonText.ToUpper();
            dataGridView.Visible = true;
            InitDataGridView();
            panel_Footer.Controls.Add(dataGridView);
            dataGridView.DataSource = AccountBUS.Instance.GetListAccount();
        }

        private void DeleteAccount() {
            label_Title.Text = father.xuiButton_DeleteAccount.ButtonText.ToUpper();
        }

        private void InitDataGridView() {
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BorderStyle = BorderStyle.None;
            this.dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Info;
            this.dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridView.DefaultCellStyle.BackColor = SystemColors.Highlight;
            this.dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new Point(0, 0);
            this.dataGridView.Margin = new Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 92;
            this.dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            this.dataGridView.RowsDefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dataGridView.RowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            this.dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.ScrollBars = ScrollBars.None;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new Size(650, 415);
            this.dataGridView.DataSourceChanged += new EventHandler(this.dataGridView_DataSourceChanged);
            this.dataGridView.MouseWheel += new MouseEventHandler(this.dataGridView_MouseWheel);
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e) {
            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[0].FillWeight = 10;
            dataGridView.Columns[1].FillWeight = 40;
            dataGridView.Columns[2].FillWeight = 50;
            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewFormat();
        }

        void dataGridViewFormat() {
            for (int i = 0; i < dataGridView.RowCount; i++) {
                if (i % 2 == 0) {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dataGridView_MouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && dataGridView.FirstDisplayedScrollingRowIndex > 0) {
                dataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0) {
                dataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void button_Save_Click(object sender, EventArgs e) {
            if (textBox_Password.Text.Length == 0) {
                label_Error.Text = "Không được để trống trường Password!";
                label_Error.Visible = true;
                textBox_Password.Select();
                return;
            }

            if (textBox_NewPass.Text.Length != 0 && textBox_Confirm.Text.Length == 0) {
                label_Error.Text = "Không được để trống trường Confirm!";
                label_Error.Visible = true;
                textBox_Confirm.Select();
                return;
            }

            if (textBox_Confirm.Text.Length != 0 && textBox_NewPass.Text.Length == 0) {
                label_Error.Text = "Không được để trống trường New Password!";
                label_Error.Visible = true;
                textBox_NewPass.Select();
                return;
            }

            if (textBox_Password.Text.Length != 0 && textBox_NewPass.Text.Length != 0 && textBox_Confirm.Text.Length != 0) {
                if (textBox_Password.Text == textBox_NewPass.Text) {
                    label_Error.Text = "Password hiện tại và Password mới trùng nhau!";
                    label_Error.Visible = true;
                    textBox_NewPass.Select();
                    return;
                }
            }

            if (AccountBUS.Instance.Login(father.LoginAccount.UserName, textBox_Password.Text)) {
                if (textBox_Name.Text.Length == 0) {
                    AccountBUS.Instance.UpdateAccount(father.LoginAccount.UserName, father.LoginAccount.DisplayName, textBox_Password.Text, textBox_NewPass.Text);
                }
                else {
                    AccountBUS.Instance.UpdateAccount(father.LoginAccount.UserName, textBox_Name.Text, textBox_Password.Text, textBox_NewPass.Text);
                    father.xuiButton_Account.ButtonText = "Hi " + textBox_Name.Text + "!";
                }

                if (!string.IsNullOrEmpty(path)) {
                    AccountBUS.Instance.SavePicture(father.LoginAccount.ID, Path.GetDirectoryName(path), Path.GetFileName(path));
                    path = string.Empty;
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_Password.Text = string.Empty;
                textBox_NewPass.Text = string.Empty;
                textBox_Confirm.Text = string.Empty;
                textBox_Name.Text = string.Empty;

                
            }
            else {
                label_Error.Text = "Password hiện tại sai!";
                label_Error.Visible = true;
                textBox_Password.Select();
                return;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e) {
            if (label_Error.Visible == true && label_Error.Text == "Không được để trống trường Password!") {
                label_Error.Visible = false;
            }
        }

        private void textBox_NewPass_TextChanged(object sender, EventArgs e) {
            if (label_Error.Visible == true && label_Error.Text == "Không được để trống trường New Password!") {
                label_Error.Visible = false;
            }
            textBox_Confirm.Text = string.Empty;
        }

        private void textBox_Confirm_TextChanged(object sender, EventArgs e) {
            if (label_Error.Visible == true && label_Error.Text == "Không được để trống trường Confirm!") {
                label_Error.Visible = false;
            }
        }

        private void button_Upload_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            open.Multiselect = false;

            if (open.ShowDialog() == DialogResult.OK) {
                pictureBox_UserPic.Image = new Bitmap(open.FileName);

                path = open.FileName;
            }
        }
    }
}
