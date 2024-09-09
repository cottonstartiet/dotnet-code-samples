using System;

namespace FuncParamAttribute;

public class AttributeUsageClass
{
  public void CreateCustomer([NotNull] string customerName)
  {
        Console.WriteLine($"Customer {customerName} created");
  }

  public void IsNumberInRange([InRange(1, 100)] int number)
  {
    Console.WriteLine($"Number {number} is in range");
  }
}
