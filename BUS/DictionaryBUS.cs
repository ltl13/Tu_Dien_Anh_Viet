using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

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
        public List<EnViDTO> GetEnViList() {
            return DictionaryDAO.Instance.GetEnViList();
        }

        public DataTable GetEnViTable() {
            return DictionaryDAO.Instance.GetEnViTable();
        }

        public List<ViEnDTO> GetViEnList() {
            return DictionaryDAO.Instance.GetViEnList();
        }

        public DataTable GetViEnTable() {
            return DictionaryDAO.Instance.GetViEnTable();
        }

        public void SaveFavoriteWord(List<EnViDTO> Favorite) {
            DictionaryDAO.Instance.SaveFavoriteWord(Favorite);
        }

        public List<EnViDTO> LoadSavedFavoriteWord() {
            return DictionaryDAO.Instance.LoadSavedFavoriteWord();
        }

        public void SaveRecentlyWordEnVi(List<EnViDTO> recently) {
            DictionaryDAO.Instance.SaveRecentlyWordEnVi(recently);
        }

        public List<EnViDTO> LoadRecentlyWordEnVi() {
            return DictionaryDAO.Instance.LoadRecentlyWordEnVi();
        }

        public void SaveRecentlyWordViEn(List<ViEnDTO> recently) {
            DictionaryDAO.Instance.SaveRecentlyWordViEn(recently);
        }

        public List<ViEnDTO> LoadRecentlyWordViEn() {
            return DictionaryDAO.Instance.LoadRecentlyWordViEn();
        }

        public DataTable GetQuiz()
        {
            return DictionaryDAO.Instance.GetQuiz();
        }

        public DataTable GetFillBlank()
        {
            return DictionaryDAO.Instance.GetFillBlank();
        }
        #endregion
    }
}
