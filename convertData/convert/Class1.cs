namespace convert;
public class Class1
{
  public int intEntry = 42;
  public double doubleResponse;
  public string someString = "oi";

  public string strEntry = "42";
  public int intResponse;

  public void Transform()
  {
    doubleResponse = (double) intEntry;
  }

  public void DoConversion()
  {
    if (strEntry is string)
    {
      intResponse = Convert.ToInt32(strEntry);
    }
  }
}
