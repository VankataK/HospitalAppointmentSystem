namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за седмичен график на доктора.
    /// Показва името на доктора и списък с неговите прегледи.
    /// </summary>
    public class DoctorScheduleViewModel
    {
        public string DoctorName { get; set; } = null!;
        public List<DoctorAppointmentViewModel> Appointments { get; set; } = new List<DoctorAppointmentViewModel>();

    }
}
