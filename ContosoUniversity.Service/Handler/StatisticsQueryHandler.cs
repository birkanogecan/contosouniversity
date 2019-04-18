using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ContosoUniversity.Model.QueryModel;
using ContosoUniversity.Service.Business.Statistics;
using MediatR;
using Statistic;

namespace ContosoUniversity.Service.Handler
{
    public class StatisticsQueryHandler : IRequestHandler<StatisticsQuery, StatisticsQueryResult>
    {
        private readonly IStatisticsBusiness _statisticsBusiness;
        public StatisticsQueryHandler(IStatisticsBusiness statisticsBusiness)
        {
            _statisticsBusiness = statisticsBusiness;
        }
        public Task<StatisticsQueryResult> Handle(StatisticsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_statisticsBusiness.GetStatistics());
        }
    }
}
