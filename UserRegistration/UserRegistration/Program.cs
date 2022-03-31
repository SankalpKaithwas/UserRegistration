using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationRegex userRegistration = new UserRegistrationRegex();
            Console.WriteLine("Choose 1: First name validation");
            Console.WriteLine("Choose 2: Last name validation");
            Console.WriteLine("Choose 3: Email validation");
            Console.WriteLine("Choose 4: Phone number validation");
            int options = int.Parse(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("Enter your First Name: ");
                    string input = Console.ReadLine();
                    userRegistration.ValidFirstName(input);
                    break;
                case 2:
                    Console.WriteLine("Enter your Last Name: ");
                    input = Console.ReadLine();
                    userRegistration.ValidLastName(input);
                    break;
                case 3:
                    Console.WriteLine("Enter your Email: ");
                    input = Console.ReadLine();
                    userRegistration.ValidEmail(input);
                    break;
                case 4:
                    Console.WriteLine("Enter your Mobile Number: ");
                    input = Console.ReadLine();
                    userRegistration.ValidMobile(input);
                    break;
                default:
                    Console.WriteLine("Choose valid Option");
                    break;
            }
        }
    }
}
