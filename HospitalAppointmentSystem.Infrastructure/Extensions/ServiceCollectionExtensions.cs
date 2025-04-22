using HospitalAppointmentSystem.Data.Models;
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
            services.AddScoped<IRepository<Appointment, Guid>, BaseRepository<Appointment, Guid>>();
            services.AddScoped<IRepository<Doctor, Guid>, BaseRepository<Doctor, Guid>>();
            services.AddScoped<IRepository<Rating, Guid>, BaseRepository<Rating, Guid>>();
            services.AddScoped<IRepository<Specialization, Guid>, BaseRepository<Specialization, Guid>>();
            services.AddScoped<IRepository<Vacation, Guid>, BaseRepository<Vacation, Guid>>();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<ISpecializationService, SpecializationService>();
            services.AddScoped<IVacationService, VacationService>();

            return services;
        }
    }
}
