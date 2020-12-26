using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Game_CarRacing : Form
    {
        Form_Main father;
        public Form_Game_CarRacing(Form_Main father)
        {
            InitializeComponent();
            this.father = father;
        }

        private void Form_Game_CarRacing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton_Back_Click(object sender, EventArgs e)
        {

        }

        private void metroButton_Music_Click(object sender, EventArgs e)
        {

        }

        private void timer_carRacing_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void metroButton_A_Click(object sender, EventArgs e)
        {

        }

        private void metroButton_B_Click(object sender, EventArgs e)
        {

        }

        private void metroButton_C_Click(object sender, EventArgs e)
        {

        }

        private void metroButton_D_Click(object sender, EventArgs e)
        {

        }
    }
}
