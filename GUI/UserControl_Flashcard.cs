using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Flashcard : UserControl {
        private List<EnViDTO> favorite;
        private int numCard = 0;

        public UserControl_Flashcard(Form_Main formMain) {
            InitializeComponent();

            favorite = formMain.Favorite;
            this.Focus();
            this.Select();
        }

        private void xuiButton_Delete_Click(object sender, EventArgs e) {
            if (favorite.Count != 0) {
                var itemToRemove = favorite.SingleOrDefault(r => r.English == favorite[numCard].English);

                if (itemToRemove != null)
                    favorite.Remove(itemToRemove);

                if (numCard == favorite.Count - 1) {
                    pictureBox_Prev_MouseDown(null, null);
                    pictureBox_Prev_MouseUp(null, null);
                }
                else {
                    pictureBox_Next_MouseDown(null, null);
                    pictureBox_Next_MouseUp(null, null);
                }
            }
        }

        private void UserControl_Flashcard_VisibleChanged(object sender, EventArgs e) {
            panel_Viet.Visible = false;
            panel_Eng.Visible = true;

            if (favorite.Count == 0) {
                label_Eng.Text = "Not add words yet =((";
                label_Viet.Text = "Bạn chưa thêm từ =((";
                label_Number.Text = "--/--";
            }
            else {
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].getCommonMeaning();
                label_Number.Text = (numCard + 1).ToString() + "/" + favorite.Count.ToString();
            }
        }

        private void label_Viet_MouseDown(object sender, MouseEventArgs e) {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }

        private void label_Eng_MouseDown(object sender, MouseEventArgs e) {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;
        }

        private void pictureBox_Prev_MouseDown(object sender, MouseEventArgs e) {
            numCard--;
            label_Eng.Text = favorite[numCard].English;
            label_Viet.Text = favorite[numCard].getCommonMeaning();
            panel_Viet.Visible = false;
            panel_Eng.Visible = true;
            label_Number.Text = (numCard + 1).ToString() + "/" + favorite.Count.ToString();

            pictureBox_Prev.Image = Properties.Resources.left_arrow1;
        }

        private void pictureBox_Next_MouseDown(object sender, MouseEventArgs e) {

            numCard++;
            label_Eng.Text = favorite[numCard].English;
            label_Viet.Text = favorite[numCard].getCommonMeaning();
            panel_Viet.Visible = false;
            panel_Eng.Visible = true;
            label_Number.Text = (numCard + 1).ToString() + "/" + favorite.Count.ToString();

            pictureBox_Next.Image = Properties.Resources.right_arrow1;
        }

        private void label_Number_TextChanged(object sender, EventArgs e) {
            if (numCard + 1 == favorite.Count) {
                pictureBox_Next.Enabled = false;
                pictureBox_Next.Image = Properties.Resources.right_arrow1;
            }
            else {
                pictureBox_Next.Enabled = true;
                pictureBox_Next.Image = Properties.Resources.right_arrow;
            }

            if (numCard == 0) {
                pictureBox_Prev.Enabled = false;
                pictureBox_Prev.Image = Properties.Resources.left_arrow1;
            }
            else {
                pictureBox_Prev.Enabled = true;
                pictureBox_Prev.Image = Properties.Resources.left_arrow;
            }

            if (favorite.Count == 0) {
                label_Eng.Text = "Not add words yet =((";
                label_Viet.Text = "Bạn chưa thêm từ =((";
                label_Number.Text = "--/--";
            }
            else {
                label_Eng.Text = favorite[numCard].English;
                label_Viet.Text = favorite[numCard].getCommonMeaning();
                label_Number.Text = (numCard + 1).ToString() + "/" + favorite.Count.ToString();
            }
        }

        private void pictureBox_Prev_MouseUp(object sender, MouseEventArgs e) {
            pictureBox_Prev.Image = Properties.Resources.left_arrow;
        }

        private void pictureBox_Next_MouseUp(object sender, MouseEventArgs e) {
            pictureBox_Next.Image = Properties.Resources.right_arrow;
        }
    }
}
