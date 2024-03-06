namespace CrmApp.Tests;

public class CustomerAgeUtilTests
{
    [Fact]
    public void CustomerIsSenior()
    {
        Customer customer = new Customer("c-name", 61);
        Assert.True(CustomerAgeUtil.IsCustomerSeniorCitizen(customer));
    }

    [Fact]
    public void CustomerIsNotSenior()
    {
        Customer customer = new Customer("c-name", 55);
        Assert.False(CustomerAgeUtil.IsCustomerSeniorCitizen(customer));
    }

    [Fact]
    public void CustomerIsNulNotSenior()
    {
        Assert.False(CustomerAgeUtil.IsCustomerSeniorCitizen(null));
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void InlineTestCustomerData(string name, int age)
    {
        Customer customer = new Customer(name, age);
        Assert.False(CustomerAgeUtil.IsCustomerSeniorCitizen(customer));
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "c-Name", 15 };
        yield return new object[] { "c-Name", 25 };
        yield return new object[] { "c-Name", 35 };
    }
}