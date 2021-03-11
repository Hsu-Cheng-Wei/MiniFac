using System;
using MiniFac.Core.Registration;

namespace MiniFac.Contract
{
    public interface IRegistrationBuilder<out TLimit>
    {
        IInstanceActivator Activator { get; set; }

        RegistrationData RegistrationData { get; }

        RegistrationInfo RegistrationInfo { get; }

        IRegistrationBuilder<TLimit> As(Type service);

        IRegistrationBuilder<TLimit> As<TService>();
    }
}
