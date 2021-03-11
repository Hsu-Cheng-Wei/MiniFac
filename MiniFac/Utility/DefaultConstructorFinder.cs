using System;
using System.Reflection;
using MiniFac.Contract;

namespace MiniFac.Utility
{
    internal class DefaultConstructorFinder: IConstructorFinder
    {
        public ConstructorInfo[] FindConstructors(Type targetType)
        => targetType.GetConstructors();
    }
}
