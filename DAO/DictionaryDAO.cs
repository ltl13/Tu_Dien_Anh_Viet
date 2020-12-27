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
        public DataTable GetEnVi() {
            return DataProvider.Instance.JsonToDataTable("en-vi");
        }

        public DataTable GetViEn() {
            return DataProvider.Instance.JsonToDataTable("vi-en");
        }

        public DataTable GetFillBlank() {
            return DataProvider.Instance.JsonToDataTable("fillBlank");
        }

        public DataTable GetQuiz() {
            return DataProvider.Instance.JsonToDataTable("quiz");
        }

        public DataTable GetFavorite() {
            return DataProvider.Instance.JsonToDataTable("favorite");
        }

        public DataTable GetRecentlyEnVi() {
            return DataProvider.Instance.JsonToDataTable("recentlyEnVi");
        }

        public DataTable GetRecentlyViEn() {
            return DataProvider.Instance.JsonToDataTable("recentlyViEn");
        }

        public void SetFavorite(DataTable favorite) {
            DataProvider.Instance.DataTableToJson(favorite, "favorite");
        }

        public void SetRecentlyEnVi(DataTable recentlyEnVi) {
            DataProvider.Instance.DataTableToJson(recentlyEnVi, "recentlyEnVi");
        }

        public void SetRecentlyViEn(DataTable recentlyViEn) {
            DataProvider.Instance.DataTableToJson(recentlyViEn, "recentlyViEn");
        }
        #endregion
    }
}
