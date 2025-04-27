namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за подробна информация за доктор, видима за пациентите.
    /// Съдържа данни за доктора и седмичен график.
    /// </summary>
    public class DoctorDetailsViewModel
    {
        public string DoctorId { get; set; } = null!;
        public string DoctorName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string SpecializationName { get; set; } = null!;
        public string? AverageProfessionalism { get; set; }
        public string? AverageAttitude { get; set; }
        public string? Description { get; set; }
        public DateTime WeekStart { get; set; }
        public List<DayAvailability> Days { get; set; } = new List<DayAvailability>();
    }
}
