namespace HospitalAppointmentSystem.ViewModels.Appointment
{
    /// <summary>
    /// Модел за потвърждение на прегледа.
    /// Използва се за визуализиране на избран лекар и час преди окончателното записване.
    /// </summary>
    public class AppointmentConfirmationViewModel
    {
        public string DoctorId { get; set; } = null!;
        public string DoctorName { get; set; } = null!;
        public string SpecializationName { get; set; } = null!;
        public DateTime AppointmentDateTime { get; set; }
    }
}
