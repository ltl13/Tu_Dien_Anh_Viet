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
using MetroFramework.Controls;

namespace GUI {
    public partial class UserControl_Search : UserControl {
        #region properties
        private readonly DataTable dataTable = new DataTable();
        private readonly DataTable dataTable1 = new DataTable();
        public UserControl_WordInfo wordInfo;
        public bool isWordInfoOn = false;
        Timer _typingTimer;

        public Form_Main Father { get; }

        public UserControl_Search(Form_Main formMain) {
            InitializeComponent();

            this.Father = formMain;
            this.dataTable = DictionaryBUS.Instance.GetEnViTable();
            this.dataTable1 = DictionaryBUS.Instance.GetViEnTable();

            listBox_Search.DataSource = dataTable;
            listBox_Search.Visible = false;
        }
        #endregion

        #region method
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e) {
            if (_typingTimer == null) {
                _typingTimer = new Timer();
                _typingTimer.Interval = 300;
                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop();
            _typingTimer.Tag = (sender as MetroTextBox).Text;
            _typingTimer.Start();
        }

        private void handleTypingTimerTimeout(object sender, EventArgs e) {
            var timer = sender as Timer;
            if (timer == null) {
                return;
            }

            var isbn = timer.Tag.ToString();
            metroTextBox_Searchbar.Text = isbn;
            timer.Stop();

            if (metroTextBox_Searchbar.Text != string.Empty) {
                if (Father.IsEnToVi) {
                    Regex regex = new Regex(@"^[a-zA-Z0-9-.]*$");

                    if (!regex.IsMatch(metroTextBox_Searchbar.Text)) {
                        metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Red;
                        metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
                        listBox_Search.Visible = false;
                    }
                    else {

                        metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
                        metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
                        dataTable.DefaultView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                        var visibleDataTable = dataTable.DefaultView.ToTable().AsEnumerable().Take(12);

                        if (visibleDataTable.Count() > 0) {
                            listBox_Search.DataSource = visibleDataTable.CopyToDataTable();
                            listBox_Search.DisplayMember = "English";
                        }
                        else {
                            listBox_Search.DataSource = null;
                        }

                        listBox_Search.Visible = true;
                    }
                }
                else {
                    metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
                    metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
                    dataTable1.DefaultView.RowFilter = string.Format("VietNamese Like '{0}%'", metroTextBox_Searchbar.Text);
                    var visibleDataTable = dataTable1.DefaultView.ToTable().AsEnumerable().Take(12);

                    if (visibleDataTable.Count() > 0) {
                        listBox_Search.DataSource = visibleDataTable.CopyToDataTable();
                        listBox_Search.DisplayMember = "VietNamese";
                    }
                    else if (visibleDataTable.Count() == 0) {
                        dataTable1.DefaultView.RowFilter = string.Format("No_Accents_Mark_VietNamese Like '{0}%'", metroTextBox_Searchbar.Text);
                        visibleDataTable = dataTable1.DefaultView.ToTable().AsEnumerable().Take(12);
                        if (visibleDataTable.Count() > 0) {
                            listBox_Search.DataSource = visibleDataTable.CopyToDataTable();
                            listBox_Search.DisplayMember = "VietNamese";
                        }
                        else {
                            listBox_Search.DataSource = null;
                        }
                    }
                    else {
                        listBox_Search.DataSource = null;
                    }

                    listBox_Search.Visible = true;
                }
            }
            else {
                metroTextBox_Searchbar.Style = MetroFramework.MetroColorStyle.Blue;
                metroTextBox_Searchbar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
                listBox_Search.Visible = false;
            }
        }

        private void listBox_Search_Click(object sender, EventArgs e) {
            if (Father.IsEnToVi) {
                isWordInfoOn = true;
                DataRowView row = (DataRowView)listBox_Search.SelectedItem;
                EnViDTO wordSelected = new EnViDTO(row);
                wordInfo = new UserControl_WordInfo(wordSelected, this);
                Father.panel_Main.Controls.Add(wordInfo);
                wordInfo.Show();
                this.Hide();
            }
            else {
                isWordInfoOn = true;
                DataRowView row = (DataRowView)listBox_Search.SelectedItem;
                ViEnDTO wordSelected = new ViEnDTO(row);
                wordInfo = new UserControl_WordInfo(wordSelected, this);
                Father.panel_Main.Controls.Add(wordInfo);
                wordInfo.Show();
                this.Hide();
            }
        }

        private void UserControl_Search_VisibleChanged(object sender, EventArgs e) {
            listBox_Search.Visible = false;
            metroTextBox_Searchbar.Text = "";
        }

        #endregion
    }
}