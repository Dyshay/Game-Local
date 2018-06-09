using Game.Models.Client.Entity;
using Game.Models.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToolBoxNET.MVVM.Command;
using ToolBoxNET.Pattern.Mediator;

namespace Game.ViewModels
{
    public class ConnectViewModel : NavigationPage
    {
        private string _Pseudo;

        public string Pseudo    
        {
            get { return _Pseudo; }
            set { _Pseudo = value; RaisePropertyChanged(); }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; RaisePropertyChanged(); }
        }
        private ICommand _ConnectBtn;
        public ICommand ConnectBtn
        {
            get { return _ConnectBtn ?? (_ConnectBtn = new RelayCommand(ConnectExec,ConnectCanExec)); }
        }

        private bool ConnectCanExec()
        {
            if (!string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Pseudo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ConnectExec()
        {
            Users U = ServiceClientLocator.Instance.Users.Get(Pseudo);

            if(U == null)
            {
                MessageBox.Show("Pseudo ou mot de passe incorrect");
                Pseudo = "";
                Password = "";
            }
            else
            {
                if (U.Pseudo == Pseudo && U.Password == Password)
                {
                    //Mediator<NavigationPage>.Instance.Unregister(Remo)
                    Mediator<NavigationPage>.Instance.Send(new GameViewModel(U));
                }
                else
                {
                    MessageBox.Show("Pseudo ou mot de passe incorrect"); ;
                    Pseudo = "";
                    Password = "";
                }
            }
        }
    }
}
