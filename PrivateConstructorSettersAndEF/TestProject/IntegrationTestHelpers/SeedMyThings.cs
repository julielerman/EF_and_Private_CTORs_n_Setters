using System.Data.Entity;
using EFDataLayer;
using PrivateConstructorSettersAndEF;

namespace IntegrationTestHelpers
{
  public class SeedMyThings : DropCreateDatabaseAlways<ThingieContext>
  {
    protected override void Seed(ThingieContext context)
    {
        var entity1 = new AThingAsEntity("This is MY thing", 42, "That is the meaning of life");
        var entity2 = new AnotherEntity
        {
            Id = 41
        };

        entity1.Relationship = entity2;
        context.Things.Add(entity1);
        context.Another.Add(entity2);
      base.Seed(context);
    }
  }
}