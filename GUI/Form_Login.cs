using BUS;
using DTO;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Login : MetroFramework.Forms.MetroForm {
        Form_Main fMain;
        AccountDTO loginAccount;

        #region properties
        public Form_Login() {
            InitializeComponent();

            this.FocusMe();
        }
        #endregion

        #region method
        private bool Login(string userName, string passWord) {
            return AccountBUS.Instance.Login(userName, passWord);
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;

            if (userName.Length == 0) {
                MessageBox.Show("Vui lòng điền tên đăng nhập!", "Thông báo");
                return;
            }
            else if (passWord.Length == 0) {
                MessageBox.Show("Vui lòng điền mật khẩu!", "Thông báo");
                return;
            }

            if (Login(userName, passWord)) {
                loginAccount = AccountBUS.Instance.GetAccountByUserName(userName);
                xuiFlatProgressBar_Login.Visible = true;

                fMain = new Form_Main(loginAccount, this);
                fMain.Show();
                this.Hide();
                xuiFlatProgressBar_Login.Visible = false;
                this.tbUsername.Select();
                this.tbUsername.Focus();
                this.tbUsername.Text = string.Empty;
                this.tbPassword.Text = string.Empty;
            }
            else {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }
        }

        private void lbCreateNewAccount_Click(object sender, EventArgs e) {
            this.tbUsername.Text = string.Empty;
            this.tbPassword.Text = string.Empty;
            Form_Signup fSignup = new Form_Signup(this);
            fSignup.Owner = this;
            this.Hide();
            fSignup.Show();
        }

        private void btExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e) {
            if (tbPassword.Text.Length != 0) {
                tbPassword.Text = string.Empty;
            }
        }

        private void lbCreateNewAccount_MouseHover(object sender, EventArgs e) {
            this.lbCreateNewAccount.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbCreateNewAccount_MouseLeave(object sender, EventArgs e) {
            this.lbCreateNewAccount.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        #endregion
    }
}