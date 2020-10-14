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
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;

            if (Login(userName, passWord)) {
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                Form_Main fMain = new Form_Main();
                this.Hide();
                fMain.ShowDialog();
                this.Show();
            }
            else {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
            }
        }

        bool Login(string userName, string passWord) {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void lbCreateNewAccount_Click(object sender, EventArgs e) {

        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }
    }
}
