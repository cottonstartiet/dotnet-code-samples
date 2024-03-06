namespace CrmApp;

public class CustomerService(ICustomerProvider customerProvider)
{
  private readonly ICustomerProvider customerProvider = customerProvider;

  public Customer GetCustomerById(string id)
  {
    return customerProvider.GetCustomerById(id);
  }

  public bool SaveCustomer(string name, int age)
  {
    customerProvider.SaveCustomer(new Customer(name, age));
    return true;
  }
}
