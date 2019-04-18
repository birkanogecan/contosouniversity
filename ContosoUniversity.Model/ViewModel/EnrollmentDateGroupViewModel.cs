using System;

namespace ContosoUniversity.Model.ViewModel
{
    public class EnrollmentDateGroupViewModel
    {
        public DateTime? EnrollmentDate { get; set; }
        public string EnrollmentDateString
        {
            get
            {
                return EnrollmentDate.Value.ToString("MM/dd/yy");
            }
        }

        public int StudentCount { get; set; }
    }
}
