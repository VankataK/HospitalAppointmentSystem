using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HospitalAppointmentSystem.Common.Constants.ApplicationConstants;

namespace HospitalAppointmentSystem.Areas.Admin.Controllers
{
    /// <summary>
    /// Контролер за началната страница на административния панел.
    /// </summary>
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class HomeController : Controller
    {
        /// <summary>
        /// Показва началната страница на административния панел.
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
