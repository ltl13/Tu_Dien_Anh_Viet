using DAO;
using DTO;
using Newtonsoft.Json;
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
        public DataTable GetListItem(string input) {
            return DictionaryDAO.Instance.GetListItem(input);
        }

        public void LoadDataToComboBox(ComboBox listbox, string input = null) {
            if (input == null || input == "")
                return;

            listbox.DataSource = GetListItem(input);
        }

        public bool AddFavorite(AccountDTO loginAccount, EnViDTO word) {
            return DictionaryDAO.Instance.AddFavorite(loginAccount, word);
        }

        public DataTable GetListFavorite(AccountDTO loginAccount) {
            return DictionaryDAO.Instance.GetListFavorite(loginAccount);
        }

        public List<EnViDTO> LoadJsonEnVi() {
            List<EnViDTO> DicEnVi = new List<EnViDTO>();

            using (System.IO.StreamReader r = new System.IO.StreamReader(@"..\..\..\resources\en-vi.json")) {
                string json = r.ReadToEnd();
                DicEnVi = JsonConvert.DeserializeObject<List<EnViDTO>>(json);
            }

            return DicEnVi;
        }

        public List<ViEnDTO> LoadJsonViEn() {
            List<ViEnDTO> DicViEn = new List<ViEnDTO>();

            using (System.IO.StreamReader r = new System.IO.StreamReader(@"..\..\..\resources\vi-en.json")) {
                string json = r.ReadToEnd();
                DicViEn = JsonConvert.DeserializeObject<List<ViEnDTO>>(json);
            }

            return DicViEn;
        }
        #endregion
    }
}
