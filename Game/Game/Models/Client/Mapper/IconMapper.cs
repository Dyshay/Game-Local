using C = Game.Models.Client.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Models.Global.Entity;

namespace Game.Models.Client.Mapper
{
    public static class IconMapper
    {
        public static C.Icon ToClient(this Icon Entity)
        {
            return new C.Icon(Entity.IconID,Entity.Nom,Entity.Access,Entity.Level);
        }
        public static Icon ToGlobal(this C.Icon Entity)
        {
            return new Icon()
            {
                IconID = Entity.IconID,
                Access = Entity.Access,
                Level = Entity.Level,
                Nom = Entity.Nom
            };
        }
    }
}
