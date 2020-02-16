using System;

namespace Interfaces.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
            Example4();
            Example5();
            Example6();
            Console.ReadKey();
        }

        private static void Example1()
        {
            var invoice = new Example1.Invoice();
            invoice.Add(new Example1.Product(3, 17.50m, true, true));
            invoice.Add(new Example1.Service(5, true));
            var total = invoice.CalculateTotal();
            Console.WriteLine(total);
        }

        private static void Example2()
        {
            var invoice = new Example2.Invoice();
            invoice.Add(new Example2.Product(3, 17.50m, true, true));
            invoice.Add(new Example2.Service(5, true));
            var total = invoice.CalculateTotal();
            Console.WriteLine(total);
        }

        private static void Example3()
        {
            var user = new Example3.User("John", "Alexander", "Smith");
            user.NameFormat = Interfaces.Example3.NameFormat.FirstName;
            var casualMessage = user.GenerateMessage("Hello ", "!  Welcome to TRINUG!");
            Console.WriteLine(casualMessage);
            user.NameFormat = Interfaces.Example3.NameFormat.Initial;
            var profileMessage = user.GenerateMessage("Profile: ", string.Empty);
            Console.WriteLine(profileMessage);
        }

        private static void Example4()
        {
            var user = new Example4.User("John", "Alexander", "Smith");
            user.NameFormatter = new Example4.FirstNameFormatter();
            var casualMessage = user.GenerateMessage("Hello ", "!  Welcome to TRINUG!");
            Console.WriteLine(casualMessage);
            user.NameFormatter = new Example4.InitialNameFormatter();
            var profileMessage = user.GenerateMessage("Profile: ", string.Empty);
            Console.WriteLine(profileMessage);
        }

        private static void Example5()
        {
            var service = new Example5.EmailService();
            service.SendWelcome("recipient@domain.com");
        }

        private static void Example6()
        {
            var service = new Example6.EmailService(new Example6.EnvironmentVariableEmailServiceSettings());
            service.SendWelcome("recipient@domain.com");
        }
    }
}
