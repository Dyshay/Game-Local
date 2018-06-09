using C = Game.Models.Client.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Models.Global.Entity;

namespace Game.Models.Client.Mapper
{
    public static class MU_IconMapper
    {
        public static C.MU_Icon ToClient(this MU_Icon Entity)
        {
            return new C.MU_Icon(Entity.UserID, Entity.IconID);
        }
        public static MU_Icon ToGlobal(this C.MU_Icon Entity)
        {
            return new MU_Icon()
            {
                UserID = Entity.UserID,
                IconID = Entity.IconID
            };
        }
    }
}
