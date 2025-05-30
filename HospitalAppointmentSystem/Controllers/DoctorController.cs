﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Services.Interfaces;
using HospitalAppointmentSystem.ViewModels.Doctor;
using HospitalAppointmentSystem.ViewModels.Specialization;
using HospitalAppointmentSystem.ViewModels.Vacation;

namespace HospitalAppointmentSystem.Controllers
{
    /// <summary>
    /// Контролер за преглед на лекари и управление на отпуски от страна на лекарите.
    /// </summary>
    [Authorize]
    public class DoctorController : BaseController
    {
        private readonly ISpecializationService specializationService;
        private readonly IVacationService vacationService;
        private readonly UserManager<ApplicationUser> userManager;

        public DoctorController(ISpecializationService specializationService, IVacationService vacationService, UserManager<ApplicationUser> userManager, IDoctorService doctorService)
            :base(doctorService)
        {
            this.specializationService = specializationService;
            this.vacationService = vacationService;
            this.userManager = userManager;
        }

        /// <summary>
        /// Показва всички лекари с възможност за филтриране по специализация.
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(DoctorListViewModel inputModel)
        {
            IEnumerable<DoctorIndexViewModel> doctors =
                await this.doctorService.GetDoctorsBySpecializationAsync(inputModel);
            IEnumerable<SpecializationViewModel> specializations = 
                await this.specializationService.GetAllAsync();

            DoctorListViewModel model = new DoctorListViewModel
            {
                SelectedSpecializationId = inputModel.SelectedSpecializationId,
                Doctors = doctors,
                Specializations = specializations
            };

            return View(model);
        }

        /// <summary>
        /// Показва детайли за конкретен лекар, включително свободни часове.
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id, int weekOffset = 0)
        {
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(id, ref doctorGuid)) 
            { 
                return RedirectToAction(nameof(Index)); 
            }

            DoctorDetailsViewModel? model = 
                await doctorService.GetDoctorAvailabilityAsync(doctorGuid, weekOffset);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewBag.WeekOffset = weekOffset;

            return View(model);
        }

        /// <summary>
        /// Показва графика с прегледите на лекаря за конкретен ден.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Schedule(int dayOffset = 0)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction("Index", "Home");
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction("Index", "Home");
            }

            if (dayOffset < 0)
            {
                return this.RedirectToAction(nameof(Schedule), new { dayOffset = 0 });
            }

            DoctorScheduleViewModel model = 
                await doctorService.GetDoctorScheduleAsync(doctorGuid, dayOffset);
            
            ViewBag.DayOffset = dayOffset;

            return View(model);
        }

        /// <summary>
        /// Показва всички отпуски на лекаря.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> MyVacations()
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction("Index", "Home");
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction("Index", "Home");
            }

            IEnumerable<VacationViewModel> vacations = 
                await this.vacationService.GetVacationsByDoctorId(doctorGuid);

            return View(vacations);
        }

        /// <summary>
        /// Показва формата за добавяне на нова отпуска.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> AddVacation()
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction("Index", "Home");
            }

            AddVacationViewModel model =  new AddVacationViewModel
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(1)
            };

            return View(model);
        }

        /// <summary>
        /// Записва нова отпуска на доктора.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddVacation(AddVacationViewModel model)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.EndDate < model.StartDate)
            {
                ModelState.AddModelError(string.Empty, "Крайната дата трябва да е след началната.");
                return View(model);
            }

            if (model.StartDate <= DateTime.Today)
            {
                ModelState.AddModelError(string.Empty, "Отпуск може да се вземе най-рано за утрешния ден.");
                return View(model);
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction("Index", "Home");
            }

            bool hasAppointments = 
                await this.doctorService.IsHavingAppointmentsAsync(doctorGuid, model.StartDate, model.EndDate);

            if (hasAppointments)
            {
                ModelState.AddModelError(string.Empty, "Имате записани прегледи в този период.");
                return View(model);
            }

            await this.vacationService.AddVacationAsync(model, doctorGuid);

            TempData["Success"] = "Успешно добавена отпуска.";
            return RedirectToAction(nameof(MyVacations));
        }

        /// <summary>
        /// Изтрива съществуваща отпуска.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> DeleteVacation(string vacationId)
        {
            bool isDoctor = await this.IsUserDoctorAsync();
            if (!isDoctor)
            {
                return this.RedirectToAction("Index", "Home");
            }

            string doctorId = this.userManager.GetUserId(User)!;
            Guid doctorGuid = Guid.Empty;
            if (!IsGuidValid(doctorId, ref doctorGuid))
            {
                return this.RedirectToAction("Index", "Home");
            }

            Guid vacationGuid = Guid.Empty;
            if (!IsGuidValid(vacationId, ref vacationGuid))
            {
                return this.RedirectToAction(nameof(MyVacations));
            }

            Vacation? vacation = await this.vacationService.GetVacationById(vacationGuid);

            if (vacation == null)
            {
                return this.RedirectToAction(nameof(MyVacations));
            }

            bool result = await this.vacationService.DeleteVacationAsync(vacation);

            if (result)
            {
                TempData["Success"] = "Отпуската е отменена успешно.";
            }

            return RedirectToAction(nameof(MyVacations));
        }
    }
}
