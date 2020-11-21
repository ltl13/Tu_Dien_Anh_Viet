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
        private bool isListBoxLoaded = false;
        private Form_Main father;
        private DataTable dataTable = new DataTable();

        public Form_Main Father { get => father; }

        public UserControl_Search(Form_Main formMain)
        {
            InitializeComponent();

            this.father = formMain;
            this.dataTable = DictionaryBUS.Instance.GetEnViTable();

            listBox_Search.DisplayMember = "English";          
            isListBoxLoaded = true;
            listBox_Search.Visible = false;
        }
        #endregion

        #region method
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox_Searchbar.Text != string.Empty) {
                DataTable data = this.dataTable;
                DataView dataView = new DataView(data);
                dataView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                data = dataView.ToTable();
                listBox_Search.DataSource = data;
                listBox_Search.Visible = true;
            }
            else { listBox_Search.Visible = false; }
        }

        private void listBox_Search_Click(object sender, EventArgs e) {
            DataRowView row = (DataRowView)listBox_Search.SelectedItem;
            EnViDTO wordSelected = new EnViDTO(row);
            UserControl_WordInfo wordInfo = new UserControl_WordInfo(wordSelected, this);
            Father.panel_Main.Controls.Add(wordInfo);
            wordInfo.Show();
            this.Hide();
        }
        /*private void listBox_Search_Click(object sender, EventArgs e)
{
   
}*/
        #endregion

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
}
