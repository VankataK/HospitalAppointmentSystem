namespace HospitalAppointmentSystem.ViewModels.Doctor
{
    /// <summary>
    /// Модел за единичен времеви интервал.
    /// Съдържа час и дали интервалът е свободен за резервация.
    /// </summary>
    public class TimeSlot
    {
        public TimeSpan Time { get; set; }
        public bool IsAvailable { get; set; }
    }
}
