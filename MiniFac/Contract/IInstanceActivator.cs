using System;

namespace MiniFac.Contract
{
    public interface IInstanceActivator
    {
        object ActivateInstance(IComponentContext context);

        Type LimitType { get; }
    }
}
