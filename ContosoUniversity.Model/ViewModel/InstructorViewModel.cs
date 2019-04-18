using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.ViewModel
{
    public class InstructorViewModel
    {
        public InstructorViewModel(){}   
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }
        public string Location { get; set; }
        public List<CourseAssignmentViewModel> Courses { get; set; }
    }
}
