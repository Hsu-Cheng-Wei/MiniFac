using System;

namespace MiniFac.Contract
{
    public interface ILifetimeScope : IComponentContext, IDisposable
    {
        Guid Id { get; }

        ILifetimeScope BeginLifetimeScope();
    }
}
