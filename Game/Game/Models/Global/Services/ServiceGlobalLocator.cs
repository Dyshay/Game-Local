using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.Locator;

namespace Game.Models.Global.Services
{
    public class ServiceGlobalLocator : LocatorBase
    {
        private static ServiceGlobalLocator _Instance;
        public static ServiceGlobalLocator Instance
        {
            get { return _Instance ?? (_Instance = new ServiceGlobalLocator()); }
        }
        public ServiceGlobalLocator()
        {
            Container.Register<UsersService>();
        }
        public UsersService Users
        {
            get { return Container.GetInstance<UsersService>(); }
        }
    }
}
