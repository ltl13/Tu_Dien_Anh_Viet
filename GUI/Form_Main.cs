using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class Form_Main : MetroFramework.Forms.MetroForm {
        #region properties
        private UserControl_Search mainSearch;
        private UserControl_Flashcard mainFlashcard;
        private UserControl_Translate mainTranslate;
        private UserControl_ComboWord mainComboWord;
        private UserControl_Exam mainExam;
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
            UserControl_Search search = new UserControl_Search(this);
            UserControl_Flashcard flashcard = new UserControl_Flashcard(loginAccount, this);
            UserControl_Translate translate = new UserControl_Translate(this);
            UserControl_ComboWord comboWord = new UserControl_ComboWord();
            UserControl_Exam exam = new UserControl_Exam(this);
            mainSearch = search;
            mainFlashcard = flashcard;
            mainTranslate = translate;
            mainComboWord = comboWord;
            mainExam = exam;

            panel_Main.Controls.Add(mainSearch);
            panel_Main.Controls.Add(mainFlashcard);
            panel_Main.Controls.Add(mainTranslate);
            panel_Main.Controls.Add(mainComboWord);
            panel_Main.Controls.Add(mainExam);

            mainSearch.Visible = true;
            mainFlashcard.Visible = false;
            mainTranslate.Visible = false;
            mainComboWord.Visible = false;
            mainExam.Visible = false;

            pictureBox_Search_Click(null, null);

            this.CancelButton = button_Exit;
        }
        #endregion
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

        private void timer_MainPanel_Tick(object sender, EventArgs e) {
            panel_Main.Width += 45;
            if (panel_Main.Size == panel_Main.MaximumSize) { timer_MainPanel.Stop(); }
        }

        private void ReturnClick(Panel selected) {
            isSearchClick = false;
            isGrammarClick = false;
            isComboWordClick = false;
            isFlashcardClick = false;
            isTranslateClick = false;
            isExamClick = false;

            if (mainSearch.isWordInfoOn) { mainSearch.isWordInfoOn = false; mainSearch.wordInfo.Dispose(); }

            mainSearch.Visible = false;
            mainFlashcard.Visible = false;
            mainTranslate.Visible = false;
            mainComboWord.Visible = false;
            mainExam.Visible = false;

            timer_PanelSearch.Start();
            timer_PanelGrammar.Start();
            timer_PanelComboWord.Start();
            timer_PanelFlashcard.Start();
            timer_PanelTranslate.Start();
            timer_PanelExam.Start();

            selected.Size = selected.MaximumSize;
        }

        #region PanelSearch
        private bool isMouseEnter_PanelSearch = false;
        private bool isSearchClick = false;
        private void pictureBox_Search_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelSearch = true;
            timer_PanelSearch.Start();
        }
        private void pictureBox_Search_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelSearch = false;
            timer_PanelSearch.Start();
        }
        private void timer_PanelSearch_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelSearch) {
                panel_Search.Width += 10;
                if (panel_Search.Size == panel_Search.MaximumSize) { timer_PanelSearch.Stop(); }
            }
            else {
                if (!isSearchClick) {
                    panel_Search.Width -= 10;
                    if (panel_Search.Size == panel_Search.MinimumSize) { timer_PanelSearch.Stop(); }
                }
                else { timer_PanelSearch.Stop(); }
            }
        }
        private void pictureBox_Search_Click(object sender, EventArgs e) {
            if (!isSearchClick) {
                ReturnClick(panel_Search);
                panel_Main.Size = panel_Main.MinimumSize;
                isSearchClick = true;
                mainSearch.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void panel_Search_Click(object sender, EventArgs e) {
            pictureBox_Search_Click(null, null);
        }
        private void panel_Search_MouseEnter(object sender, EventArgs e) {
            pictureBox_Search_MouseEnter(null, null);
        }
        private void panel_Search_MouseLeave(object sender, EventArgs e) {
            pictureBox_Search_MouseLeave(null, null);
        }
        private void label_Search_Click(object sender, EventArgs e) {
            pictureBox_Search_Click(null, null);
        }
        private void label_Search_MouseEnter(object sender, EventArgs e) {
            pictureBox_Search_MouseEnter(null, null);
        }
        #endregion

        #region PanelGrammar
        private bool isMouseEnter_PanelGrammar = false;
        private bool isGrammarClick = false;
        private void pictureBox_Grammar_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelGrammar = true;
            timer_PanelGrammar.Start();
        }
        private void pictureBox_Grammar_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelGrammar = false;
            timer_PanelGrammar.Start();
        }
        private void pictureBox_Grammar_Click(object sender, EventArgs e) {
            if (!isGrammarClick) {
                ReturnClick(panel_Grammar);
                panel_Main.Size = panel_Main.MinimumSize;
                isGrammarClick = true;
                //mainGrammar.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelGrammar_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelGrammar) {
                panel_Grammar.Width += 10;
                if (panel_Grammar.Size == panel_Grammar.MaximumSize) { timer_PanelGrammar.Stop(); }
            }
            else {
                if (!isGrammarClick) {
                    panel_Grammar.Width -= 10;
                    if (panel_Grammar.Size == panel_Grammar.MinimumSize) { timer_PanelGrammar.Stop(); }
                }
                else { timer_PanelGrammar.Stop(); }
            }
        }
        private void panel_Grammar_Click(object sender, EventArgs e) {
            pictureBox_Grammar_Click(null, null);
        }
        private void panel_Grammar_MouseEnter(object sender, EventArgs e) {
            pictureBox_Grammar_MouseEnter(null, null);
        }
        private void panel_Grammar_MouseLeave(object sender, EventArgs e) {
            pictureBox_Grammar_MouseLeave(null, null);
        }
        private void label_Grammar_Click(object sender, EventArgs e) {
            pictureBox_Grammar_Click(null, null);
        }
        private void label_Grammar_MouseEnter(object sender, EventArgs e) {
            pictureBox_Grammar_MouseEnter(null, null);
        }
        #endregion

        #region PanelComboWord
        private bool isMouseEnter_PanelComboWord = false;
        private bool isComboWordClick = false;
        private void pictureBox_ComboWord_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelComboWord = true;
            timer_PanelComboWord.Start();
        }
        private void pictureBox_ComboWord_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelComboWord = false;
            timer_PanelComboWord.Start();
        }
        private void pictureBox_ComboWord_Click(object sender, EventArgs e) {
            if (!isComboWordClick) {
                ReturnClick(panel_ComboWord);
                panel_Main.Size = panel_Main.MinimumSize;
                isComboWordClick = true;
                mainComboWord.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelComboWord_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelComboWord) {
                panel_ComboWord.Width += 10;
                if (panel_ComboWord.Size == panel_ComboWord.MaximumSize) { timer_PanelComboWord.Stop(); }
            }
            else {
                if (!isComboWordClick) {
                    panel_ComboWord.Width -= 10;
                    if (panel_ComboWord.Size == panel_ComboWord.MinimumSize) { timer_PanelComboWord.Stop(); }
                }
                else { timer_PanelComboWord.Stop(); }
            }
        }
        private void panel_ComboWord_MouseEnter(object sender, EventArgs e) {
            pictureBox_ComboWord_MouseEnter(null, null);
        }
        private void panel_ComboWord_MouseLeave(object sender, EventArgs e) {
            pictureBox_ComboWord_MouseLeave(null, null);
        }
        private void panel_ComboWord_Click(object sender, EventArgs e) {
            pictureBox_ComboWord_Click(null, null);
        }
        private void label_ComboWord_MouseEnter(object sender, EventArgs e) {
            pictureBox_ComboWord_MouseEnter(null, null);
        }
        private void label_ComboWord_Click(object sender, EventArgs e) {
            pictureBox_ComboWord_Click(null, null);
        }
        #endregion

        #region PanelFlashcards
        private bool isMouseEnter_PanelFlashcard = false;
        private bool isFlashcardClick = false;
        private void pictureBox_Flashcard_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelFlashcard = true;
            timer_PanelFlashcard.Start();
        }
        private void pictureBox_Flashcard_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelFlashcard = false;
            timer_PanelFlashcard.Start();
        }
        private void pictureBox_Flashcard_Click(object sender, EventArgs e) {
            if (!isFlashcardClick) {
                ReturnClick(panel_Flashcard);
                panel_Main.Size = panel_Main.MinimumSize;
                isFlashcardClick = true;
                mainFlashcard.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelFlashcard_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelFlashcard) {
                panel_Flashcard.Width += 10;
                if (panel_Flashcard.Size == panel_Flashcard.MaximumSize) { timer_PanelFlashcard.Stop(); }
            }
            else {
                if (!isFlashcardClick) {
                    panel_Flashcard.Width -= 10;
                    if (panel_Flashcard.Size == panel_Flashcard.MinimumSize) { timer_PanelFlashcard.Stop(); }
                }
                else { timer_PanelFlashcard.Stop(); }
            }
        }
        private void panel_Flashcard_MouseEnter(object sender, EventArgs e) {
            pictureBox_Flashcard_MouseEnter(null, null);
        }
        private void panel_Flashcard_MouseLeave(object sender, EventArgs e) {
            pictureBox_Flashcard_MouseLeave(null, null);
        }
        private void label_Flashcard_MouseEnter(object sender, EventArgs e) {
            pictureBox_Flashcard_MouseEnter(null, null);
        }
        private void panel_Flashcard_Click(object sender, EventArgs e) {
            pictureBox_Flashcard_Click(null, null);
        }
        private void label_Flashcard_Click(object sender, EventArgs e) {
            pictureBox_Flashcard_Click(null, null);
        }
        #endregion

        #region PanelTranslate
        private bool isMouseEnter_PanelTranslate = false;
        private bool isTranslateClick = false;

        private void timer_PanelTranslate_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelTranslate) {
                panel_Translate.Width += 10;
                if (panel_Translate.Size == panel_Translate.MaximumSize) { timer_PanelTranslate.Stop(); }
            }
            else {
                if (!isTranslateClick) {
                    panel_Translate.Width -= 10;
                    if (panel_Translate.Size == panel_Translate.MinimumSize) { timer_PanelTranslate.Stop(); }
                }
                else { timer_PanelTranslate.Stop(); }
            }
        }
        private void pictureBox_Translate_Click(object sender, EventArgs e) {
            if (!isTranslateClick) {
                ReturnClick(panel_Translate);
                panel_Main.Size = panel_Main.MinimumSize;
                isTranslateClick = true;
                mainTranslate.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void pictureBox_Translate_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelTranslate = true;
            timer_PanelTranslate.Start();
        }
        private void pictureBox_Translate_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelTranslate = false;
            timer_PanelTranslate.Start();
        }
        private void panel_Translate_Click(object sender, EventArgs e) {
            pictureBox_Translate_Click(null, null);
        }
        private void panel_Translate_MouseEnter(object sender, EventArgs e) {
            pictureBox_Translate_MouseEnter(null, null);
        }
        private void panel_Translate_MouseLeave(object sender, EventArgs e) {
            pictureBox_Translate_MouseLeave(null, null);
        }
        private void label_Translate_Click(object sender, EventArgs e) {
            pictureBox_Translate_Click(null, null);
        }
        private void label_Translate_MouseEnter(object sender, EventArgs e) {
            pictureBox_Translate_MouseEnter(null, null);
        }
        #endregion

        #region PanelExam
        private bool isMouseEnter_PanelExam = false;
        private bool isExamClick = false;
        private void timer_PanelExam_Tick(object sender, EventArgs e) {
            if (isMouseEnter_PanelExam) {
                panel_Exam.Width += 10;
                if (panel_Exam.Size == panel_Exam.MaximumSize) { timer_PanelExam.Stop(); }
            }
            else {
                if (!isExamClick) {
                    panel_Exam.Width -= 10;
                    if (panel_Exam.Size == panel_Exam.MinimumSize) { timer_PanelExam.Stop(); }
                }
                else { timer_PanelExam.Stop(); }
            }
        }
        private void pictureBox_Exam_Click(object sender, EventArgs e) {
            if (!isExamClick) {
                ReturnClick(panel_Exam);
                panel_Main.Size = panel_Main.MinimumSize;
                isExamClick = true;
                mainExam.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void pictureBox_Exam_MouseEnter(object sender, EventArgs e) {
            isMouseEnter_PanelExam = true;
            timer_PanelExam.Start();
        }
        private void pictureBox_Exam_MouseLeave(object sender, EventArgs e) {
            isMouseEnter_PanelExam = false;
            timer_PanelExam.Start();
        }
        private void panel_Exam_Click(object sender, EventArgs e) {
            pictureBox_Exam_Click(null, null);
        }
        private void panel_Exam_MouseEnter(object sender, EventArgs e) {
            pictureBox_Exam_MouseEnter(null, null);
        }
        private void panel_Exam_MouseLeave(object sender, EventArgs e) {
            pictureBox_Exam_MouseLeave(null, null);
        }
        private void label_Exam_Click(object sender, EventArgs e) {
            pictureBox_Exam_Click(null, null);
        }
        private void label_Exam_MouseEnter(object sender, EventArgs e) {
            pictureBox_Exam_MouseEnter(null, null);
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
        #endregion

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e) {
            BUS.DictionaryBUS.Instance.SaveFavoriteWord(favorite);
            BUS.DictionaryBUS.Instance.SaveRecentlyWordEnVi(recentlyEnVi);
            BUS.DictionaryBUS.Instance.SaveRecentlyWordViEn(recentlyViEn);
        }

        public bool IsEnToVi {
            get { return isEnToVi; }
            set { isEnToVi = value; }
        }

        private void changeLanguage(bool EnToVi) {
            if (EnToVi) { mainTranslate.xuiButton_Translate.ButtonText = "Translate"; }
            else { mainTranslate.xuiButton_Translate.ButtonText = "Dịch"; }
        }

        private void xuiSwitch_Language_MouseDown(object sender, MouseEventArgs e) {
            xuiSwitch_Language.Focus();
            isEnToVi = !isEnToVi;
            changeLanguage(IsEnToVi);
        }

        private void xuiButton_Logout_MouseClick(object sender, MouseEventArgs e) {
            father.Show();
            this.Close();
        }
    }
}
