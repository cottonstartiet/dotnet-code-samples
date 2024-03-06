namespace CrmApp;

public class CustomerProvider : ICustomerProvider
{
  public Customer GetCustomerById(string id)
  {
    return new Customer("John Doe", 35);
  }

  public void SaveCustomer(Customer customer)
  {
    return;
  }
}
