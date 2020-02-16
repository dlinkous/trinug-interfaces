using System;

namespace Interfaces.Example2
{
    public class Product : ICalculatable
    {
        private readonly int quantity;
        private readonly decimal cost;
        private readonly bool taxable;
        private readonly bool heavy;

        public Product(int quantity, decimal cost, bool taxable, bool heavy) =>
            (this.quantity, this.cost, this.taxable, this.heavy) = (quantity, cost, taxable, heavy);

        public decimal Calculate()
        {
            const decimal taxMultiplier = 1.07m;
            const decimal heavyFee = 29.99m;
            var baseDollars = quantity * cost;
            var taxedDollars = taxable ? baseDollars * taxMultiplier : baseDollars;
            var dollars = heavy ? taxedDollars + heavyFee : taxedDollars;
            return dollars;
        }
    }
}
