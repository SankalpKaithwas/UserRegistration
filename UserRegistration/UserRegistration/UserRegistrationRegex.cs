using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class UserRegistrationRegex
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumber = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordRuleOne = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordRuleTwo = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordRuleThree = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");

        public void ValidFirstName(string firstName)
        {
            Console.WriteLine("First name - " + firstName);
            if (FirstName.IsMatch(firstName))
                Console.WriteLine($"{firstName} is valid");
            else
                Console.WriteLine($"{firstName} is Invalid");
        }

        public void ValidLastName(string lastName)
        {
            Console.WriteLine("Last name - " + lastName);
            if (LastName.IsMatch(lastName))
                Console.WriteLine($"{lastName} is valid");
            else
                Console.WriteLine($"{lastName} is Invalid");
        }
        public void ValidEmail(string email)
        {
            Console.WriteLine("Email - " + email);
            if (Email.IsMatch(email))
                Console.WriteLine($"{email} is valid");
            else
                Console.WriteLine($"{email} is Invalid");
        }
        public void ValidMobile(string mobile)
        {
            Console.WriteLine("Mobile number - " + mobile);
            if (MobileNumber.IsMatch(mobile))
                Console.WriteLine($"{mobile} is valid");
            else
                Console.WriteLine($"{mobile} is Invalid");
        }
        public void ValidPasswordRuleOne(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRuleOne.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRuleTwo(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRuleTwo.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRuleThree(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordRuleThree.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
    }
}
