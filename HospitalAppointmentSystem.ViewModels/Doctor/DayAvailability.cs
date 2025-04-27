namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел описващ ангажираността на доктор за даден ден.
    /// Включва дата, ден от седмицата, информация за отпуска/уикенд и списък със свободни интервали.
    /// </summary>
    public class DayAvailability
    {
        public DateTime Date { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public bool IsVacationOrWeekend { get; set; }
        public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}
