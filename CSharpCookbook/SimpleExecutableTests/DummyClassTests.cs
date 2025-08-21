namespace SimpleExecutable.Tests;

[TestClass()]
public class DummyClassTests
{
    [TestMethod()]
    public void DoSomethingTest()
    {
        var dummyClass = new DummyClass();
        Assert.IsNotNull(dummyClass, "DummyClass instance should not be null.");
    }
}