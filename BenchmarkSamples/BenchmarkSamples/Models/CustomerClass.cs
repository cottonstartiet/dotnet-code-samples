namespace BenchmarkSamples.Models
{
    internal class CustomerClass
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public AddressClass? Address { get; set; }
    }
}
