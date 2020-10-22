using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class UserControl_Flashcard : UserControl
    {
        public UserControl_Flashcard(AccountDTO account)
        {
            InitializeComponent();
        }
    }
}
