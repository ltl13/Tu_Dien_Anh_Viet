﻿using DTO;
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
        private static UserControl_Grammar mainGrammar;
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
            mainGrammar = new UserControl_Grammar(this);

            panel_Main.Controls.Add(mainSearch);
            panel_Main.Controls.Add(mainFlashcard);
            panel_Main.Controls.Add(mainTranslate);
            panel_Main.Controls.Add(mainComboWord);
            panel_Main.Controls.Add(mainExam);
            panel_Main.Controls.Add(mainGrammar);

            panel_Main.BackColor = Color.FromArgb(199, 233, 255);

            pictureBox_Search_MouseDown(sender, null);

            xuiButton_Account.ButtonText = "Xin chào, " + loginAccount.DisplayName + "!";
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
        bool isPopUp = false;
        private void timer_MenuAccount_Tick(object sender, EventArgs e) {
            if (isPopUp) {
                if (panel_Account.Size == panel_Account.MaximumSize) {
                    timer_MenuAccount.Stop();
                }
                panel_Account.Height += 19;
            }
            else {
                if (panel_Account.Size == panel_Account.MinimumSize) {
                    timer_MenuAccount.Stop();
                }
                panel_Account.Height -= 19;
            }
        }
        private void xuiButton_Account_MouseDown(object sender, EventArgs e) {
            isPopUp = !isPopUp;
            timer_MenuAccount.Start();
        }

        private void panel_Account_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void panel_Account_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_UpdateInfo_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_ResetAccount_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_DeleteAccount_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_ListAccount_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_Logout_MouseEnter(object sender, EventArgs e) {
            isPopUp = true;
            timer_MenuAccount.Start();
        }

        private void xuiButton_Account_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_UpdateInfo_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_ResetAccount_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_DeleteAccount_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_ListAccount_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
        }

        private void xuiButton_Logout_MouseLeave(object sender, EventArgs e) {
            isPopUp = false;
            timer_MenuAccount.Start();
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

        #region Blala
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e) {
            BUS.DictionaryBUS.Instance.SaveFavoriteWord(favorite);
        }

        private void pictureBox_Search_MouseDown(object sender, MouseEventArgs e) {
            ReturnClick(panel_Search);
            mainSearch.Visible = true;
        }

        private void label_Search_MouseDown(object sender, MouseEventArgs e) {
            pictureBox_Search_MouseDown(null, null);
        }

        private void pictureBox_Translate_MouseDown(object sender, MouseEventArgs e) {
            ReturnClick(panel_Translate);
            mainTranslate.Visible = true;
        }

        private void label_Translate_MouseDown(object sender, MouseEventArgs e) {
            pictureBox_Translate_MouseDown(null, null);
        }

        private void pictureBox_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            ReturnClick(panel_ComboWord);
            mainComboWord.Visible = true;
        }

        private void label_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            pictureBox_ComboWord_MouseDown(null, null);
        }

        private void pictureBox_FlashCard_MouseDown(object sender, MouseEventArgs e) {
            ReturnClick(panel_FlashCard);
            mainFlashcard.Visible = true;
        }

        private void label_FlashCard_MouseDown(object sender, MouseEventArgs e) {
            pictureBox_FlashCard_MouseDown(null, null);
        }

        private void pictureBox_Exam_MouseDown(object sender, MouseEventArgs e) {
            ReturnClick(panel_Exam);
            mainExam.Visible = true;
        }

        private void label_Exam_MouseDown(object sender, MouseEventArgs e) {
            pictureBox_Exam_MouseDown(null, null);
        }

        private void pictureBox_Game_MouseDown(object sender, MouseEventArgs e)
        {
            ReturnClick(panel_Game);
            mainGrammar.Visible = true;
        }

        private void label_Game_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_Game_MouseDown(null, null);
        }

        private void ReturnClick(Panel chosenPanel) {
            panel_Search.BackColor = Color.LightCyan;
            panel_FlashCard.BackColor = Color.LightCyan;
            panel_Translate.BackColor = Color.LightCyan;
            panel_Exam.BackColor = Color.LightCyan;
            panel_ComboWord.BackColor = Color.LightCyan;
            panel_Game.BackColor = Color.LightCyan;

            if (mainSearch.isWordInfoOn) { mainSearch.isWordInfoOn = false; mainSearch.wordInfo.Dispose(); }

            mainSearch.Visible = false;
            mainFlashcard.Visible = false;
            mainTranslate.Visible = false;
            mainComboWord.Visible = false;
            mainExam.Visible = false;
            mainGrammar.Visible = false;

            chosenPanel.BackColor = Color.FromArgb(199, 233, 255);
        }

        private void label_Search_MouseEnter(object sender, EventArgs e) {
            if (panel_Search.BackColor != Color.FromArgb(199, 233, 255))
                panel_Search.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_Search_MouseEnter(object sender, EventArgs e) {
            if (panel_Search.BackColor != Color.FromArgb(199, 233, 255))
                panel_Search.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_Search_MouseLeave(object sender, EventArgs e) {
            if (panel_Search.BackColor != Color.FromArgb(199, 233, 255))
                panel_Search.BackColor = Color.LightCyan;
        }

        private void pictureBox_Search_MouseLeave(object sender, EventArgs e) {
            if (panel_Search.BackColor != Color.FromArgb(199, 233, 255))
                panel_Search.BackColor = Color.LightCyan;
        }

        private void label_Translate_MouseEnter(object sender, EventArgs e) {
            if (panel_Translate.BackColor != Color.FromArgb(199, 233, 255))
                panel_Translate.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_Translate_MouseEnter(object sender, EventArgs e) {
            if (panel_Translate.BackColor != Color.FromArgb(199, 233, 255))
                panel_Translate.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_Translate_MouseLeave(object sender, EventArgs e) {
            if (panel_Translate.BackColor != Color.FromArgb(199, 233, 255))
                panel_Translate.BackColor = Color.LightCyan;
        }

        private void pictureBox_Translate_MouseLeave(object sender, EventArgs e) {
            if (panel_Translate.BackColor != Color.FromArgb(199, 233, 255))
                panel_Translate.BackColor = Color.LightCyan;
        }

        private void label_ComboWord_MouseEnter(object sender, EventArgs e) {
            if (panel_ComboWord.BackColor != Color.FromArgb(199, 233, 255))
                panel_ComboWord.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_ComboWord_MouseEnter(object sender, EventArgs e) {
            if (panel_ComboWord.BackColor != Color.FromArgb(199, 233, 255))
                panel_ComboWord.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_ComboWord_MouseLeave(object sender, EventArgs e) {
            if (panel_ComboWord.BackColor != Color.FromArgb(199, 233, 255))
                panel_ComboWord.BackColor = Color.LightCyan;
        }

        private void pictureBox_ComboWord_MouseLeave(object sender, EventArgs e) {
            if (panel_ComboWord.BackColor != Color.FromArgb(199, 233, 255))
                panel_ComboWord.BackColor = Color.LightCyan;
        }

        private void label_FlashCard_MouseEnter(object sender, EventArgs e) {
            if (panel_FlashCard.BackColor != Color.FromArgb(199, 233, 255))
                panel_FlashCard.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_FlashCard_MouseEnter(object sender, EventArgs e) {
            if (panel_FlashCard.BackColor != Color.FromArgb(199, 233, 255))
                panel_FlashCard.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_FlashCard_MouseLeave(object sender, EventArgs e) {
            if (panel_FlashCard.BackColor != Color.FromArgb(199, 233, 255))
                panel_FlashCard.BackColor = Color.LightCyan;
        }

        private void pictureBox_FlashCard_MouseLeave(object sender, EventArgs e) {
            if (panel_FlashCard.BackColor != Color.FromArgb(199, 233, 255))
                panel_FlashCard.BackColor = Color.LightCyan;
        }

        private void label_Exam_MouseEnter(object sender, EventArgs e) {
            if (panel_Exam.BackColor != Color.FromArgb(199, 233, 255))
                panel_Exam.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_Exam_MouseEnter(object sender, EventArgs e) {
            if (panel_Exam.BackColor != Color.FromArgb(199, 233, 255))
                panel_Exam.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_Exam_MouseLeave(object sender, EventArgs e) {
            if (panel_Exam.BackColor != Color.FromArgb(199, 233, 255))
                panel_Exam.BackColor = Color.LightCyan;
        }

        private void pictureBox_Exam_MouseLeave(object sender, EventArgs e) {
            if (panel_Exam.BackColor != Color.FromArgb(199, 233, 255))
                panel_Exam.BackColor = Color.LightCyan;
        }

        private void label_Game_MouseEnter(object sender, EventArgs e) {
            if (panel_Game.BackColor != Color.FromArgb(199, 233, 255))
                panel_Game.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void pictureBox_Game_MouseEnter(object sender, EventArgs e) {
            if (panel_Game.BackColor != Color.FromArgb(199, 233, 255))
                panel_Game.BackColor = Color.FromArgb(174, 205, 205);
        }

        private void label_Game_MouseLeave(object sender, EventArgs e) {
            if (panel_Game.BackColor != Color.FromArgb(199, 233, 255))
                panel_Game.BackColor = Color.LightCyan;
        }

        private void pictureBox_Game_MouseLeave(object sender, EventArgs e) {
            if (panel_Game.BackColor != Color.FromArgb(199, 233, 255))
                panel_Game.BackColor = Color.LightCyan;
        }        
        #endregion
    }
}
