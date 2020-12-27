using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam_Favorite : UserControl {
        private UserControl_Exam father;
        private UserControl_Exam_Do doExam;
        private string time;
        private string number;

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }
        public string Time { get => time; set => time = value; }
        public string Number { get => number; set => number = value; }
        public UserControl_Exam Father { get => father; set => father = value; }

        public UserControl_Exam_Favorite(UserControl_Exam previous) {
            InitializeComponent();
            Father = previous;

            metroTextBox_Number.WaterMark = "less than " + Father.Father.Favorite.Count.ToString();
        }

        private void xuiButton_Start_Click(object sender, EventArgs e) {
            if (xuiButton_Start.Enabled == true) {
                if (!(string.IsNullOrEmpty(metroTextBox_Time.Text) || string.IsNullOrEmpty(metroTextBox_Number.Text))) {
                    Father.Time = Int32.Parse(metroTextBox_Time.Text);
                    Father.Number = Int32.Parse(metroTextBox_Number.Text);
                    doExam = new UserControl_Exam_Do(Father, false);
                    Father.Father.panel_Main.Controls.Add(doExam);
                    DoExam.BringToFront();
                }
            }
        }

        private void metroTextBox_Number_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Time_KeyPress(object sender, KeyPressEventArgs e) {
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

            if (int.Parse(metroTextBox_Number.Text) > Father.Father.Favorite.Count) {
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
