using NUnit.Framework;
using System;
using UserRegistration;

namespace UserRegistrationTesting
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }
        /// <summary>
        /// test for first name validation
        /// </summary>
        [Test]
        public void ValidFirst()
        {
            string expected = "First Name is Valid";
            string name = "Sankalp";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// test for last name validation
        /// </summary>
        [Test]
        public void ValidLastName()
        {
            string expected = "Last Name is Valid";
            string name = "Sankalp";
            string result = validation.ValidLastName(name);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Test for Email validation
        /// </summary>
        [Test]
        public void ValidEmail()
        {
            string expected = "Email is Valid";
            string result = null;
            string email = "kaithwas.123@something.com";
            try
            {
                result = validation.ValidEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        /// <summary>
        /// Test for Phone validation
        /// </summary>
        [Test]
        public void ValidPhone()
        {
            string expected = "Phone number is Valid";
            string result = null;
            try
            {
                string phone = "0900909090";
                result = validation.ValidPhoneNumber(phone);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        /// <summary>
        /// Test for password validation
        /// </summary>
        [Test]
        public void ValidPassWord()
        {
            string res = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "passwords";
                res = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, res);
            }
        }
        /// <summary>
        /// First name Tests
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Sankalp")]
        [TestCase("sankalp")]
        public void FirstNameNotValid_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("First name should start with upper case", ex.Message);
            }
        }
        /// <summary>
        /// TC - first name should not be Empty
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("")]
        public void EmptyFirstName_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("First name should not be empty", ex.Message);
            }
        }
        /// <summary>
        /// TC - first name should not contains numbers
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Sankalp1")]
        [TestCase("Sankalp")]
        public void FirstNameContainsNumber_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("First name should not contain number", ex.Message);
            }
        }

        /// <summary>
        /// TC - first anme should not conatins special chars
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Sankalp$")]
        public void FirstNameConatinSpecialChar_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("First name should not contain special characters", ex.Message);
            }
        }
        /// <summary>
        /// TC - first name should starts with upper case
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("sankalp")]
        public void FirstNameDoesNotStartWithUpperCase_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("First name should start with upper case", ex.Message);
            }
        }
        /// <summary>
        /// TC - first name should conatin atleast three chars
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Sankalp")]
        [TestCase("Sa")]
        public void FirstNameDoesNotContainsAtleastThreeChar_ThrowException(string firstName)
        {
            try
            {
                string firstNameResult = validation.ValidFirstName(firstName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("First name should contain atleast three character", ex.Message);
            }
        }
        /// <summary>
        /// Last name tests
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("Kaithwas")]
        public void LastNameNotValid_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("Last name is InValid", ex.Message);
            }
        }
        /// <summary>
        /// Last name should not be empty
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("")]
        public void EmptyLastName_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Last name should not be empty", ex.Message);
            }
        }

        /// <summary>
        /// Last name should not contains number
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("Kaithwas1")]
        public void LastNameContainsNumber_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("Last name should not contain number", ex.Message);
            }
        }
        /// <summary>
        /// Last name not contain special char
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("Kaithwas$")]
        public void LastNameConatinSpecialChar_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Last name should not contain special characters", ex.Message);
            }
        }
        /// <summary>
        /// Last name starts with upper
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("kaithwas")]
        public void LastNameDoesNotStartWithUpperCase_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Last name should start with upper case", ex.Message);
            }
        }
        /// <summary>
        /// TC - Last name should conatin atleast three chars
        /// </summary>
        /// <param name="lastName"></param>
        [TestCase("Ka")]
        public void LastNameDoesNotContainsAtleastThreeChar_ThrowException(string lastName)
        {
            try
            {
                string lastNameResult = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Last name should contain atleast three character", ex.Message);
            }
        }

        /// <summary>
        /// Email tests
        /// </summary>
        /// <param name="Email"></param>
        [TestCase("Kaithwas.456@gmail.com")]
        public void ValidEmail_NotThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("Email is Valid", ex.Message);
            }
        }
        /// <summary>
        /// TC - Email cannot be Empty
        /// </summary>
        /// <param name="email"></param>
        [TestCase("")]
        public void EmptyEmail_ThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Email should not be empty", ex.Message);
            }
        }
        /// <summary>
        /// TC - email should contain numbers
        /// </summary>
        /// <param name="email"></param>
        [TestCase("Kaithwas@gmail.com")]
        public void EmailDoesNotContainsNumber_ThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreSame("Email should contain atleast one number", ex.Message);
            }
        }
        /// <summary>
        /// TC - email should contains special chars
        /// </summary>
        /// <param name="email"></param>
        [TestCase("Kaithwas2@gmail.com")]
        public void EmailDoesNotConatinSpecialChar_ThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Email should contain special characters", ex.Message);
            }
        }
        /// <summary>
        /// TC - email should contains @ symbol
        /// </summary>
        /// <param name="email"></param>
        [TestCase("kaithwas1.gmail.com")]
        public void EmailDoesNotContainAtSymbol_ThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Email should contains @ Symbol", ex.Message);
            }
        }
        /// <summary>
        /// TC - email contains atleast seven chars
        /// </summary>
        /// <param name="email"></param>

        [TestCase("Kaithw")]
        public void EmailDoesNotContainsAtleastSevenChar_ThrowException(string email)
        {
            try
            {
                string emailResult = validation.ValidEmail(email);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Email should contain atleast seven character", ex.Message);
            }
        }

        /// <summary>
        /// TC - Mobile number atleast ten digit
        /// </summary>
        /// <param name="phone"></param>
        [TestCase("090909091212")]
        public void MobileDoesNotContainsAtleastTenDigit_ThrowException(string phone)
        {
            try
            {
                string phoneResult = validation.ValidPhoneNumber(phone);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Phone number should contain atleast ten digits", ex.Message);
            }
        }
        /// <summary>
        /// TC - mobile number should not be empty
        /// </summary>
        /// <param name="phone"></param>
        [TestCase("")]
        public void EmptyMobile_ThrowException(string phone)
        {
            try
            {
                string phoneResult = validation.ValidPhoneNumber(phone);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Phone number should not be empty", ex.Message);
            }
        }
        /// <summary>
        /// TC - Mobile number should not contains characters
        /// </summary>
        /// <param name="phone"></param>
        [TestCase("345345345 4")]
        public void MobileNumberShouldNotContainChar_ThrowException(string phone)
        {
            try
            {
                string phoneResult = validation.ValidPhoneNumber(phone);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Phone number should not contain characters", ex.Message);
            }
        }
        /// <summary>
        /// TC - Password contains minimum eight characters
        /// </summary>
        /// <param name="password"></param>
        [TestCase("abcd")]
        public void PasswordContainMinEightChar_ThrowException(string password)
        {
            try
            {
                string passwordResult = validation.ValidPasswordEightChars(password);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password should contain atleast eight characters", ex.Message);
            }
        }
        /// <summary>
        /// TC - password contains atleast one upper case
        /// </summary>
        /// <param name="password"></param>
        [TestCase("abcdefgh")]
        public void PasswordContainAtLeastOneUpperCase_ThrowException(string password)
        {
            try
            {
                string passwordResult = validation.ValidPasswordOneUpperCase(password);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password should contain atleast one upper case character", ex.Message);
            }
        }
        /// <summary>
        /// TC - password contains at least one number
        /// </summary>
        /// <param name="password"></param>
        [TestCase("aBcdefgh")]
        public void PasswordContainAtLeastOneNumber_ThrowException(string password)
        {
            try
            {
                string passwordResult = validation.ValidPasswordAtLeastOneNumber(password);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password should contain atleast one Digit", ex.Message);
            }
        }
        /// <summary>
        /// TC - password contains at least one special char
        /// </summary>
        /// <param name="password"></param>
        [TestCase("aBcdefgh")]
        public void PasswordContainAtLeastOneSpecialChar_ThrowException(string password)
        {
            try
            {
                string passwordResult = validation.ValidPasswordAtLeastOneSpecialChar(password);
            }
            catch (UserValidationCustomException ex)
            {
                Assert.AreEqual("Password should contain atleast one special character", ex.Message);
            }
        }
    }
}


