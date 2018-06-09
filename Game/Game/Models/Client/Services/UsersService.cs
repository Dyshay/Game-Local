using Game.Models.Client.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.Pattern.Repository;

using C = Game.Models.Client.Entity;
using G = Game.Models.Global.Entity;
using SG = Game.Models.Global.Services;
using Game.Models.Client.Mapper;

namespace Game.Models.Client.Services
{
    public class UsersService 
    {

        public IEnumerable<Users> Get()
        {
            return SG.ServiceGlobalLocator.Instance.Users.Get().Select(C => C.ToClient());
        }

        public Users Get(string ID)
        {
            return SG.ServiceGlobalLocator.Instance.Users.Get(ID)?.ToClient();
        }

        public Users Insert(Users Entity)
        {
            return SG.ServiceGlobalLocator.Instance.Users.Insert(Entity.ToGlobal()).ToClient();
        }
    }
}
