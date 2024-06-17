// See https://aka.ms/new-console-template for more information
using RecordsSamples.Models;

var user = new User("John", "Doe");
Console.WriteLine(user.FirstName);

var (firstName, lastName) = user;
Console.WriteLine($"First name: {firstName}, Last name: {lastName}");

var product = new Product("Laptop");
Console.WriteLine(product.ProductName);

// Error
//var (productName) = product;
//Console.WriteLine($"Product: {productName}");


