using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using DTO;

namespace DAO {
    public class AccountDAO {
        private static AccountDAO instance;

        public static AccountDAO Instance { 
            get {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        #region Method
        public bool Login(string userName, string passWord) {
            string hashedPassWord = sha256_hash(passWord);
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, hashedPassWord});

            return result.Rows.Count > 0;
        }

        public bool AlreadyExist(string userName) {
            string query = "SELECT * FROM dbo.Account WHERE UserName = '" + userName + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool Register(string userName, string passWord) {
            if (AlreadyExist(userName)) {
                return false;
            }

            string hashedPassWord = sha256_hash(passWord);
            string query = string.Format("INSERT dbo.Account (UserName, PassWord) VALUES ('{0}', '{1}')", userName, hashedPassWord);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Register(string userName, string displayName, string passWord) {
            if (AlreadyExist(userName)) {
                return false;
            }

            string hashedPassWord = sha256_hash(passWord);
            string query = string.Format("INSERT dbo.Account (UserName, DisplayName, PassWord) VALUES ('{0}', N'{1}', '{2}')", userName, displayName, hashedPassWord);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Register(string userName, string displayName, int type, string passWord) {
            if (AlreadyExist(userName)) {
                return false;
            }

            string hashedPassWord = sha256_hash(passWord);
            string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type, PassWord) VALUES ('{0}', N'{1}', '{2}', '{3}')", userName, displayName, type, hashedPassWord);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool Register(string userName, int type, string passWord) {
            if (AlreadyExist(userName)) {
                return false;
            }

            string hashedPassWord = sha256_hash(passWord);
            string query = string.Format("INSERT dbo.Account (UserName, Type, PassWord) VALUES ('{0}'', '{1}', '{2}')", userName, type, hashedPassWord);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        private static string sha256_hash(string value) {
            StringBuilder Sb = new StringBuilder();
           
            using (SHA256 hash = SHA256Managed.Create()) {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public bool UpdateAccount(string userName, string displayName, string passWord, string newPass) {
            // Nếu newPass rỗng thì chỉ cập nhập displayName
            string hashedPass = sha256_hash(passWord);
            int result;

            if (newPass == "" || newPass == null) {
                result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, hashedPass, newPass });
                
            }
            else {
                string hashedNewPass = sha256_hash(newPass);
                result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, hashedPass, hashedNewPass });
            }

            return result > 0;
        }

        public DataTable GetListAccount() {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
        }

        public AccountDTO GetAccountByUserName(string userName) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows) {
                return new AccountDTO(item);
            }

            return null;
        }

        public bool DeleteAccount(string userName) {
            string query = string.Format("DELETE dbo.Account WHERE UserName = '{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName) {
            string hashedPass = sha256_hash("1");
            string query = string.Format("UPDATE dbo.Account SET PassWord = '" + hashedPass + "' WHERE UserName = {0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //public List<AccountDTO> Xem() {
        //    List<AccountDTO> users = new List<AccountDTO>();
        //    return users;
        //}
        #endregion
    }
}
