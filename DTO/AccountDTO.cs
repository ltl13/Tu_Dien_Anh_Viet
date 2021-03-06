﻿using System.Data;

namespace DTO {
    public class AccountDTO {
        private int iD;
        private string userName;
        private string displayName;
        private string passWord;

        public int ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public AccountDTO() { }

        public AccountDTO(string userName, string displayName, string passWord = null) {
            this.userName = userName;
            this.displayName = displayName;
            this.passWord = passWord;
        }

        public AccountDTO(DataRow row) {
            this.iD = (int)row["ID"];
            this.userName = row["UserName"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.passWord = row["PassWord"].ToString();
        }
    }
}
