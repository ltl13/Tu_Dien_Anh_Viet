using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing;

namespace GUI {
    public partial class UserControl_Grammar : UserControl {
        private Form_Main father;
        //private Form_Game_BuildBridge fGameBuildBridge;
        //private Form_Game_CarRacing fGameCarRacing;

        public UserControl_Grammar(Form_Main father) {
            InitializeComponent();
            this.father = father;
        }

        private void UserControl_Grammar_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.Squirk_RMvV.Length;
            byte[] fontdata = Properties.Resources.Squirk_RMvV;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            button_Game_CarRacing.Font = new Font(pfc.Families[0], button_Game_CarRacing.Font.Size);
            button_Game_CarRacing.Text = "Car Racing";

            button_Game_BuildBridge.Font = new Font(pfc.Families[0], button_Game_BuildBridge.Font.Size);          
            button_Game_BuildBridge.Text = "Build Bridge";
        }

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
