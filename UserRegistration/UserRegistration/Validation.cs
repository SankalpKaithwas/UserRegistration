using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public Regex FirstName = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}$");
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex MobileNumber = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex PasswordMinEightChars = new Regex(@"^[A-Za-z]{8,}$");
        public Regex PasswordAtLeastOneUpperCase = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex PasswordAtLeastOneNumber = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        public Regex PasswordOneSpecialChar = new Regex("[A-Z][0-9][!@#$%^&*()_+=-]{1}[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$");


        public string ValidFirstName(string firstName)
        {
            bool FirstNamePattern(string FirstNamePattern) => FirstName.IsMatch(firstName);
            bool result = FirstNamePattern(firstName);
            try
            {
                if (result == false)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameEmpty,
                            "First name should not be empty");
                    else if (firstName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameLessThanMinChar,
                            "First name should contain atleast three character");
                    else if (firstName.Any(char.IsDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameContainNumber,
                            "First name should not contain number");
                    else if (!char.IsUpper(firstName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameShouldStartWithUpper,
                            "First name should start with upper case");
                    else if (firstName.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameContainsSpecialChar,
                            "First name should not contain special characters");
                }
                else
                {
                    return "First Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "First Name is Invalid";
        }
        public string ValidLastName(string lastName)
        {
            bool LastNamePattern(string LastNamePattern) => LastName.IsMatch(lastName);
            bool result = LastNamePattern(lastName);
            try
            {
                if (result == false)
                {
                    if (lastName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameEmpty,
                            "Last name should not be empty");
                    else if (lastName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameLessThanMinChar,
                            "Last name should contain atleast three character");
                    else if (lastName.Any(char.IsDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameContainNumber,
                            "Last name should not contain number");
                    else if (!char.IsUpper(lastName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameShouldStartWithUpper,
                            "Last name should start with upper case");
                    else if (lastName.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameContainsSpecialChar,
                            "Last name should not contain special characters");
                }
                else
                {
                    return "Last Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Last Name is Invalid";
        }
        public string ValidEmail(string email)
        {
            bool EmailPattern(string EmailPattern) => Email.IsMatch(EmailPattern);
            bool result = EmailPattern(email);
            try
            {
                if (result == false)
                {
                    if (email.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailEmpty,
                            "Email should not be empty");
                    else if (email.Length < 7)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailLessThanMinChar,
                            "Email should contain atleast seven character");
                    else if (!email.Any(char.IsDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainNumber,
                            "Email should contain atleast one number");
                    else if (!email.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainsSpecialChar,
                            "Email should contain special characters");
                    else if (!email.Contains('@'))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainAtSymbol,
                            "Email should contains @ Symbol");
                }
                else return "Email is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Email is Invalid";
        }
        public string ValidPhoneNumber(string phoneNumber)
        {
            bool PhoneNumber(string PhoneNumber) => MobileNumber.IsMatch(PhoneNumber);
            bool result = PhoneNumber(phoneNumber);
            try
            {
                if (result == false)
                {
                    if (phoneNumber.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberEmpty,
                            "Phone number should not be empty");
                    else if (phoneNumber.Length < 10)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberAtleastTenDigit,
                            "Phone number should contain atleast ten digits");
                    else if (phoneNumber.Contains(' '))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberContainsChar,
                            "Phone number should not contain characters");
                }
                else return "Phone Number is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Phone number is Invalid";
        }

        public string ValidPasswordEightChars(string password)
        {
            bool Password(string Password) => PasswordMinEightChars.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordEmpty,
                            "Password should not be empty");
                    else if (password.Length < 8)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordMinEightChar,
                            "Password should contain atleast eight characters");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordOneUpperCase(string password)
        {
            bool Password(string Password) => PasswordAtLeastOneUpperCase.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordEmpty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordAtLeastOneUpperCase,
                            "Password should contain atleast one upper case character");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordAtLeastOneNumber(string password)
        {
            bool Password(string Password) => PasswordAtLeastOneNumber.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordEmpty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordAtLeastOneNumber,
                            "Password should contain atleast one Digit");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }

        public string ValidPasswordAtLeastOneSpecialChar(string password)
        {
            bool Password(string Password) => PasswordOneSpecialChar.IsMatch(Password);
            bool result = Password(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordEmpty,
                            "Password should not be empty");
                    else if (!char.IsUpper(password[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordOneSpecialChar,
                            "Password should contain atleast one special character");
                }
                else return "Password is Valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
    }
}