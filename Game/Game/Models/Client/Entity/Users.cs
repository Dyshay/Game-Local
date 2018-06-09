using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Client.Entity
{
    public class Users
    {
        public int? UserID { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string IP { get; set; }
        public long Money { get; set; }
        public int Level { get; set; }

        internal Users(int? userID,string pseudo,string password,string email, string ip, long money,int level)
        {
            UserID = userID;
            Pseudo = pseudo;
            Password = password;
            Email = email;
            IP = ip;
            Money = money;
            Level = level;
        }
        public Users(string pseudo,string password, string email,string ip,long money):this(0,pseudo,password,email,ip,money,1)
        {

        }
        public Users(string pseudo,string password)
        {

        }
    }
}
