using System;

namespace Interfaces.Example4
{
    public class InitialNameFormatter : INameFormatter
    {
        public string Format(string first, string middle, string last) =>
            GetInitial(first) + GetInitial(middle) + GetInitial(last);

        private string GetInitial(string name) =>
            string.IsNullOrWhiteSpace(name) ? string.Empty : name.Substring(0, 1).ToUpper();
    }
}
