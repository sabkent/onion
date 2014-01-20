using System;

namespace Core.Commands
{
    public interface IHandleCommand<T>
    {
        void Handle(T command);
    }
}
