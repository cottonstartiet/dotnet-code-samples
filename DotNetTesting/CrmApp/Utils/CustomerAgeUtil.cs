namespace CrmApp;

public static class CustomerAgeUtil
{
  public static bool IsCustomerSeniorCitizen(Customer? customer)
  {
    return customer != null && customer.Age > 60;
  }
}
