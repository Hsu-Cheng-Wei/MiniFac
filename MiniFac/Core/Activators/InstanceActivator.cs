using System;
using MiniFac.Contract;

namespace MiniFac.Core.Activators
{
    public abstract class InstanceActivator : IInstanceActivator
    {
        public Type LimitType { get; }

        protected InstanceActivator(Type limitType)
        {
            LimitType = limitType;
        }

        public abstract object ActivateInstance(IComponentContext context);
    }
}
