using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBoxSupp.Command;

namespace ToolBoxSupp.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _Execute;
        private readonly Func<bool> _CanExecute;

        public RelayCommand(Action Execute) : this(Execute, null)
        {

        }

        public RelayCommand(Action Execute, Func<bool> CanExecute)
        {
            if (Execute == null)
                throw new ArgumentNullException("Execute");

            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        public bool CanExecute(object parameter)
        {
            return (_CanExecute == null) ? true : _CanExecute();
        }

        public void Execute(object parameter)
        {
            _Execute();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
