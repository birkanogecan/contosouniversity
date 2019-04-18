using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.ViewModel
{
    public class StudentDetailsViewModel : StudentViewModel
    {
        public List<EnrollmentViewModel> Enrollments { get; set; }
    }
}
