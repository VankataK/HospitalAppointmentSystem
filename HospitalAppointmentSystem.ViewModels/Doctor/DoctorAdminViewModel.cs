namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за визуализация на доктор в административния панел.
    /// </summary>
    public class DoctorAdminViewModel
    {
        public string Id { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string Specialization { get; set; } = null!;
    }
}
