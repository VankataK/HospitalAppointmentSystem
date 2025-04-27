using System.Security.Claims;

namespace HospitalAppointmentSystem.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        /// <summary>
        /// Извлича идентификатора на потребителя.
        /// </summary>
        public static string? GetUserId(this ClaimsPrincipal? userClaimsPrincipal)
        {
            return userClaimsPrincipal?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? null;
        }
    }
}
