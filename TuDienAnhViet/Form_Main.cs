using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        DictionaryManager dictionary;
        UserControl_Search mainPanel;
        public Form_Main()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager_FormMain;
            UserControl_Search search = new UserControl_Search(this);
            mainPanel = search;

            metroPanel_Main.Controls.Add(mainPanel);

            mainPanel.Visible = false;
        }
        private void metroTile_Search_Click(object sender, EventArgs e)
        {
            metroTile_Search.Style = MetroFramework.MetroColorStyle.White;
            mainPanel.Visible = true;
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.Red;
            button_Exit.ForeColor = Color.White;
        }
        private void Form_Main_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.White;
            button_Exit.ForeColor = Color.Black;
        }
        public void ShowWordInfo(DictionaryData word)
        {

        }
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
