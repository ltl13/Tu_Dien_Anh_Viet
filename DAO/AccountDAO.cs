using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        private AccountDAO() { 

        }

        public bool Login(string userName, string passWord) {
            string hashedPassWord = sha256_hash(passWord);
            string query = "SELECT * FROM [Account] WHERE UserName = '" + userName + "' AND PassWord = '" + hashedPassWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool AlreadyExist(string userName) {
            string query = "SELECT * FROM [Account] WHERE UserName = '" + userName + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
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

        public Account GetAccountByUserName(string userName) {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows) {
                return new Account(item);
            }

            return null;
        }

        //public List<AccountDTO> Xem() {
        //    List<AccountDTO> users = new List<AccountDTO>();
        //    return users;
        //}
    }
}
