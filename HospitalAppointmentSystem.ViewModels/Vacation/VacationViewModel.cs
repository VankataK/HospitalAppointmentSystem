namespace HospitalAppointmentSystem.ViewModels.Vacation
{
    /// <summary>
    /// Модел за показване на информация за отпуска на лекар.
    /// </summary>
    public class VacationViewModel
    {
        public string Id { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
