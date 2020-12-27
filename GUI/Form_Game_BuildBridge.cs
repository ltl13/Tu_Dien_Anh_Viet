﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using BUS;
using Newtonsoft.Json;

namespace GUI
{
    public partial class Form_Game_BuildBridge : Form
    {
        Form_Main father;
        DataTable items;
        DataRow key;

        AxWindowsMediaPlayer musicBackGround;
        AxWindowsMediaPlayer musicCorrect;
        AxWindowsMediaPlayer musicWrong;
        AxWindowsMediaPlayer musicvictory;
        AxWindowsMediaPlayer musicLose;

        bool win = false, lose = false, check = false, isclick = false, music = false, finish = false;
        int time = 0, numberOfQuestion=2, point = 0, countDown;///
        double percent = 0.5;
        int i = 0;
        int positionX = 100, positionY = 360;
        Random rand = new Random();

        public Form_Game_BuildBridge(Form_Main father)
        {
            InitializeComponent();
            items = DictionaryBUS.Instance.GetFillBlank();
            this.father = father;
            label_numOfQuestion.Text = numberOfQuestion.ToString();

            #region Music Init
            musicBackGround = new AxWindowsMediaPlayer();
            musicCorrect = new AxWindowsMediaPlayer();
            musicWrong = new AxWindowsMediaPlayer();
            musicvictory = new AxWindowsMediaPlayer();
            musicLose = new AxWindowsMediaPlayer();

            musicBackGround.CreateControl();
            musicCorrect.CreateControl();
            musicWrong.CreateControl();
            musicvictory.CreateControl();
            musicLose.CreateControl();

            var currentPath = Directory.GetCurrentDirectory();
            currentPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\Resources\SoundTrack"));

            musicBackGround.URL = Path.Combine(currentPath, "background.wav");
            musicCorrect.URL = Path.Combine(currentPath, "knock.wav");
            musicWrong.URL = Path.Combine(currentPath, "boom.wav");
            musicvictory.URL = Path.Combine(currentPath, "victory.wav");
            musicLose.URL = Path.Combine(currentPath, "lose.wav");
            #endregion

            stopAllMusic();

            key = items.Rows[rand.Next(0, items.Rows.Count)];
            label_Question.Text = key["Question"].ToString();
            timer_Bridge.Start();
        }



        #region add Bitmap Gif
        Bitmap run1 = new Bitmap(Properties.Resources.m0),
          run2 = new Bitmap(Properties.Resources.m1),
          run3 = new Bitmap(Properties.Resources.m2),
          run4 = new Bitmap(Properties.Resources.m3),
          run5 = new Bitmap(Properties.Resources.m4),
          run6 = new Bitmap(Properties.Resources.m5),
          run7 = new Bitmap(Properties.Resources.m6),
          run8 = new Bitmap(Properties.Resources.m7),
          run9 = new Bitmap(Properties.Resources.m8);

        Bitmap RunFrame;
        Bitmap[] RunFrames;

        Bitmap boom1 = new Bitmap(Properties.Resources.bum0),
            boom2 = new Bitmap(Properties.Resources.bum1),
            boom3 = new Bitmap(Properties.Resources.bum2),
            boom4 = new Bitmap(Properties.Resources.bum3),
            boom5 = new Bitmap(Properties.Resources.bum4),
            boom6 = new Bitmap(Properties.Resources.bum5),
            boom7 = new Bitmap(Properties.Resources.bum6);

        Bitmap BoomFrame;
        Bitmap[] BoomFrames;

        Bitmap ham1 = new Bitmap(Properties.Resources.hm0),
            ham2 = new Bitmap(Properties.Resources.hm1),
            ham3 = new Bitmap(Properties.Resources.hm2),
            ham4 = new Bitmap(Properties.Resources.hm3);
        Bitmap HamFrame;
        Bitmap[] HamFrames;
        #endregion

        #region Draw
        private Bitmap Run_2D_Draw()
        {
            RunFrames = new Bitmap[] { run1, run2, run3, run4, run5, run6, run7, run8, run9 };

            if (i < RunFrames.Length)
            {
                RunFrame = RunFrames[i];
                i++;
            }
            else i = 0;
            return RunFrame;
        }

        private Bitmap Boom_2D_Draw()
        {
            BoomFrames = new Bitmap[] { boom1, boom2, boom3, boom4, boom5, boom6, boom7 };

            if (i < BoomFrames.Length)
            {
                BoomFrame = BoomFrames[i];
                i++;
            }
            else i = 0;
            return BoomFrame;
        }

        private Bitmap Ham_2D_Draw()
        {
            HamFrames = new Bitmap[] { ham1, ham2, ham3, ham4 };

            if (i < HamFrames.Length)
            {
                HamFrame = HamFrames[i];
                i++;
            }
            else i = 0;
            return HamFrame;
        }
        #endregion

        #region Close Music
        void stopAllMusic()
        {
            musicBackGround.Ctlcontrols.stop();
            musicCorrect.Ctlcontrols.stop();
            musicWrong.Ctlcontrols.stop();
            musicvictory.Ctlcontrols.stop();
            musicLose.Ctlcontrols.stop();
        }
        #endregion

        void checkResult()
        {
            if (--numberOfQuestion > 0)
            {
                key = items.Rows[rand.Next(0, items.Rows.Count)];
                label_Question.Text = key["Question"].ToString();
            }
            else if((float)point/numberOfQuestion>=percent)
            {
                win = true;
                panel_Question.Hide();
                musicBackGround.Ctlcontrols.stop();
                musicvictory.Ctlcontrols.play();
                this.BackgroundImage = Properties.Resources.sky;
                timer_Bridge.Start();
            }
            else
            {
                lose = true;
                panel_Question.Hide();
                musicBackGround.Ctlcontrols.stop();
                musicLose.Ctlcontrols.play();
                timer_Bridge.Start();
            }
        }

        private void textBox_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_Answer.Hide();
                if (textBox_Answer.Text == key["Answer"].ToString())
                {
                    check = true;
                    point++;
                    if (numberOfQuestion-1!=0) musicCorrect.Ctlcontrols.play();
                    isclick = true;
                    label_numOfQuestion.Text = numberOfQuestion.ToString();
                    checkResult();
                    timer_Bridge.Start();
                }
                else
                {
                    check = false;
                    musicWrong.Ctlcontrols.play();
                    isclick = true;
                    label_numOfQuestion.Text = numberOfQuestion.ToString();
                    checkResult();
                    timer_Bridge.Start();
                }
                
            }
            
        }

        #region Button click
        private void metroTile_BackOfGb_Click(object sender, EventArgs e)
        {
            metroTile_Back_Click(sender, e);
        }

        private void metroTile_Back_Click(object sender, EventArgs e)
        {
            father.Show();
            stopAllMusic();
            this.Close();
        }

        private void metroTile_Music_Click(object sender, EventArgs e)
        {
            music = !music;
            if (music) musicBackGround.Ctlcontrols.play(); else musicBackGround.Ctlcontrols.stop();
        }

        private void xuiButton_Ok_Click(object sender, EventArgs e)
        {
            //numberOfQuestion = int.Parse(metroTextBox_NumOfQues.Text);
            //countDown = int.Parse(metroTextBox_Time.Text);
            //percent = double.Parse(metroTextBox_Percent.Text);
            groupBox_Setting.Dispose();
        }


        #endregion

        private void timer_countDown_Tick(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form_Game_BuildBridge_Paint(object sender, PaintEventArgs e)
        {
            if (lose)
            {
                e.Graphics.DrawImage(run1, positionX, positionY);
                e.Graphics.DrawImage((Properties.Resources.lose), positionX + 210, positionY - 50);
                e.Graphics.DrawImage(Boom_2D_Draw(), positionX + 130, positionY - 120);
            }
            if (win)
            {
                if (positionX < 550)
                {
                    positionX += 10;
                    e.Graphics.DrawImage(Run_2D_Draw(), positionX, positionY);
                }
                else
                {
                    e.Graphics.DrawImage(run1, positionX, positionY);
                    e.Graphics.DrawImage((Properties.Resources.win), positionX - 240, positionY - 100);
                }
            }
            else if (!isclick) e.Graphics.DrawImage(run1, positionX, positionY);
            
            if (isclick)
            {
                if (check && !win && !lose)
                {
                    if (time++ < 40)
                    {
                        e.Graphics.DrawImage(Ham_2D_Draw(), positionX + 150, positionY + 10);
                    }
                    else
                    {
                        isclick = false;
                        textBox_Answer.Show();
                        textBox_Answer.Text = string.Empty;
                        textBox_Answer.Select();
                        time = 0;
                    }
                }
                else if (!check && !lose && !win)
                {
                    if (time++ < 8)
                    {
                        e.Graphics.DrawImage(run1, positionX, positionY);
                        e.Graphics.DrawImage(Boom_2D_Draw(), positionX + 130, positionY - 120);
                    }
                    else
                    {
                        isclick = false;
                        textBox_Answer.Show();
                        textBox_Answer.Text = string.Empty;
                        textBox_Answer.Select();
                        time = 0;
                    }
                }
            }

        }
    }
}
