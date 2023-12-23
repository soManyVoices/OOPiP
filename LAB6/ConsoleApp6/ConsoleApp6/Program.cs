using System;
using RepairShopLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        // Создание экземпляра мастерской
        RepairJob.RepairShop repairShop = new RepairJob.RepairShop();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить ремонтную работу");
            Console.WriteLine("2. Получить общее количество выполненных работ за период");
            Console.WriteLine("3. Получить среднее количество работ в день для указанного типа работ");
            Console.WriteLine("4. Получить наиболее востребованный вид работ за период");
            Console.WriteLine("5. Вывести список всех добавленных работ");
            Console.WriteLine("6. Выйти из приложения");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите дату ремонтной работы (в формате ГГГГ-ММ-ДД):");
                    DateTime date;
                    if (DateTime.TryParse(Console.ReadLine(), out date))
                    {
                        Console.WriteLine("Введите тип ремонтной работы:");
                        string jobType = Console.ReadLine();

                        repairShop.AddRepairJob(new RepairJob { Date = date, JobType = jobType });
                        Console.WriteLine("Ремонтная работа добавлена!");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "2":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
                    {
                        Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                        {
                            int totalCompletedJobs = repairShop.GetTotalCompletedJobs(startDate, endDate);
                            Console.WriteLine($"Общее количество выполненных работ за период: {totalCompletedJobs}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    if (DateTime.TryParse(Console.ReadLine(), out startDate))
                    {
                        Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                        {
                            Console.WriteLine("Введите тип ремонтной работы:");
                            string jobType = Console.ReadLine();

                            double averageJobsPerDay = repairShop.GetAverageJobsPerDay(startDate, endDate, jobType);
                            Console.WriteLine($"Среднее количество работ в день для типа '{jobType}': {averageJobsPerDay}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "4":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    if (DateTime.TryParse(Console.ReadLine(), out startDate))
                    {
                        Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                        {
                            string mostPopularJobType = repairShop.GetMostPopularJobType(startDate, endDate);
                            Console.WriteLine($"Наиболее востребованный вид работ за период: {mostPopularJobType}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный формат даты. Попробуйте снова.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "5":
                    Console.WriteLine("Вывод списка всех добавленных работ:");
                    var allRepairJobs = repairShop.GetAllRepairJobs();
                    foreach (var repairJob in allRepairJobs)
                    {
                        Console.WriteLine($"Дата: {repairJob.Date}, Тип работы: {repairJob.JobType}");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "6":
                    Console.WriteLine("Выход из приложения...");
                    return;

                default:
                    Console.WriteLine("Некорректный выбор действия. Попробуйте снова.");
                    break;
            }
        }
    }
}