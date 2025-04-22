namespace HospitalAppointmentSystem.ViewModels.Rating
{
    public class RatingFilterViewModel
    {
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public IEnumerable<RatingAdminViewModel> Ratings { get; set; } = new List<RatingAdminViewModel>();
    }
}
