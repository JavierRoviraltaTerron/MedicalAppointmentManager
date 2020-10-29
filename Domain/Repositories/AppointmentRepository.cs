using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalAppointmentManager.Domain.Interfaces;
using MedicalAppointmentManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentManager.BusinessLogic.Services
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public IEnumerable<Appointment> Get()
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                return dbContext.Appointment.Include(i => i.Employee).Include(i => i.Patient).ToList();
            }
        }

        public Appointment Get(int id) 
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                return dbContext.Appointment.Include(i => i.Employee).Include(i => i.Patient).Where(a => a.Id == id).FirstOrDefault();
            }
        }

        public void Add(Appointment appointment) 
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                dbContext.Appointment.Add(appointment);
                dbContext.SaveChanges();
            }
        }

        public void Update(Appointment appointment)
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                dbContext.Appointment.Update(appointment);
                dbContext.SaveChanges();
            }
        }
    }
}
