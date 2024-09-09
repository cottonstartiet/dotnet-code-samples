// See https://aka.ms/new-console-template for more information

using NullChecks.Models;
using System.Xml;

var customer = new Customer() { Name = "John Doe", Age = 30 };
Customer? nullCustomer = null;


if ("John Doe".Equals(nullCustomer?.Name))
{
    Console.WriteLine();
}
else 
{
    Console.WriteLine("Customer is null");
}

if (nullCustomer?.Name == "John Doe")
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("Customer is null");
}

