using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxSupp.Mediator
{
    public class Mediator<TMessage>
    {
        private static Mediator<TMessage> _Instance;

        public static Mediator<TMessage> Instance
        {
            get
            {
                return _Instance ?? (_Instance = new Mediator<TMessage>());
            }
        }

        private Action<TMessage> _Broadcast;

        protected Mediator()
        {
        }

        public void Register(Action<TMessage> Method)
        {
            _Broadcast += Method;
        }

        public void Unregister(Action<TMessage> Method)
        {
            _Broadcast -= Method;
        }

        public void Send(TMessage Message)
        {
            _Broadcast?.Invoke(Message);
        }
    }
}
