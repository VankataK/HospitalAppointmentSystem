using HospitalAppointmentSystem.ViewModels.Specialization;

namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DoctorListViewModel
    {
        public string? SelectedSpecializationId { get; set; }
        public IEnumerable<SpecializationViewModel> Specializations { get; set; } = new List<SpecializationViewModel>();
        public IEnumerable<DoctorIndexViewModel> Doctors { get; set; } = new List<DoctorIndexViewModel>();
    }
}
