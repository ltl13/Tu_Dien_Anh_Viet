using BUS;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Signup : MetroFramework.Forms.MetroForm {
        #region properties
        private Form father;

        public Form_Signup(Form login) {
            InitializeComponent();
            this.FocusMe();
            this.father = login;
        }
        #endregion

        #region method
        private bool Register(string userName, int type, string passWord, string displayName = null) {
            return AccountBUS.Instance.Register(userName, type, passWord, displayName);
        }

        private void btRegister_Click(object sender, EventArgs e) {
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

        private void tbUsername_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9 ]*$");

            if (!regexItem.IsMatch(tbUsername.Text)) {
                lbError.Text = "Tài khoản chỉ gồm chữ và số!";
                lbError.Visible = true;
            }
            else {
                if (tbPassword.Text.Length != 0) {
                    tbPassword.Text = string.Empty;
                }

                if (lbError.Visible == true) {
                    lbError.Visible = false;
                }
            }
        }

        private void lbError_TextChanged(object sender, EventArgs e) {
            if (lbError.Visible == true) {
                btRegister.Enabled = false;
                if (lbError.Text == "Username đã được đăng ký!") {
                    tbUsername.Select();
                    pnlUsername.BackColor = Color.Red;
                    lbUsername.ForeColor = Color.Red;
                    pnlPassword.BackColor = Color.Red;
                    lbPassword.ForeColor = Color.Red;
                    pnlConfirm.BackColor = Color.Red;
                    lbConfirm.BackColor = Color.Red;
                }
                else if (lbError.Text == "Không được để trống!") {
                    if (tbConfirm.Text.Length == 0) {
                        tbConfirm.Select();
                        pnlConfirm.BackColor = Color.Red;
                        lbConfirm.BackColor = Color.Red;
                    }
                    if (tbPassword.Text.Length == 0) {
                        tbPassword.Select();
                        pnlPassword.BackColor = Color.Red;
                        lbPassword.ForeColor = Color.Red;
                    }
                    if (tbUsername.Text.Length == 0) {
                        tbUsername.Select();
                        pnlUsername.BackColor = Color.Red;
                        lbUsername.ForeColor = Color.Red;
                    }
                }
                else if (lbError.Text == "Tài khoản chỉ gồm chữ và số!") {
                    pnlUsername.BackColor = Color.Red;
                    lbUsername.ForeColor = Color.Red;
                }
            }
            else {
                btRegister.Enabled = true;
                if (lbPassword.ForeColor == Color.Red) {
                    if (tbPassword.Focused == true)
                        tbPassword.Select();

                    pnlPassword.BackColor = Color.DarkGray;
                    lbPassword.ForeColor = Color.DarkGray;
                }
                if (lbUsername.ForeColor == Color.Red) {
                    if (tbPassword.Focused != true)
                        tbUsername.Select();

                    pnlUsername.BackColor = Color.DarkGray;
                    lbUsername.ForeColor = Color.DarkGray;
                }
            }
        }
    }
}
