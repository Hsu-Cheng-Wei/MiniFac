using System.Collections.Generic;
using System.Linq;
using MiniFac.Contract;
using MiniFac.Core.Lifetime;

namespace MiniFac.Core.Registration
{
    public class RegistrationData
    {
        private readonly Service _defaultService;

        private readonly ICollection<Service> _services = new List<Service>();

        public Service[] Services => _services.Any() ? _services.ToArray() : new [] { _defaultService };

        public InstanceSharing Sharing { get; set; } = InstanceSharing.None;

        public IComponentLifetime Lifetime { get; set; }

        public RegistrationData(Service defaultService)
        {
            _defaultService = defaultService;

            Lifetime = new CurrentLifetimeScope();
        }

        public void AddServices(params Service[] services)
        {
            foreach (var service in services)
                _services.Add(service);
        }
    }
}
