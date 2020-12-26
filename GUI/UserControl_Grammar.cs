using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing;

namespace GUI {
    public partial class UserControl_Grammar : UserControl {
        private Form_Main father;
        private Form_Game_BuildBridge fGameBuildBridge;
        private Form_Game_CarRacing fGameCarRacing;

        public UserControl_Grammar(Form_Main father) {
            InitializeComponent();
            this.father = father;
            
        }

        //private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);


        private void button_Game_BuildBridge_Click(object sender, EventArgs e)
        {
            fGameBuildBridge = new Form_Game_BuildBridge(father);
            fGameBuildBridge.Show();
            this.father.Hide();
        }

        private void button_Game_CarRacing_Click(object sender, EventArgs e)
        {
            fGameCarRacing = new Form_Game_CarRacing(father);
            fGameCarRacing.Show();
            this.father.Hide();
        }

    }
}
