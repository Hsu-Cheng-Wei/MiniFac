namespace MiniFac.Contract
{
    public interface IComponentLifetime
    {
        ISharingLifetimeScope FindScope(ISharingLifetimeScope scope);
    }
}
