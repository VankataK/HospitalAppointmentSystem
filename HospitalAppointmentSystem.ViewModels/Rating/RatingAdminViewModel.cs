namespace HospitalAppointmentSystem.ViewModels.Rating
{
    /// <summary>
    /// Модел за показване на оценки в административния панел.
    /// </summary>
    public class RatingAdminViewModel
    {
        public string DoctorName { get; set; } = null!;
        public string PatientName { get; set; } = null!;
        public DateTime AppointmentDateTime { get; set; }
        public decimal Professionalism { get; set; }
        public decimal Attitude { get; set; }
    }
}
