using System;
using System.Collections.Generic;
using System.Text;
using MedicalAppointmentManager.Domain.Models;

namespace MedicalAppointmentManager.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        public IEnumerable<Appointment> Get(bool includeCancelled = true);
        public Appointment Get(int id);
        public void Add(Appointment appointment);
        public void Update(Appointment appointment);
    }
}
