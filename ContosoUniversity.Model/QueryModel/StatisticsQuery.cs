using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace ContosoUniversity.Model.QueryModel
{
    public class StatisticsQuery : IRequest<StatisticsQueryResult>
    {
    }
}
