﻿using System;
using System.Text;

namespace DTO {
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

        public string getPronunciation() {
            return vietNamese.Substring(0, vietNamese.IndexOf('|', vietNamese.IndexOf('|') + 1)).Replace("|@", "").Replace(english, "").Trim();
        }

        public string getVietNameseFormat() {
            vietNamese = vietNamese.Replace("|@", "");
            vietNamese = vietNamese.Replace("&quot;", "\"");
            vietNamese = vietNamese.Replace("&amp;", "&");
            vietNamese = vietNamese.Replace("|*", "\n");
            vietNamese = vietNamese.Replace("|-!", "\n\t➡ ");
            vietNamese = vietNamese.Replace("|-", "\n\t➡ ");
            vietNamese = vietNamese.Replace("|=", "\n\t• ");
            for (var i = vietNamese.IndexOf('\n'); i < vietNamese.Length - 2; i++) {
                if (vietNamese[i] == ':' && vietNamese[i + 1] != ' ') {
                    vietNamese = vietNamese.Remove(i, 1);
                    vietNamese = vietNamese.Insert(i, "\n\t   ");
                }
            }
            return vietNamese;
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
