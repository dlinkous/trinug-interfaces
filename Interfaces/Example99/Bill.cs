using System;
using System.Collections.Generic;

namespace Interfaces.Example99
{
    public class Bill
    {
        public IEnumerable<Charge> Charges { get => charges; }
        public decimal Total { get; private set; }

        private readonly List<Charge> charges = new List<Charge>();

        public void AddCharge(string description, decimal cost)
        {
            charges.Add(new Charge(description, cost));
            Total += cost;
        }
    }
}
