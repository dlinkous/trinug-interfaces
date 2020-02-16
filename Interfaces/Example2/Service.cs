using System;

namespace Interfaces.Example2
{
    public class Service : ICalculatable
    {
        private readonly int hours;
        private readonly bool onSite;

        public Service(int hours, bool onSite) =>
            (this.hours, this.onSite) = (hours, onSite);

        public decimal Calculate()
        {
            const int dollarsPerHour = 40;
            const decimal onSiteMultiplier = 1.5m;
            var baseDollars = hours * dollarsPerHour;
            var dollars = onSite ? baseDollars * onSiteMultiplier : baseDollars;
            return dollars;
        }
    }
}
