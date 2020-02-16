using System;

namespace Interfaces.Example4
{
    public class FirstNameFormatter : INameFormatter
    {
        public string Format(string first, string middle, string last) =>
            first;
    }
}
