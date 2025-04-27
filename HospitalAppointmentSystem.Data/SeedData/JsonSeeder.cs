using System.Text.Json;

namespace HospitalAppointmentSystem.Data.SeedData
{
    /// <summary>
    /// Помощен клас за зареждане на начални данни в базата от JSON файлове.
    /// </summary>
    public static class JsonSeeder
    {
        /// <summary>
        /// Зарежда съдържанието на JSON файл и го десериализира в списък от обекти от даден тип.
        /// </summary>
        public static List<T> LoadJson<T>(string filename)
        {
            var path = Path.Combine(@"../HospitalAppointmentSystem.Data\SeedData\Json", filename);
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(json)!;
        }
    }
}
