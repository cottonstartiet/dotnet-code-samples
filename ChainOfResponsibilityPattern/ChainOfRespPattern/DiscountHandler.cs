namespace ChainOfRespPattern;

public abstract class DiscountHandler
{
  protected DiscountHandler? nextHandler;
  public DiscountHandler SetNextHandler(DiscountHandler discountHandler)
  {
    nextHandler = discountHandler;
    return nextHandler;
  }

  public abstract decimal CalculateDiscount(Customer customer, decimal orderTotal);
}
