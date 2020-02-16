using System;

namespace Interfaces.Example4
{
    public class FullNameFormatter : INameFormatter
    {
        public string Format(string first, string middle, string last) =>
            $"{first} {middle} {last}";
    }
}
