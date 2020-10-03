using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDienAnhViet {
    [Serializable]
    public class DictionaryItems {
        private List<DictionaryData> items;
        public List<DictionaryData> Items { get => items; set => items = value; }
    }
}
