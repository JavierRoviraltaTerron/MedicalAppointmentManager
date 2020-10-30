using System;
using System.Collections.Generic;
using System.Text;
using MedicalAppointmentManager.BusinessLogic.Models;

namespace MedicalAppointmentManager.BusinessLogic.Interfaces
{
    public interface IAppointmentService
    {
        public IEnumerable<AppointmentDTO> Get(bool includeCancelled = true);
        public AppointmentDTO Get(int id);
        public void Add(AppointmentDTO appointment);
        public void Update(AppointmentDTO appointment);
        public void Remove(int id);
    }
}
