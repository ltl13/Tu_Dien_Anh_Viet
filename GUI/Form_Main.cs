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

namespace GUI
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        private UserControl mainSearch;

        public Form_Main()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager_FormMain;
            UserControl_Search search = new UserControl_Search(this);
            mainSearch = search;

            panel_Main.Controls.Add(mainSearch);

            pictureBox_Search_Click(null, null);
        }
        #region ButtonExit
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.Red;
            button_Exit.ForeColor = Color.White;
        }
        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.White;
            button_Exit.ForeColor = Color.Black;
        }
        #endregion

        private void timer_MainPanel_Tick(object sender, EventArgs e)
        {
            panel_Main.Width += 45;
            if (panel_Main.Size == panel_Main.MaximumSize) { timer_MainPanel.Stop(); }
        }

        private void ReturnClick(Panel selected)
        {
            isSearchClick = false;
            isGrammarClick = false;
            isComboWordClick = false;
            isFlashcardClick = false;
            isReadClick = false;
            isExamClick = false;

            mainSearch.Visible = false;

            timer_PanelSearch.Start();
            timer_PanelGrammar.Start();
            timer_PanelComboWord.Start();
            timer_PanelFlashcard.Start();
            timer_PanelRead.Start();
            timer_PanelExam.Start();

            selected.Size = selected.MaximumSize;
        }

        #region PanelSearch
        private bool isMouseEnter_PanelSearch = false;
        private bool isSearchClick = false;
        private void pictureBox_Search_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelSearch = true;
            timer_PanelSearch.Start();
        }
        private void pictureBox_Search_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelSearch = false;
            timer_PanelSearch.Start();
        }
        private void timer_PanelSearch_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelSearch)
            {
                panel_Search.Width += 10;
                if (panel_Search.Size == panel_Search.MaximumSize) { timer_PanelSearch.Stop(); }
            }
            else
            {
                if (!isSearchClick)
                {
                    panel_Search.Width -= 10;
                    if (panel_Search.Size == panel_Search.MinimumSize) { timer_PanelSearch.Stop(); }
                }
                else { timer_PanelSearch.Stop(); }
            }
        }
        private void pictureBox_Search_Click(object sender, EventArgs e)
        {           
            if (!isSearchClick)
            {
                ReturnClick(panel_Search);
                panel_Main.Size = panel_Main.MinimumSize;
                isSearchClick = true;
                mainSearch.Visible = true;
                panel_Main.BackColor = Color.FromArgb(204, 253, 255);
                timer_MainPanel.Start();
            }
        }
        private void panel_Search_Click(object sender, EventArgs e)
        {
            pictureBox_Search_Click(null, null);
        }
        private void panel_Search_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Search_MouseEnter(null, null);
        }
        private void panel_Search_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Search_MouseLeave(null, null);
        }
        private void label_Search_Click(object sender, EventArgs e)
        {
            pictureBox_Search_Click(null, null);
        }
        private void label_Search_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Search_MouseEnter(null, null);
        }
        #endregion

        #region PanelGrammar
        private bool isMouseEnter_PanelGrammar = false;
        private bool isGrammarClick = false;
        private void pictureBox_Grammar_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelGrammar = true;
            timer_PanelGrammar.Start();
        }
        private void pictureBox_Grammar_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelGrammar = false;
            timer_PanelGrammar.Start();
        }
        private void pictureBox_Grammar_Click(object sender, EventArgs e)
        {
            if (!isGrammarClick)
            {                
                ReturnClick(panel_Grammar);
                panel_Main.Size = panel_Main.MinimumSize;
                isGrammarClick = true;
                //mainGrammar.Visible = true;
                panel_Main.BackColor = Color.FromArgb(253, 255, 209);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelGrammar_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelGrammar)
            {
                panel_Grammar.Width += 10;
                if (panel_Grammar.Size == panel_Grammar.MaximumSize) { timer_PanelGrammar.Stop(); }
            }
            else
            {
                if (!isGrammarClick)
                {
                    panel_Grammar.Width -= 10;
                    if (panel_Grammar.Size == panel_Grammar.MinimumSize) { timer_PanelGrammar.Stop(); }
                }
                else { timer_PanelGrammar.Stop(); }
            }
        }
        private void panel_Grammar_Click(object sender, EventArgs e)
        {
            pictureBox_Grammar_Click(null, null);
        }
        private void panel_Grammar_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Grammar_MouseEnter(null, null);
        }
        private void panel_Grammar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Grammar_MouseLeave(null, null);
        }
        private void label_Grammar_Click(object sender, EventArgs e)
        {
            pictureBox_Grammar_Click(null, null);
        }
        private void label_Grammar_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Grammar_MouseEnter(null, null);
        }
        #endregion

        #region PanelComboWord
        private bool isMouseEnter_PanelComboWord = false;
        private bool isComboWordClick = false;
        private void pictureBox_ComboWord_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelComboWord = true;
            timer_PanelComboWord.Start();
        }
        private void pictureBox_ComboWord_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelComboWord = false;
            timer_PanelComboWord.Start();
        }
        private void pictureBox_ComboWord_Click(object sender, EventArgs e)
        {
            if (!isComboWordClick)
            {
                ReturnClick(panel_ComboWord);
                panel_Main.Size = panel_Main.MinimumSize;
                isComboWordClick = true;
                //mainComboWord.Visible = true;
                panel_Main.BackColor = Color.FromArgb(255, 223, 212);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelComboWord_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelComboWord)
            {
                panel_ComboWord.Width += 10;
                if (panel_ComboWord.Size == panel_ComboWord.MaximumSize) { timer_PanelComboWord.Stop(); }
            }
            else
            {
                if (!isComboWordClick)
                {
                    panel_ComboWord.Width -= 10;
                    if (panel_ComboWord.Size == panel_ComboWord.MinimumSize) { timer_PanelComboWord.Stop(); }
                }
                else { timer_PanelComboWord.Stop(); }
            }
        }
        private void panel_ComboWord_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_ComboWord_MouseEnter(null, null);
        }
        private void panel_ComboWord_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_ComboWord_MouseLeave(null, null);
        }
        private void panel_ComboWord_Click(object sender, EventArgs e)
        {
            pictureBox_ComboWord_Click(null, null);
        }
        private void label_ComboWord_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_ComboWord_MouseEnter(null, null);
        }
        private void label_ComboWord_Click(object sender, EventArgs e)
        {
            pictureBox_ComboWord_Click(null, null);
        }
        #endregion

        #region PanelFlashcards
        private bool isMouseEnter_PanelFlashcard = false;
        private bool isFlashcardClick = false;
        private void pictureBox_Flashcard_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelFlashcard = true;
            timer_PanelFlashcard.Start();
        }
        private void pictureBox_Flashcard_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelFlashcard = false;
            timer_PanelFlashcard.Start();
        }
        private void pictureBox_Flashcard_Click(object sender, EventArgs e)
        {
            if (!isFlashcardClick)
            {
                ReturnClick(panel_Flashcard);
                panel_Main.Size = panel_Main.MinimumSize;
                isFlashcardClick = true;
                //mainFlashcard.Visible = true;
                panel_Main.BackColor = Color.FromArgb(219, 255, 212);
                timer_MainPanel.Start();
            }
        }
        private void timer_PanelFlashcard_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelFlashcard)
            {
                panel_Flashcard.Width += 10;
                if (panel_Flashcard.Size == panel_Flashcard.MaximumSize) { timer_PanelFlashcard.Stop(); }
            }
            else
            {
                if (!isFlashcardClick)
                {
                    panel_Flashcard.Width -= 10;
                    if (panel_Flashcard.Size == panel_Flashcard.MinimumSize) { timer_PanelFlashcard.Stop(); }
                }
                else { timer_PanelFlashcard.Stop(); }
            }
        }
        private void panel_Flashcard_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Flashcard_MouseEnter(null, null);
        }
        private void panel_Flashcard_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Flashcard_MouseLeave(null, null);
        }
        private void label_Flashcard_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Flashcard_MouseEnter(null, null);
        }
        private void panel_Flashcard_Click(object sender, EventArgs e)
        {
            pictureBox_Flashcard_Click(null, null);
        }
        private void label_Flashcard_Click(object sender, EventArgs e)
        {
            pictureBox_Flashcard_Click(null, null);
        }
        #endregion

        #region PanelRead
        private bool isMouseEnter_PanelRead = false;
        private bool isReadClick = false;
        private void timer_PanelRead_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelRead)
            {
                panel_Read.Width += 10;
                if (panel_Read.Size == panel_Read.MaximumSize) { timer_PanelRead.Stop(); }
            }
            else
            {
                if (!isReadClick)
                {
                    panel_Read.Width -= 10;
                    if (panel_Read.Size == panel_Read.MinimumSize) { timer_PanelRead.Stop(); }
                }
                else { timer_PanelRead.Stop(); }
            }
        }
        private void pictureBox_Read_Click(object sender, EventArgs e)
        {
            if (!isReadClick)
            {
                ReturnClick(panel_Read);
                panel_Main.Size = panel_Main.MinimumSize;
                isReadClick = true;
                //mainRead.Visible = true;
                panel_Main.BackColor = Color.FromArgb(226, 219, 255);
                timer_MainPanel.Start();
            }
        }
        private void pictureBox_Read_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelRead = true;
            timer_PanelRead.Start();
        }
        private void pictureBox_Read_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelRead = false;
            timer_PanelRead.Start();
        }
        private void panel_Read_Click(object sender, EventArgs e)
        {
            pictureBox_Read_Click(null, null);
        }
        private void panel_Read_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Read_MouseEnter(null, null);
        }
        private void panel_Read_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Read_MouseLeave(null, null);
        }
        private void label_Read_Click(object sender, EventArgs e)
        {
            pictureBox_Read_Click(null, null);
        }
        private void label_Read_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Read_MouseEnter(null, null);
        }
        #endregion

        #region PanelExam
        private bool isMouseEnter_PanelExam = false;
        private bool isExamClick = false;
        private void timer_PanelExam_Tick(object sender, EventArgs e)
        {
            if (isMouseEnter_PanelExam)
            {
                panel_Exam.Width += 10;
                if (panel_Exam.Size == panel_Exam.MaximumSize) { timer_PanelExam.Stop(); }
            }
            else
            {
                if (!isExamClick)
                {
                    panel_Exam.Width -= 10;
                    if (panel_Exam.Size == panel_Exam.MinimumSize) { timer_PanelExam.Stop(); }
                }
                else { timer_PanelExam.Stop(); }
            }
        }
        private void pictureBox_Exam_Click(object sender, EventArgs e)
        {
            if (!isExamClick)
            {
                ReturnClick(panel_Exam);
                panel_Main.Size = panel_Main.MinimumSize;
                isExamClick = true;
                //mainRead.Visible = true;
                panel_Main.BackColor = Color.FromArgb(255, 227, 255);
                timer_MainPanel.Start();
            }
        }
        private void pictureBox_Exam_MouseEnter(object sender, EventArgs e)
        {
            isMouseEnter_PanelExam = true;
            timer_PanelExam.Start();
        }
        private void pictureBox_Exam_MouseLeave(object sender, EventArgs e)
        {
            isMouseEnter_PanelExam = false;
            timer_PanelExam.Start();
        }
        private void panel_Exam_Click(object sender, EventArgs e)
        {
            pictureBox_Exam_Click(null, null);
        }
        private void panel_Exam_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exam_MouseEnter(null, null);
        }
        private void panel_Exam_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exam_MouseLeave(null, null);
        }
        private void label_Exam_Click(object sender, EventArgs e)
        {
            pictureBox_Exam_Click(null, null);
        }
        private void label_Exam_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exam_MouseEnter(null, null);
        }
        #endregion
    }
}
