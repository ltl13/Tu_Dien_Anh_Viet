using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

        public void SaveRecentlyWord(List<EnViDTO> recently) {
            DictionaryDAO.Instance.SaveRecentlyWord(recently);
        }

        public List<EnViDTO> LoadRecentlyWord() {
            return DictionaryDAO.Instance.LoadRecentlyWord();
        }

        public string run_cmd(string cmd, string args) {
            return DictionaryDAO.Instance.run_cmd(cmd, args);
        }
        #endregion
    }
}
