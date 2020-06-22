using System;
using Microsoft.Extensions.DependencyInjection;

namespace GestContact.ToolBox.Patterns
{
    public abstract class ServiceLocator
    {
        protected IServiceProvider Container { get; set; }

        public ServiceLocator()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            Container = serviceCollection.BuildServiceProvider();
        }

        public abstract void ConfigureServices(IServiceCollection serviceCollection);
    }
}
