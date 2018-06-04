using Game.Models.Client.Entity;
using Game.Models.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToolBoxSupp.Command;
using ToolBoxSupp.Mediator;

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
            UsersService UserS = new UsersService();
            Users UserRecup = UserS.Get(Pseudo);

            if(UserRecup == null)
            {
                MessageBox.Show("Pseudo ou mot de passe incorrect");
                Pseudo = "";
                Password = "";
            }
            else
            {
                if (UserRecup.Pseudo == Pseudo && UserRecup.Password == Password)
                {
                    Mediator<NavigationPage>.Instance.Send(new GameViewModel(UserRecup));
                }
                else
                {
                    MessageBox.Show("Pseudo ou mot de passe incorrect"); ;
                    Pseudo = "";
                    Password = "";
                }
            }
            // Rajouter le model qui permettra de récuperer les infos en db pour évalué la connexion si l'utilisateur existe bien
        }
    }
}
