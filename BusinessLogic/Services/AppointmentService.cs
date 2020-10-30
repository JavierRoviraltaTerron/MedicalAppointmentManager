using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalAppointmentManager.BusinessLogic.Interfaces;
using MedicalAppointmentManager.BusinessLogic.Models;
using MedicalAppointmentManager.Domain.Interfaces;
using MedicalAppointmentManager.Domain.Models;

namespace MedicalAppointmentManager.BusinessLogic.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IMapper _mapper;
        private IAppointmentRepository _appointmentRepository;
        private IEmployeeRepository _employeeRepository;
        private IPatientRepository _patientRepository;

        public AppointmentService(IMapper mapper, IAppointmentRepository appointmentRepository, IEmployeeRepository employeeRepository, IPatientRepository patientRepository) 
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
            _employeeRepository = employeeRepository;
            _patientRepository = patientRepository;
        }

        public IEnumerable<AppointmentDTO> Get(bool includeCancelled = true)
        {
            var repository = _appointmentRepository.Get(includeCancelled);
            return _mapper.Map<IEnumerable<Appointment>,List<AppointmentDTO>>(repository);
        }

        public AppointmentDTO Get(int id)
        {
            var item = _appointmentRepository.Get(id);
            return _mapper.Map<Appointment, AppointmentDTO>(item);
        }

        public void Add(AppointmentDTO appointment)
        {
            var mapedItem = _mapper.Map<AppointmentDTO, Appointment>(appointment);
            _appointmentRepository.Add(mapedItem);
        }

        public void Update(AppointmentDTO appointment)
        {
            if (appointment != null)
            {
                // Empleado
                var employee = _employeeRepository.GetByNif(appointment?.Employee?.Nif) ?? null;
                if (employee != null)
                {
                    // Campos protegidos
                    appointment.Employee.Id = employee.Id;
                    appointment.Employee.Nif = employee.Nif;

                    var mappedEmployee = _mapper.Map<EmployeeDTO, Employee>(appointment.Employee);
                    _employeeRepository.Update(mappedEmployee);

                    // Se quita el objeto para que no se inserte un registro nuevo de empleado junto con la cita
                    appointment.Employee = null;
                }

                // Paciente
                var patient = _patientRepository.GetByNif(appointment?.Patient?.Nif) ?? null;
                if (patient != null)
                {
                    // Campos protegidos
                    appointment.Patient.Id = patient.Id;
                    appointment.Patient.Nif = patient.Nif;

                    var mappedPatient = _mapper.Map<PatientDTO, Patient>(appointment.Patient);
                    _patientRepository.Update(mappedPatient);

                    // Se quita el objeto para que no se inserte un registro nuevo de paciente junto con la cita
                    appointment.Patient = null;
                }

                // Cita
                var dbAppointment = _appointmentRepository.Get(appointment.Id);
                if (dbAppointment != null)
                {
                    // Campos protegidos
                    appointment.Id = dbAppointment.Id;
                    appointment.EmployeeId = dbAppointment.EmployeeId;
                    appointment.PatientId = dbAppointment.PatientId;
                    appointment.Place = dbAppointment.Place;
                    appointment.Requirements = dbAppointment.Requirements;
                    appointment.Observations = dbAppointment.Observations;
                    appointment.Cancelled = dbAppointment.Cancelled;

                    var mappedAppointment = _mapper.Map<AppointmentDTO, Appointment>(appointment);
                    _appointmentRepository.Update(mappedAppointment);
                }
                else
                {
                    var mappedAppointment = _mapper.Map<AppointmentDTO, Appointment>(appointment);
                    _appointmentRepository.Add(mappedAppointment);
                }
            }
        }

        public void Remove(int id) 
        {
            if (id > 0)
            {
                var appointment = _appointmentRepository.Get(id);
                appointment.Cancelled = true;
                _appointmentRepository.Update(appointment);
            }
        }
    }
}
