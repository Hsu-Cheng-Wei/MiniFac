using System;

namespace MiniFac.Contract
{
    public interface IDisposer : IDisposable
    {
        void AddInstanceForDisposal(IDisposable instance);
    }
}
