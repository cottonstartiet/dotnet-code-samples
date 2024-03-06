namespace FuncParamAttribute;

public abstract class ArgumentValidationAttribute : Attribute
{
  public abstract void Validate(object value, string argumentName);
}