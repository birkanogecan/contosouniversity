using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Model.QueryModel;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Service.Business.Statistics
{
    public class StatisticsBusiness : IStatisticsBusiness
    {
        readonly SchoolContext _context;
        public StatisticsBusiness(SchoolContext context)
        {
            _context = context;
        }

        public List<EnrollmentsQueryResult> GetEnrollments()
        {
            List<EnrollmentsQueryResult> groups = new List<EnrollmentsQueryResult>();

            var conn = _context.Database.GetDbConnection();
            var data = from p in _context.Students
                       from pk in p.Enrollments.DefaultIfEmpty()
                       group p by p.EnrollmentDate
                       into result
                       select new
                       {
                           StudentCount = result.Count(),
                           EnrollmentDate = result.Key
                       };


            foreach (var item in data)
            {
                var row = new EnrollmentsQueryResult { EnrollmentsDate = item.EnrollmentDate.ToShortDateString(), StudentCount = item.StudentCount };
                groups.Add(row);
            }


            return groups;
        }

        public StatisticsQueryResult GetStatistics()
        {
            var studentsCount = _context.Students.Count();
            var coursesCount = _context.Courses.Count();
            var instructorsCount = _context.Instructors.Count();
            var departmentsCount = _context.Departments.Count();
            return new StatisticsQueryResult() { Courses = coursesCount, Departments = departmentsCount, Instructors = instructorsCount, Students = studentsCount };
        }
    }
}
