using MiniFac.Contract;
using MiniFac.Core.Activators;
using MiniFac.Utility;
using System;

namespace MiniFac.Core
{
    public class ReflectionActivatorData
    {
        public Type Implement { get; }
        public IConstructorFinder ConstructorFinder { get; }

        public ReflectionActivatorData(Type implement)
        {
            Implement = implement;
            ConstructorFinder = new DefaultConstructorFinder();
        }

        public IInstanceActivator Activator
            => new ReflectionActivator(Implement, ConstructorFinder);
    }
}
