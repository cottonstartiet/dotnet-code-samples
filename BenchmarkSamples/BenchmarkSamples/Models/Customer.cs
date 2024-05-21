namespace BenchmarkSamples;

public record class Customer
{
  public required string Name { get; init; }
  public int Age { get; init; }
  public Address? Address { get; init; }
}
