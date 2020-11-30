using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace GUI
{
    public partial class UserControl_Exam_Do : UserControl
    {
        //private UserControl_Exam grandfather;
        private UserControl_Exam grandfather;
        private int time;
        private bool WhatToDo;
        int number, socau, socaudung = 0;

        EnViDTO key;
        List<EnViDTO> listAnswer = new List<EnViDTO>();
        List<EnViDTO> listQuestion = new List<EnViDTO>();

        public UserControl_Exam_Do(UserControl_Exam exam, bool whatToDo)
        {
            InitializeComponent();
            grandfather = exam;
            socau = grandfather.Number;
            time = grandfather.Time;
            label_RightAnswer.Text = "0";

            if (whatToDo) taotrachnghiemCB();
            else taotrachnghiemFR();

            this.WhatToDo = whatToDo;
        }

        private void xuiButton_Back_Click(object sender, EventArgs e)
        {
            grandfather.BringToFront();
            this.Dispose();
        }

        private void xuiButton_Retry_Click(object sender, EventArgs e)
        {
            socaudung = 0;
            socau = grandfather.Number;
            label_RightAnswer.Text = "0";

            grandfather.listQuestion.Clear();
            grandfather.listAnswer.Clear();

            listAnswer.Clear();
            listQuestion.Clear();

            xuiButton_Answer1.Enabled = true;
            xuiButton_Answer2.Enabled = true;
            xuiButton_Answer3.Enabled = true;
            xuiButton_Answer4.Enabled = true;

            if (WhatToDo) taotrachnghiemCB();
            else taotrachnghiemFR();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            metroProgressSpinner_Time.Value = (int)((1.0*time / grandfather.Time) * 100); 
            label_time.Text = time.ToString();
            if (time == 0)
            {
                if (--socau == 0) ketthuc();
                else
                {
                    if (WhatToDo) taotrachnghiemCB(); else taotrachnghiemFR();
                }
            }
        }

        public bool checkanswer(DataRow answer4)
        {
            if (grandfather.listAnswer.Count < 3) return true;
            for (int i = 0; i < grandfather.listAnswer.Count; i++)
            {
                if (!grandfather.listQuestion.Contains(grandfather.listAnswer[i])) return true;
            }
            if (grandfather.listQuestion.Contains(answer4)) return false;
            else return true;
        }

        public void taotrachnghiemCB()
        {
            time = grandfather.Time;
            grandfather.listAnswer.Clear();
            var rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = rand.Next(0, grandfather.dt.Rows.Count);
                    while ((i == 3 && !checkanswer(grandfather.dt.Rows[number])) || grandfather.listAnswer.Contains(grandfather.dt.Rows[number]))
                        number = rand.Next(0, grandfather.dt.Rows.Count);

                    if (grandfather.listAnswer.Count == 0)
                    {
                        grandfather.listAnswer.Add(grandfather.dt.Rows[number]);
                        break;
                    }
                } while (grandfather.listAnswer.Contains(grandfather.dt.Rows[number])); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                if (i > 0) grandfather.listAnswer.Add(grandfather.dt.Rows[number]);

            }

            xuiButton_Answer1.ButtonText = grandfather.listAnswer[0][2].ToString();
            xuiButton_Answer2.ButtonText = grandfather.listAnswer[1][2].ToString();
            xuiButton_Answer3.ButtonText = grandfather.listAnswer[2][2].ToString();
            xuiButton_Answer4.ButtonText = grandfather.listAnswer[3][2].ToString();

            do grandfather.key = grandfather.listAnswer[rand.Next(0, 4)]; while (grandfather.listQuestion.Contains(grandfather.key));
            label_Question.Text = grandfather.key[0].ToString();
            grandfather.listQuestion.Add(grandfather.key);

            timer1.Start();
            metroProgressSpinner_Time.Value = 100; label_time.Text = time.ToString();
        }

        public void ketthuc()
        {
            timer1.Stop();
            MessageBox.Show("Điểm của bạn là: " + socaudung.ToString());

            xuiButton_Answer1.Enabled = false;
            xuiButton_Answer2.Enabled = false;
            xuiButton_Answer3.Enabled = false;
            xuiButton_Answer4.Enabled = false;
        }

        private void xuiButton_Answer1_Click(object sender, EventArgs e)
        {
            if (WhatToDo)
            {
                if (grandfather.key[2] == xuiButton_Answer1.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }
            else
            {
                if (key.VietNamese == xuiButton_Answer1.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }

            if (socau-- > 1)
            {
                if (WhatToDo) taotrachnghiemCB(); else taotrachnghiemFR();
            }
            else ketthuc();
        }

        private void xuiButton_Answer2_Click(object sender, EventArgs e)
        {
            if (WhatToDo)
            {
                if (grandfather.key[2] == xuiButton_Answer2.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }
            else
            {
                if (key.VietNamese == xuiButton_Answer2.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }

            if (socau-- > 1)
            {
                if (WhatToDo) taotrachnghiemCB(); else taotrachnghiemFR();
            }
            else ketthuc();
        }

        private void xuiButton_Answer3_Click(object sender, EventArgs e)
        {
            if (WhatToDo)
            {
                if (grandfather.key[2] == xuiButton_Answer3.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }
            else
            {
                if (key.VietNamese == xuiButton_Answer3.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }

            if (socau-- > 1)
            {
                if (WhatToDo) taotrachnghiemCB(); else taotrachnghiemFR();
            }
            else ketthuc();
        }

        private void xuiButton_Answer4_Click(object sender, EventArgs e)
        {
            if (WhatToDo)
            {
                if (grandfather.key[2] == xuiButton_Answer4.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }
            else
            {
                if (key.VietNamese == xuiButton_Answer4.ButtonText)
                {
                    socaudung++;
                    label_RightAnswer.Text = socaudung.ToString();
                }
            }

            if (socau-- > 1)
            {
                if (WhatToDo) taotrachnghiemCB(); else taotrachnghiemFR();
            }
            else ketthuc();
        }

        ////////////////////////////////
        public bool checkanswerFR(EnViDTO answer4)
        {
            if (listAnswer.Count < 3) return true;
            for (int i = 0; i < listAnswer.Count; i++)
            {
                if (!listQuestion.Contains(listAnswer[i])) return true;
            }
            if (listQuestion.Contains(answer4)) return false;
            else return true;
        }

        public void taotrachnghiemFR()
        {
            time = grandfather.Time;
            listAnswer.Clear();
            var rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = rand.Next(0, grandfather.Father.Favorite.Count);
                    while ((i == 3 && !checkanswerFR(grandfather.Father.Favorite[number])) || listAnswer.Contains(grandfather.Father.Favorite[number]))
                        number = rand.Next(0, grandfather.Father.Favorite.Count);

                    if (listAnswer.Count == 0)
                    {
                        listAnswer.Add(grandfather.Father.Favorite[number]);
                        break;
                    }
                } while (listAnswer.Contains(grandfather.Father.Favorite[number])); //4 cau tra loi bi trung thi tiep tuc random i tang den khi du 4 cau
                if (i > 0) listAnswer.Add(grandfather.Father.Favorite[number]);

            }

            xuiButton_Answer1.ButtonText = listAnswer[0].VietNamese;
            xuiButton_Answer2.ButtonText = listAnswer[1].VietNamese;
            xuiButton_Answer3.ButtonText = listAnswer[2].VietNamese;
            xuiButton_Answer4.ButtonText = listAnswer[3].VietNamese;

            key = listAnswer[rand.Next(0, 4)];
            label_Question.Text = key.English.ToString();
            listQuestion.Add(key);

            timer1.Start();
            metroProgressSpinner_Time.Value = 100; label_time.Text = time.ToString();
        }

    }
}
