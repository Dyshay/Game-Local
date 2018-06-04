using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using C = Game.Models.Client.Entity;
using G = Game.Models.Global.Entity;

namespace Game.Models.Client.Mapper
{
    public static class UsersMapper
    {
        public static C.Users ToClient (this G.Users Entity)
        {
            return new C.Users(Entity.Pseudo, Entity.Password, Entity.Email, Entity.IP, Entity.Money, Entity.Level);
        }
        public static G.Users ToGlobal (this C.Users Entity)
        {
            return new G.Users()
            {
                Pseudo = Entity.Pseudo,
                Password = Entity.Password,
                Email = Entity.Email,
                Money = Entity.Money,
                Level = Entity.Level,
                IP = Entity.IP
            };
        }
    }
}
