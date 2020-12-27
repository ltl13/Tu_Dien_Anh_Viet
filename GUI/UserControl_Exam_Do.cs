using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace GUI {
    public partial class UserControl_Exam_Do : UserControl {
        private class yourTest {
            public string ques, key, choose, A, B, C, D;
        }

        private UserControl_Exam father;
        private int time;
        private bool whatToDo;
        private int number, socau, socaudung = 0;

        private EnViDTO key;
        private List<EnViDTO> listAnswer = new List<EnViDTO>();
        private List<EnViDTO> listQuestion = new List<EnViDTO>();
        private List<yourTest> listYourTest = new List<yourTest>();
        private yourTest instance;

        public UserControl_Exam_Do(UserControl_Exam exam, bool whatToDo) {
            InitializeComponent(); 
            father = exam;
            socau = father.Number;
            time = father.Time;

            if (whatToDo) InitQuizCombo();
            else InitQuizFavorite();

            this.whatToDo = whatToDo;
        }

        private void xuiButton_Back_Click(object sender, EventArgs e) {
            father.BringToFront();
            this.Dispose();
        }

        private void xuiButton_Retry_Click(object sender, EventArgs e) {
            socaudung = 0;
            socau = father.Number;

            father.listQuestion.Clear();
            father.listAnswer.Clear();

            listAnswer.Clear();
            listQuestion.Clear();
            listYourTest.Clear();

            metroProgressSpinner_Time.Visible = true;
            label_time.Visible = true;
            xuiButton_Answer1.Enabled = true;
            xuiButton_Answer2.Enabled = true;
            xuiButton_Answer3.Enabled = true;
            xuiButton_Answer4.Enabled = true;

            if (whatToDo) InitQuizCombo();
            else InitQuizFavorite();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time--;
            metroProgressSpinner_Time.Value = (int)((1.0 * time / father.Time) * 100);
            label_time.Text = time.ToString();
            if (time == 0) {
                listYourTest.Add(instance);
                if (--socau == 0) ketthuc();
                else {
                    if (whatToDo) InitQuizCombo(); else InitQuizFavorite();
                }
            }
        }

        public void ketthuc() {
            timer1.Stop();
            xuiFlatProgressBar_Question.Value = 0;
            metroProgressSpinner_Time.Visible = false;
            label_time.Visible = false;
            xuiButton_Answer1.Enabled = false;
            xuiButton_Answer2.Enabled = false;
            xuiButton_Answer3.Enabled = false;
            xuiButton_Answer4.Enabled = false;
        }

        public bool checkanswer(DataRow answer4) {
            if (father.listAnswer.Count < 3) return true;
            for (int i = 0; i < father.listAnswer.Count; i++) {
                if (!father.listQuestion.Contains(father.listAnswer[i])) return true;
            }
            if (father.listQuestion.Contains(answer4)) return false;
            else return true;
        }

        public bool checkanswerFR(EnViDTO answer4) {
            if (listAnswer.Count < 3) return true;
            for (int i = 0; i < listAnswer.Count; i++) {
                if (!listQuestion.Contains(listAnswer[i])) return true;
            }
            if (listQuestion.Contains(answer4)) return false;
            else return true;
        }

        public void InitQuizCombo() {
            instance = new yourTest();
            time = father.Time;
            father.listAnswer.Clear();
            var rand = new Random();
            xuiFlatProgressBar_Question.Value = (int)(1.0 * socau / father.Number * 100);

            for (int i = 0; i < 4; i++) {
                do {
                    number = rand.Next(0, father.dt.Rows.Count);
                    while ((i == 3 && !checkanswer(father.dt.Rows[number])) || father.listAnswer.Contains(father.dt.Rows[number]))
                        number = rand.Next(0, father.dt.Rows.Count);

                    if (father.listAnswer.Count == 0) {
                        father.listAnswer.Add(father.dt.Rows[number]);
                        break;
                    }
                } while (father.listAnswer.Contains(father.dt.Rows[number])); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                if (i > 0) father.listAnswer.Add(father.dt.Rows[number]);

            }

            xuiButton_Answer1.ButtonText = father.listAnswer[0][2].ToString(); instance.A = father.listAnswer[0][2].ToString();
            xuiButton_Answer2.ButtonText = father.listAnswer[1][2].ToString(); instance.B = father.listAnswer[1][2].ToString();
            xuiButton_Answer3.ButtonText = father.listAnswer[2][2].ToString(); instance.C = father.listAnswer[2][2].ToString();
            xuiButton_Answer4.ButtonText = father.listAnswer[3][2].ToString(); instance.D = father.listAnswer[3][2].ToString();

            do father.key = father.listAnswer[rand.Next(0, 4)]; while (father.listQuestion.Contains(father.key));
            label_Question.Text = father.key[0].ToString();
            father.listQuestion.Add(father.key); instance.key = father.key[2].ToString(); instance.ques = father.key[0].ToString();

            timer1.Start();
            metroProgressSpinner_Time.Value = 100; label_time.Text = time.ToString();
        }

        public void InitQuizFavorite() {
            instance = new yourTest();
            time = father.Time;
            listAnswer.Clear();
            var rand = new Random();
            xuiFlatProgressBar_Question.Value = (int)(1.0 * socau / father.Number * 100);

            for (int i = 0; i < 4; i++) {
                do {
                    number = rand.Next(0, father.Father.Favorite.Count);
                    while ((i == 3 && !checkanswerFR(father.Father.Favorite[number])) || listAnswer.Contains(father.Father.Favorite[number]))// 3 cau va cau cuoi da dung/ 2 dap an giong nhau
                        number = rand.Next(0, father.Father.Favorite.Count);

                    if (listAnswer.Count == 0) {
                        listAnswer.Add(father.Father.Favorite[number]);
                        break;
                    }
                } while (listAnswer.Contains(father.Father.Favorite[number])); ///co cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                if (i > 0) listAnswer.Add(father.Father.Favorite[number]);

            }

            xuiButton_Answer1.ButtonText = listAnswer[0].getCommonMeaning(); instance.A = listAnswer[0].getCommonMeaning();
            xuiButton_Answer2.ButtonText = listAnswer[1].getCommonMeaning(); instance.B = listAnswer[1].getCommonMeaning();
            xuiButton_Answer3.ButtonText = listAnswer[2].getCommonMeaning(); instance.C = listAnswer[2].getCommonMeaning();
            xuiButton_Answer4.ButtonText = listAnswer[3].getCommonMeaning(); instance.D = listAnswer[3].getCommonMeaning();

            do key = listAnswer[rand.Next(0, 4)]; while (listQuestion.Contains(key));
            listQuestion.Add(key); instance.key = key.getCommonMeaning(); instance.ques = key.English.ToString();

            label_Question.Text = key.English.ToString();
            timer1.Start();
            metroProgressSpinner_Time.Value = 100; label_time.Text = time.ToString();
        }

        private void xuiButton_Answer1_Click(object sender, EventArgs e) {
            if (whatToDo) {
                if (father.key[2].ToString() == xuiButton_Answer1.ButtonText) {
                    socaudung++;
                }
            }
            else {
                if (key.getCommonMeaning() == xuiButton_Answer1.ButtonText) {
                    socaudung++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * socaudung * 1.0 / father.Number), 2).ToString();
            instance.choose = xuiButton_Answer1.ButtonText;
            listYourTest.Add(instance);

            if (socau-- > 1) {
                if (whatToDo) InitQuizCombo(); else InitQuizFavorite();
            }
            else {
                listYourTest.Add(instance);
                ketthuc();
            }
        }

        private void xuiButton_Answer2_Click(object sender, EventArgs e) {
            if (whatToDo) {
                if (father.key[2].ToString() == xuiButton_Answer2.ButtonText) {
                    socaudung++;
                }
            }
            else {
                if (key.getCommonMeaning() == xuiButton_Answer2.ButtonText) {
                    socaudung++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * socaudung * 1.0 / father.Number), 2).ToString();

            instance.choose = xuiButton_Answer2.ButtonText;
            listYourTest.Add(instance);

            if (socau-- > 1) {
                if (whatToDo) InitQuizCombo(); else InitQuizFavorite();
            }
            else ketthuc();
        }

        private void xuiButton_Answer3_Click(object sender, EventArgs e) {
            if (whatToDo) {
                if (father.key[2].ToString() == xuiButton_Answer3.ButtonText) {
                    socaudung++;
                }
            }
            else {
                if (key.getCommonMeaning() == xuiButton_Answer3.ButtonText) {
                    socaudung++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * socaudung * 1.0 / father.Number), 2).ToString();

            instance.choose = xuiButton_Answer3.ButtonText;
            listYourTest.Add(instance);

            if (socau-- > 1) {
                if (whatToDo) InitQuizCombo(); else InitQuizFavorite();
            }
            else ketthuc();
        }

        private void xuiButton_Answer4_Click(object sender, EventArgs e) {
            if (whatToDo) {
                if (father.key[2].ToString() == xuiButton_Answer4.ButtonText) {
                    socaudung++;
                }
            }
            else {
                if (key.getCommonMeaning() == xuiButton_Answer4.ButtonText) {
                    socaudung++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * socaudung * 1.0 / father.Number), 2).ToString();
            instance.choose = xuiButton_Answer4.ButtonText;
            listYourTest.Add(instance);

            if (socau-- > 1) {
                if (whatToDo) InitQuizCombo(); else InitQuizFavorite();
            }
            else ketthuc();
        }

    }
}
