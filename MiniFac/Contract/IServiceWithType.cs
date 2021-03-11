using System;
using MiniFac.Core;

namespace MiniFac.Contract
{
    public interface IServiceWithType
    {
        Type ServiceType { get; }

        Service ChangeType(Type newType);
    }
}
