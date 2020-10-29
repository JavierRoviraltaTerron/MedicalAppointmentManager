using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MedicalAppointmentManager.BusinessLogic;
using MedicalAppointmentManager.BusinessLogic.Interfaces;
using MedicalAppointmentManager.BusinessLogic.Services;
using MedicalAppointmentManager.Domain.Interfaces;
using MedicalAppointmentManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentManager.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsApi", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddDbContext<MedicalAppointmentManagerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MedicalAppointmentManagerDB")));
            services.AddAutoMapper(typeof(AutoMapping));
            services.AddControllers();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsApi");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
