using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Flashcard : UserControl {
        private Form_Main father;
        private int numCard;

        public UserControl_Flashcard(Form_Main formMain) {
            InitializeComponent();

            father = formMain;
            this.Focus();
            this.Select();
        }

        private void xuiButton_Delete_Click(object sender, EventArgs e) {
            if (numCard != -1) {
                if (numCard == father.Favorite.Count - 1) {
                    numCard--;
                    father.Favorite.Remove(father.Favorite[numCard + 1]);
                    label_Number_TextChanged(sender, e);
                }
                else {
                    father.Favorite.Remove(father.Favorite[numCard]);
                    label_Number_TextChanged(sender, e);
                }
            }
        }

        private void UserControl_Flashcard_VisibleChanged(object sender, EventArgs e) {
            if (father.Favorite.Count == 0)
                numCard = -1;
            else
                numCard = 0;

            panel_Viet.Visible = false;
            panel_Eng.Visible = true;
            label_Number_TextChanged(sender, e);
        }

        private void label_Viet_MouseDown(object sender, MouseEventArgs e) {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;

            label_Eng.BackColor = Color.Gainsboro;
            label_Viet.BackColor = Color.Gainsboro;
            xuiButton_Panel.BackgroundColor = Color.Gainsboro;
        }

        private void label_Viet_MouseUp(object sender, MouseEventArgs e) {
            label_Eng.BackColor = Color.White;
            label_Viet.BackColor = Color.White;
            xuiButton_Panel.BackgroundColor = Color.White;
        }

        private void label_Eng_MouseDown(object sender, MouseEventArgs e) {
            panel_Eng.Visible = !panel_Eng.Visible;
            panel_Viet.Visible = !panel_Viet.Visible;

            label_Eng.BackColor = Color.Gainsboro;
            label_Viet.BackColor = Color.Gainsboro;
            xuiButton_Panel.BackgroundColor = Color.Gainsboro;
        }

        private void label_Eng_MouseUp(object sender, MouseEventArgs e) {
            label_Eng.BackColor = Color.White;
            label_Viet.BackColor = Color.White;
            xuiButton_Panel.BackgroundColor = Color.White;
        }

        private void pictureBox_Prev_MouseDown(object sender, MouseEventArgs e) {
            if (numCard != -1) {
                numCard--;
                label_Eng.Text = father.Favorite[numCard].English;
                label_Viet.Text = father.Favorite[numCard].getCommonMeaning();
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number_TextChanged(sender, e);

                pictureBox_Prev.Image = Properties.Resources.left_arrow1;
            }
        }

        private void pictureBox_Next_MouseDown(object sender, MouseEventArgs e) {
            if (numCard != -1) {
                numCard++;
                label_Eng.Text = father.Favorite[numCard].English;
                label_Viet.Text = father.Favorite[numCard].getCommonMeaning();
                panel_Viet.Visible = false;
                panel_Eng.Visible = true;
                label_Number_TextChanged(sender, e);

                pictureBox_Next.Image = Properties.Resources.right_arrow1;
            }
        }

        private void label_Number_TextChanged(object sender, EventArgs e) {
            if (numCard == -1) {
                label_Eng.Text = "Not add words yet =((";
                label_Viet.Text = "Bạn chưa thêm từ =((";
                label_Number.Text = "--/--";

                pictureBox_Prev.Enabled = false;
                pictureBox_Next.Enabled = false;
                pictureBox_Prev.Image = Properties.Resources.left_arrow1;
                pictureBox_Next.Image = Properties.Resources.right_arrow1;
            }
            else {
                label_Eng.Text = father.Favorite[numCard].English;
                label_Viet.Text = father.Favorite[numCard].getCommonMeaning();
                label_Number.Text = (numCard + 1).ToString() + "/" + father.Favorite.Count.ToString();

                if (numCard + 1 == father.Favorite.Count) {
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
