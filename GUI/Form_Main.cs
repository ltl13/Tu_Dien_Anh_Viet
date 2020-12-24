using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Main : MetroFramework.Forms.MetroForm {
        #region properties
        private static UserControl_Search mainSearch;
        private static UserControl_Flashcard mainFlashcard;
        private static UserControl_Translate mainTranslate;
        private static UserControl_ComboWord mainComboWord;
        private static UserControl_Exam mainExam;
        private AccountDTO loginAccount;
        private List<EnViDTO> favorite;
        private List<EnViDTO> recentlyEnVi;
        private List<ViEnDTO> recentlyViEn;
        private Form father;
        private bool isEnToVi = true;

        public AccountDTO LoginAccount { get => loginAccount; set => loginAccount = value; }
        public List<EnViDTO> Favorite { get => favorite; set => favorite = value; }
        public List<EnViDTO> RecentlyEnVi { get => recentlyEnVi; set => recentlyEnVi = value; }
        public List<ViEnDTO> RecentlyViEn { get => recentlyViEn; set => recentlyViEn = value; }

        public Form_Main(AccountDTO loginAccount, Form login) {
            InitializeComponent();

            this.FocusMe();
            this.loginAccount = loginAccount;
            this.favorite = BUS.DictionaryBUS.Instance.LoadSavedFavoriteWord();
            this.recentlyEnVi = BUS.DictionaryBUS.Instance.LoadRecentlyWordEnVi();
            this.recentlyViEn = BUS.DictionaryBUS.Instance.LoadRecentlyWordViEn();
            this.father = login;
            this.StyleManager = metroStyleManager_FormMain;
        }
        #endregion
        private void Form_Main_Load(object sender, EventArgs e) {
            mainSearch = new UserControl_Search(this);
            mainFlashcard = new UserControl_Flashcard(this);
            mainTranslate = new UserControl_Translate(this);
            mainComboWord = new UserControl_ComboWord();
            mainExam = new UserControl_Exam(this);

            panel_Main.Controls.Add(mainSearch);
            panel_Main.Controls.Add(mainFlashcard);
            panel_Main.Controls.Add(mainTranslate);
            panel_Main.Controls.Add(mainComboWord);
            panel_Main.Controls.Add(mainExam);

            pictureBox_Search_MouseDown(sender, null);

            this.CancelButton = button_Exit;
        }

        #region ButtonExit
        private void button_Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void button_Exit_MouseEnter(object sender, EventArgs e) {
            button_Exit.BackColor = Color.Red;
            button_Exit.ForeColor = Color.White;
        }
        private void button_Exit_MouseLeave(object sender, EventArgs e) {
            button_Exit.BackColor = Color.White;
            button_Exit.ForeColor = Color.Black;
        }
        #endregion

        #region MenuAccount
        private bool isButtonAccountClick = false;
        private void timer_MenuAccount_Tick(object sender, EventArgs e) {
            if (isButtonAccountClick) {
                panel_Account.Height += 20;
                if (panel_Account.Size == panel_Account.MaximumSize) { timer_MenuAccount.Stop(); }
            }
            else {
                panel_Account.Height -= 20;
                if (panel_Account.Size == panel_Account.MinimumSize) { timer_MenuAccount.Stop(); }
            }
        }
        private void xuiButton_Account_Click(object sender, EventArgs e) {
            xuiButton_Account_MouseEnter(null, null);
            isButtonAccountClick = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_Account_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account.BackgroundColor = Color.FromArgb(199, 233, 255);
            xuiButton_Account.TextColor = Color.Black;
        }

        private void xuiButton_Account_MouseLeave(object sender, EventArgs e) {
            if (!isButtonAccountClick) {
                xuiButton_Account.BackgroundColor = Color.White;
                xuiButton_Account.TextColor = Color.White;
            }
        }

        private void panel_Account_MouseLeave(object sender, EventArgs e) {
            isButtonAccountClick = false;
            timer_MenuAccount.Start();
            xuiButton_Account_MouseLeave(null, null);
        }

        private void xuiButton_UpdateInfo_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account_Click(null, null);
        }

        private void xuiButton_ResetAccount_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account_Click(null, null);
        }

        private void xuiButton_DeleteAccount_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account_Click(null, null);
        }

        private void xuiButton_ListAccount_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account_Click(null, null);
        }

        private void xuiButton_FindUser_MouseEnter(object sender, EventArgs e) {
            xuiButton_Account_Click(null, null);
        }

        private void xuiButton_Logout_MouseClick(object sender, MouseEventArgs e) {
            father.Show();
            this.Close();
        }
        #endregion

        #region ButtonSwitchLanguage
        public bool IsEnToVi {
            get { return isEnToVi; }
            set { isEnToVi = value; }
        }

        private void changeLanguage(bool EnToVi) {
            if (EnToVi) { mainTranslate.xuiButton_Translate.ButtonText = "Translate"; }
            else { mainTranslate.xuiButton_Translate.ButtonText = "Dịch"; }
        }

        private void xuiSwitch_Language_MouseDown(object sender, MouseEventArgs e) {
            isEnToVi = !isEnToVi;
            changeLanguage(IsEnToVi);
        }
        #endregion

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e) {
            BUS.DictionaryBUS.Instance.SaveFavoriteWord(favorite);
        }

        private void pictureBox_Search_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Search.BackColor.ToArgb());
            ReturnClick();
            mainSearch.Visible = true;
        }

        private void label_Search_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Search.BackColor.ToArgb());
            ReturnClick();
            mainSearch.Visible = true;
        }

        private void pictureBox_Translate_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Translate.BackColor.ToArgb());
            ReturnClick();
            mainTranslate.Visible = true;
        }

        private void label_Translate_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Translate.BackColor.ToArgb());
            ReturnClick();
            mainTranslate.Visible = true;
        }

        private void pictureBox_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_ComboWord.BackColor.ToArgb());
            ReturnClick();
            mainComboWord.Visible = true;
        }

        private void label_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_ComboWord.BackColor.ToArgb());
            ReturnClick();
            mainComboWord.Visible = true;
        }

        private void pictureBox_FlashCard_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_FlashCard.BackColor.ToArgb());
            ReturnClick();
            mainFlashcard.Visible = true;
        }

        private void label_FlashCard_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_FlashCard.BackColor.ToArgb());
            ReturnClick();
            mainFlashcard.Visible = true;
        }

        private void pictureBox_Exam_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Exam.BackColor.ToArgb());
            ReturnClick();
            mainExam.Visible = true;
        }

        private void label_Exam_MouseDown(object sender, MouseEventArgs e) {
            panel_Main.BackColor = Color.FromArgb(panel_Exam.BackColor.ToArgb());
            ReturnClick();
            mainExam.Visible = true;
        }

        private void ReturnClick() {
            if (mainSearch.isWordInfoOn) { mainSearch.isWordInfoOn = false; mainSearch.wordInfo.Dispose(); }

            mainSearch.Visible = false;
            mainFlashcard.Visible = false;
            mainTranslate.Visible = false;
            mainComboWord.Visible = false;
            mainExam.Visible = false;
        }
    }
}
