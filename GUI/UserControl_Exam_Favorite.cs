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
        public UserControl_Exam_Favorite(UserControl_Exam previous)
        {
            InitializeComponent();
            father = previous;
        }

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e)
        {
            DoExam = new UserControl_Exam_Do(father, false);
            father.father.panel_Main.Controls.Add(doExam);
            DoExam.BringToFront();
        }
    }
}
