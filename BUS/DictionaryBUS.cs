using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace BUS {
    public class DictionaryBUS {
        #region properties
        private static DictionaryBUS instance;

        public static DictionaryBUS Instance {
            get {
                if (instance == null)
                    instance = new DictionaryBUS();
                return instance;
            }
            private set { instance = value; }
        }

        public DictionaryBUS() { }
        #endregion

        #region method
        private static List<T> ToList<T>(DataTable dataTable) {
            List<T> data = new List<T>();
            foreach (DataRow row in dataTable.Rows) {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public DataTable ToDataTable<T>(List<T> items) {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props) {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        private static T GetItem<T>(DataRow dr) {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns) {
                foreach (PropertyInfo pro in temp.GetProperties()) {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public DataTable GetEnVi() {
            return DictionaryDAO.Instance.GetDictionary("_en_vi");
        }

        public DataTable GetViEn() {
            return DictionaryDAO.Instance.GetDictionary("_vi_en");
        }

        public List<EnViDTO> GetFavorite() {
            return ToList<EnViDTO>(DictionaryDAO.Instance.GetDictionary("favorite"));
        }

        public List<EnViDTO> GetRecentlyEnVi() {
            return ToList<EnViDTO>(DictionaryDAO.Instance.GetDictionary("recently_en_vi"));
        }

        public List<ViEnDTO> GetRecentlyViEn() {
            return ToList<ViEnDTO>(DictionaryDAO.Instance.GetDictionary("recently_vi_en"));
        }

        public DataTable GetFillBlank() {
            return DictionaryDAO.Instance.GetGame("fill_blank");
        }

        public DataTable GetQuiz() {
            return DictionaryDAO.Instance.GetGame("quiz");
        }

        public DataSet GetVocabulary(string fileName) {
            return DictionaryDAO.Instance.GetVocabulary(fileName);
        }

        public void SetFavorite(List<EnViDTO> favorite) {
            DictionaryDAO.Instance.SetDictionary(ToDataTable<EnViDTO>(favorite), "favorite");
        }

        public void SetRecentlyEnVi(List<EnViDTO> recentlyEnVi) {
            DictionaryDAO.Instance.SetDictionary(ToDataTable<EnViDTO>(recentlyEnVi), "recently_en_vi");
        }

        public void SetRecentlyViEn(List<ViEnDTO> recentlyViEn) {
            DictionaryDAO.Instance.SetDictionary(ToDataTable<ViEnDTO>(recentlyViEn), "recently_vi_en");
        }
        #endregion
    }
}
