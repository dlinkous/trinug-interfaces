using System;
using System.Collections.Generic;

namespace Interfaces.Example99
{
    public class FileSystemInvoiceRepository : IInvoiceRepository
    {
        private readonly IFileSystemSettings settings;

        public FileSystemInvoiceRepository(IFileSystemSettings settings) =>
            this.settings = settings;

        public IEnumerable<InvoiceSummary> GetSummaries(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
