using System;
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
using Newtonsoft.Json;

namespace GUI
{
    public partial class Form_Game_CarRacing : Form
    {
        Form_Main father;
        List<item> items;
        public class item
        {
            public string id, question, result, A, B, C, D;
        }
        AxWindowsMediaPlayer musicBackGround;
        AxWindowsMediaPlayer musicCoin;
        AxWindowsMediaPlayer musicBoom;

        bool check, isclick = false, music = false, colision = false, isboom = false;
        int time = 0, numberOfQuestion = 2, n = 2, point = 0;
        int iCoin = 0, iCar = 0, iGift = 0;
        int positionXcar = 30, positionYcar = 160;
        int positionXcoin = 1250, positionYcoin = 240;
        Random rand = new Random();

        public Form_Game_CarRacing(Form_Main father)
        {
            InitializeComponent();
            LoadJson();
            this.father = father;
            label_NumQues.Text = n.ToString();

            #region Music Init
            musicBackGround = new AxWindowsMediaPlayer();
            musicCoin = new AxWindowsMediaPlayer();
            musicBoom = new AxWindowsMediaPlayer();

            musicBackGround.CreateControl();
            musicCoin.CreateControl();
            musicBoom.CreateControl();

            var currentPath = Directory.GetCurrentDirectory();
            currentPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\Resources\SoundTrack"));

            musicBackGround.URL = Path.Combine(currentPath, "backgroundCar.wav");
            musicCoin.URL = Path.Combine(currentPath, "coin.wav");
            musicBoom.URL = Path.Combine(currentPath, "boom.wav");
            #endregion

            stopAllMusic();

            timer_carRacing.Start();
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\trachnghiemtonghop.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<item>>(json);
            }
        }

        #region add Bitmap Gif
        Bitmap run1 = new Bitmap(Properties.Resources.car0),
            run2 = new Bitmap(Properties.Resources.car1),
            run3 = new Bitmap(Properties.Resources.car2),
            run4 = new Bitmap(Properties.Resources.car3),
            run5 = new Bitmap(Properties.Resources.car4),
            run6 = new Bitmap(Properties.Resources.car5),
            run7 = new Bitmap(Properties.Resources.car6),
            run8 = new Bitmap(Properties.Resources.car7),
            run9 = new Bitmap(Properties.Resources.car8),
            run10 = new Bitmap(Properties.Resources.car9),
            run11 = new Bitmap(Properties.Resources.car10);

        Bitmap RunFrame;
        Bitmap[] RunFrames;

        Bitmap coin1 = new Bitmap(Properties.Resources.coin0),
         coin2 = new Bitmap(Properties.Resources.coin1),
         coin3 = new Bitmap(Properties.Resources.coin2),
         coin4 = new Bitmap(Properties.Resources.coin3),
         coin5 = new Bitmap(Properties.Resources.coin4),
         coin6 = new Bitmap(Properties.Resources.coin5),
         coin7 = new Bitmap(Properties.Resources.coin6),
         coin8 = new Bitmap(Properties.Resources.coin7);
        Bitmap CoinFrame;
        Bitmap[] CoinFrames;

        Bitmap gift1 = new Bitmap(Properties.Resources.gift1),
            gift2 = new Bitmap(Properties.Resources.gift2),
            gift3 = new Bitmap(Properties.Resources.gift3),
            gift4 = new Bitmap(Properties.Resources.gift4),
            gift5 = new Bitmap(Properties.Resources.gift5),
            gift6 = new Bitmap(Properties.Resources.gift6),
            gift7 = new Bitmap(Properties.Resources.gift7),
            gift8 = new Bitmap(Properties.Resources.gift8),
            gift9 = new Bitmap(Properties.Resources.gift9),
            gift10 = new Bitmap(Properties.Resources.gift10),
            gift11 = new Bitmap(Properties.Resources.gift11),
            gift12 = new Bitmap(Properties.Resources.gift12),
            gift13 = new Bitmap(Properties.Resources.gift13);
        Bitmap GiftFrame;
        Bitmap[] GiftFrames;

        Bitmap rock = new Bitmap(Properties.Resources.rock);
        Bitmap pow = new Bitmap(Properties.Resources.pow);
        #endregion

        #region Draw
        private Bitmap Run_2D_Draw()
        {
            RunFrames = new Bitmap[] { run1, run2, run3, run4, run5, run6, run7, run8, run9, run10, run11 };

            if (iCar < RunFrames.Length)
            {
                RunFrame = RunFrames[iCar];
                iCar++;
            }
            else iCar = 0;
            return RunFrame;
        }

        private Bitmap Coin_2D_Draw()
        {
            CoinFrames = new Bitmap[] { coin1, coin2, coin3, coin4, coin5, coin6, coin7, coin8 };

            if (iCoin < CoinFrames.Length)
            {
                CoinFrame = CoinFrames[iCoin];
                iCoin++;
            }
            else iCoin = 0;
            return CoinFrame;
        }

        private Bitmap Gift_2D_Draw()
        {
            GiftFrames = new Bitmap[] { gift1, gift2, gift3, gift4, gift5, gift6, gift7, gift8, gift9, gift10, gift11, gift12, gift13 };

            if (iGift < GiftFrames.Length)
            {
                GiftFrame = GiftFrames[iGift];
                iGift++;
            }
            else iGift = 0;
            return GiftFrame;
        }
        #endregion

        #region Close Music
        void stopAllMusic()
        {
            musicBackGround.Ctlcontrols.stop();
            musicCoin.Ctlcontrols.stop();
            musicBoom.Ctlcontrols.stop();
        }
        #endregion

        private void Form_Game_CarRacing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Run_2D_Draw(), positionXcar, positionYcar);

            if (check && isclick && !colision) e.Graphics.DrawImage(Coin_2D_Draw(), positionXcoin, positionYcoin);
            else if (!check && isclick && !colision) e.Graphics.DrawImage(rock, positionXcoin, positionYcoin);
            else if (!check && isclick && isboom)
            {
                e.Graphics.DrawImage(pow, positionXcoin, positionYcoin);
                musicBoom.Ctlcontrols.play();
                isboom = false;
            }

            if (!isclick) e.Graphics.DrawImage(Gift_2D_Draw(), positionXcoin - 140, positionYcoin - 70);

            if (isclick)
            {
                positionXcar += 20;
                if (positionXcar + RunFrame.Width == positionXcoin && check)
                {
                    colision = true;
                    musicCoin.Ctlcontrols.play();
                }
                else if (positionXcar + RunFrame.Width == positionXcoin && !check)
                {
                    isboom = true;
                    colision = true;
                }
            }
            if (positionXcar > 1500)
            {
                showAllButton();
                positionXcar = 30;
                isclick = false;
                colision = false;
            }
        }

        private void metroButton_Back_Click(object sender, EventArgs e)
        {
            father.Show();
            stopAllMusic();
            this.Close();
        }

        private void metroButton_Music_Click(object sender, EventArgs e)
        {
            music = !music;
            if (music) musicBackGround.Ctlcontrols.play(); else musicBackGround.Ctlcontrols.stop();
        }

        private void timer_carRacing_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        
        void hideAllButton()
        {
            xuiButton_A.Visible = false;
            xuiButton_B.Visible = false;
            xuiButton_C.Visible = false;
            xuiButton_D.Visible = false;
        }

        void showAllButton()
        {
            xuiButton_A.Visible = true;
            xuiButton_B.Visible = true;
            xuiButton_C.Visible = true;
            xuiButton_D.Visible = true;
        }

        private void xuiButton_D_Click(object sender, EventArgs e)
        {
            hideAllButton();
        }

        private void xuiButton_C_Click(object sender, EventArgs e)
        {
            hideAllButton();
        }

        private void xuiButton_B_Click(object sender, EventArgs e)
        {
            hideAllButton();
            check = false;
            isclick = true;
        }

        private void xuiButton_A_Click(object sender, EventArgs e)
        {
            check = true;
            isclick = true;
            hideAllButton();
        }
    }
}
