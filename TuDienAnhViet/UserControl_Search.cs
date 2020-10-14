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
        private bool checkLoadCombobox = false;
        Form_Main father;
        DictionaryManager dictionary;
        public UserControl_Search(Form_Main formMain)
        {
            InitializeComponent();
            father = formMain;          
        }
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e)
        {
            comboBox_Search.Text = metroTextBox_Searchbar.Text;
            if (metroTextBox_Searchbar.Text.ToString() != "")
            {
                comboBox_Search.DroppedDown = true;
            }
        }
        public void InitCombobox()
        {
            comboBox_Search.DisplayMember = "English";
            dictionary = new DictionaryManager();
            dictionary.LoadDataToComboBox(comboBox_Search);
            checkLoadCombobox = true;
        }
    }
}
