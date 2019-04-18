using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Model.QueryModel;

namespace ContosoUniversity.Service.Business.Statistics
{
    public class StatisticsBusiness : IStatisticsBusiness
    {
        public StatisticsQueryResult GetStatistics()
        {
            return new StatisticsQueryResult() { Courses = 2, Departments = 3, Instructors = 4, Students = 5 };
        }
    }
}
