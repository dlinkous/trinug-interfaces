using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces.Example2
{
    public class Invoice
    {
        private readonly List<ICalculatable> items = new List<ICalculatable>();

        public void Add(ICalculatable item) => items.Add(item);

        public decimal CalculateTotal() =>
            Math.Round(items.Sum(i => i.Calculate()), 2);
    }
}
