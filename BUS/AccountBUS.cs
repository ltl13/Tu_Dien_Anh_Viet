using DAO;
using DTO;

namespace BUS {
    public class AccountBUS {
        #region properties
        private static AccountBUS instance;

        public static AccountBUS Instance {
            get {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        private AccountBUS() { }
        #endregion

        #region method
        public bool Login(string userName, string passWord) {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        public bool Register(string userName, int type, string passWord, string displayName = null) {
            if (displayName == null) {
                return AccountDAO.Instance.Register(userName, type, passWord);
            }

            return AccountDAO.Instance.Register(userName, type, passWord, displayName);
        }

        public bool UpdateAccount(string userName, string displayName, string passWord, string newPass) {
            return AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPass);
        }

        public AccountDTO GetAccountByUserName(string userName) {
            return AccountDAO.Instance.GetAccountByUserName(userName);
        }
        #endregion
    }
}
