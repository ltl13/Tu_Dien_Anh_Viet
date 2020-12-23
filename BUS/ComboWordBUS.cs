using DAO;
using System.Data;

namespace BUS {
    public class ComboWordBUS {
        #region properties
        private static ComboWordBUS instance;

        public static ComboWordBUS Instance {
            get {
                if (instance == null)
                    instance = new ComboWordBUS();
                return instance;
            }
            private set { instance = value; }
        }

        public ComboWordBUS() { }
        #endregion

        #region method
        public DataTable GetAnimal() {
            return ComboWordDAO.Instance.GetAnimal();
        }
        #endregion
    }
}
