namespace RecordBenchmark;

public record class Address
{
  public string Street { get; init; }
  public string City { get; init; }
  public string State { get; init; }
  public string Zip { get; init; }
}
