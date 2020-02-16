using System;

namespace Interfaces.Example99
{
    public class SqlServerBillRepository : IBillRepository
    {
        private readonly ISqlServerSettings settings;

        public SqlServerBillRepository(ISqlServerSettings settings) =>
            this.settings = settings;

        public void Save(int clientId, Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
