using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.Pattern.Locator;

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
            Container.Register<IconService>();
            Container.Register<MU_IconService>();
        }
        public UsersService Users
        {
            get { return Container.GetInstance<UsersService>(); }
        }
        public IconService Icon
        {
            get { return Container.GetInstance<IconService>(); }
        }
        public MU_IconService MUIcon
        {
            get { return Container.GetInstance<MU_IconService>(); }
        }
    }
}
