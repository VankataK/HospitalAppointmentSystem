using HospitalAppointmentSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalAppointmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
            
        public IActionResult Index()
        {
            return View();
        }
    }
}
