using System.ComponentModel.DataAnnotations.Schema;

namespace PrivateConstructorSettersAndEF
{
    public class AnotherEntity
    {
        
      [ForeignKey("YouAreMyMaster")]
      public int Id { get; set; }
      
      public AThingAsEntity YouAreMyMaster { get; set; }
    }
}