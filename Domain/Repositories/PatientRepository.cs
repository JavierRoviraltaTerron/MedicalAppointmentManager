using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalAppointmentManager.Domain.Interfaces;
using MedicalAppointmentManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentManager.BusinessLogic.Services
{
    public class PatientRepository : IPatientRepository
    {
        //public IEnumerable<Appointment> Get()
        //{
        //    using (var dbContext = new MedicalAppointmentManagerContext())
        //    {
        //        return dbContext.Appointment.Include(i => i.Employee).Include(i => i.Patient).ToList();
        //    }
        //}

        //public Appointment Get(int id) 
        //{
        //    using (var dbContext = new MedicalAppointmentManagerContext())
        //    {
        //        return dbContext.Appointment.Include(i => i.Employee).Include(i => i.Patient).Where(a => a.Id == id).FirstOrDefault();
        //    }
        //}

        public Patient GetByNif(string nif)
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                return dbContext.Patient.Where(a => a.Nif == nif).FirstOrDefault();
            }
        }

        //public void Add(Appointment appointment) 
        //{
        //    using (var dbContext = new MedicalAppointmentManagerContext())
        //    {
        //        dbContext.Appointment.Add(appointment);
        //        dbContext.SaveChanges();
        //    }
        //}

        public void Update(Patient patient)
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                dbContext.Patient.Update(patient);
                dbContext.SaveChanges();
            }
        }
    }
}
