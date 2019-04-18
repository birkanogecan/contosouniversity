using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoUniversity.Model.ViewModel
{
    public class DepartmentViewModel
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorID { get; set; }
        public string AdministratorFullName { get; set; }
    }
}
