using System;

namespace Interfaces.Example99
{
    public class EnvironmentVariableSqlServerSettings : ISqlServerSettings
    {
        public string ConnectionString => Environment.GetEnvironmentVariable("Example99ConnectionString");
    }
}
