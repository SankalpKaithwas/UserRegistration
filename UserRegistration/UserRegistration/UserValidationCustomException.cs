using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserValidationCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {

            NameEmpty,
            NameLessThanMinChar,
            NameContainNumber,
            NameShouldStartWithUpper,
            NameContainsSpecialChar,
            EmailEmpty,
            EmailLessThanMinChar,
            EmailContainNumber,
            EmailContainsSpecialChar,
            EmailContainAtSymbol,
            MobileNumberEmpty,
            MobileNumberAtleastTenDigit,
            MobileNumberContainsChar,
            PasswordEmpty,
            PasswordMinEightChar,
            PasswordAtLeastOneUpperCase,
            PasswordAtLeastOneNumber,
            PasswordOneSpecialChar,
        }
        public UserValidationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
