﻿using DAO;
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
    public partial class Form_Signup : Form {
        public Form_Signup(Form login) {
            InitializeComponent();
            this.AcceptButton = btLogin;
            this.CancelButton = btCancel;
            father = login;
        }
        private Form father;
        private void btCancel_Click(object sender, EventArgs e) {
            father.Show();
            this.Close();
        }

        /* ----- Đăng ký ----- */
        private bool Register(string userName, string displayName, int type, string passWord) {
            return AccountDAO.Instance.Register(userName, displayName, type, passWord);
        }

        private void btLogin_Click(object sender, EventArgs e) {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;
            string confirm = tbConfirm.Text;
            string displayName = tbName.Text;
            int type = 1;

            if (userName.Length == 0 || passWord.Length == 0 || confirm.Length == 0 || displayName.Length == 0) {
                MessageBox.Show("Không được bỏ trống!", "Thông báo");
                return;
            }
            else if (passWord != confirm) {
                tbPassword.Text = string.Empty;
                tbConfirm.Text = string.Empty;
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo");
                return;
            }

<<<<<<< Updated upstream
            if (Register(userName, displayName, type, passWord)) {
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
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
=======
            if (displayName.Length != 0) {
                if (Register(userName, displayName, passWord)) {
                    AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    Form_Main fMain = new Form_Main(loginAccount, father);
                    fMain.Show();
                    this.Close();
                }
                else {
                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
                }
            }
            else {
                if (Register(userName, passWord)) {
                    AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    Form_Main fMain = new Form_Main(loginAccount, father);
                    fMain.Show();
                    this.Close();
                }
                else {
                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
                }
>>>>>>> Stashed changes
            }
        }
        /* ------------------- */

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
    }
}
