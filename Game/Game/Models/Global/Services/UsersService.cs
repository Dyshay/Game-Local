using Game.Models.Global.Entity;
using Game.Models.Global.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.Connection.Database;

namespace Game.Models.Global.Services
{
    public class UsersService 
    {

        public  IEnumerable<Users> Get()
        {
            Command cmd = new Command("SELECT * FROM Users");
            return AccessLocator.Instance.Connection.ExecuteReader(cmd, c => c.ToUsers());
        }

        public  Users Get(string ID)
        {
            Command cmd = new Command("SELECT * FROM Users WHERE Pseudo = @Pseudo ");
            cmd.AddParameter("Pseudo", ID);
            return AccessLocator.Instance.Connection.ExecuteReader(cmd, c => c.ToUsers()).SingleOrDefault();
        }

        public Users Insert(Users Entity)
        {
            Command cmd = new Command("Proc_Adduser", true);
            cmd.AddParameter("Username", Entity.Pseudo);
            cmd.AddParameter("Password", Entity.Password);
            cmd.AddParameter("Money", Entity.Money);
            cmd.AddParameter("IP", Entity.IP);
            cmd.AddParameter("Email", Entity.Email);

            AccessLocator.Instance.Connection.ExecuteScalar(cmd);
            return Entity;
        }
        
    }
}
