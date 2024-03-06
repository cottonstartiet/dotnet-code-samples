namespace ChainOfRespPattern;

public class RegularDiscountHandler : DiscountHandler
{
  public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
  {
    if (customer.Status == CustomerStatus.REGULAR)
    {
      Console.WriteLine("Regular discount");
      return orderTotal * .8m;
    }

    System.Console.WriteLine("No regular discount");
    return nextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
  }
}
