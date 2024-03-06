using FluentAssertions;
using Moq;

namespace CrmApp.Tests;

public class CustomerServiceTests
{
  readonly Mock<ICustomerProvider> customerProvider = new();
  readonly CustomerService customerService;
  readonly Customer knownCustomer = new("John Doe", 45);

  public CustomerServiceTests()
  {
    customerProvider.Setup(p => p.GetCustomerById(It.IsAny<string>())).Returns(knownCustomer);
    customerService = new CustomerService(customerProvider.Object);
  }

  [Fact]
  public void GetCustomerById_Success()
  {
    var actual = customerService.GetCustomerById("random-id");
    actual.Name.Should().Be("John Doe");
    actual.Age.Should().Be(45);
    customerProvider.Verify(p => p.GetCustomerById(It.IsAny<string>()), Times.Once());
  }

  [Fact]
  public void SaveCustomerSuccess()
  {
    customerProvider.Setup(p => p.SaveCustomer(It.IsAny<Customer>()))
    .Callback((Customer customer) => System.Console.WriteLine(customer.Name))
    .Verifiable();
    var result = customerService.SaveCustomer("John", 25);
    result.Should().Be(true);
    customerProvider.Verify(p => p.SaveCustomer(It.IsAny<Customer>()), Times.Once());
  }
}
