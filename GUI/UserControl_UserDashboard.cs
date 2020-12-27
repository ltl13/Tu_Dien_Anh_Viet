using BUS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_UserDashboard : UserControl {
        Form_Main father;
        DataGridView dataGridView = new DataGridView();
        Label label_Search = new Label();
        TextBox textBox_Search = new TextBox();
        Label label_Search_Name = new Label();
        Label label_Error_Search = new Label();
        Label label_Delete = new Label();
        TextBox textBox_Delete = new TextBox();

        string path;

        public UserControl_UserDashboard(Form_Main fMain) {
            InitializeComponent();
            father = fMain;
        }

        private void UserControl_UserDashboard_VisibleChanged(object sender, EventArgs e) {
            label_Password.Visible = false;
            label_NewPass.Visible = false;
            label_Confirm.Visible = false;
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
            label_Search.Visible = false;
            textBox_Search.Visible = false;
            label_Error_Search.Visible = false;
            label_Search_Name.Visible = false;
            label_Delete.Visible = false;
            textBox_Delete.Visible = false;
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

            byte[] byteArrayIn = AccountBUS.Instance.LoadImage(father.LoginAccount.ID);

            using (var ms = new MemoryStream(byteArrayIn)) {
                pictureBox_UserPic.Image = Image.FromStream(ms);
            }

            label_Password.Visible = true;
            label_NewPass.Visible = true;
            label_Confirm.Visible = true;
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
            label_Search.Visible = true;
            textBox_Search.Visible = true;
            InitFindUser();
            panel_Footer.Controls.Add(label_Search);
            panel_Footer.Controls.Add(textBox_Search);
            panel_Footer.Controls.Add(label_Error_Search);
            panel_Footer.Controls.Add(label_Search_Name);
        }

        private void InitFindUser() {
            // 
            // label_Search
            // 
            label_Search.AutoSize = true;
            label_Search.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label_Search.ForeColor = SystemColors.ControlText;
            label_Search.Location = new Point(28, 40);
            label_Search.Name = "label_Search";
            label_Search.Size = new Size(215, 29);
            label_Search.Text = "Nhập Username cần tìm:";
            // 
            // textBox_Search
            // 
            textBox_Search.BackColor = Color.White;
            textBox_Search.BorderStyle = BorderStyle.FixedSingle;
            textBox_Search.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox_Search.Location = new Point(33, 72);
            textBox_Search.MaxLength = 50;
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(230, 28);
            textBox_Search.KeyDown += new KeyEventHandler(textBox_Search_KeyDown);
            textBox_Search.TextChanged += new EventHandler(textBox_Search_TextChanged);
            // 
            // label_Error_Search
            //
            label_Error_Search.AutoSize = true;
            label_Error_Search.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            label_Error_Search.ForeColor = Color.Red;
            label_Error_Search.Location = new Point(30, 100);
            label_Error_Search.Name = "label_Error_Search";
            label_Error_Search.Size = new Size(74, 18);
            label_Error_Search.Text = "label_Error_Search";
            label_Error_Search.Visible = false;
            // 
            // label_Search_Name
            // 
            label_Search_Name.AutoSize = false;
            label_Search_Name.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label_Search_Name.ForeColor = SystemColors.ControlText;
            label_Search_Name.Location = new Point(340, 360);
            label_Search_Name.Name = "label_Search";
            label_Search_Name.Size = new Size(295, 30);
            label_Search_Name.Text = "label_Search";
            label_Search_Name.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void textBox_Search_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (label_Error_Search.Visible == true && label_Error_Search.Text == "Tài khoản chỉ gồm chữ và số!") {
                    return;
                }

                DTO.AccountDTO userTarget = AccountBUS.Instance.GetAccountByUserName(textBox_Search.Text);

                if (userTarget != null) {
                    byte[] byteArrayIn = AccountBUS.Instance.LoadImage(userTarget.ID);

                    using (var ms = new MemoryStream(byteArrayIn)) {
                        pictureBox_UserPic.Image = Image.FromStream(ms);
                    }

                    if (userTarget.ID == father.LoginAccount.ID)
                        label_Search_Name.Text = "Là bạn đó ahihi ^^";
                    else
                        label_Search_Name.Text = "Name: " + userTarget.DisplayName;

                    label_Search_Name.TextAlign = ContentAlignment.MiddleCenter;
                    label_Search_Name.Visible = true;
                    pictureBox_UserPic.Visible = true;
                }
                else {
                    label_Error_Search.Text = "Tài khoản không tồn tại!";
                    label_Error_Search.Visible = true;
                }
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9 ]*$");

            if (!regexItem.IsMatch(textBox_Search.Text)) {
                label_Error_Search.Text = "Tài khoản chỉ gồm chữ và số!";
                label_Error_Search.Visible = true;
            }
            else {
                label_Error_Search.Visible = false;
            }

            if (pictureBox_UserPic.Visible == true) {
                pictureBox_UserPic.Visible = false;
                label_Search_Name.Visible = false;
            }
        }

        private void ListAccount() {
            label_Title.Text = father.xuiButton_ListAccount.ButtonText.ToUpper();
            dataGridView.Visible = true;
            InitListAccount();
            panel_Footer.Controls.Add(dataGridView);
            dataGridView.DataSource = AccountBUS.Instance.GetListAccount();
        }

        private void InitListAccount() {
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Info;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersHeight = 35;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridView.DefaultCellStyle.BackColor = SystemColors.Highlight;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 92;
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.RowsDefaultCellStyle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridView.RowsDefaultCellStyle.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.RowTemplate.Height = 37;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowEditingIcon = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(650, 415);
            dataGridView.DataSourceChanged += new EventHandler(dataGridView_DataSourceChanged);
            dataGridView.MouseWheel += new MouseEventHandler(dataGridView_MouseWheel);
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e) {
            foreach (DataGridViewColumn column in dataGridView.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewRow row in dataGridView.Rows) {
                row.Cells[0].Value = row.Index;
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

        private void DeleteAccount() {
            label_Title.Text = father.xuiButton_DeleteAccount.ButtonText.ToUpper();
            label_Delete.Visible = true;
            textBox_Delete.Visible = true;
            InitDeleteAccount();
            panel_Footer.Controls.Add(label_Delete);
            panel_Footer.Controls.Add(textBox_Delete);
        }

        private void InitDeleteAccount() {
            // 
            // label_Delete
            // 
            label_Delete.AutoSize = true;
            label_Delete.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label_Delete.ForeColor = SystemColors.ControlText;
            label_Delete.Location = new Point(28, 40);
            label_Delete.Name = "label_Delete";
            label_Delete.Size = new Size(215, 29);
            label_Delete.Text = "Nhập Password để xóa tài khoản:";
            // 
            // textBox_Delete
            // 
            textBox_Delete.BackColor = Color.White;
            textBox_Delete.BorderStyle = BorderStyle.FixedSingle;
            textBox_Delete.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox_Delete.Location = new Point(33, 72);
            textBox_Delete.MaxLength = 64;
            textBox_Delete.Name = "textBox_Delete";
            textBox_Delete.UseSystemPasswordChar = true;
            textBox_Delete.Size = new Size(230, 28);
            textBox_Delete.KeyDown += new KeyEventHandler(textBox_Delete_KeyDown);
        }

        private void textBox_Delete_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (AccountBUS.Instance.Login(father.LoginAccount.UserName, textBox_Delete.Text)) {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        if (AccountBUS.Instance.DeleteAccount(father.LoginAccount.ID)) {
                            MessageBox.Show("Xóa tài khoản thành công!\nChương trình sẽ quay về nơi đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            father.Close();
                            father.Father.Show();
                        }
                    }
                }
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
