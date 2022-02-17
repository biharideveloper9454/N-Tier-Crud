using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Models.ViewModel
{
    public class EmployeeCompanyViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string HighestQualification { get; set; }
        public int PassingYear { get; set; }
        public int Percentage { get; set; }
        public string EmployerName { get; set; }
        public string Experience { get; set; }
        public int LastWorkingDate { get; set; }
        public string Company { get; set; }
    }
}
