namespace ChainOfRespPattern;

public class NewDiscountHandler : DiscountHandler
{
  public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
  {
    if (customer.Status == CustomerStatus.NEW)
    {
      Console.WriteLine("New discount");
      return orderTotal * .95m;
    }

    Console.WriteLine("No new discount");
    return nextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
  }
}
