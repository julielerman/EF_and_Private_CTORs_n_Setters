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
            //Id = 41  
            //normally in order to set PK, you have to config no db id generation 
            //but this is a special case, the 1:1 since
            //id isthe FK back to the primary type in th erelationship,
            //you can't just set it yourself
        };

        entity1.Relationship = entity2;
        context.Things.Add(entity1);
        //context.Another.Add(entity2);
      base.Seed(context);
    }
  }
}