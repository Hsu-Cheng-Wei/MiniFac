using System;
using System.Collections.Generic;
using MiniFac.Contract;
using MiniFac.Core;
using MiniFac.Core.Feature;
using MiniFac.Unexpected;

namespace MiniFac.Builder
{
    public class MiniContainerBuilder
    {
        private readonly IList<Action<IComponentRegistry>> _lazyConfiguration =
            new List<Action<IComponentRegistry>>();

        public void AddLazyConfiguration(Action<IComponentRegistry> action)
        {
            _lazyConfiguration.Add(action);
        }

        private bool _isBuild = false;
        public MiniContainer Build()
        {
            if (_isBuild) MiniException.UnExpectedOperatedArgument(typeof(MiniContainerBuilder), 
                nameof(_isBuild), _isBuild.ToString(), "false");

            var container = CreateContainer();

            Configure(container.ComponentRegistry);

            _isBuild = true;

            return container;
        }

        private void Configure(IComponentRegistry componentRegistry)
        {
            foreach (var cfgAct in _lazyConfiguration)
                cfgAct(componentRegistry);
        }

        private static MiniContainer CreateContainer()
        {
            var container = new MiniContainer();

            container.ComponentRegistry.AddRegistrationSource(new CollectionRegistrationSource());

            return container;
        }
    }
}
