using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.Locator;

namespace Game.Models.Client.Services
{
    public class ServiceClientLocator : LocatorBase
    {
        private static ServiceClientLocator _Instance;
        public static ServiceClientLocator Instance
        {
            get { return _Instance ?? (_Instance = new ServiceClientLocator()); }
        }
        public ServiceClientLocator()
        {
            Container.Register<UsersService>();
        }
        public UsersService Users
        {
            get { return Container.GetInstance<UsersService>(); }
        }
    }
}
