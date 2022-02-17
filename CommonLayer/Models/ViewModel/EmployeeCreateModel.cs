using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models.ViewModel
{
    public class EmployeeCreateModel
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
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

        [DisplayName("Organization")]
        public int Company { get; set; }
    }
}
