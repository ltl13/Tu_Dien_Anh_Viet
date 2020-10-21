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
using SpeechLib;
using BUS;

namespace GUI
{
    public partial class UserControl_WordInfo : UserControl {
        private UserControl_Search father;
        EnViDTO word;

        public UserControl_WordInfo(EnViDTO args, UserControl_Search usercontrolSearch) {
            InitializeComponent();
            father = usercontrolSearch;
            word = args;
            label_Word.Text = word.getEnglishDisplay();
            label_VietNamese.Text = word.VietNamese;
        }

        private void metroTile_Back_Click(object sender, EventArgs e) {
            father.Show();
            this.Dispose();
        }

        private void metroTile_Back_MouseEnter(object sender, EventArgs e) {
            metroTile_Back.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void metroTile_Back_MouseLeave(object sender, EventArgs e) {
            metroTile_Back.Style = MetroFramework.MetroColorStyle.White;
        }

        private void metroTile_Speaker_Click(object sender, EventArgs e)
        {
            SpVoice speakEnglish = new SpVoice();
            speakEnglish.Speak(label_Word.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void xuiButton_Interest_Click(object sender, EventArgs e)
        {
            xuiButton_Interest.Visible = false;
            xuiButton_NotInterest.Visible = true;
            
        }
        private void xuiButton_NotInterest_Click(object sender, EventArgs e)
        {
            xuiButton_Interest.Visible = true;
            xuiButton_NotInterest.Visible = false;
            DictionaryBUS dictionaryBUS = new DictionaryBUS();
            dictionaryBUS.AddFavorite(father.father.LoginAccount, word);
        }
    }
}
