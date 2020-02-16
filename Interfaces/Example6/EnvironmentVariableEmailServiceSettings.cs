using System;

namespace Interfaces.Example6
{
    public class EnvironmentVariableEmailServiceSettings : IEmailServiceSettings
    {
        public string From => Environment.GetEnvironmentVariable("EmailFrom");
    }
}
