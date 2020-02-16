using System;

namespace Interfaces.Example4
{
    public class User
    {
        public INameFormatter NameFormatter { get; set; }

        private readonly string firstName;
        private readonly string middleName;
        private readonly string lastName;

        public User(string firstName, string middleName, string lastName) =>
            (this.firstName, this.middleName, this.lastName) = (firstName, middleName, lastName);

        public string GenerateMessage(string prefix, string suffix) =>
            $"{prefix}{NameFormatter.Format(firstName, middleName, lastName)}{suffix}";
    }
}
