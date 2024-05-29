using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkSamples.Models;
using Microsoft.Diagnostics.Tracing.Parsers;

namespace BenchmarkSamples;

[MemoryDiagnoser]
public class BenchmarkRecord
{
    [Benchmark]
    public void DeserializeClass()
    {
        var customer = new CustomerClass
        {
            Name = "Name",
            Age = 30,
            Address = new AddressClass
            {
                City = "City",
                Country = "Country"
            }
        };

        // serialise customer to string
        var json = System.Text.Json.JsonSerializer.Serialize(customer);
        // deserialise to customer object from string
        var customerDeserialized = System.Text.Json.JsonSerializer.Deserialize<CustomerClass>(json);
    }

    [Benchmark]
    public void DeserializeClassWithSpan()
    {
        Span<string> name = new Span<string>();
        name.Fill("Name");

        Span<string> city = new Span<string>();
        city.Fill("City");

        Span<string> country = new Span<string>();
        country.Fill("Country");

        var customer = new CustomerClass
        {
            Name = name.ToString(),
            Age = 30,
            Address = new AddressClass
            {
                City = city.ToString(),
                Country = country.ToString()
            }
        };

        // serialise customer to string
        var json = System.Text.Json.JsonSerializer.Serialize(customer);
        // deserialise to customer object from string
        var customerDeserialized = System.Text.Json.JsonSerializer.Deserialize<CustomerClass>(json);
    }

    [Benchmark]
    public void DeserializeRecord() 
    {
        var customer = new CustomerRecord
        {
            Name = "Name",
            Age = 30,
            Address = new AddressRecord
            {
                City = "City",
                Country = "Country"
            }
        };

        // serialise customer to string
        var json = System.Text.Json.JsonSerializer.Serialize(customer);
        // deserialise to customer object from string
        var customerDeserialized = System.Text.Json.JsonSerializer.Deserialize<CustomerRecord>(json);
    }
}
