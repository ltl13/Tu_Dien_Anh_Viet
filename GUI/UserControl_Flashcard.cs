using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class UserControl_Flashcard : UserControl
    {
        public List<EnViDTO> favorite;
        private int numCard = 0;
        public UserControl_Flashcard(AccountDTO account, Form_Main formMain)
        {
            InitializeComponent();
            favorite = formMain.Favorite;
            label_Eng.Text = favorite[numCard].English;
            label_Viet.Text = favorite[numCard].VietNamese;
            panel_Viet.Visible = false;
            panel_Eng.Visible = true;
            label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
        }

        private void xuiButton_Next_Click(object sender, EventArgs e)
        {
            if (numCard < favorite.Count - 1) 
            { 
                numCard++;
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].VietNamese;
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
            }
        }

        private void xuiButton_Previous_Click(object sender, EventArgs e)
        {
            if (numCard > 0)
            {
                numCard--;
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].VietNamese;
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
            }
        }

        private void metroPanel_Eng_Click(object sender, EventArgs e)
        {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }

        private void label_Viet_Click(object sender, EventArgs e)
        {
            metroPanel_Eng_Click(null, null);
        }

        private void label_Eng_Click(object sender, EventArgs e)
        {
            metroPanel_Eng_Click(null, null);
        }
    }
}
