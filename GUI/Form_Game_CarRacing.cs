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
    public partial class Form_Game_CarRacing : MetroFramework.Forms.MetroForm
    {
        Form_Main father;
        public Form_Game_CarRacing(Form_Main father)
        {
            InitializeComponent();
            this.father = father;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            father.Show();
            this.Close();
        }
    }
}
