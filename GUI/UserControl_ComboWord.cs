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

        #region Animal
        private void button_ComboWord1_MouseDown(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel_ComboWord1.Size == flowLayoutPanel_ComboWord1.MaximumSize)
            {
                flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MinimumSize;
            }
            else { flowLayoutPanel_ComboWord1.Size = flowLayoutPanel_ComboWord1.MaximumSize; }
        }

        private void button_ComboWord1_MouseEnter(object sender, EventArgs e)
        {
            button_ComboWord1.FlatStyle = FlatStyle.Popup;
        }
        private void button_ComboWord1_MouseLeave(object sender, EventArgs e)
        {
            button_ComboWord1.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region Economic&ForeignTrade
        private void button_ComboWord2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button_ComboWord2_MouseEnter(object sender, EventArgs e)
        {
            button_ComboWord2.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord2_MouseLeave(object sender, EventArgs e)
        {
            button_ComboWord2.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region IrregularVerbs
        private void button_ComboWord3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button_ComboWord3_MouseEnter(object sender, EventArgs e)
        {
            button_ComboWord3.FlatStyle = FlatStyle.Popup;
        }

        private void button_ComboWord3_MouseLeave(object sender, EventArgs e)
        {
            button_ComboWord3.FlatStyle = FlatStyle.Flat;
        }
        #endregion
    }
}
