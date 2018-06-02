using ToolBoxSupp.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ViewModels
{
    public class MainViewModels : NavigationPage
    {

        // Constructeur s'abonnant à la méthode changement de ViewModel (Mediator)
        // Et Envoyant le ViewModel directement pour l'affichage de l'accueil
        public MainViewModels()
        {
            Mediator<NavigationPage>.Instance.Register(SwitchView);
            Mediator<NavigationPage>.Instance.Send(new HomeViewModel());
        }
    }
}
