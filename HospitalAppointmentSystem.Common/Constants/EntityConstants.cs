namespace HospitalAppointmentSystem.Common.Constants
{
    /// <summary>
    /// Константи за ограниченията на данните на ентитетите в приложението.
    /// </summary>
    public static class EntityConstants
    {
        /// <summary>
        /// Константи за потребителя
        /// </summary>
        public const int UserFirstNameMinLength = 2;

        public const int UserFirstNameMaxLength = 50;

        public const int UserLastNameMinLength = 2;

        public const int UserLastNameMaxLength = 50;

        public const int UserAgeMinValue = 18;

        public const int UserAgeMaxValue = 150;

        /// <summary>
        /// Константи за специалността
        /// </summary>
        public const int SpecializationNameMinLength = 4;
                         
        public const int SpecializationNameMaxLength = 100;

        /// <summary>
        /// Константи за доктора
        /// </summary>
        public const int DoctorDescriptionMaxLength = 1000;

        /// <summary>
        /// Константи за оценката
        /// </summary>
        public const string RatingMinValue = "1";

        public const string RatingMaxValue = "10";
    }
}
