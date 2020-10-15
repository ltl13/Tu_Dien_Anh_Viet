using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS {
    public class AccountBUS {
        private static AccountBUS instance;

        public static AccountBUS Instance {
            get {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() {

        }

        //public void Xem(DataGridView data) {
        //    data.DataSource = AccountDAO.Instance.Xem();
        //}
    }
}
