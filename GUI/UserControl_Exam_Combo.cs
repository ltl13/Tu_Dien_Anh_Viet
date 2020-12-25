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
        }

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }
        public UserControl_Exam Father { get => father; set => father = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e) {
            father.Time = Int32.Parse(metroTextBox_Time.Text);
            father.Number = Int32.Parse(metroTextBox_Number.Text);

            doExam = new UserControl_Exam_Do(father, true);
            Father.Father.panel_Main.Controls.Add(doExam);
            DoExam.BringToFront();
        }

        private void comboBox_Main_SelectedValueChanged(object sender, EventArgs e) {
            comboBox_Branch.Items.Clear();

            dataSet = ComboWordBUS.Instance.GetDataSet(comboBox_Main.SelectedItem.ToString());

            for (int i = 0; i < dataSet.Tables.Count; i++) {
                comboBox_Branch.Items.Add(dataSet.Tables[i].TableName);
            }
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
    }
}
