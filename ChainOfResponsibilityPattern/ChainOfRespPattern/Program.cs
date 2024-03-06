// See https://aka.ms/new-console-template for more information
using ChainOfRespPattern;

VipDiscountHandler vipDiscountHandler = new();

vipDiscountHandler
  .SetNextHandler(new RegularDiscountHandler())
  .SetNextHandler(new NewDiscountHandler())
  .SetNextHandler(new NoDiscountHandler());

Console.WriteLine("Calculate discount for customer");
Customer customer = new(CustomerStatus.REGULAR);
Console.WriteLine(vipDiscountHandler.CalculateDiscount(customer, 100));

