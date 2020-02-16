using System;

namespace Interfaces.Example99
{
    public class InvoiceSummary
    {
        public int Number { get; }
        public decimal Total { get; }
        public decimal Paid { get; }
        public decimal Remaining { get; }
        public bool IsPaid { get; }

        public InvoiceSummary(int number, decimal total, decimal paid)
        {
            (Number, Total, Paid) = (number, total, paid);
            Remaining = Total - Paid;
            IsPaid = (Remaining <= 0);
        }
    }
}
