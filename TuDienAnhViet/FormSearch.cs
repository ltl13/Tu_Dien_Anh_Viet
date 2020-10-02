using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void rtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (rtbSearch.Text.ToString() == "a")
            {
                isCollapse = true;
                lsbListSearch.Items.Add("Amen");
                lsbListSearch.Items.Add("Adu");
                lsbListSearch.Items.Add("Athea");
                lsbListSearch.Items.Add("Athelamsaomaa");
                lsbListSearch.Items.Add("adfa");
                lsbListSearch.Items.Add("adfadf");
                timerSearchList.Start();
            }
            else
            {
                lsbListSearch.Items.Clear();
                isCollapse = false;
                timerSearchList.Start();
            }
        }

        private void rtbSearch_Click(object sender, EventArgs e)
        {
            isCollapse = true;
            timerSearchList.Start();
        }
        private bool isCollapse = true;
        private void timerSearchList_Tick(object sender, EventArgs e)
        {           
            if (isCollapse)
            {
                panelSearchbox.Height += 10;
                if (panelSearchbox.Size == panelSearchbox.MaximumSize)
                {
                    timerSearchList.Stop();
                }
            }
            else
            {
                panelSearchbox.Height -= 10;
                if (panelSearchbox.Size == panelSearchbox.MinimumSize)
                {
                    timerSearchList.Stop();
                }
            }
        }

        private void lsbListSearch_Click(object sender, EventArgs e)
        {
            FormWordInfo wordInfo = new FormWordInfo(lsbListSearch.SelectedItem.ToString(), this);
            wordInfo.Show();
        }
    }
}
