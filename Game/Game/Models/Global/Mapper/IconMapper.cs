using Game.Models.Global.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Global.Mapper
{
    public static class IconMapper 
    {
        public static Icon ToIcon(this IDataRecord Data)
        {
            if (Data == null) throw new ArgumentNullException();

            return new Icon()
            {
                IconID = (int?)Data["IconID"],
                Access = (string)Data["Access"],
                Level = (int)Data["Level"],
                Nom = (string)Data["Nom"]
            };
        }
    }
}
