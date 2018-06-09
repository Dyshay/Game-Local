using C = Game.Models.Client.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Models.Global.Services;
using Game.Models.Client.Mapper;

namespace Game.Models.Client.Services
{
    public class MU_IconService
    {
        public IEnumerable<C.MU_Icon> Get()
        {
            return ServiceGlobalLocator.Instance.MUIcon.Get().Select(e => e.ToClient());
        }
    }
}
