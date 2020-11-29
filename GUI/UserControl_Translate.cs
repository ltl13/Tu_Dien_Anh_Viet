using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserControl_Translate : UserControl
    {
        #region properties
        Form_Main father;
        string _translatedText;
        Timer _typingTimer;

        public UserControl_Translate(Form_Main form_Main) {
            InitializeComponent();
            father = form_Main;
        }
        #endregion

        #region method
        private void richTextBox_From_TextChanged(object sender, EventArgs e) {
            if (_typingTimer == null) {
                _typingTimer = new Timer();
                _typingTimer.Interval = 1000;
                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop();
            _typingTimer.Tag = (sender as RichTextBox).Text;
            _typingTimer.Start();
        }

        private void handleTypingTimerTimeout(object sender, EventArgs e) {
            var timer = sender as Timer;
            if (timer == null) {
                return;
            }
            if (richTextBox_From.Text == string.Empty) {
                richTextBox_To.Text = string.Empty;
                return;
            }

            if (father.IsEnToVi) {
                try {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    _translatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", richTextBox_From.Text, "", "vi");
                    richTextBox_To.Text = _translatedText;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                try {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    _translatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", richTextBox_From.Text, "", "en");
                    richTextBox_To.Text = _translatedText;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    #endregion
}
