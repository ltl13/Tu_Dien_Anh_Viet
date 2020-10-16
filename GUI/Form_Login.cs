using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Login : Form {
        public Form_Login() {
            InitializeComponent();
            this.AcceptButton = btLogin;
            this.CancelButton = btExit;
        }

        /* ---------- Đăng nhập ---------- */
        private bool Login(string userName, string passWord) {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;

            if (userName.Length == 0 || passWord.Length == 0) {
                MessageBox.Show("Không được bỏ trống!", "Thông báo");
                return;
            }

            if (Login(userName, passWord)) {
<<<<<<< Updated upstream
                tbUsername.TextChanged -= tbUsername_TextChanged;
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                tbUsername.Focus();
                tbUsername.TextChanged += tbUsername_TextChanged;
                Form_Main fMain = new Form_Main();
                fMain.Owner = this;
                this.Hide();
                fMain.Show();
=======
                AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);           
                Form_Main fMain = new Form_Main(loginAccount, this);
                fMain.Show();
                this.Hide();
                tbPassword.Text = string.Empty;
                tbUsername.Text = string.Empty;
                tbUsername.Select();
>>>>>>> Stashed changes
            }
            else {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }
        }
        /* ------------------------------- */

        private void lbCreateNewAccount_Click(object sender, EventArgs e) {          
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            Form_Signup fSignup = new Form_Signup(this);
            fSignup.Owner = this;
            this.Hide();
            fSignup.Show();
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
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
    }
}
