using Models.Models;
using System;

namespace ExecuterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TblUser tu = new TblUser();
            //tu.UserNameSurname = "Kadir Akalın";
            //tu.UserMail = "kadirakalindev@gmail.com";
           
            using (var conn = new TODEBProjeDBContext())
            {
                var user = new TblUser
                {
                    UserNameSurname = "Kadir Akalın",
                    UserMail = "kadirakalindev@gmail.com",
                    UserPhone = "5416510577",
                    UserCarInfo = "16ANR973",
                    UserRole = "Kiraci",
                    UserTcNo = "11111111111"
                };
                conn.TblUsers.Add(user);
                conn.SaveChanges();
            }

        }
    }
}
