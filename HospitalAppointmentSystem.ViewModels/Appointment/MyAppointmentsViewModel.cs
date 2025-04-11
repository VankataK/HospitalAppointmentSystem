namespace HospitalAppointmentSystem.ViewModels.Appointment
{
    public class MyAppointmentsViewModel
    {
        public string Id { get; set; } = null!;

        public string DoctorName { get; set; } = null!;

        public DateTime AppointmentDateTime { get; set; }

        public bool HasRating { get; set; }
    }
}
