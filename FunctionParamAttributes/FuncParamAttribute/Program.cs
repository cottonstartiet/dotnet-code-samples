using FuncParamAttribute;

var attributeUsage = new AttributeUsageClass();
attributeUsage.CreateCustomer("John Doe");
attributeUsage.CreateCustomer(null);
attributeUsage.IsNumberInRange(50);
attributeUsage.IsNumberInRange(150);