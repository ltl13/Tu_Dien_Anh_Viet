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
        Form_Main father;
        public UserControl_Translate(Form_Main form_Main)
        {
            InitializeComponent();
            father = form_Main;
        }

        private void button_Translate_Click(object sender, EventArgs e)
        {
            if (father.IsEnToVi)
            {
                string strTranslatedText = null;
                try
                {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", richTextBox_From.Text, "", "vi");
                    richTextBox_To.Text = strTranslatedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string strTranslatedText = null;
                try
                {
                    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                    client = new TranslatorService.LanguageServiceClient();
                    strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", richTextBox_From.Text, "", "en");
                    richTextBox_To.Text = strTranslatedText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    /*private void bt_trans_EngToViet_Click(object sender, EventArgs e)
        {
            string strTranslatedText = null;
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", tb_sensten.Text, "", "vi");
                tb_translate.Text = strTranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dich_VietToEng_Click(object sender, EventArgs e)
        {
            string strTranslatedText = null;
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", tb_sensten.Text, "", "en");
                tb_translate.Text = strTranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
}
