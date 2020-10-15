using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    [Serializable]
    public class DictionaryItem {
        private List<DictionaryData> items;
        public List<DictionaryData> Items { get => items; set => items = value; }
    }
}
