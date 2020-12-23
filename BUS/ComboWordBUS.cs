using DAO;
using System.Data;

namespace BUS {
    public class ComboWordBUS {
        #region variables
        private static ComboWordBUS instance;
        #endregion

        #region properties
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
        public DataSet GetDataSet(string fileName) {
            return ComboWordDAO.Instance.GetDataSet(fileName);
        }
        #endregion
    }
}
