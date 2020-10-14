using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet {
    public partial class Form_Login : Form {
        public Form_Login() {
            InitializeComponent();
            this.AcceptButton = btLogin;
            this.CancelButton = btExit;
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;

            if (Login(userName, passWord)) {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                Form_Main fMain = new Form_Main();
                fMain.Owner = this;
                this.Hide();
                fMain.Show();
            }
            else {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }
        }

        bool Login(string userName, string passWord) {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void lbCreateNewAccount_Click(object sender, EventArgs e) {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            Form_Signup fSignup = new Form_Signup();
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
