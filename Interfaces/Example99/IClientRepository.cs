using System;
using System.Collections.Generic;

namespace Interfaces.Example99
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClients();
    }
}
