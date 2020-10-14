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
    public partial class UserControl_Search : UserControl
    {
        private bool isDrop = false;
        Form_Main father;
        public UserControl_Search(Form_Main formMain)
        {
            InitializeComponent();
            father = formMain;
        }
        private void metroTextBox_Searchbar_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox_Searchbar.Text.ToString() != "") { isDrop = true; }
            else { isDrop = false; }
            listBox_Search.Items.Add("a");
            listBox_Search.Items.Add("b");
            listBox_Search.Items.Add("c");
            timer_SearchDrop.Start();
        }
        private void timer_SearchDrop_Tick(object sender, EventArgs e)
        {
            if (isDrop)
            {
                metroPanel_Searchbox.Height += 10;
                if (metroPanel_Searchbox.Size == metroPanel_Searchbox.MaximumSize) { timer_SearchDrop.Stop(); }
            }
            else
            {
                metroPanel_Searchbox.Height -= 10;
                if (metroPanel_Searchbox.Size == metroPanel_Searchbox.MinimumSize) { timer_SearchDrop.Stop(); }
            }
        }
        private void listBox_Search_Click(object sender, EventArgs e)
        {
            UserControl_WordInfo wordInfo = new UserControl_WordInfo(listBox_Search.SelectedItem.ToString(), this);
            father.metroPanel_Main.Controls.Add(wordInfo);
            wordInfo.Show();
            this.Hide();
        }
    }
}
