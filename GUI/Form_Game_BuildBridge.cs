using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace GUI
{
    public partial class Form_Game_BuildBridge : MetroFramework.Forms.MetroForm
    {
        Form_Main father;
        AxWindowsMediaPlayer musicBackGround;
        //AxWindowsMediaPlayer musicTrue;
        //AxWindowsMediaPlayer musicFalse;
        //AxWindowsMediaPlayer musicVictory;
        //AxWindowsMediaPlayer musicLose;
        public Form_Game_BuildBridge(Form_Main father)
        {
            InitializeComponent();
            this.father = father;
            this.StartPosition = FormStartPosition.CenterScreen;

            musicBackGround = new AxWindowsMediaPlayer();
            musicBackGround.CreateControl();


            //musicTrue = new AxWindowsMediaPlayer();
            //musicFalse = new AxWindowsMediaPlayer();
            //musicVictory = new AxWindowsMediaPlayer();
            //musicLose = new AxWindowsMediaPlayer();

            musicBackGround.URL = "./Resources/background.wav";

            //musicTrue.URL = "./knock.wav";
            //musicFalse.URL = "./boom.wav";
            //musicVictory.URL = "./victory.wav";
            //musicLose.URL = "./lose.wav";

            musicBackGround.Ctlcontrols.play();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            father.Show();
            this.Close();
        }
    }
}
