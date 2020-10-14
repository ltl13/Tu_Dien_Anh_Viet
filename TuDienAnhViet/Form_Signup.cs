using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDienAnhViet {
    public partial class Form_Signup : Form {
        public Form_Signup() {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            var owner = this.Owner;
            this.Close();
            owner.Show();
        }

        private void btLogin_Click(object sender, EventArgs e) {
            Form_Main fMain = new Form_Main();
            fMain.Owner = this.Owner;
            this.Close();
            fMain.Show();
        }
    }
}
