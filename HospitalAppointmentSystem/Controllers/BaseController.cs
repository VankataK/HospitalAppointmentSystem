using HospitalAppointmentSystem.Infrastructure.Extensions;
using HospitalAppointmentSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    /// <summary>
    /// Базов контролер, съдържащ обща логика за наследяващите го контролери.
    /// </summary>
    public class BaseController : Controller
    {
        protected readonly IDoctorService doctorService;

        public BaseController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        /// <summary>
        /// Проверява дали подаден низ е валиден Guid.
        /// </summary>
        protected bool IsGuidValid(string? id, ref Guid parsedGuid)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            bool isGuidValid = Guid.TryParse(id, out parsedGuid);
            if (!isGuidValid)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверява дали текущият потребител е доктор.
        /// </summary>
        protected async Task<bool> IsUserDoctorAsync()
        {
            string? userId = this.User.GetUserId();
            bool isDoctor = await this.doctorService
                .IsUserDoctorAsync(userId);

            return isDoctor;
        }
    }
}
