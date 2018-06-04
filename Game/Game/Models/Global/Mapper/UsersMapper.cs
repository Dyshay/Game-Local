using Game.Models.Global.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Global.Mapper
{
    internal static class UsersMapper
    {
        public static Users ToUsers(this IDataRecord Data)
        {
            if (Data == null) throw new ArgumentNullException();

            return new Users()
            {
                Pseudo = (string)Data["Pseudo"],
                Password = (string)Data["Password"],
                Email = (string)Data["Email"],
                IP = (string)Data["IP"],
                Level = (int)Data["Level"],
                Money = (long)Data["Money"]
            };
        }
    }
}
