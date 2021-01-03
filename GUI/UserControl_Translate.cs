using System;
using System.Net.NetworkInformation;
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
        private static bool CheckForInternetConnection() {
            try {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception) {
                return false;
            }
        }

        private void xuiButton_Translate_Click(object sender, EventArgs e) {
            if (CheckForInternetConnection()) {
                richTextBox_To.ForeColor = System.Drawing.SystemColors.WindowText;
                if (richTextBox_From.Text == string.Empty) {
                    richTextBox_To.Text = string.Empty;
                    return;
                }

                if (father.IsEnToVi) {
                    try {
                        TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                        client = new TranslatorService.LanguageServiceClient();
                        _translatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F5", richTextBox_From.Text, "", "vi");
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
                        _translatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F5", richTextBox_From.Text, "", "en");
                        richTextBox_To.Text = _translatedText;
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else {
                richTextBox_To.ForeColor = System.Drawing.Color.Red;
                if (father.IsEnToVi) {
                    richTextBox_To.Text = "Bạn cần kết nối internet để sử dụng tính năng này";
                }
                else {
                    richTextBox_To.Text = "You need an internet connection to use this feature";
                }
            }
        }
    }
    #endregion
}
