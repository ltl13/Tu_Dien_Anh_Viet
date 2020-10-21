using DAO;
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

        private DictionaryBUS() { }
        #endregion

        #region method
        public DataTable GetListItem(string input) {
            return DictionaryDAO.Instance.GetListItem(input);
        }

        public void LoadDataToComboBox(ComboBox listbox, string input = null) {
            if (input == null || input == "")
                return;

            listbox.DataSource = GetListItem(input);
        }

        public bool AddFavorite(DTO.AccountDTO loginAccount, DTO.DictionaryDTO word) {
            return DictionaryDAO.Instance.AddFavorite(loginAccount, word);
        }

        public System.Data.DataTable GetListFavorite(DTO.AccountDTO loginAccount) {
            return DictionaryDAO.Instance.GetListFavorite(loginAccount);
        }

        //public void LoadJsonToComboBox() {
        //    using (System.IO.StreamReader r = new System.IO.StreamReader(@"..\..\..\resources\en-vi.json")) {
        //        string json = r.ReadToEnd();
        //        List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
        //    }
        //}
        #endregion
    }
}
