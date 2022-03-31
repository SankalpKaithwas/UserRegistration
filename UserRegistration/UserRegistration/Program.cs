using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationRegex userRegistration = new UserRegistrationRegex();
            Console.WriteLine("Enter your first Name: ");
            string input = Console.ReadLine();
            userRegistration.ValidFirstName(input);

        }
    }
}
