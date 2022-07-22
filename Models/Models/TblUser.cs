using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserNameSurname { get; set; }
        public string UserTcNo { get; set; }
        public string UserMail { get; set; }
        public string UserPhone { get; set; }
        public string UserCarInfo { get; set; }
        public string UserRole { get; set; }
    }
}
