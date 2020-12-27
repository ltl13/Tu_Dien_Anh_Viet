using BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam_Combo : UserControl {
        private UserControl_Exam_Do doExam;
        private UserControl_Exam father;
        private DataSet dataSet;

        public UserControl_Exam_Combo(UserControl_Exam previous) {
            InitializeComponent();
            Father = previous;

            foreach (string path in System.IO.Directory.GetFiles(@"..\..\..\resources\vocabulary", "*.json")) {
                comboBox_Main.Items.Add(System.IO.Path.GetFileNameWithoutExtension(path));
            }

            comboBox_Main.SelectedIndex = 0;
        }

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }
        public UserControl_Exam Father { get => father; set => father = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e) {
            if (xuiButton_Start.Enabled == true) {
                if (!(string.IsNullOrEmpty(metroTextBox_Time.Text) || string.IsNullOrEmpty(metroTextBox_Number.Text))) {
                    father.Time = Int32.Parse(metroTextBox_Time.Text);
                    father.Number = Int32.Parse(metroTextBox_Number.Text);

                    father.Father.panel_Main.Controls.Remove(this);
                    doExam = new UserControl_Exam_Do(father, true);
                    Father.Father.panel_Main.Controls.Add(doExam);
                    DoExam.BringToFront();
                }
            }
        }

        private void comboBox_Main_SelectedValueChanged(object sender, EventArgs e) {
            comboBox_Branch.Items.Clear();

            dataSet = DictionaryBUS.Instance.GetVocabulary(comboBox_Main.SelectedItem.ToString());

            for (int i = 0; i < dataSet.Tables.Count; i++) {
                comboBox_Branch.Items.Add(dataSet.Tables[i].TableName);
            }

            comboBox_Branch.SelectedIndex = 0;
        }

        private void comboBox_Branch_SelectedValueChanged(object sender, EventArgs e) {
            father.listQuestion.Clear();
            father.dt.Clear();

            father.dt = dataSet.Tables[comboBox_Branch.SelectedItem.ToString()];

            metroTextBox_Number.WaterMark = "less than " + father.dt.Rows.Count.ToString();
        }

        private void metroTextBox_Time_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Number_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Number_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex("^[0-9]");

            if (metroTextBox_Number.Text.Length == 0) {
                label_Error.Visible = false;
                return;
            }

            if (!regexItem.IsMatch(metroTextBox_Number.Text)) {
                metroTextBox_Number.WaterMark = "";
                label_Error.Text = "Chỉ được nhập số!";
                label_Error.Visible = true;
                metroTextBox_Time.Enabled = false;
                return;
            }
            else {
                label_Error.Visible = false;
                metroTextBox_Time.Enabled = true;
            }

            if (int.Parse(metroTextBox_Number.Text) > father.dt.Rows.Count) {
                label_Error.Text = "Số lượng không hợp lệ!";
                label_Error.Visible = true;
                return;
            }
        }

        private void metroTextBox_Time_TextChanged(object sender, EventArgs e) {
            System.Text.RegularExpressions.Regex regexItem = new System.Text.RegularExpressions.Regex("^[0-9]");

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

            if (int.Parse(metroTextBox_Time.Text) > 100) {
                label_Error.Text = "Thời gian không quá 100s!";
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
