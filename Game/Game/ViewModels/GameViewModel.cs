using Game.Models.Client.Entity;
using Game.Models.Client.Services;
using Game.ViewModels.Application;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Threading;
using ToolBoxSupp.Command;
using ToolBoxSupp.Mediator;

namespace Game.ViewModels
{
    public class GameViewModel : NavigationPage
    {
        #region Propiété
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
        private DateTime _Heure;
        public DateTime Heure
        {
            get
            {
                return _Heure;
            }
            set
            {
                _Heure = value;
                RaisePropertyChanged();
            }
        }
        private GameViewModel _Software;
        public GameViewModel Software
        {
            get { return _Software; }
            set { _Software = value; RaisePropertyChanged(); }
        }
        #endregion

        #region List
        private ObservableCollection<Icon> _IconDesktop;
        public ObservableCollection<Icon> IconDesktop
        {
            get { return _IconDesktop ?? (_IconDesktop = new ObservableCollection<Icon>()); }
        }
        #endregion

        #region Constructeur

        public GameViewModel()
        {

        }
        internal GameViewModel(Users User)
        {
            Pseudo = User.Pseudo;
            IP = User.IP;
            Level = $"Niveau : {User.Level}";
            Money = $"{User.Money} €";

            Heure = DateTime.Now;
            DispatcherTimer Dt = new DispatcherTimer();
            Dt.Interval = new TimeSpan(0, 0, 1);
            Dt.Tick += (s, e) => Heure = DateTime.Now;
            Dt.Start();
            Mediator<GameViewModel>.Instance.Register(DisplayApp);
            ToAddList();
        }
        #endregion

        #region Bouton
        private void DisplayApp(GameViewModel obj)
        {
            Software = obj;
        }
        private ICommand _NavigatorBtn;
        public ICommand NavigatorBtn
        {
            get { return _NavigatorBtn ?? (_NavigatorBtn = new RelayCommand(NavExec)); }
        }

        private void NavExec()
        {
            Mediator<GameViewModel>.Instance.Send(new NavigationVMApp());
        }
        #endregion

        private ICommand _IconBtn;
        public ICommand IconBtn
        {
            get { return _IconBtn ?? (_IconBtn = new RelayCommandParameter((Nom) => IconBtnExec(Nom))); }
        }

        private void IconBtnExec(object Nom)
        {
            switch (Nom)
            {
                case "Navigateur": Mediator<GameViewModel>.Instance.Send(new NavigationVMApp());
                    break;
                default:
                    break;
            }
        }

        #region Methode Generation List
        private void ToAddList()
        {
            foreach (Users user in ServiceClientLocator.Instance.Users.Get())
            {
                if (user.Pseudo == Pseudo)
                {
                    foreach (Icon icon in ServiceClientLocator.Instance.Icon.Get())
                    {
                        foreach (MU_Icon item in ServiceClientLocator.Instance.MUIcon.Get())
                        {
                            if (user.UserID == item.UserID && icon.IconID == item.IconID)
                            {
                                IconDesktop.Add(icon);
                            }

                        }
                    }
                }
            }
        }
#endregion

    }
}
