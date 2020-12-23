using Newtonsoft.Json;
using System.Data;
using System.IO;

namespace DAO {
    public class ComboWordDAO {
        #region variables
        private static ComboWordDAO instance;
        #endregion

        #region properties
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
        public DataSet GetDataSet(string fileName) {
            DataSet dataSet = new DataSet();

            using (StreamReader r = new StreamReader(string.Format(@"..\..\..\resources\vocabulary\{0}.json", fileName))) {
                string json = r.ReadToEnd();
                dataSet = JsonConvert.DeserializeObject<DataSet>(json);
            }

            return dataSet;
        }
        #endregion
    }
}
