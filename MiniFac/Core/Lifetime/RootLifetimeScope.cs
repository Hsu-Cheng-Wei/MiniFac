using MiniFac.Contract;
using MiniFac.Unexpected;

namespace MiniFac.Core.Lifetime
{
    public class RootLifetimeScope : IComponentLifetime
    {
        public ISharingLifetimeScope FindScope(ISharingLifetimeScope scope) 
            => scope?.RootLifetimeScope ??
               throw MiniException.ArgumentNull(typeof(ISharingLifetimeScope));
    }
}
