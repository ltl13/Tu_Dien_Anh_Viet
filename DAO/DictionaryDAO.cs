using System.Data;
using System.IO;

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
        public DataTable GetFavorite(int userID) {
            string query = "SELECT * FROM dbo.[FavoriteWord] WHERE ID = " + userID;

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void SetFavorite(int userID, DataTable favorite) {
            string query = "DELETE FROM dbo.[FavoriteWord] WHERE ID = " + userID;

            DataProvider.Instance.ExecuteNonQuery(query);

            query = "";
            for (int i = 0; i < favorite.Rows.Count; i++) {
                query += string.Format("INSERT INTO dbo.[FavoriteWord] VALUES ({0}, N'{1}', N'{2}');", favorite.Rows[i]["ID"], favorite.Rows[i]["English"], favorite.Rows[i]["VietNamese"]);
            }
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetDictionary(string fileName) {
            string path = string.Format(@"..\..\..\resources\dictionary\{0}.json", fileName);

            if (!File.Exists(path)) {
                string json = "[\n]";
                File.WriteAllText(path, json);
            }

            return DataProvider.Instance.JsonToDataTable(string.Format(@"..\..\..\resources\dictionary\{0}.json", fileName));
        }

        public DataTable GetGame(string fileName) {
            return DataProvider.Instance.JsonToDataTable(string.Format(@"..\..\..\resources\game\{0}.json", fileName));
        }

        public DataSet GetVocabulary(string fileName) {
            return DataProvider.Instance.JsonToDataSet(string.Format(@"..\..\..\resources\vocabulary\{0}.json", fileName));
        }

        public void SetDictionary(DataTable dataTable, string fileName) {
            DataProvider.Instance.DataTableToJson(dataTable, string.Format(@"..\..\..\resources\dictionary\{0}.json", fileName));
        }
        #endregion
    }
}
