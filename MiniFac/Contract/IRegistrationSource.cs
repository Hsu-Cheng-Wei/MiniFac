using System.Collections.Generic;
using MiniFac.Core;

namespace MiniFac.Contract
{
    public interface IRegistrationSource
    {
        IEnumerable<IComponentRegistration> RegistrationsFor(Service service);
    }
}
