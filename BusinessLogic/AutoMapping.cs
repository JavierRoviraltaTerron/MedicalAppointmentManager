using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalAppointmentManager.BusinessLogic.Models;
using MedicalAppointmentManager.Domain.Models;

namespace MedicalAppointmentManager.BusinessLogic
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            CreateMap<Appointment, AppointmentDTO>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.EmployeeId, x => x.MapFrom(e => e.EmployeeId))
                .ForMember(x => x.PatientId, x => x.MapFrom(e => e.PatientId))
                .ForMember(x => x.DateTime, x => x.MapFrom(e => e.DateTime))
                .ForMember(x => x.Place, x => x.MapFrom(e => e.Place))
                .ForMember(x => x.Requirements, x => x.MapFrom(e => e.Requirements))
                .ForMember(x => x.Observations, x => x.MapFrom(e => e.Observations))
                .ForMember(x => x.Cancelled, x => x.MapFrom(e => e.Cancelled))
                .ForMember(x => x.Employee, x => x.MapFrom(e => e.Employee))
                .ForMember(x => x.Patient, x => x.MapFrom(e => e.Patient))
                .ReverseMap();

            CreateMap<Employee, EmployeeDTO>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.Nif, x => x.MapFrom(e => e.Nif))
                .ForMember(x => x.FirstName, x => x.MapFrom(e => e.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(e => e.LastName))
                .ForMember(x => x.CollegiateNumber, x => x.MapFrom(e => e.CollegiateNumber))
                .ForMember(x => x.ConsultationType, x => x.MapFrom(e => e.ConsultationType))
                .ForMember(x => x.Address, x => x.MapFrom(e => e.Address))
                .ForMember(x => x.Specialities, x => x.MapFrom(e => e.Specialities))
                .ReverseMap();

            CreateMap<Patient, PatientDTO>()
                .ForMember(x => x.Id, x => x.MapFrom(e => e.Id))
                .ForMember(x => x.Nif, x => x.MapFrom(e => e.Nif))
                .ForMember(x => x.FirstName, x => x.MapFrom(e => e.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(e => e.LastName))
                .ForMember(x => x.Email, x => x.MapFrom(e => e.Email))
                .ForMember(x => x.Phone, x => x.MapFrom(e => e.Phone))
                .ForMember(x => x.Company, x => x.MapFrom(e => e.Company))
                .ReverseMap();
        }
    }
}
