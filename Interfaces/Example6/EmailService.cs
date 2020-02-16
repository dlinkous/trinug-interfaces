using System;

namespace Interfaces.Example6
{
    public class EmailService
    {
        private readonly IEmailServiceSettings settings;

        public EmailService(IEmailServiceSettings settings) =>
            this.settings = settings;

        public void SendWelcome(string to) =>
            Send(new Email()
            {
                From = settings.From,
                To = to,
                Subject = "Welcome!",
                Body = "Welcome to our company!"
            });

        private void Send(Email email) { }
    }
}
