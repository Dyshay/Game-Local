using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxSupp.Command
{
    public class RelayCommandParameter : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> _Execute;
        private readonly Func<bool> _CanExecute;

        public RelayCommandParameter(Action<object> Execute) : this(Execute, null)
        {

        }

        public RelayCommandParameter(Action<object> Execute, Func<bool> CanExecute)
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
            _Execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
