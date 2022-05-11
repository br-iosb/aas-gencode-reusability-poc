using NUnit.Framework;
using System.Linq;

namespace AasFaker.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var types = typeof(AasCore.Aas3_0_RC02.AssetAdministrationShell).Assembly.GetTypes();
            var iclasses =    types.AsQueryable().Where(x => typeof(AasCore.Aas3_0_RC02.IClass).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();
            iclasses[0].GetConstructors().First().GetParameters();
            TestContext.WriteLine("Done");
        }

        [Test]
        public void Test1()
        {
            var langstringset = new AasFaker.AASDataFake().FakeLangStringSet();

            TestContext.WriteLine(AasCore.Aas3_0_RC02.Jsonization.Serialize.ToJsonObject(langstringset));
        }
    }
}