using System;
using MiniFac.Contract;

namespace MiniFac.Unexpected
{
    public class ContextException
    {
        public static void ResolveErr(Type resolveType)
            => MiniException.UnExpectedOperated(typeof(IComponentContext), $"Can't resolve {resolveType.FullName}");
    }
}
