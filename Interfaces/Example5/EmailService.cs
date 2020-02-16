using System;

namespace Interfaces.Example5
{
    public class EmailService
    {
        public void SendWelcome(string to) =>
            Send(new Email()
            {
                From = "contact@ourcompany.com",
                To = to,
                Subject = "Welcome!",
                Body = "Welcome to our company!"
            });

        private void Send(Email email) { }
    }
}
