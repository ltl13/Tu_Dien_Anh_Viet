using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class ViEnDTO {
        #region properties
        private string vietNamese;
        private string no_Accents_Mark_VietNamese;
        private string english;
        
        public string VietNamese { get => vietNamese; set => vietNamese = value; }
        public string No_Accents_Mark_VietNamese { get => no_Accents_Mark_VietNamese; set => no_Accents_Mark_VietNamese = value; }
        public string English { get => english; set => english = value; }

        public ViEnDTO() { }

        public ViEnDTO(string vietNamese, string no_Accents_Mark_VietNamese, string english) {
            this.vietNamese = vietNamese;
            this.no_Accents_Mark_VietNamese = no_Accents_Mark_VietNamese;
            this.english = english;           
        }

        public ViEnDTO(System.Data.DataRowView row) {
            this.vietNamese = row["VietNamese"].ToString();
            this.no_Accents_Mark_VietNamese = row["No_Accents_Mark_VietNamese"].ToString();
            this.english = row["English"].ToString();            
        }
        #endregion
    }
}
