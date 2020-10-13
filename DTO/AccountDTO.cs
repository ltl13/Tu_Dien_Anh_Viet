using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class AccountDTO {
        private string id;
        private string name;
        private string info;
        private DateTime DateOfBirth;
        private string gender;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Info { get => info; set => info = value; }
        public DateTime DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }

        public AccountDTO(string id, string name, string info, DateTime dob, string gender) {
            this.id = id;
            this.name = name;
            this.info = info;
            this.DateOfBirth = dob;
            this.gender = gender;
        }
    }
}
