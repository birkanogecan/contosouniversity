using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Model.QueryModel;
using Grpc.Core;
using MediatR;
using Statistic;

namespace ContosoUniversity.Service.Services
{
    public class StatisticsService : Statistics.StatisticsBase
    {
        private readonly IMediator _mediator;
        public StatisticsService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override Task<StatisticsReply> GetStatistics(StatisticsRequest request, ServerCallContext context)
        {
            var result = _mediator.Send(new StatisticsQuery()).Result;

            return Task.FromResult(new StatisticsReply
            {
                Courses = result.Courses.ToString(),
                Departments = result.Departments.ToString(),
                Instructors = result.Instructors.ToString(),
                Students = result.Students.ToString()
            });
        }
        public override Task<EnrollmentsListReply> GetEnrollments(EnrollmentsRequest request, ServerCallContext context)
        {
            var result = _mediator.Send(new EnrollmentsQuery()).Result;
            EnrollmentsListReply enrollmentsListReply = new EnrollmentsListReply();

            foreach (var item in result)
            {
                EnrollmentsReply enrollmentsReply = new EnrollmentsReply { Studentcount = item.StudentCount.ToString(), Enrollmentsdate = item.EnrollmentsDate };
                enrollmentsListReply.Items.Add(enrollmentsReply);
            }

            return Task.FromResult(enrollmentsListReply);
        }
    }
}
