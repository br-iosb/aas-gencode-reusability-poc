using NUnit.Framework;

namespace core.test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var ai = new AasCore.Aas3.AssetInformation(AasCore.Aas3.AssetKind.Instance, new AasCore.Aas3.GlobalReference("globaleRef"));
            ai.Accept(new PrintVisitor());
            var transformed = ai.Transform(new StringTransformer());
            TestContext.WriteLine($"transformed: {transformed}");

            TestContext.WriteLine($"descend recursive");
            var enumerator = ai.Descend();
            foreach (var item in enumerator)
            {
                item.Accept(new PrintVisitor());
            }
        }
    }

    public class StringTransformer : AasCore.Aas3.Visitation.ITransformer<string>
    {
        public string Transform(AasCore.Aas3.IClass that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Resource that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Extension that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.AdministrativeInformation that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Qualifier that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.AssetAdministrationShell that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.AssetInformation that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.IdentifierKeyValuePair that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Submodel that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.SubmodelElementList that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.SubmodelElementStruct that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Property that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.MultiLanguageProperty that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Range that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.ReferenceElement that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Blob that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.File that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.AnnotatedRelationshipElement that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Entity that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.EventPayload that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.BasicEventElement that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Operation that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.OperationVariable that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Capability that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.ConceptDescription that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.GlobalReference that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.ModelReference that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Key that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.LangString that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.LangStringSet that)
        {
            return that.GetType().Name;
        }

        public string Transform(AasCore.Aas3.Environment that)
        {
            return that.GetType().Name;
        }
    }

    public class PrintVisitor : AasCore.Aas3.Visitation.IVisitor
    {
        public void Visit(AasCore.Aas3.IClass that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Resource that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Extension that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.AdministrativeInformation that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Qualifier that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.AssetAdministrationShell that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.AssetInformation that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.IdentifierKeyValuePair that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Submodel that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.SubmodelElementList that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.SubmodelElementStruct that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Property that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.MultiLanguageProperty that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Range that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.ReferenceElement that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Blob that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.File that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.AnnotatedRelationshipElement that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Entity that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.EventPayload that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.BasicEventElement that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Operation that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.OperationVariable that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Capability that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.ConceptDescription that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.GlobalReference that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.ModelReference that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Key that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.LangString that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.LangStringSet that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }

        public void Visit(AasCore.Aas3.Environment that)
        {
            TestContext.WriteLine($"visited: {that.GetType().Name}");
        }
    }
}