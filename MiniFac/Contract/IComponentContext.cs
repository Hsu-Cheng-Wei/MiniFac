namespace MiniFac.Contract
{
    public interface IComponentContext
    {
        IComponentRegistry ComponentRegistry { get; }

        object ResolveComponent(IComponentRegistration registration);
    }
}
