using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllenBank.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T> (T @event) where T : Event;
        void Subscribe<TEvent, THandler> () where TEvent : Event where THandler : IEventHandler;
    }
}
