using Game.ViewModels.Application.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxNET.MVVM.Command;
using ToolBoxNET.Pattern.Mediator;

namespace Game.ViewModels.Application
{
    public class NavigationVMApp : GameViewModel
    {
        private string _Url;
        public string Url
        {
            get { return _Url; }
            set { _Url = value; RaisePropertyChanged(); }
        }
        private NavigationVMApp _Website;
        public NavigationVMApp Website
        {
            get { return _Website; }
            set { _Website = value; RaisePropertyChanged(); }
        }
        private ICommand _SendWebsite;
        public ICommand SendWebsite
        {
            get { return _SendWebsite ?? (_SendWebsite = new RelayCommand(SendWebExec,SendWebCanExec)); }
        }

        private bool SendWebCanExec()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SendWebExec()
        {
            switch (Url)
            {
                case "http://market.com": Mediator<NavigationVMApp>.Instance.Send(new MarketVM());
                    break;
                default: Mediator<NavigationVMApp>.Instance.Send(new NotFoundVM());
                    break;
            }
        }
        private ICommand _CloseNav;
        public ICommand CloseNav
        {
            get { return _CloseNav ?? (_CloseNav = new RelayCommand(CloseExec)); }
        }

        private void CloseExec()
        {
            Mediator<GameViewModel>.Instance.Send(new GameViewModel());
        }

        public NavigationVMApp()
        {
            Mediator<NavigationVMApp>.Instance.Register(AffichageWebSite);
        }

        private void AffichageWebSite(NavigationVMApp obj)
        {
            Website = obj;
        }
    }
}
