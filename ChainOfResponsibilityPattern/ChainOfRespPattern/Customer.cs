namespace ChainOfRespPattern;

public class Customer(CustomerStatus status)
{
  public CustomerStatus Status { get; } = status;
}