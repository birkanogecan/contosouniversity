using ContosoUniversity.Model.QueryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Service.Business.Statistics
{
    public interface IStatisticsBusiness
    {
        StatisticsQueryResult GetStatistics();
        List<EnrollmentsQueryResult> GetEnrollments();
    }
}
