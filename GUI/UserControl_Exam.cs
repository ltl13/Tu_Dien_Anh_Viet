using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam : UserControl {
        private Form_Main father;
        private UserControl_Exam_Combo examCombo;
        private UserControl_Exam_Favorite examFavorite;
        private int time;
        private int number;
        public DataTable dt = new DataTable();
        public DataRow key;
        public List<DataRow> listAnswer = new List<DataRow>();
        public List<DataRow> listQuestion = new List<DataRow>();

        public int Time { get => time; set => time = value; }
        public int Number { get => number; set => number = value; }
        public Form_Main Father { get => father; set => father = value; }

        public UserControl_Exam(Form_Main main) {
            InitializeComponent();
            Father = main;
        }

        private void metroTile_ComboWord_MouseDown(object sender, MouseEventArgs e) {
            examCombo = new UserControl_Exam_Combo(this);
            Father.panel_Main.Controls.Add(examCombo);
            examCombo.Show();
            examCombo.BringToFront();

            foreach (string path in Directory.GetFiles(@"..\..\..\resources\vocabulary", "*.json")) {
                examCombo.comboBox_Main.Items.Add(Path.GetFileNameWithoutExtension(path));
            }
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
            }
            else {
                metroTile_Favorite.Enabled = true;
                panel_Lock.Visible = false;
            }
            if (examCombo != null) {
                examCombo.Dispose();
                if (examCombo.DoExam != null) { examCombo.DoExam.Dispose(); }
            }
            if (examFavorite != null) {
                examFavorite.Dispose();
                if (examFavorite.DoExam != null) { examFavorite.DoExam.Dispose(); }
            }
        }

        private void metroTile_Favorite_MouseDown(object sender, MouseEventArgs e) {
            examFavorite = new UserControl_Exam_Favorite(this);
            Father.panel_Main.Controls.Add(examFavorite);
            examFavorite.Show();
            examFavorite.BringToFront();
        }

        private void label_Favorite_MouseDown(object sender, MouseEventArgs e) {
            metroTile_Favorite_MouseDown(null, null);
        }

        private void pictureBox_Favorite_MouseDown(object sender, MouseEventArgs e) {
            metroTile_Favorite_MouseDown(null, null);
        }
    }
}
