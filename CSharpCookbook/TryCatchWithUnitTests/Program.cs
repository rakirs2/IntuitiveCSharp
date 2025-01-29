// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;

Console.WriteLine("Hello, World!");


try
{
    Console.WriteLine("something");
    Assert.Fail("unreachable");
}
//catch
//{
//    Console.WriteLine("Exception");
//}
finally
{
    Console.WriteLine("do we hit this");
}
