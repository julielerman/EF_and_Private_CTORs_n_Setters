using System.Data.Entity;
using PrivateConstructorSettersAndEF;

namespace EFDataLayer
{
    public class ThingieContext: DbContext
    {
        public DbSet<AThingAsEntity> Things { get; set; }
        public DbSet<AnotherEntity> Another { get; set; }
    }
}
