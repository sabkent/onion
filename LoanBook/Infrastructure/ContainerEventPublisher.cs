
using Core;
using Core.Events;
using NHibernate.Linq;
using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public sealed class ContainerEventPublisher : IRaiseEvents
    {
        private readonly IResolutionRoot _resolutionRoot;

        public ContainerEventPublisher(IResolutionRoot resolutionRoot)
        {
            _resolutionRoot = resolutionRoot;
        }

        public void Publish<T>(T @event)
        {
            var subscribers = _resolutionRoot.GetAll<ISubscribeToEvent<T>>();
            subscribers.ToList().AsParallel().ForEach(subscriber => subscriber.Notify(@event));
        }
    }
}
