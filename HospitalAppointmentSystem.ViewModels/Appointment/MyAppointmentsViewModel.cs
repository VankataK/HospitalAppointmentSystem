namespace HospitalAppointmentSystem.ViewModels.Appointment
{
    /// <summary>
    /// Модел за визуализация на записаните прегледи на пациент.
    /// Използва се за показване на списък със записани часове.
    /// </summary>
    public class MyAppointmentsViewModel
    {
        public string Id { get; set; } = null!;

        public string DoctorName { get; set; } = null!;

        public DateTime AppointmentDateTime { get; set; }

        public bool HasRating { get; set; }
    }
}
