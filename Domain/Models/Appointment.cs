using System;
using System.Collections.Generic;

namespace MedicalAppointmentManager.Domain.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }
        public string Place { get; set; }
        public string Requirements { get; set; }
        public string Observations { get; set; }
        public bool Cancelled { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
