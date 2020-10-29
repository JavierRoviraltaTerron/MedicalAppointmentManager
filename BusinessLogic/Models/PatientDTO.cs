using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalAppointmentManager.BusinessLogic.Models
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Nif { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
    }
}
