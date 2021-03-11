using System;
using System.Reflection;
using MiniFac.Contract;

namespace MiniFac.Core
{
    public abstract class Parameter
    {
        protected readonly IComponentContext Context;

        public Parameter(IComponentContext context)
        {
            Context = context;
        }

        public abstract bool CanSupplyValue(ParameterInfo parameterInfo, out Func<object> activiator);
    }
}
