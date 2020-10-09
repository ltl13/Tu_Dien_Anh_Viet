using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TuDienAnhViet {
    public class DictionaryManager {
        #region properties
        private string filePath = @"..\..\resources\data.json";
        private DictionaryItem dicItem;
        public DictionaryItem DicItem { get => dicItem; set => dicItem = value; }
        #endregion

        #region method
        public DictionaryManager() {
            dicItem = (DictionaryItem)DeserializeFromJson(filePath);
        }

        public void LoadDataToListBox(ListBox listbox) {
            listbox.DataSource = dicItem.Items;
        }

        public void SerializeToJson(object data, string filePath) {
            //using (StreamReader)
        }

        public object DeserializeFromJson(string filePath) {
            using (StreamReader r = new StreamReader(filePath)) {
                string json = r.ReadToEnd();
                dicItem = new DictionaryItem();
                dicItem.Items = new List<DictionaryData>();
                dicItem.Items = JsonConvert.DeserializeObject<List<DictionaryData>>(json);
            }
            return dicItem;
        }
        #endregion
    }
}
