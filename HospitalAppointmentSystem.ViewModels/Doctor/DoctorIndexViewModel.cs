namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DoctorIndexViewModel
    {
        public string Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string SpecializationName { get; set; } = null!;
        public string? AverageProfessionalism { get; set; }
        public string? AverageAttitude { get; set; }
    }
}
