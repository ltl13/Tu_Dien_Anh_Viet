using BUS;
using DTO;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Login : MetroFramework.Forms.MetroForm {
        Form_Main fMain;
        AccountDTO loginAccount;
        Form_Signup fSignup;

        #region properties
        public Form_Login() {
            InitializeComponent();
            FocusMe();
        }
        #endregion

        #region method
        private void btLogin_Click(object sender, EventArgs e) {
            if (CheckNull())
                return;

            if (CheckLogin()) {
                xuiFlatProgressBar_Login.Visible = true;

                for (int i = 0; i < 100; i++) {
                    xuiFlatProgressBar_Login.Value = i;
                    xuiFlatProgressBar_Login.Update();
                    Thread.Sleep(10);
                }

                loginAccount = AccountBUS.Instance.GetAccountByUserName(tbUsername.Text);                
                fMain = new Form_Main(loginAccount, this);
                Hide();
                fMain.Show();       
            }
        }

        private void lbCreateNewAccount_Click(object sender, EventArgs e) {
            fSignup = new Form_Signup(this);
            Hide();
            fSignup.Show();
        }

        private void btExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e) {
            if (tbPassword.Text.Length != 0) {
                tbPassword.Text = string.Empty;
            }

            if (lbError.Visible == true) {
                lbError.Visible = false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            if (lbError.Visible == true) {
                lbError.Visible = false;
            }
        }

        private void lbCreateNewAccount_MouseHover(object sender, EventArgs e) {
            lbCreateNewAccount.Font = new Font("Calibri", 10.8F, ((FontStyle)(((FontStyle.Bold | FontStyle.Italic) | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbCreateNewAccount_MouseLeave(object sender, EventArgs e) {
            lbCreateNewAccount.Font = new Font("Calibri", 10.8F, ((FontStyle)((FontStyle.Italic | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
        }

        private void Form_Login_VisibleChanged(object sender, EventArgs e) {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbUsername.Select();
            xuiFlatProgressBar_Login.Visible = false;
        }

        private void lbError_VisibleChanged(object sender, EventArgs e) {
            if (lbError.Visible == true) {
                if (lbError.Text == "Username hoặc Password sai!") {
                    tbUsername.Select();
                    pnlUsername.BackColor = Color.Red;
                    lbUsername.ForeColor = Color.Red;
                    pnlPassword.BackColor = Color.Red;
                    lbPassword.ForeColor = Color.Red;
                }
                else if (lbError.Text == "Không được để trống!") {
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
            }
            else {
                if (lbPassword.ForeColor == Color.Red) {
                    tbPassword.Select();
                    pnlPassword.BackColor = Color.DarkGray;
                    lbPassword.ForeColor = Color.DarkGray;
                }
                if (lbUsername.ForeColor == Color.Red) {
                    tbUsername.Select();
                    pnlUsername.BackColor = Color.DarkGray;
                    lbUsername.ForeColor = Color.DarkGray;
                }
            }
        }

        private bool CheckLogin() {
            if (AccountBUS.Instance.Login(tbUsername.Text, tbPassword.Text)) {
                return true;
            }
            else {
                lbError.Text = "Username hoặc Password sai!";
                lbError.Visible = true;
                return false;
            }
        }

        private bool CheckNull() {
            if (tbUsername.Text.Length == 0 || tbPassword.Text.Length == 0) {
                lbError.Text = "Không được để trống!";
                lbError.Visible = true;
                return true;
            }
            return false;
        }
        #endregion
    }
}