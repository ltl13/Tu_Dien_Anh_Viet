using BUS;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Signup : MetroFramework.Forms.MetroForm {
        #region properties
        private Form father;
        private AccountDTO loginAccount;
        private Form_Main fMain;

        public Form_Signup(Form login) {
            InitializeComponent();
            this.FocusMe();
            this.father = login;
        }
        #endregion

        #region method
        private bool Register(string userName, string passWord, string displayName = null) {
            return AccountBUS.Instance.Register(userName, passWord, displayName);
        }

        private void btRegister_Click(object sender, EventArgs e) {
            if (CheckNull())
                return;

            if (CheckRegister()) {
                xuiFlatProgressBar_Login.Visible = true;

                for (int i = 0; i < 100; i++) {
                    xuiFlatProgressBar_Login.Value = i;
                    xuiFlatProgressBar_Login.Update();
                    System.Threading.Thread.Sleep(10);
                }

                loginAccount = AccountBUS.Instance.GetAccountByUserName(tbUsername.Text);
                fMain = new Form_Main(loginAccount, father);
                Hide();
                fMain.Show();
            }
        }

        private bool CheckRegister() {
            if (tbPassword.Text != tbConfirm.Text) {
                lbError.Text = "Xác nhận mật khẩu không khớp!";
                lbError.Visible = true;
                return false;
            }

            if (tbName.Text.Length == 0) {
                if (AccountBUS.Instance.Register(tbUsername.Text, tbPassword.Text)) {
                    return true;
                }
            }
            else {
                if (AccountBUS.Instance.Register(tbUsername.Text, tbPassword.Text, tbName.Text)) {
                    return true;
                }
            }

            lbError.Text = "Tài khoản đã được đăng ký!";
            lbError.Visible = true;
            return false;
        }

        private bool CheckNull() {
            if (tbUsername.Text.Length == 0 || tbPassword.Text.Length == 0 || tbConfirm.Text.Length == 0) {
                lbError.Text = "Không được để trống!";
                lbError.Visible = true;
                return true;
            }
            return false;
        }

        private void btBack_Click(object sender, EventArgs e) {
            father.Show();
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            if (tbConfirm.Text.Length != 0) {
                tbConfirm.Text = string.Empty;
            }
            if (lbError.Visible == true) {
                lbError.Visible = false;
            }
        }

        private void tbConfirm_TextChanged(object sender, EventArgs e) {
            if (lbError.Visible == true) {
                lbError.Visible = false;
            }
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e) {
            if (tbPassword.Text.Length != 0) {
                tbPassword.Text = string.Empty;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9 ]*$");

            if (tbPassword.Text.Length != 0) {
                tbPassword.Text = string.Empty;
            }
            if (tbConfirm.Text.Length != 0) {
                tbConfirm.Text = string.Empty;
            }
            if (!regexItem.IsMatch(tbUsername.Text)) {
                lbError.Text = "Tài khoản chỉ gồm chữ và số!";
                lbError.Visible = true;
            }
            else {
                if (lbError.Visible == true) {
                    lbError.Visible = false;
                }
            }
        }

        private void lbError_VisibleChanged(object sender, EventArgs e) {
            if (lbError.Visible == true) {
                btRegister.Enabled = false;
                if (lbError.Text == "Tài khoản đã được đăng ký!") {
                    tbUsername.Select();
                    pnlUsername.BackColor = Color.Red;
                    lbUsername.ForeColor = Color.Red;
                    pnlPassword.BackColor = Color.Red;
                    lbPassword.ForeColor = Color.Red;
                    pnlConfirm.BackColor = Color.Red;
                    lbConfirm.ForeColor = Color.Red;
                }
                else if (lbError.Text == "Không được để trống!") {
                    if (tbConfirm.Text.Length == 0) {
                        tbConfirm.Select();
                        pnlConfirm.BackColor = Color.Red;
                        lbConfirm.ForeColor = Color.Red;
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
                    tbPassword.Enabled = false;
                    tbConfirm.Enabled = false;
                    tbName.Enabled = false;
                }
                else if (lbError.Text == "Xác nhận mật khẩu không khớp!") {
                    tbPassword.Select();
                    pnlPassword.BackColor = Color.Red;
                    lbPassword.ForeColor = Color.Red;
                    pnlConfirm.BackColor = Color.Red;
                    lbConfirm.ForeColor = Color.Red;
                }
            }
            else {
                btRegister.Enabled = true;
                tbPassword.Enabled = true;
                tbConfirm.Enabled = true;
                tbName.Enabled = true;

                if (lbConfirm.ForeColor == Color.Red) {
                    if (tbConfirm.Focused == true)
                        tbConfirm.Select();

                    pnlConfirm.BackColor = Color.DarkGray;
                    lbConfirm.ForeColor = Color.DarkGray;
                }
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

        private void lbError_TextChanged(object sender, EventArgs e) {
            if (lbError.Text == "Tài khoản chỉ gồm chữ và số!") {
                pnlUsername.BackColor = Color.Red;
                lbUsername.ForeColor = Color.Red;
                pnlPassword.BackColor = Color.DarkGray;
                lbPassword.ForeColor = Color.DarkGray;
                pnlConfirm.BackColor = Color.DarkGray;
                lbConfirm.ForeColor = Color.DarkGray;
                tbPassword.Enabled = false;
                tbConfirm.Enabled = false;
                tbName.Enabled = false;
            }
        }
        #endregion
    }
}
