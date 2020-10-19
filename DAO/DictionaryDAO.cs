using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DAO {
    public class DictionaryDAO {
        #region properties
        private static DictionaryDAO instance;

        public static DictionaryDAO Instance {
            get {
                if (instance == null)
                    instance = new DictionaryDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private DictionaryDAO() { }
        #endregion

        #region method
        public static string StringToHexString(string plainText) {
            var bb = System.Text.Encoding.UTF8.GetBytes(plainText);
            var hexString = System.BitConverter.ToString(bb);
            string s = HexStringToString(hexString);
            return hexString;
        }

        public static string HexStringToString(string HexString) {
            byte[] bb = FromHex(HexString);
            return System.Text.Encoding.UTF8.GetString(bb);
        }

        public static byte[] FromHex(string hex) {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];

            for (int i = 0; i < raw.Length; i++) {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return raw;
        }

        public DataTable GetListItem(string input) {
            string encode = StringToHexString(input) + "%";
            DataTable DT = DataProvider.Instance.ExecuteQuery("SELECT English, VietNamese FROM dbo.Word WHERE English LIKE '" + encode + "'");

            for (int i = 0; i < DT.Rows.Count; i++) {
                DT.Rows[i][0] = HexStringToString(DT.Rows[i][0].ToString());
                DT.Rows[i][1] = HexStringToString(DT.Rows[i][1].ToString());
            }

            return DT;
        }
        #endregion
    }
}
