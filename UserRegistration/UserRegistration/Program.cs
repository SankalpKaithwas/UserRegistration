using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationRegex userRegistration = new UserRegistrationRegex();
            int options = 0;
            do
            {
                Console.WriteLine("Choose 1: First name validation");
                Console.WriteLine("Choose 2: Last name validation");
                Console.WriteLine("Choose 3: Email validation");
                Console.WriteLine("Choose 4: Phone number validation");
                Console.WriteLine("Choose 5: Password validation Rule one");
                Console.WriteLine("Choose 6: Password validation Rule Two");
                Console.WriteLine("Choose 7: Password validation Rule Three");
                Console.WriteLine("Choose 8: Password validation Rule Four");
                Console.WriteLine("Choose 0: To Exit");
                try
                {
                    options = int.Parse(Console.ReadLine());
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
                        case 5:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRuleOne(input);
                            break;
                        case 6:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRuleTwo(input);
                            break;
                        case 7:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRuleThree(input);
                            break;
                        case 8:
                            Console.WriteLine("Enter Password: ");
                            input = Console.ReadLine();
                            userRegistration.ValidPasswordRuleFour(input);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Choose From the Options given above");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a valid option");
                }
            } while (options != 0);
        }
    }
}
