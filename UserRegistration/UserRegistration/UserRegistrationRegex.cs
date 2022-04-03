using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class UserRegistrationRegex
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumber = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordMinEightChars = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordAtLeastOneUpperCase = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordAtLeastOneNumber = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        public Regex PasswordOneSpecialChar = new Regex("[A-Z][0-9][!@#$%^&*()_+=-]{1}[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$");

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
            if (PasswordMinEightChars.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRuleTwo(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordAtLeastOneUpperCase.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRuleThree(string password)
        {
            Console.WriteLine("Password - " + password);
            if (PasswordAtLeastOneNumber.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
        public void ValidPasswordRuleFour(string password)
        {
            if (PasswordOneSpecialChar.IsMatch(password))
                Console.WriteLine($"{password} is valid");
            else
                Console.WriteLine($"{password} is Invalid");
        }
    }
}