using CommonData;

namespace PrivateConstructorSettersAndEF
{
  public class SomeOtherThing:ValueObject<SomeOtherThing>
  {
    private int anInt;
    private string aString;

    internal SomeOtherThing(int anInt, string aString)
    {
      AValue = anInt;
      AnotherValue = aString;
    }

    private SomeOtherThing(){}
 
    public int AValue { get; private set; }
    public string AnotherValue { get; private set; }
  }
}