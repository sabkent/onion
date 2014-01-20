using System;

namespace Core
{
    public interface IDispatchCommands
    {
        void Dispatch<T>(T command);
    }
}
