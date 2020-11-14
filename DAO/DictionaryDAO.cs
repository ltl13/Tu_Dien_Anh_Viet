using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using DTO;
using System.Data;
using FastMember;

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
        public List<EnViDTO> GetEnViList() {
            List<EnViDTO> items = new List<EnViDTO>();

            using (StreamReader r = new StreamReader(@"..\..\..\resources\en-vi.json")) {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
            }

            return items;
        }

        public DataTable GetEnViTable() {
            DataTable table = new DataTable();

            using (StreamReader r = new StreamReader(@"..\..\..\resources\en-vi.json")) {
                string json = r.ReadToEnd();
                table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            }

            return table;
        }

        public List<ViEnDTO> GetViEnList() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\vi-en.json")) {
                string json = r.ReadToEnd();
                List<ViEnDTO> items = JsonConvert.DeserializeObject<List<ViEnDTO>>(json);
                return items;
            }
        }

        public DataTable GetViEnTable() {
            DataTable table = new DataTable();

            using (StreamReader r = new StreamReader(@"..\..\..\resources\vi-en.json")) {
                string json = r.ReadToEnd();
                table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            }

            return table;
        }

        public void SaveFavoriteWord(List<EnViDTO> Favorite) {
            string json = JsonConvert.SerializeObject(Favorite.ToArray());
            File.WriteAllText(@"..\..\..\resources\favorite.json", json);
        }

        public List<EnViDTO> LoadSavedFavoriteWord() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\favorite.json")) {
                string json = r.ReadToEnd();
                List<EnViDTO> items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
                return items;
            }
        }

        //public bool AddFavorite(AccountDTO loginAccount, EnViDTO word) {
        //    //word.English = StringToHexString(word.English);
        //    string query = string.Format("INSERT dbo.Favorite_Word (ID_User, ID_Word) VALUE ({0}, '{1}')", loginAccount.ID, word.English);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //public DataTable GetListFavorite(AccountDTO loginAccount) {
        //    DataTable DT = DataProvider.Instance.ExecuteQuery("SELECT ID_Word FROM dbo.Favorite_English WHERE ID_User = " + loginAccount.ID.ToString());

        //    for (int i = 0; i < DT.Rows.Count; i++) {
        //        //DT.Rows[i][1] = HexStringToString(DT.Rows[i][1].ToString());
        //    }

        //    return DT;
        //}

        //public DataTable GetListItem(string input) {
        //    //string encode = StringToHexString(input) + "%";
        //    DataTable DT = DataProvider.Instance.ExecuteQuery("SELECT English, VietNamese FROM dbo.Word WHERE English LIKE '" + encode + "'");

        //    for (int i = 0; i < DT.Rows.Count; i++) {
        //        //DT.Rows[i][0] = HexStringToString(DT.Rows[i][0].ToString());
        //        //DT.Rows[i][1] = HexStringToString(DT.Rows[i][1].ToString());
        //    }

        //    return DT;
        //}

        #endregion
    }
}
