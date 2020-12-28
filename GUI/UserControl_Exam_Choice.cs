using System;
using System.Data;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam_Choice : UserControl {
        private UserControl_Exam father;
        private DataSet dataSet;

        public UserControl_Exam_Choice(UserControl_Exam userControl_Exam) {
            InitializeComponent();
            father = userControl_Exam;
        }

        private void UserControl_Exam_Choice_Load(object sender, EventArgs e) {
            if (father.Choice == 1) {
                foreach (string path in System.IO.Directory.GetFiles(@"..\..\..\resources\vocabulary", "*.json")) {
                    if (!path.Contains("Irregular Verb")) {
                        comboBox_Main.Items.Add(System.IO.Path.GetFileNameWithoutExtension(path));
                    }
                }
                comboBox_Main.SelectedIndex = 0;
            }
            else if (father.Choice == 2) {
                metroTextBox_Number.WaterMark = "less than " + father.Father.Favorite.Count.ToString();
                comboBox_Main.Visible = false;
                comboBox_Branch.Visible = false;
                label_Combo.Visible = false;
            }
        }

        private void xuiButton_Start_Click(object sender, EventArgs e) {
            if (xuiButton_Start.Enabled == true) {
                if (!(string.IsNullOrEmpty(metroTextBox_Time.Text) || string.IsNullOrEmpty(metroTextBox_Number.Text))) {
                    father.CountDown = Int32.Parse(metroTextBox_Time.Text);
                    father.NumbersOfQuestion = Int32.Parse(metroTextBox_Number.Text);

                    if (father.Choice == 1) {
                        father.DataTable = this.dataSet.Tables[comboBox_Branch.SelectedIndex];
                    }
                    else if (father.Choice == 2) {
                        father.DataTable = BUS.DictionaryBUS.Instance.ToDataTable<DTO.EnViDTO>(father.Father.Favorite);
                    }

                    father.Father.panel_Main.Controls.Remove(this);
                    father.ExamDo = new UserControl_Exam_Do(father);
                    father.Father.panel_Main.Controls.Add(father.ExamDo);
                    father.ExamDo.BringToFront();
                    this.Dispose();
                }
            }
        }

        private void comboBox_Main_SelectedValueChanged(object sender, EventArgs e) {
            if (father.Choice == 1) {
                comboBox_Branch.Items.Clear();

                dataSet = BUS.DictionaryBUS.Instance.GetVocabulary(comboBox_Main.SelectedItem.ToString());

                for (int i = 0; i < dataSet.Tables.Count; i++) {
                    comboBox_Branch.Items.Add(dataSet.Tables[i].TableName);
                }

                comboBox_Branch.SelectedIndex = 0;
            }
        }

        private void comboBox_Branch_SelectedValueChanged(object sender, EventArgs e) {
            if (father.Choice == 1) {
                metroTextBox_Number.WaterMark = "less than " + dataSet.Tables[comboBox_Branch.SelectedIndex].Rows.Count.ToString();
            }
        }

        private void metroTextBox_Time_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Number_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Number_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");

            if (metroTextBox_Number.Text.Length == 0) {
                if (father.Choice == 1) {
                    metroTextBox_Number.WaterMark = "less than " + dataSet.Tables[comboBox_Branch.SelectedIndex].Rows.Count.ToString();
                }
                else if (father.Choice == 2) {
                    metroTextBox_Number.WaterMark = "less than " + father.Father.Favorite.Count.ToString();
                }

                label_Error.Visible = false;
                return;
            }

            if (!regexItem.IsMatch(metroTextBox_Number.Text)) {
                label_Error.Text = "Chỉ được nhập số!";
                label_Error.Visible = true;
                metroTextBox_Time.Enabled = false;
                return;
            }
            else {
                label_Error.Visible = false;
                metroTextBox_Time.Enabled = true;
            }

            if (father.Choice == 1) {
                if (int.Parse(metroTextBox_Number.Text) > dataSet.Tables[comboBox_Branch.SelectedIndex].Rows.Count) {
                    label_Error.Text = "Số lượng không hợp lệ!";
                    label_Error.Visible = true;
                    return;
                }
            }
            else if (father.Choice == 2) {
                if (int.Parse(metroTextBox_Number.Text) > father.Father.Favorite.Count) {
                    label_Error.Text = "Số lượng không hợp lệ!";
                    label_Error.Visible = true;
                    return;
                }
            }
        }

        private void metroTextBox_Time_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");

            if (metroTextBox_Time.Text.Length == 0) {
                label_Error.Visible = false;
                return;
            }

            if (!regexItem.IsMatch(metroTextBox_Time.Text)) {
                metroTextBox_Time.WaterMark = "";
                label_Error.Text = "Chỉ được nhập số!";
                metroTextBox_Number.Enabled = false;
                label_Error.Visible = true;
                return;
            }
            else {
                label_Error.Visible = false;
                metroTextBox_Number.Enabled = true;
            }

            if (int.Parse(metroTextBox_Time.Text) > 100 || int.Parse(metroTextBox_Time.Text) < 1) {
                label_Error.Text = "Thời gian giữa 1s và 100s!";
                label_Error.Visible = true;
                return;
            }
        }

        private void label_Error_VisibleChanged(object sender, EventArgs e) {
            if (label_Error.Visible == true) {
                xuiButton_Start.Enabled = false;
            }
            else {
                xuiButton_Start.Enabled = true;
            }
        }
    }
}
