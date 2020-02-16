using System;

namespace Interfaces.Example99
{
    public interface IBillRepository
    {
        void Save(int clientId, Bill bill);
    }
}
