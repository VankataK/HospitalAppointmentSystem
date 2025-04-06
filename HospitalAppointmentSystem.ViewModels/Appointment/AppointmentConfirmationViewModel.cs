namespace HospitalAppointmentSystem.ViewModels.Appointment
{
    public class AppointmentConfirmationViewModel
    {
        public string DoctorId { get; set; } = null!;
        public string DoctorName { get; set; } = null!;
        public string SpecializationName { get; set; } = null!;
        public DateTime AppointmentDateTime { get; set; }
    }
}
