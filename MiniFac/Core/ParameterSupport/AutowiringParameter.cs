using MiniFac.Contract;
using System;
using System.Reflection;

namespace MiniFac.Core.ParameterSupport
{
    public class AutoWiringParameter : Parameter
    {
        public AutoWiringParameter(IComponentContext context) : base(context) { }

        public override bool CanSupplyValue(ParameterInfo parameterInfo, out Func<object> activiator)
        {
            activiator = null;

            var type = new TypedService(parameterInfo.ParameterType);

            if (!Context.ComponentRegistry.TryGetRegistration(type, out var re)) return false;

            activiator = () => Context.ResolveComponent(re);

            return true;
        }
    }
}
