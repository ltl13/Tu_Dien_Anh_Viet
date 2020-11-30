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
    public partial class UserControl_Exam_Favorite : UserControl
    {
        private UserControl_Exam father;
        private UserControl_Exam_Do doExam;
        private string time;
        private string number;

        public UserControl_Exam_Favorite(UserControl_Exam previous)
        {
            InitializeComponent();
            father = previous;

            metroTextBox_Number.WaterMark = "less than " + father.Father.Favorite.Count.ToString();
        }

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }
        public string Time { get => time; set => time = value; }
        public string Number { get => number; set => number = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e)
        {
            father.Time = Int32.Parse(metroTextBox_Time.Text);
            father.Number = Int32.Parse(metroTextBox_Number.Text);
            doExam = new UserControl_Exam_Do(father, false);
            father.Father.panel_Main.Controls.Add(doExam);
            DoExam.BringToFront();
        }

        private void metroTextBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }

        private void metroTextBox_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { xuiButton_Start_Click(null, null); }
        }
    }
}
