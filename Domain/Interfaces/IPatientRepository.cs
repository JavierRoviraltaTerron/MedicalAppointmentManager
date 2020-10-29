using System;
using System.Collections.Generic;
using System.Text;
using MedicalAppointmentManager.Domain.Models;

namespace MedicalAppointmentManager.Domain.Interfaces
{
    public interface IPatientRepository
    {
        //public IEnumerable<Appointment> Get();
        //public Appointment Get(int id);
        public Patient GetByNif(string nif);
        //public void Add(Appointment appointment);
        public void Update(Patient patient);
    }
}
