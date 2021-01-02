using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Grammar : UserControl {
        private Form_Main father;
        private Form_Game_BuildBridge fGameBuildBridge;
        private Form_Game_CarRacing fGameCarRacing;

        public UserControl_Grammar(Form_Main father) {
            InitializeComponent();

            this.father = father;
        }

        private void button_Game_BuildBridge_Click(object sender, EventArgs e) {
            try {
                if (int.Parse(metroTextBox_Number.Text) > 100) {
                    label_Error.Text = "Number of question is invalid";
                    label_Error2.Text = "Time is invalid";
                }
                else {
                    fGameBuildBridge = new Form_Game_BuildBridge(father, int.Parse(metroTextBox_Number.Text), int.Parse(metroTextBox_Time.Text));
                    fGameBuildBridge.Show();
                    this.father.Visible = false;
                    label_Error.Text = "";
                    label_Error2.Text = "";
                }
            }
            catch {
                label_Error.Text = "Number of question is invalid";
                label_Error2.Text = "Time is invalid";
            }
        }

        private void button_Game_CarRacing_Click(object sender, EventArgs e) {
            try {
                if (int.Parse(metroTextBox_Number.Text) > 100) {
                    label_Error.Text = "Number of question is invalid";
                    label_Error2.Text = "Time is invalid";
                }
                else {
                    fGameCarRacing = new Form_Game_CarRacing(father, int.Parse(metroTextBox_Number.Text), int.Parse(metroTextBox_Time.Text));
                    fGameCarRacing.Show();
                    this.father.Visible = false;
                    label_Error.Text = "";
                    label_Error2.Text = "";
                }
            }
            catch {
                label_Error.Text = "Number of question is invalid";
                label_Error2.Text = "Time is invalid";
            }
        }
    }
}
