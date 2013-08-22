using System.Data.Entity;
using EFDataLayer;
using PrivateConstructorSettersAndEF;

namespace IntegrationTestHelpers
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