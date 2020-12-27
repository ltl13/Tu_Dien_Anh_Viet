using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class UserControl_Exam_Result : UserControl {
        private UserControl_Exam father;
        System.Collections.Generic.List<UserControl_Exam_Do.yourTest> result;
        private Button[] button;
        
        public UserControl_Exam_Result(UserControl_Exam userControl_Exam, System.Collections.Generic.List<UserControl_Exam_Do.yourTest> result) {
            InitializeComponent();

            this.father = userControl_Exam;
            this.result = result;
            this.button = new Button[this.result.Count];

            for (int i = 0; i < this.result.Count; i++) {
                Init(button[i], i, this.result[i]);
            }
        }

        public void Init(Button button, int i, UserControl_Exam_Do.yourTest result) {
            button = new Button();            

            if (string.IsNullOrEmpty(result.Choice)) {
                button.BackColor = Color.Gray;
                button.ForeColor = Color.Black;
            }
            else if (result.Key != result.Choice) {
                button.BackColor = Color.Red;
                button.ForeColor = Color.White;
            }
            else if (result.Key == result.Choice) {
                button.BackColor = Color.Green;
                button.ForeColor = Color.White;
            }

            button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button.Size = new Size(160, 50);
            button.Text = "Question " + (i + 1).ToString();
            button.Click += new EventHandler((object sender, EventArgs e) => {
                Reset(xuiButton_Answer1);
                Reset(xuiButton_Answer2);
                Reset(xuiButton_Answer3);
                Reset(xuiButton_Answer4);

                label_Question.Text = result.Question;
                xuiButton_Answer1.ButtonText = result.A;
                xuiButton_Answer2.ButtonText = result.B;
                xuiButton_Answer3.ButtonText = result.C;
                xuiButton_Answer4.ButtonText = result.D;

                if (result.Choice == result.Key || string.IsNullOrEmpty(result.Choice)) {
                    if (result.Key == result.A) {
                        InitCorrect(xuiButton_Answer1);
                    }
                    else if (result.Key == result.B) {
                        InitCorrect(xuiButton_Answer2);
                    }
                    else if (result.Key == result.C) {
                        InitCorrect(xuiButton_Answer3);
                    }
                    else if (result.Key == result.D) {
                        InitCorrect(xuiButton_Answer4);
                    }
                }
                else {
                    if (result.Key == result.A) {
                        InitCorrect(xuiButton_Answer1);
                    }
                    else if (result.Key == result.B) {
                        InitCorrect(xuiButton_Answer2);
                    }
                    else if (result.Key == result.C) {
                        InitCorrect(xuiButton_Answer3);
                    }
                    else if (result.Key == result.D) {
                        InitCorrect(xuiButton_Answer4);
                    }

                    if (result.Choice == result.A) {
                        InitWrong(xuiButton_Answer1);
                    }
                    else if (result.Choice == result.B) {
                        InitWrong(xuiButton_Answer2);
                    }
                    else if (result.Choice == result.C) {
                        InitWrong(xuiButton_Answer3);
                    }
                    else if (result.Choice == result.D) {
                        InitWrong(xuiButton_Answer4);
                    }
                }
            });

            this.flowLayoutPanel1.Controls.Add(button);
        }

        private void Reset(XanderUI.XUIButton xuiButton) {
            xuiButton.BackgroundColor = System.Drawing.Color.Silver;
            xuiButton.ClickBackColor = System.Drawing.Color.Black;
            xuiButton.ClickTextColor = System.Drawing.Color.Black;
            xuiButton.HoverBackgroundColor = System.Drawing.Color.Black;
            xuiButton.HoverTextColor = System.Drawing.Color.Silver;
            xuiButton.TextColor = System.Drawing.Color.Black;
        }

        private void InitWrong(XanderUI.XUIButton xuiButton) {
            xuiButton.BackgroundColor = System.Drawing.Color.Red;
            xuiButton.ClickBackColor = System.Drawing.Color.White;
            xuiButton.ClickTextColor = System.Drawing.Color.White;
            xuiButton.HoverBackgroundColor = System.Drawing.Color.White;
            xuiButton.HoverTextColor = System.Drawing.Color.Red;
            xuiButton.TextColor = System.Drawing.Color.White;
        }

        private void InitCorrect(XanderUI.XUIButton xuiButton) {
            xuiButton.BackgroundColor = System.Drawing.Color.Green;
            xuiButton.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            xuiButton.ClickBackColor = System.Drawing.Color.White;
            xuiButton.ClickTextColor = System.Drawing.Color.White;
            xuiButton.HoverBackgroundColor = System.Drawing.Color.White;
            xuiButton.HoverTextColor = System.Drawing.Color.Green;
            xuiButton.TextColor = System.Drawing.Color.White;
        }

        private void xuiButton_Back_Click(object sender, EventArgs e) {
            father.BringToFront();
            this.Dispose();
        }
    }
}
