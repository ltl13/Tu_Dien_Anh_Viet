using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class UserControl_Flashcard : UserControl
    {
        DictionaryBUS dictionaryBUS = new DictionaryBUS();
        public UserControl_Flashcard(AccountDTO account)
        {
            InitializeComponent();
            //textBox_Eng.Text =  dictionaryBUS.GetListFavorite(account).ToString();
        }
    }
}
