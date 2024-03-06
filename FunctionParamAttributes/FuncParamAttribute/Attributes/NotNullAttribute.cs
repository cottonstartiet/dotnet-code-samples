namespace FuncParamAttribute;

[AttributeUsage(AttributeTargets.Parameter)]
public class NotNullAttribute : ArgumentValidationAttribute
{
  public override void Validate(object value, string argumentName)
  {
    if (value == null)
    {
      throw new ArgumentNullException($"{argumentName} can not be null");
    }
  }
}
