using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    /// <summary>
    /// ��������� �� ��������� �������� �� ������������.
    /// </summary>
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        /// <summary>
        /// ������� ��������� ��������.
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
