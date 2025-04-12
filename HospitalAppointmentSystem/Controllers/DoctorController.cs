using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Appointment;
using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    public class DoctorController : BaseController
    {
        private readonly ISpecializationService specializationService;

        public DoctorController(ISpecializationService specializationService, IDoctorService doctorService)
            :base(doctorService)
        {
            this.specializationService = specializationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(DoctorListViewModel inputModel)
        {
            IEnumerable<DoctorIndexViewModel> doctors =
                await this.doctorService.GetDoctorsBySpecializationAsync(inputModel);
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            DoctorListViewModel viewModel = new DoctorListViewModel
            {
                SelectedSpecializationId = inputModel.SelectedSpecializationId,
                Doctors = doctors,
                Specializations = specializations
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id, int weekOffset = 0)
        {
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(id, ref doctorGuid)) 
            { 
                return RedirectToAction(nameof(Index)); 
            }

            DoctorDetailsViewModel? viewModel = await doctorService.GetDoctorAvailabilityAsync(doctorGuid, weekOffset);
            if (viewModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.WeekOffset = weekOffset;

            return View(viewModel);
        }
    }
}
