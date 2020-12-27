using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam : UserControl {
        private Form_Main father;
        private UserControl_Exam_Choice examCombo;
        private UserControl_Exam_Do examDo;

        private int numbersOfQuestion;
        private int countDown;
        private int choice;

        private DataTable dataTable;

        public Form_Main Father { get => father; }
        public UserControl_Exam_Do ExamDo { get => examDo; set => examDo = value; }
        public int NumbersOfQuestion { get => numbersOfQuestion; set => numbersOfQuestion = value; }
        public int CountDown { get => countDown; set => countDown = value; }
        public int Choice { get => choice; }
        public DataTable DataTable { get => dataTable; set => dataTable = value; }

        public UserControl_Exam(Form_Main main) {
            InitializeComponent();
            this.father = main;
        }

        private void metroTile_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            this.choice = 1;
            examCombo = new UserControl_Exam_Choice(this);
            father.panel_Main.Controls.Add(examCombo);
            examCombo.BringToFront();
        }

        private void metroTile_Favorite_MouseDown(object sender, MouseEventArgs e) {
            this.choice = 2;
            examCombo = new UserControl_Exam_Choice(this);
            father.panel_Main.Controls.Add(examCombo);
            examCombo.BringToFront();
        }

        private void pictureBox_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            metroTile_ComboWord_MouseDown(null, null);
        }

        private void label_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            metroTile_ComboWord_MouseDown(null, null);
        }

        private void UserControl_Exam_VisibleChanged(object sender, EventArgs e) {
            if (Father.Favorite.Count < 10) {
                metroTile_Favorite.Enabled = false;
                panel_Lock.Visible = true;

                if (!label_Lock.Text.Contains("\n\nSố từ hiện tại: "))
                    label_Lock.Text += "\n\nSố từ hiện tại: " + Father.Favorite.Count.ToString();
            }
            else {
                metroTile_Favorite.Enabled = true;
                panel_Lock.Visible = false;
            }

            if (examCombo != null) {
                examCombo.Dispose();
            }

            if (examDo != null) {
                examDo.Dispose();
            }
        }

        private void label_Favorite_MouseDown(object sender, MouseEventArgs e) {
            metroTile_Favorite_MouseDown(null, null);
        }

        private void pictureBox_Favorite_MouseDown(object sender, MouseEventArgs e) {
            metroTile_Favorite_MouseDown(null, null);
        }
    }
}
