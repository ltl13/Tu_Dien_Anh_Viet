using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UserControl_Search : UserControl
    {
        #region properties
        private bool isComboBoxLoaded = false;
        public Form_Main father;
        DataTable dataTable = new DataTable();

        public UserControl_Search(Form_Main formMain)
        {
            InitializeComponent();
            father = formMain;
            comboBox_Search.DisplayMember = "English";
            dataTable = DictionaryBUS.Instance.GetEnViTable();
            isComboBoxLoaded = true;
        }
        #endregion

        #region method
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox_Searchbar.Text != string.Empty) {
                DataTable data = dataTable;
                DataView dataView = new DataView(data);
                dataView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                data = dataView.ToTable();
                comboBox_Search.DataSource = data;
                comboBox_Search.DroppedDown = true;
            }          
        }

        private void comboBox_Search_SelectionChangeCommitted(object sender, EventArgs e) {
            DataRowView row = (DataRowView)comboBox_Search.SelectedItem;
            EnViDTO wordSelected = new EnViDTO(row);
            //metroTextBox_Searchbar.Text = wordSelected.English;
            UserControl_WordInfo wordInfo = new UserControl_WordInfo(wordSelected, this);
            father.panel_Main.Controls.Add(wordInfo);
            wordInfo.Show();
            this.Hide();
        }
        /*private void listBox_Search_Click(object sender, EventArgs e)
{
   
}*/
        #endregion

        private void bt_trans_EngToViet_Click(object sender, EventArgs e)
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
        }
    }
}
