namespace FuncParamAttribute;

public class InRangeAttribute(int min, int max) : ArgumentValidationAttribute
{
  private int min = min;
  private int max = max;

  public override void Validate(object value, string argumentName)
  {
    int val = (int)value;
    if (val < min || val > max)
    {
      throw new ArgumentOutOfRangeException($"{argumentName} value {value} is outside the range min:{min}-max{max}");
    }
  }
}
