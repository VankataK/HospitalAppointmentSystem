namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за представяне на записан преглед при доктора.
    /// Използва се в графика на доктора.
    /// </summary>
    public class DoctorAppointmentViewModel
    {
        public TimeSpan Time { get; set; }
        public string PatientName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
    }
}
