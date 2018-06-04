using Game.Models.Client.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Game.ViewModels
{
    public class GameViewModel : NavigationPage
    {
        private string _Pseudo;

        public string Pseudo
        {
            get { return _Pseudo; }
            set { _Pseudo = value; RaisePropertyChanged(); }
        }
        private string _IP;

        public string IP
        {
            get { return _IP; }
            set { _IP = value; RaisePropertyChanged(); }
        }
        private string _Level;

        public string Level
        {
            get { return _Level; }
            set { _Level = value; RaisePropertyChanged(); }
        }

        private string _Money;

        public string Money
        {
            get { return _Money; }
            set { _Money = value; RaisePropertyChanged(); }
        }
        private string _Heure;
        public string Heure
        {
            get {
                return _Heure;
                }
            set
            {
                _Heure = value;
                RaisePropertyChanged();
            }
        }

        public Dispatcher Dispatcher { get; }

        public GameViewModel(Users User)
        {
            Pseudo = User.Pseudo;
            IP = User.IP;
            Level = $"Niveau : {User.Level}";
            Money = $"{User.Money} €";
            //DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate 
            //{
            //    Heure = DateTime.Now.ToString("HH:mm");
            //}, Dispatcher);
        }
        //TODO Rajouter un méthode permettant d'afficher l'heure.
    }
}
