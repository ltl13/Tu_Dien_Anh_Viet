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
        #endregion
    }
}
