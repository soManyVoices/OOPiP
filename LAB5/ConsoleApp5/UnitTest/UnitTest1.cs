using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CheckLibrary.Tests
{
    [TestClass]
    public class UserInformationValidatorTests
    {
        private UserInformationValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new UserInformationValidator();
        }


        [TestMethod]
        public void IsAddressValid_ValidAddress_ReturnsTrue()
        {
            // Arrange
            string address = "ул. Ленина 123";

            // Act
            bool isValid = validator.IsAddressValid(address);

            // Assert
            Assert.IsTrue(isValid);
        }


        [TestMethod]
        public void IsEmailValid_ValidEmail_ReturnsTrue()
        {
            // Arrange
            string email = "ivanov@example.com";

            // Act
            bool isValid = validator.IsEmailValid(email);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsEmailValid_InvalidEmail_ReturnsFalse()
        {
            // Arrange
            string email = "ivanov@example";

            // Act
            bool isValid = validator.IsEmailValid(email);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsPhoneNumberValid_ValidPhoneNumber_ReturnsTrue()
        {
            // Arrange
            string phoneNumber = "(123) 456-7890";

            // Act
            bool isValid = validator.IsPhoneNumberValid(phoneNumber);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void IsPhoneNumberValid_InvalidPhoneNumber_ReturnsFalse()
        {
            // Arrange
            string phoneNumber = "123-456-7890";

            // Act
            bool isValid = validator.IsPhoneNumberValid(phoneNumber);

            // Assert
            Assert.IsFalse(isValid);
        }
    }
}