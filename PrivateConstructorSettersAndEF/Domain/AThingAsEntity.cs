using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorSettersAndEF
{
  public class AThingAsEntity
  {
    private AThingAsEntity()
    {
    }

    public AThingAsEntity(string description, int anInt, string aString)
    {
      Description = description;
      SomeOtherThing = new SomeOtherThing(anInt, aString);
    }

    public int Id { get; private set; }
    public string Description { get; private set; }
    public SomeOtherThing SomeOtherThing { get; set; }

    public void TheOtherThingMustChange(int anInt, string aString)
    {
      SomeOtherThing = new SomeOtherThing(anInt, aString);
    }
  }
}
