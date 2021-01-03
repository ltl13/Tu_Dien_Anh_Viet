using BUS;
using DTO;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Search : UserControl {
        #region properties
        private readonly DataTable dataTableEnVi = new DataTable();
        private readonly DataTable dataTableViEn = new DataTable();
        public UserControl_WordInfo wordInfo;
        public bool isWordInfoOn = false;
        Timer _typingTimer;
        Form_Main father;

        public Form_Main Father { get => father; set => father = value; }

        public UserControl_Search(Form_Main formMain) {
            InitializeComponent();

            this.father = formMain;
            this.dataTableEnVi = DictionaryBUS.Instance.GetEnVi();
            this.dataTableViEn = DictionaryBUS.Instance.GetViEn();

            listBox_Search.DataSource = dataTableEnVi;
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
            _typingTimer.Tag = (sender as MetroFramework.Controls.MetroTextBox).Text;
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
                if (father.IsEnToVi) {
                    Regex regex = new Regex(@"^[a-zA-Z0-9-.]*$");

                    if (!regex.IsMatch(metroTextBox_Searchbar.Text)) {
                        listBox_Search.Visible = false;
                        label_Error.Text = "Kí tự không hợp lệ";
                        label_Error.Visible = true;
                    }
                    else {
                        label_Error.Visible = false;
                        dataTableEnVi.DefaultView.RowFilter = string.Format("English Like '{0}%'", metroTextBox_Searchbar.Text);
                        var visibleDataTable = dataTableEnVi.DefaultView.ToTable().AsEnumerable().Take(15);

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
                    Regex regex = new Regex(@"^[a-zA-Z0-9-\p{L}-\s]*$");

                    if (!regex.IsMatch(metroTextBox_Searchbar.Text)) {
                        listBox_Search.Visible = false;
                        label_Error.Text = "Kí tự không hợp lệ";
                        label_Error.Visible = true;
                    }
                    else {
                        label_Error.Visible = false;
                        dataTableViEn.DefaultView.RowFilter = string.Format("VietNamese Like '{0}%'", metroTextBox_Searchbar.Text);
                        var visibleDataTable = dataTableViEn.DefaultView.ToTable().AsEnumerable().Take(15);

                        if (visibleDataTable.Count() > 0) {
                            listBox_Search.DataSource = visibleDataTable.CopyToDataTable();
                            listBox_Search.DisplayMember = "VietNamese";
                        }
                        else if (visibleDataTable.Count() == 0) {
                            dataTableViEn.DefaultView.RowFilter = string.Format("No_Accents_Mark_VietNamese Like '{0}%'", metroTextBox_Searchbar.Text);
                            visibleDataTable = dataTableViEn.DefaultView.ToTable().AsEnumerable().Take(15);
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
            }
            else {
                if (father.IsEnToVi) {
                    listBox_Search.DataSource = father.RecentlyEnVi;
                    listBox_Search.DisplayMember = "English";
                    listBox_Search.Visible = true;
                }
                else {
                    listBox_Search.DataSource = father.RecentlyViEn;
                    listBox_Search.DisplayMember = "Vietnamese";
                    listBox_Search.Visible = true;
                }
            }
        }

        private void listBox_Search_Click(object sender, EventArgs e) {
            if (metroTextBox_Searchbar.Text == string.Empty) {
                if (father.IsEnToVi) {
                    isWordInfoOn = true;
                    EnViDTO wordSelected = (EnViDTO)listBox_Search.SelectedItem;
                    wordInfo = new UserControl_WordInfo(wordSelected, this);
                    father.panel_Main.Controls.Add(wordInfo);
                    wordInfo.Show();
                    this.Hide();
                }
                else {
                    isWordInfoOn = true;
                    ViEnDTO wordSelected = (ViEnDTO)listBox_Search.SelectedItem;
                    wordInfo = new UserControl_WordInfo(wordSelected, this);
                    father.panel_Main.Controls.Add(wordInfo);
                    wordInfo.Show();
                    this.Hide();
                }
            }
            else {
                if (father.IsEnToVi) {
                    isWordInfoOn = true;
                    DataRowView row = (DataRowView)listBox_Search.SelectedItem;
                    EnViDTO wordSelected = new EnViDTO(row);

                    if (!father.RecentlyEnVi.Contains(wordSelected)) {
                        if (father.RecentlyEnVi.Count == 15) {
                            father.RecentlyEnVi.RemoveAt(14);
                        }
                        father.RecentlyEnVi.Insert(0, wordSelected);
                    }
                    else {
                        father.RecentlyEnVi.RemoveAt(father.RecentlyEnVi.IndexOf(wordSelected));
                        father.RecentlyEnVi.Insert(0, wordSelected);
                    }

                    wordInfo = new UserControl_WordInfo(wordSelected, this);
                    father.panel_Main.Controls.Add(wordInfo);
                    wordInfo.Show();
                    this.Hide();
                }
                else {
                    isWordInfoOn = true;
                    DataRowView row = (DataRowView)listBox_Search.SelectedItem;
                    ViEnDTO wordSelected = new ViEnDTO(row);

                    if (!father.RecentlyViEn.Contains(wordSelected)) {
                        if (father.RecentlyViEn.Count == 15) {
                            father.RecentlyViEn.RemoveAt(14);
                        }
                        father.RecentlyViEn.Insert(0, wordSelected);
                    }
                    else {
                        father.RecentlyViEn.RemoveAt(father.RecentlyViEn.IndexOf(wordSelected));
                        father.RecentlyViEn.Insert(0, wordSelected);
                    }

                    wordInfo = new UserControl_WordInfo(wordSelected, this);
                    father.panel_Main.Controls.Add(wordInfo);
                    wordInfo.Show();
                    this.Hide();
                }
            }
        }

        private void UserControl_Search_VisibleChanged(object sender, EventArgs e) {
            listBox_Search.Visible = false;
            metroTextBox_Searchbar.Text = "";
        }

        private void metroTextBox_Searchbar_Enter(object sender, EventArgs e) {
            if (metroTextBox_Searchbar.Text == string.Empty) {
                if (father.IsEnToVi) {
                    listBox_Search.DataSource = father.RecentlyEnVi;
                    listBox_Search.DisplayMember = "English";
                    listBox_Search.Visible = true;
                }
                else {
                    listBox_Search.DataSource = father.RecentlyViEn;
                    listBox_Search.DisplayMember = "Vietnamese";
                    listBox_Search.Visible = true;
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            listBox_Search.Visible = false;
            panel1.Focus();
        }

        private void listBox_Search_KeyDown(object sender, KeyEventArgs e) {
            if (listBox_Search.Visible == true) {
                if (e.KeyCode == Keys.Enter) {
                    listBox_Search_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Up) {
                    this.listBox_Search.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.Down) {
                    this.listBox_Search.SelectedIndex++;
                }
            }
        }

        private void metroTextBox_Searchbar_KeyDown(object sender, KeyEventArgs e) {
            if (listBox_Search.Visible == true) {
                if (e.KeyCode == Keys.Enter) {
                    listBox_Search_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Up) {
                    this.listBox_Search.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.Down) {
                    this.listBox_Search.SelectedIndex++;
                }
            }
        }
        #endregion
    }
}