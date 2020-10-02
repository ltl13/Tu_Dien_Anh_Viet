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
    public partial class FormWordInfo : Form
    {
        public FormWordInfo(string args, FormSearch formSearch)
        {
            InitializeComponent();
            this.Left = formSearch.Left + 818;
            Text = args;
            labelWord.Text = args;
        }
    }
}
