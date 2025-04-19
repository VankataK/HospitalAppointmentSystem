namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DoctorScheduleViewModel
    {
        public string DoctorName { get; set; } = null!;
        public List<DoctorAppointmentViewModel> Appointments { get; set; } = new List<DoctorAppointmentViewModel>();

    }
}
