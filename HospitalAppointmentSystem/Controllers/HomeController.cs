using Microsoft.AspNetCore.Mvc;

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
