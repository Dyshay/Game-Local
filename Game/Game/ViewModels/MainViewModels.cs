using ToolBoxSupp.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.MVVM.Commands;

namespace Game.ViewModels
{
    public class MainViewModels : NavigationPage
    {
        // Crée une ICommand qui va permettre le binding sur la vue
        private ICommand _ConnectBtn;
        public ICommand ConnectBtn
        {
            get { return _ConnectBtn ?? (_ConnectBtn = new RelayCommand(ConnectExec)); }
        }

        private void ConnectExec()
        {
            //Envoi via le médiateur le DataContext
            Mediator<NavigationPage>.Instance.Send(new ConnectViewModel());
        }

        // Constructeur s'abonnant à la méthode changement de ViewModel (Mediator)
        // Et Envoyant le ViewModel directement pour l'affichage de l'accueil
        public MainViewModels()
        {
            Mediator<NavigationPage>.Instance.Register(SwitchView);
            Mediator<NavigationPage>.Instance.Send(new HomeViewModel());
        }
    }
}
