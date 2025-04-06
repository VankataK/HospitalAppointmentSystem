namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    public class DayAvailability
    {
        public DateTime Date { get; set; }
        public string DayOfWeekName { get; set; } = null!;
        public bool IsVacationOrWeekend { get; set; }
        public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}
