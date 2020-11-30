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
            UserControl_Flashcard_VisibleChanged(null, null);
        }

        private void xuiButton_Delete_Click(object sender, EventArgs e)
        {           
            var itemToRemove = favorite.SingleOrDefault(r => r.English == favorite[numCard].English);
            if (itemToRemove != null)
                favorite.Remove(itemToRemove);
            if (numCard == favorite.Count)
            {
                if (favorite.Count == 0)
                {
                    label_Eng.Text = "Not add words yet =((";
                    label_Viet.Text = "Bạn chưa thêm từ =((";
                    label_Number.Text = "--/--";
                }
                else { xuiButton_Previous_MouseDown(null, null); }              
            }
            else
            {
                    xuiButton_Next_MouseDown(null, null);
            }
        }

        private void UserControl_Flashcard_VisibleChanged(object sender, EventArgs e)
        {
            panel_Viet.Visible = false;
            panel_Eng.Visible = true;
            if (favorite.Count == 0)
            {
                label_Eng.Text = "Not add words yet =((";
                label_Viet.Text = "Bạn chưa thêm từ =((";
                label_Number.Text = "--/--";
            }
            else
            {
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].getCommonMeaning();
                label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
            }
        }

        private void xuiButton_Next_MouseDown(object sender, MouseEventArgs e)
        {
            if (numCard < favorite.Count - 1)
            {
                numCard++;
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].getCommonMeaning();
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
            }
        }

        private void xuiButton_Previous_MouseDown(object sender, MouseEventArgs e)
        {
            if (numCard > 0)
            {
                numCard--;
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].getCommonMeaning();
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number.Text = Convert.ToString(numCard + 1) + "/" + favorite.Count.ToString();
            }
        }

        private void metroPanel_Eng_MouseDown(object sender, MouseEventArgs e)
        {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }

        private void label_Viet_MouseDown(object sender, MouseEventArgs e)
        {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }

        private void label_Eng_MouseDown(object sender, MouseEventArgs e)
        {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }
    }
}
