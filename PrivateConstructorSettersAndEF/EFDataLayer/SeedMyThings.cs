using System.Data.Entity;
using PrivateConstructorSettersAndEF;

namespace EFDataLayer
{
  public class SeedMyThings : DropCreateDatabaseAlways<ThingieContext>
  {
    protected override void Seed(ThingieContext context)
    {
      context.Things.Add(new AThingAsEntity("This is MY thing", 42, "That is the meaning of life"));
      base.Seed(context);
    }
  }
}