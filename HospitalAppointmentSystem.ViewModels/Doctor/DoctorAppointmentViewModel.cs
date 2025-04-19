namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DoctorAppointmentViewModel
    {
        public TimeSpan Time { get; set; }
        public string PatientName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
    }
}
