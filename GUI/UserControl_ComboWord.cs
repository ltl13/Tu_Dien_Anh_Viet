using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserControl_ComboWord : UserControl
    {
        public UserControl_ComboWord()
        {
            InitializeComponent();
        }

        private void button_ComboWord1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel_ComboWord1.Size == flowLayoutPanel_ComboWord1.MaximumSize)
            {
                flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MaximumSize; }
        }
    }
}
