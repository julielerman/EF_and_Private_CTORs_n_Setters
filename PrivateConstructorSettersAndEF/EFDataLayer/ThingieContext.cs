using System.Data.Entity;
using PrivateConstructorSettersAndEF;

namespace EFDataLayer
{
    public class ThingieContext: DbContext
    {
        public DbSet<AThingAsEntity> Things { get; set; }
      //JL:removing this since I can get to Another through AThingAsEntity
     //   public DbSet<AnotherEntity> Another { get; set; }
    }
}
