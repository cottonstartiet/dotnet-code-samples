namespace ChainOfRespPattern;

public class NoDiscountHandler : DiscountHandler
{
  public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
  {
    Console.WriteLine("No status");
    return orderTotal * .9m;
  }
}
