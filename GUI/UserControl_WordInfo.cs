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
        List<EnViDTO> favorite;

        public UserControl_WordInfo(EnViDTO args, UserControl_Search usercontrolSearch, List<EnViDTO> Favorite) {
            InitializeComponent();
            father = usercontrolSearch;
            favorite = Favorite;
            word = args;
            label_Word.Text = word.getEnglishDisplay();
            label_VietNamese.Text = word.VietNamese;
            foreach (var fa in favorite) {
                if (fa.English == word.English) {
                    xuiButton_Interest.Visible = true;
                    xuiButton_NotInterest.Visible = false;
                    break;
                }
            }
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
            var itemToRemove = favorite.SingleOrDefault(r => r.English == word.English);
            if (itemToRemove != null)
                favorite.Remove(itemToRemove);
            DictionaryBUS.Instance.SaveFavoriteWord(favorite);
        }
        private void xuiButton_NotInterest_Click(object sender, EventArgs e)
        {
            xuiButton_Interest.Visible = true;
            xuiButton_NotInterest.Visible = false;
            favorite.Add(word);
            DictionaryBUS.Instance.SaveFavoriteWord(favorite);
            
            //dictionaryBUS.AddFavorite(father.father.LoginAccount, word);
        }
    }
}
