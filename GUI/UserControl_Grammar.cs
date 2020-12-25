
using System.Windows.Forms;

namespace GUI
{
    public partial class UserControl_Grammar : UserControl
    {
        public UserControl_Grammar()
        {
            InitializeComponent();
            
        }

        private void UserControl_Grammar_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.SnesItalic_1G9Be.Length;
            byte[] fontdata = Properties.Resources.SnesItalic_1G9Be;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);

            button_Game1.Font = new Font(pfc.Families[0], button_Game1.Font.Size);
            button_Game1.Text = "Build Bridge";

            button_Game2.Font = new Font(pfc.Families[0], button_Game2.Font.Size);
            button_Game2.Text = "Car Racing";
        }
    }
}
