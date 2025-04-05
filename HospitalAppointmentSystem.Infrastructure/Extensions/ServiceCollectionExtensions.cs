﻿using HospitalAppointmentSystem.Data.Models;
using HospitalAppointmentSystem.Data.Repository;
using HospitalAppointmentSystem.Data.Repository.Interfaces;
using HospitalAppointmentSystem.Services;
using HospitalAppointmentSystem.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalAppointmentSystem.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Doctor, Guid>, BaseRepository<Doctor, Guid>>();
            services.AddScoped<IRepository<Specialization, Guid>, BaseRepository<Specialization, Guid>>();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<ISpecializationService, SpecializationService>();

            return services;
        }
    }
}
