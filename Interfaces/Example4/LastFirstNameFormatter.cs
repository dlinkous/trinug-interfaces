using System;

namespace Interfaces.Example4
{
    public class LastFirstNameFormatter : INameFormatter
    {
        public string Format(string first, string middle, string last) =>
            $"{last}, {first}";
    }
}
