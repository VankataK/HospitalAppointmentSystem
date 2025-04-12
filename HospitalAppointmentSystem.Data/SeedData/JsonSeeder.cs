using System.Text.Json;

namespace HospitalAppointmentSystem.Data.SeedData
{
    public static class JsonSeeder
    {
        public static List<T> LoadJson<T>(string filename)
        {
            var path = Path.Combine(@"../HospitalAppointmentSystem.Data\SeedData\Json", filename);
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(json)!;
        }
    }
}
