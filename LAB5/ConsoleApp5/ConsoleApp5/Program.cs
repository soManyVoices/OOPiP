using System;
using CheckLibrary;

/// <summary>
/// Класс, содержащий метод `Main` для запуска программы проверки информации о пользователях.
/// </summary>
public class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    public static void Main(string[] args)
    {
        string[] userInformation = new string[]
        {
            "Иван Иванов, ул. Пушкина 10, ivan@example.com, (555) 123-4567",
            "Екатерина Петрова, ул. Лермонтова 5, ekaterina@example.com, (555) 987-6543",
            "Ян Соловьёв, ул Гоголя 7, invalid.email, 423-456-789",
            "Алексей Смирнов, ул. Кирова 3, alex@example.com, (555) 111-2222",
            "мария Иванова, ул. Ленина 12, maria@example.com, (555) 333-4444",
            "Петр Сидоров, ул. Советская 8, petr@example.com, (555) 555-6666",
        };

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите, какую информацию о пользователе проверить:");
            Console.WriteLine("1. ФИО");
            Console.WriteLine("2. Адрес");
            Console.WriteLine("3. Email");
            Console.WriteLine("4. Номер телефона");
            Console.WriteLine("5. Выход");
            Console.WriteLine("6.");
            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        CheckFullName(userInformation);
                        break;
                    case 2:
                        CheckAddress(userInformation);
                        break;
                    case 3:
                        CheckEmail(userInformation);
                        break;
                    case 4:
                        CheckPhoneNumber(userInformation);
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали выход. Завершение программы.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Проверяет корректность ФИО пользователей.
    /// </summary>
    /// <param name="userInformation">Массив строк с информацией о пользователях.</param>
    
    public static void CheckFullName(string[] userInformation)
    {
        UserInformationValidator validator = new UserInformationValidator();

        foreach (string userInfo in userInformation)
        {
            string fullName = userInfo.Split(',')[0].Trim();
            bool isFullNameValid = validator.IsFullNameValid(fullName);

            Console.WriteLine($"Информация о пользователе: {userInfo}");
            Console.WriteLine($"ФИО корректно: {isFullNameValid}");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Проверяет корректность адресов пользователей.
    /// </summary>
    /// <param name="userInformation">Массив строк с информацией о пользователях.</param>
    
    public static void CheckAddress(string[] userInformation)
    {
        UserInformationValidator validator = new UserInformationValidator();

        foreach (string userInfo in userInformation)
        {
            string address = userInfo.Split(',')[1].Trim();
            bool isAddressValid = validator.IsAddressValid(address);

            Console.WriteLine($"Информация о пользователе: {userInfo}");
            Console.WriteLine($"Адрес корректен: {isAddressValid}");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Проверяет корректность email пользователей.
    /// </summary>
    /// <param name="userInformation">Массив строк с информацией о пользователях.</param>
    
    public static void CheckEmail(string[] userInformation)
    {
        UserInformationValidator validator = new UserInformationValidator();

        foreach (string userInfo in userInformation)
        {
            string Email = userInfo.Split(',')[3].Trim();
            bool IsEmailValid = validator.IsPhoneNumberValid(Email);

            Console.WriteLine($"Информация о пользователе: {userInfo}");
            Console.WriteLine($"e-mail корректен: {IsEmailValid}");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Проверяет корректность номеров телефонов пользователей.
    /// </summary>
    /// <param name="userInformation">Массив строк с информацией о пользователях.</param>
    
    public static void CheckPhoneNumber(string[] userInformation)
    {
        UserInformationValidator validator = new UserInformationValidator();

        foreach (string userInfo in userInformation)
        {
            string phoneNumber = userInfo.Split(',')[3].Trim();
            bool isPhoneNumberValid = validator.IsPhoneNumberValid(phoneNumber);

            Console.WriteLine($"Информация о пользователе: {userInfo}");
            Console.WriteLine($"Номер телефона корректен: {isPhoneNumberValid}");
            Console.WriteLine();
        }
    }
}