using System;
using System.Reflection;

namespace MiniFac.Contract
{
    public interface IConstructorFinder
    {
        ConstructorInfo[] FindConstructors(Type targetType);
    }
}
