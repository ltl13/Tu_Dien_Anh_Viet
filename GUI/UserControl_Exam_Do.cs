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

        private UserControl_Exam father;//
        private int number;
        private int countDown;//
        private int numbersOfQuestion;//
        private int numbersOfCorrect;//

        private DataTable dtAnswer; //4 Câu trả lời không có câu nào trùng
        private DataTable dtQuestion; //Các câu đã hỏi
        private DataRow key; //--
        private List<yourTest> listYourTest;
        private yourTest instance;

        public UserControl_Exam_Do(UserControl_Exam userControl_Exam) {
            InitializeComponent(); 
            father = userControl_Exam;
        }

        private void UserControl_Exam_Do_Load(object sender, EventArgs e) {
            this.dtAnswer = new DataTable();
            this.dtQuestion = new DataTable();
            this.countDown = father.CountDown;
            this.numbersOfQuestion = father.NumbersOfQuestion;
            this.numbersOfCorrect = 0;
            this.listYourTest = new List<yourTest>();
            this.instance = new yourTest();

            foreach (DataColumn column in father.DataTable.Columns) {
                this.dtAnswer.Columns.Add(column.ColumnName);
                this.dtQuestion.Columns.Add(column.ColumnName);
            }

            metroProgressSpinner_Time.Visible = true;
            label_time.Visible = true;
            xuiButton_Answer1.Enabled = true;
            xuiButton_Answer2.Enabled = true;
            xuiButton_Answer3.Enabled = true;
            xuiButton_Answer4.Enabled = true;

            if (father.Choice == 1) InitQuizCombo();
            else if (father.Choice == 2) InitQuizFavorite();
        }

        private void xuiButton_Back_Click(object sender, EventArgs e) {
            father.Visible = true;
            this.Dispose();
        }

        private void xuiButton_Retry_Click(object sender, EventArgs e) {
            UserControl_Exam_Do_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.countDown--;
            metroProgressSpinner_Time.Value = (int)((1.0 * this.countDown / father.CountDown) * 100);
            label_time.Text = this.countDown.ToString();
            if (this.countDown == 0) {
                listYourTest.Add(instance);
                if (--numbersOfQuestion == 0) ketthuc();
                else {
                    if (father.Choice == 1) InitQuizCombo(); 
                    else if (father.Choice == 2) InitQuizFavorite();
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
            if (this.dtAnswer.Rows.Count < 3) { 
                return true;
            }

            for (int i = 0; i < this.dtAnswer.Rows.Count; i++) {
                if (!ContainDataRowInDataTable(this.dtQuestion, this.dtAnswer.Rows[i])) {
                    return true;
                }
            }

            if (ContainDataRowInDataTable(this.dtQuestion, answer4)) {
                return false;
            }
            else {
                return true;
            }
        }

        bool ContainDataRowInDataTable(DataTable T, DataRow R) {
            foreach (DataRow item in T.Rows) {
                if (System.Linq.Enumerable.SequenceEqual(item.ItemArray, R.ItemArray))
                    return true;
            }
            return false;
        }

        public void InitQuizCombo() {
            this.instance = new yourTest();
            this.countDown = father.CountDown;
            this.dtAnswer.Rows.Clear();

            var rand = new Random();
            xuiFlatProgressBar_Question.Value = (int)(1.0 * numbersOfQuestion / father.NumbersOfQuestion * 100);
            DataRow temp;

            for (int i = 0; i < 4; i++) {
                do {
                    number = rand.Next(0, father.DataTable.Rows.Count);
                    temp = father.DataTable.Rows[number];

                    while ((i == 3 && !checkanswer(father.DataTable.Rows[number])) || ContainDataRowInDataTable(this.dtAnswer, temp)) {
                        number = rand.Next(0, father.DataTable.Rows.Count);
                        temp = father.DataTable.Rows[number];
                    }
                        

                    if (this.dtAnswer.Rows.Count == 0) {
                        this.dtAnswer.Rows.Add(temp.ItemArray);
                        break;
                    }
                } while (ContainDataRowInDataTable(this.dtAnswer, temp)); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau

                if (i > 0) this.dtAnswer.Rows.Add(temp.ItemArray);
            }

            xuiButton_Answer1.ButtonText = this.dtAnswer.Rows[0]["Meaning"].ToString();
            xuiButton_Answer2.ButtonText = this.dtAnswer.Rows[1]["Meaning"].ToString();
            xuiButton_Answer3.ButtonText = this.dtAnswer.Rows[2]["Meaning"].ToString();
            xuiButton_Answer4.ButtonText = this.dtAnswer.Rows[3]["Meaning"].ToString();

            //instance.A = father.listAnswer[0][2].ToString();
            //instance.B = father.listAnswer[1][2].ToString();
            //instance.C = father.listAnswer[2][2].ToString();
            //instance.D = father.listAnswer[3][2].ToString();

            do {
                this.key = this.dtAnswer.Rows[rand.Next(0, 4)];
            } while (ContainDataRowInDataTable(this.dtQuestion, this.key));

            label_Question.Text = key[0].ToString();
            this.dtQuestion.Rows.Add(key.ItemArray);
            //instance.key = father.key[2].ToString();
            //instance.ques = father.key[0].ToString();

            timer1.Start();
            metroProgressSpinner_Time.Value = 100;
            label_time.Text = this.countDown.ToString();
        }

        public void InitQuizFavorite() {
            this.instance = new yourTest();
            this.countDown = father.CountDown;
            this.dtAnswer = new DataTable();

            var rand = new Random();
            xuiFlatProgressBar_Question.Value = (int)(1.0 * numbersOfQuestion / father.NumbersOfQuestion * 100);

            for (int i = 0; i < 4; i++) {
                DataRow temp;

                do {
                    number = rand.Next(0, father.Father.Favorite.Count);
                    temp = father.DataTable.Rows[number];

                    // 3 cau va cau cuoi da dung/ 2 dap an giong nhau
                    while ((i == 3 && !checkanswer(father.DataTable.Rows[number])) || ContainDataRowInDataTable(this.dtAnswer, temp)) {
                        number = rand.Next(0, father.DataTable.Rows.Count);
                        temp = father.DataTable.Rows[number];
                    }

                    if (this.dtAnswer.Rows.Count == 0) {
                        this.dtAnswer.Rows.Add(temp.ItemArray);
                        break;
                    }
                } while (ContainDataRowInDataTable(this.dtAnswer, temp)); //co cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau

                if (i > 0) this.dtAnswer.Rows.Add(temp.ItemArray);
            }

            EnViDTO tempEnVi;

            tempEnVi = new EnViDTO(dtAnswer.Rows[0]);
            xuiButton_Answer1.ButtonText = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[1]);
            xuiButton_Answer2.ButtonText = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[2]);
            xuiButton_Answer3.ButtonText = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[3]);
            xuiButton_Answer4.ButtonText = tempEnVi.getCommonMeaning();

            //instance.A = listAnswer[0].getCommonMeaning();
            //instance.B = listAnswer[1].getCommonMeaning();
            //instance.C = listAnswer[2].getCommonMeaning();
            //instance.D = listAnswer[3].getCommonMeaning();

            do {
                this.key = this.dtAnswer.Rows[rand.Next(0, 4)];
            } while (ContainDataRowInDataTable(this.dtQuestion, this.key));

            label_Question.Text = key[0].ToString();
            this.dtQuestion.Rows.Add(key.ItemArray);
            //instance.key = father.key[2].ToString();
            //instance.ques = father.key[0].ToString();

            timer1.Start();
            metroProgressSpinner_Time.Value = 100;
            label_time.Text = this.countDown.ToString();
        }

        private void xuiButton_Answer1_Click(object sender, EventArgs e) {
            if (father.Choice == 1) {
                if (this.key["Meaning"].ToString() == xuiButton_Answer1.ButtonText) {
                    numbersOfCorrect++;
                }
            }
            else if (father.Choice == 2) {
                EnViDTO tempEnVi = new EnViDTO(key);

                if (tempEnVi.getCommonMeaning() == xuiButton_Answer1.ButtonText) {
                    numbersOfCorrect++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * numbersOfCorrect * 1.0 / father.NumbersOfQuestion), 2).ToString();
            instance.choose = xuiButton_Answer1.ButtonText;
            listYourTest.Add(instance);

            if (numbersOfQuestion-- > 1) {
                if (father.Choice == 1) {
                    InitQuizCombo();
                }
                else if (father.Choice == 2) {
                    InitQuizFavorite();
                }
            }
            else {
                ketthuc();
            }
        }

        private void xuiButton_Answer2_Click(object sender, EventArgs e) {
            if (father.Choice == 1) {
                if (this.key["Meaning"].ToString() == xuiButton_Answer2.ButtonText) {
                    numbersOfCorrect++;
                }
            }
            else if (father.Choice == 2) {
                EnViDTO tempEnVi = new EnViDTO(key);

                if (tempEnVi.getCommonMeaning() == xuiButton_Answer2.ButtonText) {
                    numbersOfCorrect++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * numbersOfCorrect * 1.0 / father.NumbersOfQuestion), 2).ToString();

            instance.choose = xuiButton_Answer2.ButtonText;
            listYourTest.Add(instance);

            if (numbersOfQuestion-- > 1) {
                if (father.Choice == 1) {
                    InitQuizCombo();
                }
                else if (father.Choice == 2) {
                    InitQuizFavorite();
                }
            }
            else {
                ketthuc();
            }
        }

        private void xuiButton_Answer3_Click(object sender, EventArgs e) {
            if (father.Choice == 1) {
                if (this.key["Meaning"].ToString() == xuiButton_Answer3.ButtonText) {
                    numbersOfCorrect++;
                }
            }
            else if (father.Choice == 2) {
                EnViDTO tempEnVi = new EnViDTO(key);

                if (tempEnVi.getCommonMeaning() == xuiButton_Answer3.ButtonText) {
                    numbersOfCorrect++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * numbersOfCorrect * 1.0 / father.NumbersOfQuestion), 2).ToString();

            instance.choose = xuiButton_Answer3.ButtonText;
            listYourTest.Add(instance);

            if (numbersOfQuestion-- > 1) {
                if (father.Choice == 1) {
                    InitQuizCombo();
                }
                else if (father.Choice == 2) {
                    InitQuizFavorite();
                }
            }
            else { 
                ketthuc(); 
            }
        }

        private void xuiButton_Answer4_Click(object sender, EventArgs e) {
            if (father.Choice == 1) {
                if (this.key["Meaning"].ToString() == xuiButton_Answer4.ButtonText) {
                    numbersOfCorrect++;
                }
            }
            else if (father.Choice == 2) {
                EnViDTO tempEnVi = new EnViDTO(key);

                if (tempEnVi.getCommonMeaning() == xuiButton_Answer4.ButtonText) {
                    numbersOfCorrect++;
                }
            }

            label_Score.Text = "Your score: " + Math.Round((float)(10 * numbersOfCorrect * 1.0 / father.NumbersOfQuestion), 2).ToString();
            instance.choose = xuiButton_Answer4.ButtonText;
            listYourTest.Add(instance);

            if (numbersOfQuestion-- > 1) {
                if (father.Choice == 1) {
                    InitQuizCombo();
                }
                else if (father.Choice == 2) {
                    InitQuizFavorite();
                }
            }
            else { 
                ketthuc(); 
            }
        }

    }
}
