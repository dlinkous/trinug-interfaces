using System;
using System.Linq;

namespace Interfaces.Example99
{
    public class BillService
    {
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IBillRepository billRepository;

        public BillService(IInvoiceRepository invoiceRepository, IBillRepository billRepository) =>
            (this.invoiceRepository, this.billRepository) = (invoiceRepository, billRepository);

        public void Generate(int clientId)
        {
            var bill = new Bill();
            var unpaidInvoices = invoiceRepository.GetSummaries(clientId).Where(i => !i.IsPaid);
            foreach (var invoice in unpaidInvoices)
                bill.AddCharge($"Invoice {invoice.Number} ({invoice.Total})", invoice.Remaining);
            billRepository.Save(clientId, bill);
        }
    }
}
