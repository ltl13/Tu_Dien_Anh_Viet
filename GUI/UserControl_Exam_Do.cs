using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace GUI {
    public partial class UserControl_Exam_Do : UserControl {
        public class yourTest {
            private string question;
            private string key;
            private string choice;
            private string a, b, c, d;

            public yourTest() {
                question = null;
                key = null;
                choice = null;
                a = null;
                b = null;
                c = null;
                d = null;
            }

            public yourTest(string question, string key, string choice, string a, string b, string c, string d) {
                this.question = question;
                this.key = key;
                this.choice = choice;
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }

            public string Question { get => question; set => question = value; }
            public string Key { get => key; set => key = value; }
            public string Choice { get => choice; set => choice = value; }
            public string A { get => a; set => a = value; }
            public string B { get => b; set => b = value; }
            public string C { get => c; set => c = value; }
            public string D { get => d; set => d = value; }
        }

        private UserControl_Exam father;
        private UserControl_Exam_Result userControl_Exam_Result;
        private int number;
        private int countDown;
        private int numbersOfQuestion;
        private int numbersOfCorrect;

        private DataTable dtAnswer; //4 Câu trả lời không có câu nào trùng
        private DataTable dtQuestion; //Các câu đã hỏi
        private DataRow key;
        private List<yourTest> listYourTest;
        private yourTest instance;

        public List<yourTest> ListYourTest { get => listYourTest; set => listYourTest = value; }

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
            this.ListYourTest = new List<yourTest>();
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
            father.BringToFront();
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
                ListYourTest.Add(instance);
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

            father.ExamResult = new UserControl_Exam_Result(father, listYourTest);
            father.Father.panel_Main.Controls.Add(father.ExamResult);
            father.ExamResult.BringToFront();
            this.Dispose();
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
                } while (ContainDataRowInDataTable(this.dtAnswer, temp));

                if (i > 0) this.dtAnswer.Rows.Add(temp.ItemArray);
            }

            xuiButton_Answer1.ButtonText = this.dtAnswer.Rows[0]["Meaning"].ToString();
            instance.A = this.dtAnswer.Rows[0]["Meaning"].ToString();
            xuiButton_Answer2.ButtonText = this.dtAnswer.Rows[1]["Meaning"].ToString();
            instance.B = this.dtAnswer.Rows[1]["Meaning"].ToString();
            xuiButton_Answer3.ButtonText = this.dtAnswer.Rows[2]["Meaning"].ToString();
            instance.C = this.dtAnswer.Rows[2]["Meaning"].ToString();
            xuiButton_Answer4.ButtonText = this.dtAnswer.Rows[3]["Meaning"].ToString();
            instance.D = this.dtAnswer.Rows[3]["Meaning"].ToString();

            do {
                this.key = this.dtAnswer.Rows[rand.Next(0, 4)];
            } while (ContainDataRowInDataTable(this.dtQuestion, this.key));

            label_Question.Text = key["Vocabulary"].ToString();
            this.dtQuestion.Rows.Add(key.ItemArray);
            instance.Key = this.key["Meaning"].ToString();
            instance.Question = this.key["Vocabulary"].ToString();

            timer1.Start();
            metroProgressSpinner_Time.Value = 100;
            label_time.Text = this.countDown.ToString();
        }

        public void InitQuizFavorite() {
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
                } while (ContainDataRowInDataTable(this.dtAnswer, temp));

                if (i > 0) this.dtAnswer.Rows.Add(temp.ItemArray);
            }

            EnViDTO tempEnVi;

            tempEnVi = new EnViDTO(dtAnswer.Rows[0]);
            xuiButton_Answer1.ButtonText = tempEnVi.getCommonMeaning();
            instance.A = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[1]);
            xuiButton_Answer2.ButtonText = tempEnVi.getCommonMeaning();
            instance.B = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[2]);
            xuiButton_Answer3.ButtonText = tempEnVi.getCommonMeaning();
            instance.C = tempEnVi.getCommonMeaning();
            tempEnVi = new EnViDTO(dtAnswer.Rows[3]);
            xuiButton_Answer4.ButtonText = tempEnVi.getCommonMeaning();
            instance.D = tempEnVi.getCommonMeaning();

            do {
                this.key = this.dtAnswer.Rows[rand.Next(0, 4)];
            } while (ContainDataRowInDataTable(this.dtQuestion, this.key));

            label_Question.Text = key["English"].ToString();
            this.dtQuestion.Rows.Add(key.ItemArray);

            tempEnVi = new EnViDTO(key);
            instance.Key = tempEnVi.getCommonMeaning();
            instance.Question = this.key["English"].ToString();

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

            instance.Choice = xuiButton_Answer1.ButtonText;
            ListYourTest.Add(instance);

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

            instance.Choice = xuiButton_Answer2.ButtonText;
            ListYourTest.Add(instance);

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

            instance.Choice = xuiButton_Answer3.ButtonText;
            ListYourTest.Add(instance);

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

            instance.Choice = xuiButton_Answer4.ButtonText;
            ListYourTest.Add(instance);

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
