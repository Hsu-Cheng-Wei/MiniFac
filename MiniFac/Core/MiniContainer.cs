using MiniFac.Contract;
using MiniFac.Core.Activators;
using MiniFac.Core.Lifetime;
using MiniFac.Core.Registration;
using MiniFac.Core.Registry;
using MiniFac.Unexpected;
using System;

namespace MiniFac.Core
{
    public class MiniContainer : IContainer
    {
        public IComponentRegistry ComponentRegistry { get; }

        public ILifetimeScope RootLifetimeScope { get; }

        public Guid Id { get; } = Guid.NewGuid();

        internal MiniContainer()
        {
            ComponentRegistry = new ComponentRegistry();

            ComponentRegistry.Register(new ComponentRegistration(
                LifetimeScope.SelfScopeId,
                new DelegateActivator(typeof(LifetimeScope), c => throw
                    MiniException.UnExpectedOperated(
                        typeof(MiniContainer),
                        $"root can't resolve {typeof(ILifetimeScope).FullName}, {typeof(IComponentContext)}")),
                new CurrentLifetimeScope(),
                InstanceSharing.Shared,
                new TypedService(typeof(ILifetimeScope)),
                new TypedService(typeof(IComponentContext)
                )));

            RootLifetimeScope = new LifetimeScope(ComponentRegistry);
        }

        public ILifetimeScope BeginLifetimeScope()
        => RootLifetimeScope.BeginLifetimeScope();

        public object ResolveComponent(IComponentRegistration registration)
        => RootLifetimeScope.ResolveComponent(registration);

        public void Dispose()
        {
            RootLifetimeScope.Dispose();
        }
    }
}
