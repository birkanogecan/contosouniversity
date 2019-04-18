using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
