using System;

namespace Interfaces.Example6
{
    public class HardCodedEmailServiceSettings : IEmailServiceSettings
    {
        public string From => "contact@ourcompany.com";
    }
}
