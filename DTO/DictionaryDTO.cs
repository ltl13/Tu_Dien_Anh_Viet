using System.Data;

namespace DTO {
    public class DictionaryDTO {
        #region properties
        private string english;
        private string vietNamese;

        public string English { get => english; set => english = value; }
        public string VietNamese { get => vietNamese; set => vietNamese = value; }

        public DictionaryDTO() { }

        public DictionaryDTO(string english, string vietNamese) {
            this.english = english;
            this.vietNamese = vietNamese;
        }

        public DictionaryDTO(DataRow row) {
            this.english = row["English"].ToString();
            this.vietNamese = row["VietNamese"].ToString();
        }
        #endregion
    }
}
