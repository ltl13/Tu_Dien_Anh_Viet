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
    public partial class FormSearch : Form
    {
        DictionaryManager dictionary;
        public FormSearch()
        {
            InitializeComponent();
            lsbListSearch.DisplayMember = "English";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToListBox(lsbListSearch);
            AddBook();
            panelSearchbox.Visible = true;
            panelListRead.Visible = false;
            tableLayoutPanelGrammar.Visible = false;
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
            FormWordInfo wordInfo = new FormWordInfo(lsbListSearch.SelectedItem.ToString(), this);
            wordInfo.Show();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelSearchbox.Show();
            panelListRead.Hide();
            tableLayoutPanelGrammar.Hide();
        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            panelSearchbox.Hide();
            panelListRead.Show();
            tableLayoutPanelGrammar.Hide();
        }
        private void buttonGrammar_Click(object sender, EventArgs e)
        {
            panelSearchbox.Hide();
            panelListRead.Hide();
            tableLayoutPanelGrammar.Show();
        }
    }
}
