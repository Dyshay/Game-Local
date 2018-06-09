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
    public class IconService
    {
        public IEnumerable<C.Icon> Get()
        {
            return ServiceGlobalLocator.Instance.Icon.Get().Select(a => a.ToClient());
        }
    }
}
