using System;

namespace GestContact.ToolBox.ADO
{
    public class ConnectionInfo : IConnectionInfo
    {
        public string ConnectionString
        {
            get;
            private set;
        }

        public ConnectionInfo(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            ConnectionString = connectionString;
        }
    }
}
