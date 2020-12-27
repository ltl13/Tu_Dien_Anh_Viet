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
            return DictionaryDAO.Instance.GetEnVi();
        }

        public DataTable GetViEn() {
            return DictionaryDAO.Instance.GetViEn();
        }

        public DataTable GetFillBlank() {
            return DictionaryDAO.Instance.GetFillBlank();
        }

        public DataTable GetQuiz() {
            return DictionaryDAO.Instance.GetQuiz();
        }

        public List<EnViDTO> GetFavorite() {
            return ToList<EnViDTO>(DictionaryDAO.Instance.GetFavorite());
        }

        public List<EnViDTO> GetRecentlyEnVi() {
            return ToList<EnViDTO>(DictionaryDAO.Instance.GetRecentlyEnVi());
        }

        public List<ViEnDTO> GetRecentlyViEn() {
            return ToList<ViEnDTO>(DictionaryDAO.Instance.GetRecentlyViEn());
        }

        public void SetFavorite(List<EnViDTO> favorite) {
            DictionaryDAO.Instance.SetFavorite(ToDataTable<EnViDTO>(favorite));
        }

        public void SetRecentlyEnVi(List<EnViDTO> recentlyEnVi) {
            DictionaryDAO.Instance.SetRecentlyEnVi(ToDataTable<EnViDTO>(recentlyEnVi));
        }

        public void SetRecentlyViEn(List<ViEnDTO> recentlyViEn) {
            DictionaryDAO.Instance.SetRecentlyViEn(ToDataTable<ViEnDTO>(recentlyViEn));
        }
        #endregion
    }
}
