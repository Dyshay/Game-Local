using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelBase
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelBase()
        {
            Type TViewModel = GetType();

            IEnumerable<PropertyInfo> Commands = TViewModel.GetProperties().Where(PI => PI.PropertyType == typeof(ICommand) || PI.PropertyType.GetInterfaces().Contains(typeof(ICommand)));

            foreach (PropertyInfo pi in Commands)
            {
                ICommand cmd = (ICommand)pi.GetMethod.Invoke(this, null);
                PropertyChanged += (s, e) => cmd.RaiseCanExecuteChanged();
            }
        }

        protected void RaisePropertyChanged([CallerMemberName]string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
