// See https://aka.ms/new-console-template for more information
namespace WorkingWithJson.Models
{
    internal class User
    {
        //[JsonPropertyName("firstName")]
        public required string FirstName { get; set; }

        //[JsonPropertyName("lastName")]
        public required string LastName { get; set; }

        //[JsonPropertyName("age")]
        public int Age { get; set; } // Defaults to 0

        //[JsonPropertyName("isPremiumUser")]
        public bool IsPremiumUser { get; set; } // Not marked required so defaults to False.

        //[JsonPropertyName("email")]
        public string? Email { get; set; } // Deserialized to empty

        //[JsonPropertyName("addresses")]
        public required IList<Address> Addresses { get; set; }
    }
}
