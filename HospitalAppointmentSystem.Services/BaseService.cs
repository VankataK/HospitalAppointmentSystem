using HospitalAppointmentSystem.Services.Interfaces;

namespace HospitalAppointmentSystem.Services
{
    /// <summary>
    /// Базов клас, съдържащ обща логика за валидация.
    /// </summary>
    public class BaseService : IBaseService
    {
        /// <summary>
        /// Проверява дали подаденият низ е валиден GUID.
        /// </summary>
        public bool IsGuidValid(string? id, ref Guid parsedGuid)
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
    }
}
