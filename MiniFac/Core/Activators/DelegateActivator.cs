using System;
using MiniFac.Contract;

namespace MiniFac.Core.Activators
{
    public class DelegateActivator : InstanceActivator 
    {
        private readonly Func<IComponentContext, object> _activationFunction;

        public DelegateActivator(Type limitType, Func<IComponentContext, object> activationFunction) : base(limitType)
        {
            _activationFunction = activationFunction;
        }

        public override object ActivateInstance(IComponentContext context)
        {
            return _activationFunction(context);
        }
    }
}
