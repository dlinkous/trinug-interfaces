using System;

namespace Interfaces.Example99
{
    public class Charge
    {
        public string Description { get; }
        public decimal Cost { get; }

        public Charge(string description, decimal cost) =>
            (Description, Cost) = (description, cost);
    }
}
