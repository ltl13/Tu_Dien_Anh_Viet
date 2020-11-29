﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class UserControl_Exam : UserControl
    {
        public Form_Main father;
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

        public UserControl_Exam(Form_Main main)
        {
            InitializeComponent();
            father = main;
            
        }

        private void metroTile_ComboWord_MouseDown(object sender, MouseEventArgs e)
        {
            examCombo = new UserControl_Exam_Combo(this);
            father.panel_Main.Controls.Add(examCombo);
            examCombo.Show();
            examCombo.BringToFront();

            foreach (var child in Directory.GetFiles("..\\..\\..\\resources\\vocabulary"))
            {
                string name = Path.GetFileName(child);
                if (name.Contains(".xls")) examCombo.comboBox_Main.Items.Add(name.Substring(0, name.Length - 4));
            }
        }

        private void pictureBox_ComboWord_MouseDown(object sender, MouseEventArgs e)
        {
            metroTile_ComboWord_MouseDown(null, null);
        }

        private void label_ComboWord_MouseDown(object sender, MouseEventArgs e)
        {
            metroTile_ComboWord_MouseDown(null, null);
        }

        private void UserControl_Exam_VisibleChanged(object sender, EventArgs e)
        {
            if (father.Favorite.Count < 10)
            {
                metroTile_Favorite.Enabled = false;
                panel_Lock.Visible = true;
            }
            else
            {
                metroTile_Favorite.Enabled = true;
                panel_Lock.Visible = false;
            }
            if(examCombo != null) { 
                examCombo.Dispose();
                if(examCombo.DoExam != null) { examCombo.DoExam.Dispose(); }
            }
            if(examFavorite != null) { 
                examFavorite.Dispose();
                if(examFavorite.DoExam != null) { examFavorite.DoExam.Dispose(); }
            }
        }

        private void metroTile_Favorite_MouseDown(object sender, MouseEventArgs e)
        {
            examFavorite = new UserControl_Exam_Favorite(this);
            father.panel_Main.Controls.Add(examFavorite);
            examFavorite.Show();
            examFavorite.BringToFront();
        }

        private void label_Favorite_MouseDown(object sender, MouseEventArgs e)
        {
            metroTile_Favorite_MouseDown(null, null);
        }

        private void pictureBox_Favorite_MouseDown(object sender, MouseEventArgs e)
        {
            metroTile_Favorite_MouseDown(null, null);
        }
    }
}
