namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DoctorDetailsViewModel
    {
        public string DoctorId { get; set; } = null!;
        public string DoctorName { get; set; } = null!;
        public string SpecializationName { get; set; } = null!;
        public DateTime WeekStart { get; set; }
        public List<DayAvailability> Days { get; set; } = new List<DayAvailability>();
    }
}
