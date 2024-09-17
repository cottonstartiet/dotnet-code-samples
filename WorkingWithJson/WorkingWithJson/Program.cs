// Read a json file from disk and deserialize it into a C# object without using Newtonsoft.Json

using System.Text.Json;
using System.Text.Json.Serialization;
using WorkingWithJson.Models;

namespace WorkingWithJson
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            JsonSerializerOptions serializationOptions = new()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string json = File.ReadAllText("data.json");
            User? user = JsonSerializer.Deserialize<User>(json, serializationOptions);
            Console.WriteLine($"Frist name: {user?.FirstName}");
            Console.WriteLine($"Age: {user?.Age}");
            Console.WriteLine($"Is Premium: {user?.IsPremiumUser}");
            Console.WriteLine($"Email: {user?.Email}");
            Console.WriteLine($"Addresses count: {user?.Addresses.Count}");

            string result = JsonSerializer.Serialize<User>(user, serializationOptions);
            Console.WriteLine(result);
        }
    }
}