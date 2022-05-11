using Bogus;
using AasCore.Aas3_0_RC02;

namespace AasFaker
{
    public class AASDataFake
    {
        /*
        public AasCore.Aas3.Environment FakeAASEnvironment()
        {
            var aasFaker = new Faker<AasCore.Aas3.AssetAdministrationShell>().CustomInstantiator(f => new AasCore.Aas3.AssetAdministrationShell()).RuleFor(aas => aas.Id, f => f.Internet.UrlWithPath().ToString());
            var smFaker = new Faker<AasCore.Aas3.Submodel>().RuleFor(sm => sm.Id, f => f.Internet.UrlWithPath().ToString());
            var cdFaker = new Faker<AasCore.Aas3.ConceptDescription>().RuleFor(cd => cd.Id, f => f.Internet.UrlWithPath().ToString());

            var testEnv = new Faker<AasCore.Aas3.Environment>()
                .RuleFor(e => e.AssetAdministrationShells, aasFaker.GenerateBetween(3, 6))
                .RuleFor(e => e.ConceptDescriptions, cdFaker.GenerateBetween(20, 30))
                .RuleFor(e => e.Submodels, smFaker.GenerateBetween(10, 15));

            var env = testEnv.Generate();
            return env;
        }
        public Property FakeProperty()
        {
            return new Faker<Property>().CustomInstantiator(f => new Property(DataTypeDefXsd.String)).RuleFor(p => p.IdShort, f => f.Lorem.Word()).RuleFor(p => p.Description, f => f.Lorem.Text()).Generate();
        }
        */
        public LangString FakeLangString()
        {
            var faker = new Faker<LangString>().CustomInstantiator(f => new LangString("en", f.Lorem.Sentence(9, 9)));
            return faker.Generate();
        }

        public LangStringSet FakeLangStringSet()
        {
            var fakerlang = new Faker<LangString>().CustomInstantiator(f => new LangString("en", f.Lorem.Sentence(9, 9)));
            var faker = new Faker<LangStringSet>().CustomInstantiator(f => new LangStringSet(fakerlang.GenerateBetween(1,1)));
            return faker.Generate();
        }


    }
}