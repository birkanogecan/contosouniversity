using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.QueryModel
{
    public class StatisticsQueryResult
    {
        public int Students { get; set; }
        public int Courses { get; set; }
        public int Instructors { get; set; }
        public int Departments { get; set; }
    }
}
