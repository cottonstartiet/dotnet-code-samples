namespace ChainOfRespPattern;

public class VipDiscountHandler : DiscountHandler
{
  public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
  {
    if (customer.Status == CustomerStatus.VIP)
    {
      Console.WriteLine("VIP discount");
      return orderTotal * .9m;
    }

    Console.WriteLine("No VIP discount");
    return nextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
  }
}
