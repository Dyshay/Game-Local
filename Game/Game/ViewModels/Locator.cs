using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.Locator;

namespace Game.ViewModels
{
    public class Locator : LocatorBase
    {
        private static Locator _Instance;
        public static Locator Instance
        {
            get { return _Instance ?? (_Instance = new Locator()); }
        }
        public Locator()
        {
            Container.Register<GenerationIP>();
            Container.Register<GameViewModel>();
            Container.Register<ConnectViewModel>();
        }
        public GenerationIP GenerateIP
        {
            get { return Container.GetInstance<GenerationIP>(); }
        }
        public GameViewModel GameVM
        {
            get { return Container.GetInstance<GameViewModel>(); }
        }
        public ConnectViewModel ConnectVM
        {
            get { return Container.GetInstance<ConnectViewModel>(); }
        }
    }
}
