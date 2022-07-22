using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    class UserModel
    {
        [Key]
        public string userID { get; set; }
        public string userNameSurname { get; set; }
        public string userTcNo { get; set; }
        public string userMail { get; set; }
        public string userPhone { get; set; }
        public string userCarInfo { get; set; }
        public string userRole { get; set; }
    }
}
