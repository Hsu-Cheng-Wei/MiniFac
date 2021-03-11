using MiniFac.Contract;
using MiniFac.Unexpected;

namespace MiniFac.Core.Lifetime
{
    public class CurrentLifetimeScope : IComponentLifetime
    {
        public ISharingLifetimeScope FindScope(ISharingLifetimeScope scope)
            => scope ?? throw MiniException.ArgumentNull(typeof(ISharingLifetimeScope));
    }
}
