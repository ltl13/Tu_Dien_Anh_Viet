using BUS;
using DTO;
using SpeechLib;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_WordInfo : UserControl {
        private UserControl_Search father;
        EnViDTO word;
        ViEnDTO word1;

        public UserControl_WordInfo(EnViDTO args, UserControl_Search usercontrolSearch) {
            InitializeComponent();
            father = usercontrolSearch;
            word = args;
            label_Word.Text = word.English;
            rtb_vietnamese.Text = word.getVietNameseFormat();

            foreach (var fa in father.Father.Favorite) {
                if (fa.English == word.English) {
                    xuiButton_Interest.Visible = true;
                    xuiButton_NotInterest.Visible = false;
                    break;
                }
            }
        }

        public UserControl_WordInfo(ViEnDTO args, UserControl_Search usercontrolSearch) {
            InitializeComponent();
            father = usercontrolSearch;
            word1 = args;
            label_Word.Text = word1.VietNamese;
            rtb_vietnamese.Text = word1.getEnglishFormat();
            metroTile_Speaker.Visible = false;
            xuiButton_Interest.Visible = false;
            xuiButton_NotInterest.Visible = false;
        }

        private void UserControl_WordInfo_Load(object sender, EventArgs e) {
            label_Word.Focus();
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

        private void metroTile_Speaker_Click(object sender, EventArgs e) {
            if (father.Father.IsEnToVi) {
                SpVoice speakEnglish = new SpVoice();
                speakEnglish.Speak(word.English, SpeechVoiceSpeakFlags.SVSFDefault);
            }
        }

        private void xuiButton_Interest_Click(object sender, EventArgs e) {
            xuiButton_Interest.Visible = false;
            xuiButton_NotInterest.Visible = true;

            var itemToRemove = father.Father.Favorite.SingleOrDefault(r => r.English == word.English);
            if (itemToRemove != null)
                father.Father.Favorite.Remove(itemToRemove);
            DictionaryBUS.Instance.SaveFavoriteWord(father.Father.Favorite);
        }
        private void xuiButton_NotInterest_Click(object sender, EventArgs e) {
            xuiButton_Interest.Visible = true;
            xuiButton_NotInterest.Visible = false;
            father.Father.Favorite.Add(word);
            DictionaryBUS.Instance.SaveFavoriteWord(father.Father.Favorite);
        }
    }
}
