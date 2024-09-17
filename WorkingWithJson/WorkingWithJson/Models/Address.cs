using System.Text.Json.Serialization;

namespace WorkingWithJson.Models
{
    internal class Address
    {
        //[JsonPropertyName("city")]
        public required string City { get; set; }
        [JsonPropertyName("zip")]
        public required string ZipCode { get; set; }

    }
}
