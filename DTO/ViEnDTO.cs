using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class ViEnDTO {
        #region variables
        private string vietNamese;
        private string no_Accents_Mark_VietNamese;
        private string english;
        #endregion

        #region properties
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

        #region method
        public string getEnglishFormat() {
            string[] typeOfWord = { "|*dtừ", "|*ngđtừ", "|*thán từ", "|*ttừ", "|*đại từ", "|*thngữ", "|*nđtừ", "|*đtừ" };
            string temp = english;

            foreach(var word in typeOfWord) {
                if (temp.Contains(word)) {
                    if (temp.IndexOf(word) != 0) {
                        temp = temp.Insert(temp.IndexOf(word), "\n");
                    }
                    if (word == "|*dtừ") {
                        temp = temp.Replace("|*dtừ", "Danh từ");
                    }
                    else if (word == "|*ngđtừ") {
                        temp = temp.Replace("|*ngđtừ", "Ngoại động từ");
                    }
                    else if (word == "|*thán từ") {
                        temp = temp.Replace("|*thán từ", "Thán từ");
                    }
                    else if (word == "|*ttừ") {
                        temp = temp.Replace("|*ttừ", "Tính từ");
                    }
                    else if (word == "|*đại từ") {
                        temp = temp.Replace("|*đại từ", "Đại từ");
                    }
                    else if (word == "|*thngữ") {
                        temp = temp.Replace("|*thngữ", "Thành ngữ");
                    }
                    else if (word == "|*nđtừ") {
                        temp = temp.Replace("|*nđtừ", "Nội động từ");
                    }
                    else if (word == "|*đtừ") {
                        temp = temp.Replace("|*đtừ", "Động từ");
                    }
                }
            }

            temp = temp.Replace("|-", "\n\t➡ ");
            temp = temp.Replace("|=", "\n\t• ");
            return temp;
        }
        #endregion
    }
}
