using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationRegex userRegistration = new UserRegistrationRegex();
            Console.WriteLine("Enter your First Name: ");
            string input = Console.ReadLine();
            userRegistration.ValidFirstName(input);
            Console.WriteLine("Enter your Last Name: ");
            input = Console.ReadLine();
            userRegistration.ValidLastName(input);
            Console.WriteLine("Enter your Email: ");
            input = Console.ReadLine();
            userRegistration.ValidEmail(input);
        }
    }
}
