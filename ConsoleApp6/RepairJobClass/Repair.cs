using System;
using System.Collections.Generic;
using System.Linq;

namespace RepairShopLibrary
{
    /// <summary>
    /// Представляет задание по ремонту.
    /// </summary>
    public class RepairJob
    {
        /// <summary>
        /// Дата выполнения задания.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Тип задания.
        /// </summary>
        public string JobType { get; set; }
    }

    /// <summary>
    /// Представляет сервис.
    /// </summary>
    public class RepairShop
    {
        private List<RepairJob> repairJobs;

        /// <summary>
        /// Создает экземпляр класса RepairShop.
        /// </summary>
        public RepairShop()
        {
            repairJobs = new List<RepairJob>();
        }

        /// <summary>
        /// Добавляет задание по ремонту в сервис.
        /// </summary>
        /// <param name="repairJob">Задание по ремонту.</param>
        public void AddRepairJob(RepairJob repairJob)
        {
            repairJobs.Add(repairJob);
        }

        /// <summary>
        /// Возвращает общее количество выполненных заданий по ремонту в заданный период времени.
        /// </summary>
        /// <param name="startDate">Дата начала периода.</param>
        /// <param name="endDate">Дата окончания периода.</param>
        /// <returns>Общее количество выполненных заданий.</returns>
        public int GetTotalCompletedJobs(DateTime startDate, DateTime endDate)
        {
            return repairJobs.Count(job => job.Date >= startDate && job.Date <= endDate);
        }

        /// <summary>
        /// Возвращает среднее количество заданий по ремонту в день для заданного типа задания в заданный период времени.
        /// </summary>
        /// <param name="startDate">Дата начала периода.</param>
        /// <param name="endDate">Дата окончания периода.</param>
        /// <param name="jobType">Тип задания.</param>
        /// <returns>Среднее количество заданий в день.</returns>
        public double GetAverageJobsPerDay(DateTime startDate, DateTime endDate, string jobType)
        {
            int totalDays = (endDate - startDate).Days + 1;
            int jobCount = repairJobs.Count(job => job.Date >= startDate && job.Date <= endDate && job.JobType == jobType);
            return (double)jobCount / totalDays;
        }

        /// <summary>
        /// Возвращает наиболее популярный тип задания по ремонту в заданный период времени.
        /// </summary>
        /// <param name="startDate">Дата начала периода.</param>
        /// <param name="endDate">Дата окончания периода.</param>
        /// <returns>Наиболее популярный тип задания.</returns>
        public string GetMostPopularJobType(DateTime startDate, DateTime endDate)
        {
            var jobTypeCounts = repairJobs
                .Where(job => job.Date >= startDate && job.Date <= endDate)
                .GroupBy(job => job.JobType)
                .Select(group => new { JobType = group.Key, Count = group.Count() })
                .OrderByDescending(group => group.Count)
                .FirstOrDefault();

            return jobTypeCounts != null ? jobTypeCounts.JobType : null;
        }
    }
}