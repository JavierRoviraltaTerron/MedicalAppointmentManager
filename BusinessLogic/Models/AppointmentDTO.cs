using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalAppointmentManager.BusinessLogic.Models
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }
        public string Place { get; set; }
        public string Requirements { get; set; }
        public string Observations { get; set; }
        public bool Cancelled { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public virtual PatientDTO Patient { get; set; }
    }
}
