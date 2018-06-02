using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ViewModels
{
    public class NavigationPage : ViewModelBase
    {
        // Element qui va servir de switch pour affiché la vue dans le content control
        private NavigationPage _CurrentView;
        public NavigationPage CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value ; RaisePropertyChanged(); }
        }
        
        // Methode permettant au médiateur de changer le Content Control
        public void SwitchView(NavigationPage obj)
        {
            CurrentView = obj;
        }
    }
}
