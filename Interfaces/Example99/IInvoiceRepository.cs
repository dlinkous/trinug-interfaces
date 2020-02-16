using System;
using System.Collections.Generic;

namespace Interfaces.Example99
{
    public interface IInvoiceRepository
    {
        IEnumerable<InvoiceSummary> GetSummaries(int clientId);
    }
}
