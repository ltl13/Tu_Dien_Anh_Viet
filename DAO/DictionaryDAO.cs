using DTO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        public List<EnViDTO> GetEnViList() {
            List<EnViDTO> items = new List<EnViDTO>();

            using (StreamReader r = new StreamReader(@"..\..\..\resources\en-vi.json")) {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
            }

            return items;
        }

        public DataTable GetEnViTable() {
            return DataProvider.Instance.JsonToDataTable("en-vi");
        }

        public List<ViEnDTO> GetViEnList() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\vi-en.json")) {
                string json = r.ReadToEnd();
                List<ViEnDTO> items = JsonConvert.DeserializeObject<List<ViEnDTO>>(json);
                return items;
            }
        }

        public DataTable GetViEnTable() {
            return DataProvider.Instance.JsonToDataTable("vi-en");
        }

        public void SaveFavoriteWord(List<EnViDTO> Favorite) {
            string json = JsonConvert.SerializeObject(Favorite.ToArray(), Formatting.Indented);
            File.WriteAllText(@"..\..\..\resources\favorite.json", json);
        }

        public List<EnViDTO> LoadSavedFavoriteWord() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\favorite.json")) {
                string json = r.ReadToEnd();
                List<EnViDTO> items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
                return items;
            }
        }

        public void SaveRecentlyWordEnVi(List<EnViDTO> recently) {
            string json = JsonConvert.SerializeObject(recently.ToArray(), Formatting.Indented);
            File.WriteAllText(@"..\..\..\resources\recentlyEnVi.json", json);
        }

        public List<EnViDTO> LoadRecentlyWordEnVi() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\recentlyEnVi.json")) {
                string json = r.ReadToEnd();
                List<EnViDTO> items = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
                return items;
            }
        }

        public void SaveRecentlyWordViEn(List<ViEnDTO> recently) {
            string json = JsonConvert.SerializeObject(recently.ToArray(), Formatting.Indented);
            File.WriteAllText(@"..\..\..\resources\recentlyViEn.json", json);
        }

        public List<ViEnDTO> LoadRecentlyWordViEn() {
            using (StreamReader r = new StreamReader(@"..\..\..\resources\recentlyViEn.json")) {
                string json = r.ReadToEnd();
                List<ViEnDTO> items = JsonConvert.DeserializeObject<List<ViEnDTO>>(json);
                return items;
            }
        }

        public DataTable GetFillBlank() {
            return DataProvider.Instance.JsonToDataTable("fillBlank");
        }

        public DataTable GetQuiz() {
            return DataProvider.Instance.JsonToDataTable("quiz");
        }
        #endregion
    }
}
