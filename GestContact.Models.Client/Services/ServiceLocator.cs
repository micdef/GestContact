using GestContact.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContact.Models.Client.Data;
using GestContact.ToolBox.Patterns;

namespace GestContact.Models.Client.Services
{
    public class ServiceLocator : ToolBox.Patterns.ServiceLocator
    {
        private static ServiceLocator _instance;

        public static ServiceLocator Instance
        {
            get { return _instance ?? new ServiceLocator(); }
        }

        public ServiceLocator() {}

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuthService<User>, AuthService>();
            serviceCollection.AddScoped<IContactService<Contact>, ContactService>();
        }

        public IAuthService<User> AuthService
        {
            get { return Container.GetService<IAuthService<User>>(); }
        }

        public IContactService<Contact> ContactService
        {
            get { return Container.GetService<IContactService<Contact>>(); }
        }
    }
}
