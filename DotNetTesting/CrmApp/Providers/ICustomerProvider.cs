namespace CrmApp;

public interface ICustomerProvider
{
  Customer GetCustomerById(string id);

  void SaveCustomer(Customer customer);
}