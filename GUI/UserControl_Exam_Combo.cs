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
    public partial class UserControl_Exam_Combo : UserControl
    {
        private UserControl_Exam_Do doExam;
        private UserControl_Exam father;
        public UserControl_Exam_Combo(UserControl_Exam previous)
        {
            InitializeComponent();
            father = previous;
        }

        public UserControl_Exam_Do DoExam { get => doExam; set => doExam = value; }

        private void xuiButton_Start_Click(object sender, EventArgs e)
        {
            DoExam = new UserControl_Exam_Do(father,true);
            father.father.panel_Main.Controls.Add(DoExam);
            DoExam.BringToFront();
        }
    }
}
