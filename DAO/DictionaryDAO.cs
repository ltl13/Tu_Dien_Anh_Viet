using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
