using Game.Models.Global.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Global.Mapper
{
    public static class MU_IconMapper
    {
        public static MU_Icon ToMUIcon(this IDataRecord data)
        {
            if (data == null) throw new ArgumentNullException();

            return new MU_Icon()
            {
                IconID = (int)data["IconID"],
                UserID = (int)data["UserID"]
            };
        }
    }
}
