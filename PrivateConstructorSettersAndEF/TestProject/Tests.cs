using System;
using System.Data.Entity;
using System.Linq;
using EFDataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrivateConstructorSettersAndEF;

namespace TestProject
{
  [TestClass]
  public class Tests
  {
    public Tests()
    {
      Database.SetInitializer(new SeedMyThings());
    }
    [TestMethod]
    public void EfCanPopulateObjectWithPrivateCtorAndSetters()
    {
      using (var context=new ThingieContext() )
      {
        var thing = context.Things.FirstOrDefault();
        Assert.IsInstanceOfType(thing,typeof(AThingAsEntity));
        Assert.AreNotEqual(0, thing.Id);
        Assert.IsFalse(string.IsNullOrEmpty(thing.Description));
        Assert.IsFalse(string.IsNullOrEmpty(thing.SomeOtherThing.AnotherValue));
      }
    }
  }
}
