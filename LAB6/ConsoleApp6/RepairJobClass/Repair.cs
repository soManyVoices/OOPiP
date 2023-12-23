using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Представляет сервис ремонтной мастерской.
        /// </summary>
        public class RepairShop
        {
            private readonly List<RepairJob> repairJobs;

            /// <summary>
            /// Создает экземпляр класса RepairShop.
            /// </summary>
            public RepairShop()
            {
                repairJobs = new List<RepairJob>();
            }

            public List<RepairJob> GetAllRepairJobs()
            {
                return repairJobs;
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
                int count = 0;
                foreach (var job in repairJobs)
                {
                    if (job.Date >= startDate && job.Date <= endDate)
                    {
                        count++;
                    }
                }
                return count;
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
                int jobCount = 0;
                foreach (var job in repairJobs)
                {
                    if (job.Date >= startDate && job.Date <= endDate && job.JobType == jobType)
                    {
                        jobCount++;
                    }
                }
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
                Dictionary<string, int> jobTypeCounts = new Dictionary<string, int>();
                foreach (var job in repairJobs)
                {
                    if (job.Date >= startDate && job.Date <= endDate)
                    {
                        if (jobTypeCounts.ContainsKey(job.JobType))
                        {
                            jobTypeCounts[job.JobType]++;
                        }
                        else
                        {
                            jobTypeCounts[job.JobType] = 1;
                        }
                    }
                }
                string mostPopularJobType = null;
                int maxCount = 0;
                foreach (var kvp in jobTypeCounts)
                {
                    if (kvp.Value > maxCount)
                    {
                        maxCount = kvp.Value;
                        mostPopularJobType = kvp.Key;
                    }
                }
                return mostPopularJobType;
            }
        }
    }
}