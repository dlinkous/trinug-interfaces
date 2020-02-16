using System;

namespace Interfaces.Example3
{
    public class User
    {
        public NameFormat NameFormat { get; set; }

        private readonly string firstName;
        private readonly string middleName;
        private readonly string lastName;

        public User(string firstName, string middleName, string lastName) =>
            (this.firstName, this.middleName, this.lastName) = (firstName, middleName, lastName);

        public string GenerateMessage(string prefix, string suffix) =>
            $"{prefix}{FormatName()}{suffix}";

        private string FormatName() =>
            NameFormat switch
            {
                NameFormat.FullName => $"{firstName} {middleName} {lastName}",
                NameFormat.FirstName => firstName,
                NameFormat.LastFirst => $"{lastName}, {firstName}",
                NameFormat.Initial => GetInitial(firstName) + GetInitial(middleName) + GetInitial(lastName),
                _ => throw new NotSupportedException()
            };

        private string GetInitial(string name) =>
            string.IsNullOrWhiteSpace(name) ? string.Empty : name.Substring(0, 1).ToUpper();
    }
}
