using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Commands;
using Ninject;
using Ninject.Syntax;

namespace Infrastructure
{
    public class ContainerCommandDispatcher : IDispatchCommands
    {
        private readonly IResolutionRoot _container;
        public ContainerCommandDispatcher(IResolutionRoot container)
        {
            _container = container;
        }

        public void Dispatch<T>(T command)
        {
            var handler = _container.Get<IHandleCommand<T>>();
            handler.Handle(command);
        }
    }
}
