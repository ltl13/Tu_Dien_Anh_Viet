using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
namespace TuDienAnhViet
{
    public partial class FormWordInfo : Form
    {
        public FormWordInfo(DictionaryData args, FormSearch formSearch)
        {
            InitializeComponent();
            this.Left = formSearch.Left + 818;
            Text = args.English.ToString();
            labelWord.Text = args.English.ToString();
            textboxNghia.Text = args.Vietnamese_analytics.ToString();
        }

        private void buttonSpeaker_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(labelWord.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
