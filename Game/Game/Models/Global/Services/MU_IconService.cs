using Game.Models.Global.Entity;
using Game.Models.Global.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.Connection.Database;

namespace Game.Models.Global.Services
{
    public class MU_IconService
    {
        public IEnumerable<MU_Icon> Get()
        {
            Command cmd = new Command("SELECT * FROM MUserIcon");
            return AccessLocator.Instance.Connection.ExecuteReader(cmd, (e) => e.ToMUIcon());
        }
    }
}
