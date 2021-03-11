using System;
using MiniFac.Core;
using MiniFac.Core.Lifetime;

namespace MiniFac.Contract
{
    public interface IComponentRegistration
    {
        Guid Id { get; }

        IInstanceActivator Activator { get; }

        IComponentLifetime Lifetime { get; }

        InstanceSharing Sharing { get; }

        Service[] Services { get; }
    }
}
