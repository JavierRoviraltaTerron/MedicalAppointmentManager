using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalAppointmentManager.Domain.Interfaces;
using MedicalAppointmentManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentManager.BusinessLogic.Services
{
    public class EmployeeRepository : IEmployeeRepository
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

        public Employee GetByNif(string nif)
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                return dbContext.Employee.Where(a => a.Nif == nif).FirstOrDefault();
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

        public void Update(Employee employee)
        {
            using (var dbContext = new MedicalAppointmentManagerContext())
            {
                dbContext.Employee.Update(employee);
                dbContext.SaveChanges();
            }
        }
    }
}
