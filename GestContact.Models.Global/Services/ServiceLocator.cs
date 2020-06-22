using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using GestContact.Models.Global.Data;
using GestContact.Repositories;
using GestContact.ToolBox.ADO;
using Microsoft.Extensions.DependencyInjection;

namespace GestContact.Models.Global.Services
{
    public class ServiceLocator : ToolBox.Patterns.ServiceLocator
    {
        private static ServiceLocator _instance;

        public static ServiceLocator Instance
        {
            get { return _instance ?? new ServiceLocator(); }
        }

        private ServiceLocator() {}

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<DbProviderFactory, SqlClientFactory>((sp) => SqlClientFactory.Instance);
            serviceCollection.AddSingleton<IConnectionInfo, ConnectionInfo>((sp) => new ConnectionInfo(ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString));
            serviceCollection.AddSingleton<IConnection, Connection>();
            serviceCollection.AddScoped<IAuthService<User>, AuthService>();
            serviceCollection.AddScoped<IContactService<Contact>, ContactService>();
        }

        internal IConnection Connection
        {
            get { return Container.GetService<IConnection>(); }
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
