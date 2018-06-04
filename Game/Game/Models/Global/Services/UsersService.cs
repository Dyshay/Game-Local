using Game.Models.Global.Entity;
using Game.Models.Global.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections;
using ToolBox.Patterns.Repository;

namespace Game.Models.Global.Services
{
    public class UsersService : ServiceBase<string, Users>, IDataService<string,Users>
    {

        public override IEnumerable<Users> Get()
        {
            Command cmd = new Command("SELECT * FROM Users");
            return Context.ExecuteReader(cmd, MapperToGlobal);
        }

        public override Users Get(string ID)
        {
            Command cmd = new Command("SELECT * FROM Users WHERE Pseudo = @Pseudo ");
            cmd.AddParameter("Pseudo", ID);
            return Context.ExecuteReader(cmd, MapperToGlobal).SingleOrDefault();
        }

        public override Users Insert(Users Entity)
        {
            Command cmd = new Command("INSERT INTO Users(Pseudo,Money,IP,Password,Email) VALUES (@Pseudo,@Money,@IP,@Password,@Email)");
            cmd.AddParameter("Pseudo", Entity.Pseudo);
            cmd.AddParameter("Money", Entity.Money);
            cmd.AddParameter("IP", Entity.IP);
            cmd.AddParameter("Password", Entity.Password);
            cmd.AddParameter("Email", Entity.Email);
            Context.ExecuteNonQuery(cmd);
            return Entity;
        }

        public override bool Update(Users Entity)
        {
            throw new NotImplementedException();
        }
        public override bool Delete(string ID)
        {
            throw new NotImplementedException();
        }

        protected override Users MapperToGlobal(IDataRecord Data)
        {
            return Data.ToUsers();
        }
    }
}
