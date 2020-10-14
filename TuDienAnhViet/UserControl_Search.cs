using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class UserControl_Search : UserControl
    {
        private bool isComboBoxLoaded = false;
        DictionaryManager dictionary;
        Form_Main father;
        public UserControl_Search(Form_Main formMain)
        {
            InitializeComponent();
            father = formMain;
            comboBox_Search.DisplayMember = "English";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToComboBox(comboBox_Search);
            isComboBoxLoaded = true;
        }
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e)
        {
            comboBox_Search.Text = metroTextBox_Searchbar.Text;
            if (comboBox_Search.Text == "")
            {
                comboBox_Search.DroppedDown = false;
            }
            else
            {
                comboBox_Search.DroppedDown = true;
            }
        }
        private void comboBox_Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DictionaryData wordSelected = (DictionaryData)comboBox_Search.SelectedItem;
            metroTextBox_Searchbar.Text = wordSelected.English;
            UserControl_WordInfo wordInfo = new UserControl_WordInfo(wordSelected, this);
            father.metroPanel_Main.Controls.Add(wordInfo);
            wordInfo.Show();
            this.Hide();
        }
        /*private void listBox_Search_Click(object sender, EventArgs e)
{
   UserControl_WordInfo wordInfo = new UserControl_WordInfo(comboBox_Search.SelectedItem.ToString(), this);
   father.metroPanel_Main.Controls.Add(wordInfo);
   wordInfo.Show();
   this.Hide();
}*/
    }
}
