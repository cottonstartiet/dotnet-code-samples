namespace BenchmarkSamples.Models
{
    public class CustomerClass
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public AddressClass? Address { get; set; }
        public int? DobDate { get; set; }
        public int? DobMonth { get; set; }
        public int? DobYear { get; set; }
    }
}
