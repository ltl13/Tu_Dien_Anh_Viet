﻿namespace DTO {
    public class EnViDTO {
        #region properties
        private string english;
        private string vietNamese;

        public string English { get => english; set => english = value; }
        public string VietNamese { get => vietNamese; set => vietNamese = value; }

        public EnViDTO() { }

        public EnViDTO(string english, string vietNamese) {
            this.english = english;
            this.vietNamese = vietNamese;
        }

        public EnViDTO(System.Data.DataRowView row) {
            this.english = row["English"].ToString();
            this.vietNamese = row["VietNamese"].ToString();
        }

        public EnViDTO(System.Data.DataRow row) {
            this.english = row["English"].ToString();
            this.vietNamese = row["VietNamese"].ToString();
        }

        public static bool operator ==(EnViDTO word1, EnViDTO word2) {
            if (word1.english == word2.english && word1.vietNamese == word2.vietNamese) {
                return true;
            }
            return false;
        }

        public static bool operator !=(EnViDTO word1, EnViDTO word2) {
            if (word1.english == word2.english && word1.vietNamese == word2.vietNamese) {
                return false;
            }
            return true;
        }

        public bool Equals(EnViDTO other) {
            return this == other;
        }

        public override int GetHashCode() {
            return 1;
        }

        public override bool Equals(object obj) {
            return Equals(obj as EnViDTO);
        }

        public string getPronunciation() {
            return vietNamese.Substring(0, vietNamese.IndexOf('|', vietNamese.IndexOf('|') + 1)).Replace("|@", "").Replace(english, "").Trim();
        }

        public string getVietNameseFormat() {
            string temp = vietNamese;
            temp = temp.Replace("|@", "");
            temp = temp.Replace("&quot;", "\"");
            temp = temp.Replace("&amp;", "&");
            temp = temp.Replace("&lt;y&gt;", "(y học)");
            temp = temp.Replace("&lt;thgt&gt;", "(thông tục)");
            temp = temp.Replace("|*", "\n");
            temp = temp.Replace("|-!", "\n\t➡ ");
            temp = temp.Replace("|-", "\n\t➡ ");
            temp = temp.Replace("|=", "\n\t• ");
            for (var i = temp.IndexOf('\n'); i < temp.Length - 2; i++) {
                if (temp[i] == ':' && temp[i + 1] != ' ') {
                    temp = temp.Remove(i, 1);
                    temp = temp.Insert(i, "\n\t   ");
                }
            }
            return temp;
        }

        public string getCommonMeaning() {
            string temp = vietNamese;
            temp = temp.Replace("&quot;", "\"");
            temp = temp.Replace("&amp;", "&");
            temp = temp.Replace("&lt;y&gt;", "(y học)");
            temp = temp.Replace("&lt;thgt&gt;", "(thông tục)");
            string[] arr = temp.Split('|');

            foreach (string str in arr)
                if (str.Insert(0, "|").Contains("|-"))
                    return str.Replace("-", "");

            return null;
        }

        //public static bool operator ==(EnViDTO temp1, EnViDTO temp2) {
        //    if (temp1.English == temp2.English && temp1.VietNamese == temp2.VietNamese)
        //        return true;
        //    return false;
        //}

        //public static bool operator !=(EnViDTO temp1, EnViDTO temp2) {
        //    if (temp2 == null && temp1.English == null && temp1.VietNamese == null)
        //        return true;
        //    if (temp1.English == temp2.English && temp1.VietNamese == temp2.VietNamese)
        //        return false;
        //    return true;
        //}

        //public bool Equals(EnViDTO obj) {
        //    if (this.English == obj.English && this.VietNamese == obj.VietNamese)
        //        return true;
        //    return false;
        //}
        #endregion
    }
}
