using System;
using RepairShopLibrary;


public class Program
{
    public static void Main(string[] args)
    {
        // Создание экземпляра мастерской
        RepairShop repairShop = new RepairShop();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить ремонтную работу");
            Console.WriteLine("2. Получить общее количество выполненных работ за период");
            Console.WriteLine("3. Получить среднее количество работ в день для указанного типа работ");
            Console.WriteLine("4. Получить наиболее востребованный вид работ за период");
            Console.WriteLine("5. Выйти из приложения");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите дату ремонтной работы (в формате ГГГГ-ММ-ДД):");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите тип ремонтной работы:");
                    string jobType = Console.ReadLine();

                    repairShop.AddRepairJob(new RepairJob { Date = date, JobType = jobType });
                    Console.WriteLine("Ремонтная работа добавлена!");
                    break;

                case "2":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());

                    int totalCompletedJobs = repairShop.GetTotalCompletedJobs(startDate, endDate);
                    Console.WriteLine($"Общее количество выполненных работ за период: {totalCompletedJobs}");
                    break;

                case "3":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    startDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                    endDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите тип ремонтной работы:");
                    jobType = Console.ReadLine();

                    double averageJobsPerDay = repairShop.GetAverageJobsPerDay(startDate, endDate, jobType);
                    Console.WriteLine($"Среднее количество работ в день для типа '{jobType}': {averageJobsPerDay}");
                    break;

                case "4":
                    Console.WriteLine("Введите начальную дату периода (в формате ГГГГ-ММ-ДД):");
                    startDate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите конечную дату периода (в формате ГГГГ-ММ-ДД):");
                    endDate = DateTime.Parse(Console.ReadLine());

                    string mostPopularJobType = repairShop.GetMostPopularJobType(startDate, endDate);
                    Console.WriteLine($"Наиболее востребованный вид работ за период: {mostPopularJobType}");
                    break;

                case "5":
                    Console.WriteLine("Выход из приложения...");
                    return;

                default:
                    Console.WriteLine("Некорректный выбор действия. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}