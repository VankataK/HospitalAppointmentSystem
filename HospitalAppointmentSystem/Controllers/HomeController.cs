using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    /// <summary>
    ///  онтролер за началната страница на приложението.
    /// </summary>
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        /// <summary>
        /// «арежда началната страница.
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
