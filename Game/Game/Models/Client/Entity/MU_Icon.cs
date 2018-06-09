using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Client.Entity
{
    public class MU_Icon
    {
        public int UserID { get; set; }
        public int IconID { get; set; }

        public MU_Icon(int userid,int iconid)
        {
            UserID = userid;
            IconID = iconid;
        }
    }
}
