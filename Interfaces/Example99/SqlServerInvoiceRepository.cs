using System;
using System.Collections.Generic;

namespace Interfaces.Example99
{
    public class SqlServerInvoiceRepository : IInvoiceRepository
    {
        private readonly ISqlServerSettings settings;

        public SqlServerInvoiceRepository(ISqlServerSettings settings) =>
            this.settings = settings;

        public IEnumerable<InvoiceSummary> GetSummaries(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
