using DAO;
using DTO;
using System.Data;

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

        public bool Register(string userName, string passWord, string displayName = null) {
            if (displayName == null) {
                return AccountDAO.Instance.Register(userName, passWord);
            }

            return AccountDAO.Instance.Register(userName, passWord, displayName);
        }

        public bool UpdateAccount(string userName, string displayName, string passWord, string newPass) {
            return AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPass);
        }

        public AccountDTO GetAccountByUserName(string userName) {
            return AccountDAO.Instance.GetAccountByUserName(userName);
        }

        public DataTable GetListAccount() {
            return AccountDAO.Instance.GetListAccount();
        }

        public int ImportImage(int userID, string folderPath, string fileName) {
            return AccountDAO.Instance.ImportImage(userID, folderPath, fileName);
        }

        public int ExportImage(int userID, string folderPath, string fileName) {
            return AccountDAO.Instance.ExportImage(userID, folderPath, fileName);
        }
        #endregion
    }
}
