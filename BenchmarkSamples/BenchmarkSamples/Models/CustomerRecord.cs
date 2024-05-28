namespace BenchmarkSamples;

public record class CustomerRecord
{
  public required string Name { get; init; }
  public int Age { get; init; }
  public AddressRecord? Address { get; init; }
}
