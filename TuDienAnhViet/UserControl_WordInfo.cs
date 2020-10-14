using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class UserControl_WordInfo : UserControl
    {
        UserControl_Search father;
        public UserControl_WordInfo(string args, UserControl_Search usercontrolSearch)
        {
            InitializeComponent();
            father = usercontrolSearch;
            label_Word.Text = args;
        }
        private void metroTile_Back_Click(object sender, EventArgs e)
        {
            father.Show();
            this.Dispose();          
        }
        private void metroTile_Back_MouseEnter(object sender, EventArgs e)
        {
            metroTile_Back.Style = MetroFramework.MetroColorStyle.Red;
        }
        private void metroTile_Back_MouseLeave(object sender, EventArgs e)
        {
            metroTile_Back.Style = MetroFramework.MetroColorStyle.White;
        }
        private void UserControl_WordInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
