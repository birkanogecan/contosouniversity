using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.ViewModel
{
    public class StudentViewModel
    {
        public StudentViewModel(){}

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public string FullName {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public DateTime EnrollmentDate { get; set; }
    }
}
