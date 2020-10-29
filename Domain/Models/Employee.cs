using System;
using System.Collections.Generic;

namespace MedicalAppointmentManager.Domain.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Nif { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CollegiateNumber { get; set; }
        public string ConsultationType { get; set; }
        public string Address { get; set; }
        public string Specialities { get; set; }
    }
}
