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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class UserControl_Search : UserControl
    {
        #region properties
        private bool isListBoxLoaded = false;
        private Form_Main father;
        private DataTable dataTable = new DataTable();
        public UserControl_WordInfo wordInfo;
        public bool isWordInfoOn = false;

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
            try
            {
                if (metroTextBox_Searchbar.Text != string.Empty)
                {
                    dataTable.DefaultView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                    listBox_Search.DataSource = dataTable;
                    listBox_Search.Visible = true;
                    Regex regex = new Regex(@"^[a-zA-Z0-9-]*$");

                    if (!regex.IsMatch(metroTextBox_Searchbar.Text))
                    {
                        throw new FormatException();
                        
                    }
                    else
                    {
                        //metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
                        metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
                        dataTable.DefaultView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                        listBox_Search.DataSource = dataTable;
                        listBox_Search.Visible = true;
                    }
                }
                else { listBox_Search.Visible = false; }
            }
            catch (FormatException)
            {
                metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Red;
                metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
                listBox_Search.Visible = false;
            }
        }

        private void listBox_Search_Click(object sender, EventArgs e) {
            isWordInfoOn = true;
            DataRowView row = (DataRowView)listBox_Search.SelectedItem;
            EnViDTO wordSelected = new EnViDTO(row);
            wordInfo = new UserControl_WordInfo(wordSelected, this);
            Father.panel_Main.Controls.Add(wordInfo);
            wordInfo.Show();
            this.Hide();
        }

        private void UserControl_Search_VisibleChanged(object sender, EventArgs e)
        {
            listBox_Search.Visible = false;
            metroTextBox_Searchbar.Text = "";
        }

        #endregion

        
    }
}
