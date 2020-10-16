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

            mainSearch.Visible = true;
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

            mainSearch.Visible = false;

            timer_PanelSearch.Start();
            timer_PanelGrammar.Start();
            timer_PanelComboWord.Start();
            timer_PanelFlashcard.Start();

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
                //mainComboWord.Visible = true;
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
        #endregion
        /*private void ReColor()
{
panelSearchbox.Visible = false;
panelListRead.Visible = false;
tableLayoutPanelGrammar.Visible = false;
panelComboWords.Visible = false;
splitcontainerFlashcard.Visible = false;
buttonSearch.BackColor = Color.Orchid;
buttonRead.BackColor = Color.Orchid;
buttonComboWord.BackColor = Color.Orchid;
buttonFlashcard.BackColor = Color.Orchid;
buttonTest.BackColor = Color.Orchid;
buttonGrammar.BackColor = Color.Orchid;
buttonSearch.FlatStyle = FlatStyle.Popup;
buttonRead.FlatStyle = FlatStyle.Popup;
buttonGrammar.FlatStyle = FlatStyle.Popup;
buttonTest.FlatStyle = FlatStyle.Popup;
buttonComboWord.FlatStyle = FlatStyle.Popup;
buttonFlashcard.FlatStyle = FlatStyle.Popup;
}
private void AddBook()
{
listboxRead.Items.Add("Book 1");
listboxRead.Items.Add("Book 2");
listboxRead.Items.Add("Book 3");
listboxRead.Items.Add("Book 4");
listboxRead.Items.Add("Book 5");
listboxRead.Items.Add("Book 6");
listboxRead.Items.Add("Book 7");
listboxRead.Items.Add("Book 8");
listboxRead.Items.Add("Book 9");
listboxRead.Items.Add("Book 10");
listboxRead.Items.Add("Book 11");
listboxRead.Items.Add("Book 12");
listboxRead.Items.Add("Book 13");
listboxRead.Items.Add("Book 14");
listboxRead.Items.Add("Book 15");
listboxRead.Items.Add("Book 16");
}
private void rtbSearch_TextChanged(object sender, EventArgs e)
{
if (rtbSearch.Text.ToString() == "a")
{
isCollapse = true;
timerSearchList.Start();
}
else
{
lsbListSearch.Items.Clear();
isCollapse = false;
timerSearchList.Start();
}
}
private void rtbSearch_Click(object sender, EventArgs e)
{
isCollapse = true;
timerSearchList.Start();
}
private bool isCollapse = true;
private void timerSearchList_Tick(object sender, EventArgs e)
{           
if (isCollapse)
{
panelSearchbox.Height += 10;
if (panelSearchbox.Size == panelSearchbox.MaximumSize)
{
timerSearchList.Stop();
}
}
else
{
panelSearchbox.Height -= 10;
if (panelSearchbox.Size == panelSearchbox.MinimumSize)
{
timerSearchList.Stop();
}
}
}
private void lsbListSearch_Click(object sender, EventArgs e)
{
FormWordInfo wordInfo = new FormWordInfo((TuDienAnhViet.DictionaryData)lsbListSearch.SelectedItem, this);
wordInfo.Show();
}
private void buttonSearch_Click(object sender, EventArgs e)
{
ReColor();
panelSearchbox.Show();
buttonSearch.BackColor = Color.FromArgb(250, 167, 228);
buttonSearch.FlatStyle = FlatStyle.Flat;
}
private void buttonRead_Click(object sender, EventArgs e)
{
ReColor();
panelListRead.Show();
buttonRead.BackColor = Color.FromArgb(250, 167, 228);
buttonRead.FlatStyle = FlatStyle.Flat;
}
private void buttonGrammar_Click(object sender, EventArgs e)
{
ReColor();
tableLayoutPanelGrammar.Show();
buttonGrammar.BackColor = Color.FromArgb(250, 167, 228);
buttonGrammar.FlatStyle = FlatStyle.Flat;
}
private void buttonComboWord_Click(object sender, EventArgs e)
{
ReColor();
panelComboWords.Show();
buttonComboWord.BackColor = Color.FromArgb(250, 167, 228);
buttonComboWord.FlatStyle = FlatStyle.Flat;
}
private void tableLayoutPanelGrammar_Paint(object sender, PaintEventArgs e)
{

}
private void buttonFlashcard_Click(object sender, EventArgs e)
{
ReColor();
splitcontainerFlashcard.Show();
buttonFlashcard.BackColor = Color.FromArgb(250, 167, 228);
buttonFlashcard.FlatStyle = FlatStyle.Flat;
}*/
    }
}
