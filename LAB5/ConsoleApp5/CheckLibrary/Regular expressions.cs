using System.Text.RegularExpressions;

namespace CheckLibrary
{
    /// <summary>
    /// Класс, предоставляющий методы для проверки информации о пользователе.
    /// </summary>
    public class UserInformationValidator
    {
        /// <summary>
        /// Проверяет, является ли ФИО корректным.
        /// </summary>
        /// <param name="fullName">ФИО для проверки.</param>
        /// <returns>True, если ФИО корректно, иначе False.</returns>
        public bool IsFullNameValid(string fullName)
        {
            return Regex.IsMatch(fullName, @"^([\p{Lu}][\p{Ll}]{1,})\s([\p{Lu}][\p{Ll}]{1,})$");
        }

        /// <summary>
        /// Проверяет, является ли адрес корректным.
        /// </summary>
        /// <param name="address">Адрес для проверки.</param>
        /// <returns>True, если адрес корректен, иначе False.</returns>
        public bool IsAddressValid(string address)
        {
            return Regex.IsMatch(address, @"^ул\.\s[\p{L}0-9\s-]+$");
        }

        /// <summary>
        /// Проверяет, является ли email корректным.
        /// </summary>
        /// <param name="email">Email для проверки.</param>
        /// <returns>True, если email корректен, иначе False.</returns>
        public bool IsEmailValid(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Проверяет, является ли номер телефона корректным.
        /// </summary>
        /// <param name="phoneNumber">Номер телефона для проверки.</param>
        /// <returns>True, если номер телефона корректен, иначе False.</returns>
        public bool IsPhoneNumberValid(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}$");
        }
    }
}