namespace HospitalAppointmentSystem.Common.Constants
{
    /// <summary>
    /// Константи за съобщения за грешки при валидирането на данни.
    /// </summary>
    public static class EntityMessages
    {
        public const string RequiredMessage = "Полето за {0} е задължително!";

        public const string RatingProfessionalismRangeMessage = "Оценката за професионализма трябва да е между 1 и 10!";

        public const string RatingAttitudeRangeMessage = "Оценката за отношението трябва да е между 1 и 10!";
    }
}
