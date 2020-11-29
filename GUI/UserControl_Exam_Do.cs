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
    public partial class UserControl_Exam_Do : UserControl
    {
        private UserControl_Exam grandfather;
        public UserControl_Exam_Do(UserControl_Exam exam)
        {
            InitializeComponent();
            grandfather = exam;
        }

        private void xuiButton_Back_Click(object sender, EventArgs e)
        {
            grandfather.BringToFront();
            this.Dispose();
        }
    }
}
