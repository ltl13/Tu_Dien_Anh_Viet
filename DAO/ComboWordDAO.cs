using Newtonsoft.Json;
using System.Data;
using System.IO;

namespace DAO {
    public class ComboWordDAO {
        #region properties
        private static ComboWordDAO instance;

        public static ComboWordDAO Instance {
            get {
                if (instance == null)
                    instance = new ComboWordDAO();

                return instance;
            }
            private set { instance = value; }
        }

        private ComboWordDAO() { }
        #endregion

        #region method
        public DataTable GetAnimal() {
            DataTable table = new DataTable();

            using (StreamReader r = new StreamReader(@"..\..\..\resources\vocabulary\animal.json")) {
                string json = r.ReadToEnd();
                table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            }

            return table;
        }
        #endregion
    }
}
