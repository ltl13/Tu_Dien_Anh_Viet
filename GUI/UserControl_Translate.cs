using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Translate : UserControl {
        #region properties
        Form_Main father;
        string _translatedText;

        public UserControl_Translate(Form_Main form_Main) {
            InitializeComponent();
            father = form_Main;
        }
        #endregion

        #region method
        private void xuiButton_Translate_Click(object sender, EventArgs e) {
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
