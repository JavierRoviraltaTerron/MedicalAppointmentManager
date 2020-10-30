using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MedicalAppointmentManager.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<AppointmentDTO> lstAppointment = new List<AppointmentDTO>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44375/api/appointment"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    lstAppointment = JsonConvert.DeserializeObject<List<AppointmentDTO>>(apiResponse);
                }
            }
            return View(lstAppointment);
        }


        // TODO: Update


        public async Task<IActionResult> Remove(int id)
        {
            List<AppointmentDTO> lstAppointment = new List<AppointmentDTO>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44375/api/appointment/" + id))
                {

                }

                using (var response = await httpClient.GetAsync("https://localhost:44375/api/appointment"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    lstAppointment = JsonConvert.DeserializeObject<List<AppointmentDTO>>(apiResponse);
                }
            }
            return PartialView("_AppointmentList", lstAppointment);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
