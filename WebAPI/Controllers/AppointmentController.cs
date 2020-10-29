using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MedicalAppointmentManager.BusinessLogic.Interfaces;
using MedicalAppointmentManager.BusinessLogic.Models;

namespace MedicalAppointmentManager.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        public IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService) 
        {
            _appointmentService = appointmentService;
        }

        // GET: api/Appointment
        [HttpGet]
        public IEnumerable<AppointmentDTO> Get()
        {
            var lstAppointments = _appointmentService.Get();
            return lstAppointments;
        }

        // GET: api/Appointment/5
        [HttpGet("{id}", Name = "Get")]
        public AppointmentDTO Get(int id)
        {
            var appointment = _appointmentService.Get(id);
            return appointment;
        }

        // POST: api/Appointment
        [HttpPost]
        public void Add([FromBody] AppointmentDTO appointment)
        {
            if (appointment != null)
            {
                _appointmentService.Add(appointment);
            }
        }

        //// PUT: api/Appointment/5
        //[HttpPut("{id}")]
        //public void Put([FromBody] AppointmentDTO appointment)
        //{

        //}

        // POST: api/Appointment/Update
        [Route("Update")]
        [HttpPost]
        public void Update([FromBody] AppointmentDTO appointment) 
        {
            if (appointment != null)
            {
                _appointmentService.Update(appointment);
            }
        }

        // DELETE: api/Appointment/5
        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            _appointmentService.Remove(id);
        }
    }
}
