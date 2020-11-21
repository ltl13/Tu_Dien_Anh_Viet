using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Signup : MetroFramework.Forms.MetroForm {
        #region properties
        private Form father;

        public Form_Signup(Form login) {
            InitializeComponent();
            this.AcceptButton = btLogin;
            this.CancelButton = btCancel;
            this.father = login;
        }
        #endregion

        #region method
        private bool Register(string userName, int type, string passWord, string displayName = null) {
            return AccountBUS.Instance.Register(userName, type, passWord, displayName);
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;
            string confirm = tbConfirm.Text;
            string displayName = tbName.Text;
            int type = 0;

            if (displayName.Length == 0) {
                displayName = null;
            }

            if (userName.Length == 0) {
                MessageBox.Show("Vui lòng điền tên đăng nhập!", "Thông báo");
                return;
            }
            else if (passWord.Length == 0) {
                MessageBox.Show("Vui lòng điền mật khẩu!", "Thông báo");
                return;
            }
            else if (confirm.Length == 0) {
                MessageBox.Show("Vui lòng điền xác nhận mật khẩu!", "Thông báo");
                return;
            }
            else if (passWord != confirm) {
                tbPassword.Text = string.Empty;
                tbConfirm.Text = string.Empty;
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo");
                return;
            }


            if (Register(userName, type, passWord, displayName)) {
                AccountDTO loginAccount = AccountBUS.Instance.GetAccountByUserName(userName);
                Form_Main fMain = new Form_Main(loginAccount, this);
                fMain.Show();
                this.Close();
            }
            else {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
            }
        }

        private void btCancel_Click(object sender, EventArgs e) {
            father.Show();
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            if (tbConfirm.Text.Length != 0) {
                tbConfirm.Text = string.Empty;
            }
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e) {
            if (tbPassword.Text.Length != 0) {
                tbPassword.Text = string.Empty;
            }
        }
        #endregion
    }
}
