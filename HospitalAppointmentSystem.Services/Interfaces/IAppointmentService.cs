﻿using HospitalAppointmentSystem.ViewModels.Appointment;

namespace HospitalAppointmentSystem.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(AppointmentConfirmationViewModel inputModel, string patientId);
    }
}
